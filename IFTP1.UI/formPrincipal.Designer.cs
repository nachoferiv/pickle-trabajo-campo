namespace IFTP1_UI
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.sesionToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.optionLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.optionRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.optionVerUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSession = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSesionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pickleLogo = new System.Windows.Forms.PictureBox();
            this.btHome = new FontAwesome.Sharp.IconButton();
            this.btPurchases = new FontAwesome.Sharp.IconButton();
            this.btProfile = new FontAwesome.Sharp.IconButton();
            this.btConfig = new FontAwesome.Sharp.IconButton();
            this.btExit = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLogin = new FontAwesome.Sharp.IconButton();
            this.btAdmin = new FontAwesome.Sharp.IconButton();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickleLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenu,
            this.administradorToolStripMenu});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1184, 25);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // sesionToolStripMenu
            // 
            this.sesionToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionLogin,
            this.optionLogout,
            this.optionRegister});
            this.sesionToolStripMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesionToolStripMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sesionToolStripMenu.Name = "sesionToolStripMenu";
            this.sesionToolStripMenu.Size = new System.Drawing.Size(63, 21);
            this.sesionToolStripMenu.Text = "Sesión";
            // 
            // optionLogin
            // 
            this.optionLogin.Name = "optionLogin";
            this.optionLogin.Size = new System.Drawing.Size(163, 22);
            this.optionLogin.Text = "Iniciar Sesión";
            this.optionLogin.Click += new System.EventHandler(this.optionLogin_Click);
            // 
            // optionLogout
            // 
            this.optionLogout.Name = "optionLogout";
            this.optionLogout.Size = new System.Drawing.Size(163, 22);
            this.optionLogout.Text = "Cerrar Sesión";
            this.optionLogout.Click += new System.EventHandler(this.optionLogout_Click);
            // 
            // optionRegister
            // 
            this.optionRegister.Name = "optionRegister";
            this.optionRegister.Size = new System.Drawing.Size(163, 22);
            this.optionRegister.Text = "Registrarse";
            this.optionRegister.Click += new System.EventHandler(this.optionRegister_Click);
            // 
            // administradorToolStripMenu
            // 
            this.administradorToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionUsuarios});
            this.administradorToolStripMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administradorToolStripMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.administradorToolStripMenu.Name = "administradorToolStripMenu";
            this.administradorToolStripMenu.Size = new System.Drawing.Size(109, 21);
            this.administradorToolStripMenu.Text = "Administrador";
            // 
            // optionUsuarios
            // 
            this.optionUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionVerUsuarios});
            this.optionUsuarios.Name = "optionUsuarios";
            this.optionUsuarios.Size = new System.Drawing.Size(129, 22);
            this.optionUsuarios.Text = "Usuarios";
            // 
            // optionVerUsuarios
            // 
            this.optionVerUsuarios.Name = "optionVerUsuarios";
            this.optionVerUsuarios.Size = new System.Drawing.Size(153, 22);
            this.optionVerUsuarios.Text = "Ver Usuarios";
            this.optionVerUsuarios.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSession,
            this.toolStripSesionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSession
            // 
            this.toolStripSession.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripSession.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripSession.Name = "toolStripSession";
            this.toolStripSession.Size = new System.Drawing.Size(149, 17);
            this.toolStripSession.Text = "Estado de la sesión:";
            // 
            // toolStripSesionStatus
            // 
            this.toolStripSesionStatus.Name = "toolStripSesionStatus";
            this.toolStripSesionStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pickleLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // pickleLogo
            // 
            this.pickleLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(91)))), ((int)(((byte)(107)))));
            this.pickleLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pickleLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickleLogo.Location = new System.Drawing.Point(0, 0);
            this.pickleLogo.Name = "pickleLogo";
            this.pickleLogo.Size = new System.Drawing.Size(220, 80);
            this.pickleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickleLogo.TabIndex = 0;
            this.pickleLogo.TabStop = false;
            // 
            // btHome
            // 
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btHome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btHome.IconColor = System.Drawing.Color.White;
            this.btHome.IconSize = 40;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(0, 140);
            this.btHome.Name = "btHome";
            this.btHome.Rotation = 0D;
            this.btHome.Size = new System.Drawing.Size(220, 61);
            this.btHome.TabIndex = 1;
            this.btHome.Text = "Inicio";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btPurchases
            // 
            this.btPurchases.FlatAppearance.BorderSize = 0;
            this.btPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPurchases.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btPurchases.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPurchases.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btPurchases.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btPurchases.IconColor = System.Drawing.Color.White;
            this.btPurchases.IconSize = 40;
            this.btPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPurchases.Location = new System.Drawing.Point(0, 200);
            this.btPurchases.Name = "btPurchases";
            this.btPurchases.Rotation = 0D;
            this.btPurchases.Size = new System.Drawing.Size(220, 60);
            this.btPurchases.TabIndex = 2;
            this.btPurchases.Text = "Compras";
            this.btPurchases.UseVisualStyleBackColor = true;
            this.btPurchases.Click += new System.EventHandler(this.btPurchases_Click);
            // 
            // btProfile
            // 
            this.btProfile.FlatAppearance.BorderSize = 0;
            this.btProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProfile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btProfile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btProfile.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btProfile.IconColor = System.Drawing.Color.White;
            this.btProfile.IconSize = 40;
            this.btProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProfile.Location = new System.Drawing.Point(0, 260);
            this.btProfile.Name = "btProfile";
            this.btProfile.Rotation = 0D;
            this.btProfile.Size = new System.Drawing.Size(220, 60);
            this.btProfile.TabIndex = 3;
            this.btProfile.Text = "Perfil";
            this.btProfile.UseVisualStyleBackColor = true;
            this.btProfile.Click += new System.EventHandler(this.btProfile_Click);
            // 
            // btConfig
            // 
            this.btConfig.FlatAppearance.BorderSize = 0;
            this.btConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfig.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btConfig.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfig.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btConfig.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btConfig.IconColor = System.Drawing.Color.White;
            this.btConfig.IconSize = 40;
            this.btConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConfig.Location = new System.Drawing.Point(0, 320);
            this.btConfig.Name = "btConfig";
            this.btConfig.Rotation = 0D;
            this.btConfig.Size = new System.Drawing.Size(220, 60);
            this.btConfig.TabIndex = 5;
            this.btConfig.Text = "Configuracion";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // btExit
            // 
            this.btExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btExit.IconColor = System.Drawing.Color.White;
            this.btExit.IconSize = 40;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExit.Location = new System.Drawing.Point(0, 574);
            this.btExit.Name = "btExit";
            this.btExit.Rotation = 0D;
            this.btExit.Size = new System.Drawing.Size(220, 60);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Salir";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.btAdmin);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.btConfig);
            this.panel1.Controls.Add(this.btProfile);
            this.panel1.Controls.Add(this.btPurchases);
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 634);
            this.panel1.TabIndex = 6;
            // 
            // btLogin
            // 
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btLogin.IconColor = System.Drawing.Color.White;
            this.btLogin.IconSize = 40;
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.Location = new System.Drawing.Point(0, 86);
            this.btLogin.Name = "btLogin";
            this.btLogin.Rotation = 0D;
            this.btLogin.Size = new System.Drawing.Size(220, 60);
            this.btLogin.TabIndex = 8;
            this.btLogin.Text = "Iniciar Sesión";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btAdmin
            // 
            this.btAdmin.FlatAppearance.BorderSize = 0;
            this.btAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdmin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btAdmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAdmin.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btAdmin.IconColor = System.Drawing.Color.White;
            this.btAdmin.IconSize = 40;
            this.btAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdmin.Location = new System.Drawing.Point(0, 380);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Rotation = 0D;
            this.btAdmin.Size = new System.Drawing.Size(220, 60);
            this.btAdmin.TabIndex = 7;
            this.btAdmin.Text = "Administración";
            this.btAdmin.UseVisualStyleBackColor = true;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "formPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pickleLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem optionLogin;
        private System.Windows.Forms.ToolStripMenuItem optionLogout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSession;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSesionStatus;
        private System.Windows.Forms.ToolStripMenuItem optionRegister;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem optionUsuarios;
        private System.Windows.Forms.ToolStripMenuItem optionVerUsuarios;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pickleLogo;
        private FontAwesome.Sharp.IconButton btHome;
        private FontAwesome.Sharp.IconButton btPurchases;
        private FontAwesome.Sharp.IconButton btProfile;
        private FontAwesome.Sharp.IconButton btConfig;
        private FontAwesome.Sharp.IconButton btExit;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btAdmin;
        private FontAwesome.Sharp.IconButton btLogin;
    }
}

