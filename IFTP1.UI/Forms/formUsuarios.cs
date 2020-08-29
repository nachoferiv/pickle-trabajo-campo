using IFTP1.BLL;
using IFTP1.EE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFTP1_UI
{
    public partial class formUsuarios : Form
    {
        UsuarioBLL bllUsuarios = new UsuarioBLL();
        public formUsuarios()
        {
            InitializeComponent();
        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formUsuarios_Load(object sender, EventArgs e)
        {
            this.loadUsuariosData();
            
        }

        private void loadUsuariosData()
        {
            this.dgUsuarios.DataSource = null;
            this.dgUsuarios.DataSource = bllUsuarios.GetAll().Where(u => u.Activo.Equals(true)).ToList();
            this.hideColumns();
        }

        private void hideColumns()
        {
            List<string> hiddenColumns = new List<string>();
            hiddenColumns.Add("Password");
            hiddenColumns.Add("FechaBaja");
            hiddenColumns.Add("Activo");

            List<string> readOnlyColumns = new List<string>();
            readOnlyColumns.Add("Password");
            readOnlyColumns.Add("FechaAlta");
            readOnlyColumns.Add("FechaBaja");
            readOnlyColumns.Add("Id");

            foreach (DataGridViewColumn col in dgUsuarios.Columns)
            {
                if (hiddenColumns.Contains(col.DataPropertyName)) col.Visible = false;
                if (readOnlyColumns.Contains(col.DataPropertyName)) col.ReadOnly = true;
            }
        }

        private void btBaja_Click(object sender, EventArgs e)
        {
            try
            {
                
                var selected = dgUsuarios.SelectedRows;
                if (selected.Count != 1) throw new Exception("No hay un solo usuario seleccionado");
                else
                {
                    EEUsuario usuarioBaja = new EEUsuario();
                    usuarioBaja = (EEUsuario)selected[0].DataBoundItem;
                    bllUsuarios.Delete(usuarioBaja);
                    this.loadUsuariosData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Baja de Usuario: Error");
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {

                var selected = dgUsuarios.SelectedRows;
                if (selected.Count != 1) throw new Exception("No hay un solo usuario seleccionado");
                else
                {

                    EEUsuario usuarioModificado = new EEUsuario();
                    usuarioModificado = (EEUsuario)selected[0].DataBoundItem;
                    if (MessageBox.Show("¿Está seguro que desea modificar al usuario '" +
                    usuarioModificado.Username + "'?", "Confirmar Modificación", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        bllUsuarios.Save(usuarioModificado);
                    }
                    
                    this.loadUsuariosData();
                    MessageBox.Show("Usuario modificado correctamente.", "Modificar Usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Modificar Usuario: Error");
            }
        }
    }
}
