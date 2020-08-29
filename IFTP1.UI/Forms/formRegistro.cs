using IFTP1.BLL;
using IFTP1.EE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFTP1_UI
{
    public partial class formRegistro : Form
    {
        UsuarioBLL bllUsuario;
        public formRegistro()
        {
            InitializeComponent();
            bllUsuario = new UsuarioBLL();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                var errors = this.getFormErrors();
                if (errors.Count > 0)
                {
                    string message = "Se presentaron los siguientes errores en el formulario:\r\n\r\n";
                    foreach (string msg in errors)
                    {
                        message += msg + "\r\n";
                    }

                    MessageBox.Show(message, "Error!");

                    return;
                }

                this.createUserFromForm();

                MessageBox.Show("Usuario creado exitosamente.", "Registro");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void createUserFromForm()
        {
            EEUsuario usuario = new EEUsuario();

            usuario.Username = this.tbUsername.Text;
            usuario.Password = this.tbPassword1.Text;
            usuario.Nombre = this.tbNombre.Text;
            usuario.Apellido = this.tbApellido.Text;
            usuario.Email = this.tbEmail1.Text;
            usuario.NumDocumento = this.tbNumDocumento.Text;
            usuario.Domicilio = this.tbDomicilio.Text;
            usuario.Telefono = this.tbTelefono.Text;

            this.bllUsuario.Save(usuario);
        }

        private List<string> getFormErrors()
        {
            List<string> errors = new List<string>();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(System.Windows.Forms.TextBox) && errors.Count == 0)
                {
                    if (ctrl.Text.Length == 0) errors.Add("Debe completar todos los campos del formulario.");
                }
            }

            if (this.tbPassword1.Text != this.tbPassword2.Text)
            {
                errors.Add("Las contraseñas no coinciden.");
            } else
            {
                var regex = new Regex(@"(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,15}");
                if (!regex.IsMatch(this.tbPassword1.Text))
                    errors.Add("La contraseña debe: contener al menos una minúscula, una mayúscula, un número y ser de entre 8 y 15 caracteres.");
            }

            if (this.tbEmail1.Text != this.tbEmail2.Text)
            {
                errors.Add("Los emails no coincide.");
            } else
            {
                var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!regex.IsMatch(this.tbEmail1.Text))
                    errors.Add("El email no es válido.");
            }

            
            if (this.tbUsername.Text.Length >= 8)
            {
                if (this.bllUsuario.GetAll() != null)
                {
                    var usernameExists = this.bllUsuario.GetAll().Where(u => u.Username.Equals(this.tbUsername.Text)).FirstOrDefault();
                    if (usernameExists != null)
                    {
                        errors.Add("Ya existe un usuario con ese nombre de usuario.");
                    }
                }
            } else
            {
                errors.Add("El username debe ser de al menos 8 caracteres.");
            }

            if (this.tbNumDocumento.Text.Length < 7)
            {
                errors.Add("Número de documento inválido.");
            }

            return errors;
        }        
    }
}
