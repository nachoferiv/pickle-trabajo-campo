using IFTP1.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFTP1_UI
{
    public partial class formLogin : Form
    {
        UsuarioBLL bllUsuario;
        public static formLogin instance = null;

        private formLogin()
        {
            InitializeComponent();
            bllUsuario = new UsuarioBLL();
        }

        public static formLogin getFormInstance()
        {
            return formInstance;
        }

        private static formLogin formInstance
        {
            get
            {
                if(instance is null)
                {
                    instance = new formLogin();
                    instance.Disposed += new EventHandler(instance_Disposed);
                }
                return instance;
            }
        }

        static void instance_Disposed(object sender, EventArgs e)
        {
            instance = null;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var response = bllUsuario.Login(this.tbUsername.Text, this.tbPassword.Text);
                if (response)
                {
                    formPrincipal formPrincipal = (formPrincipal)this.MdiParent;
                    formPrincipal.ActualizarEstado();

                    this.Close();
                } else
                {
                    MessageBox.Show("Hubo un error al intentar loguearse. Intente nuevamente.", "Error!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error en Inicio de Sesión");
            }
        }
    }
}
