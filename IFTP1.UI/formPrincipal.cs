using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using IFTP1.BLL;
using IFTP1.Servicios;
using IFTP1.UI;

namespace IFTP1_UI
{
    public partial class formPrincipal : Form
    {

        UsuarioBLL bllUsuario;
        private Button currentButton;

        public formPrincipal()
        {
            InitializeComponent();
            this.ActualizarEstado();
            this.bllUsuario = new UsuarioBLL();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    Color color = ColorTranslator.FromHtml(ThemeColor.ColorList[currentButton.Name]);
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panel1.Controls)
            {
                if(previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void ActualizarEstado()
        {

            this.toolStripSesionStatus.Text = Sesion.Instance.isLogged() ?
                Sesion.Instance.User.Username + " [Conectado]" : "[Sesión no iniciada]";
          
            this.optionLogin.Enabled = !Sesion.Instance.isLogged();
            this.optionLogout.Enabled = Sesion.Instance.isLogged();
            this.optionRegister.Enabled = !Sesion.Instance.isLogged();
            if (!Sesion.Instance.isLogged())
            {
                this.btLogin.Show();

                this.btHome.Hide();
                this.btPurchases.Hide();
                this.btProfile.Hide();
                this.btConfig.Hide();
                this.btAdmin.Hide();
            } else
            {
                this.btLogin.Hide();

                this.btHome.Show();
                this.btPurchases.Show();
                this.btProfile.Show();
                this.btConfig.Show();
                this.btAdmin.Show();
            }
        }

        private void optionLogin_Click(object sender, EventArgs e)
        {
            //formLogin formLogin = new formLogin();
            //formLogin.MdiParent = this;
            //formLogin.Show();
        }

        private void optionLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bllUsuario.Logout();
                this.ActualizarEstado();
            }
        }

        private void optionRegister_Click(object sender, EventArgs e)
        {
            formRegistro formRegistro = new formRegistro();
            formRegistro.MdiParent = this;
            formRegistro.Show();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsuarios formUsuarios = new formUsuarios();
            formUsuarios.MdiParent = this;
            formUsuarios.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btPurchases_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void btAdmin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            formLogin formLogin = formLogin.getFormInstance();
            formLogin.MdiParent = this;
            formLogin.Show();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (Sesion.Instance.isLogged() && MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bllUsuario.Logout();
                this.ActualizarEstado();
            }

            this.Close();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(900, 700);
        }
    }
}
