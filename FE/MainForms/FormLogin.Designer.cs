namespace FE
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblLogin = new System.Windows.Forms.Label();
            this.panelControlBox = new Siticone.UI.WinForms.SiticonePanel();
            this.controlMinimize = new Siticone.UI.WinForms.SiticoneControlBox();
            this.controlClose = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransparentDrag1 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.siticoneTransparentDrag2 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.lblTitleLog = new Siticone.UI.WinForms.SiticoneLabel();
            this.lblTitle = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.linkLabel1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.btnregister = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.txtPass = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.txtUser = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.linkpass = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneElipse2 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.toolTipLogin = new Siticone.UI.WinForms.SiticoneToolTip();
            this.foroLink = new Siticone.UI.WinForms.SiticoneImageButton();
            this.gitHub = new Siticone.UI.WinForms.SiticoneImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Oswald Regular", 20.25F);
            this.lblLogin.ForeColor = System.Drawing.Color.LightGray;
            this.lblLogin.Location = new System.Drawing.Point(330, 30);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(76, 36);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "LOGIN";
            this.toolTipLogin.SetToolTip(this.lblLogin, "Ingrese nombre de usuario y contraseña para ingresar  ;)");
            // 
            // panelControlBox
            // 
            this.panelControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelControlBox.Controls.Add(this.controlMinimize);
            this.panelControlBox.Controls.Add(this.controlClose);
            this.panelControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlBox.Location = new System.Drawing.Point(0, 0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.ShadowDecoration.Parent = this.panelControlBox;
            this.panelControlBox.Size = new System.Drawing.Size(780, 19);
            this.panelControlBox.TabIndex = 28;
            // 
            // controlMinimize
            // 
            this.controlMinimize.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlMinimize.FillColor = System.Drawing.Color.Transparent;
            this.controlMinimize.HoveredState.FillColor = System.Drawing.Color.Gainsboro;
            this.controlMinimize.HoveredState.Parent = this.controlMinimize;
            this.controlMinimize.IconColor = System.Drawing.Color.White;
            this.controlMinimize.Location = new System.Drawing.Point(730, 0);
            this.controlMinimize.Name = "controlMinimize";
            this.controlMinimize.ShadowDecoration.Parent = this.controlMinimize;
            this.controlMinimize.Size = new System.Drawing.Size(25, 19);
            this.controlMinimize.TabIndex = 29;
            this.controlMinimize.TabStop = false;
            this.controlMinimize.Click += new System.EventHandler(this.controlMinimize_Click);
            // 
            // controlClose
            // 
            this.controlClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlClose.FillColor = System.Drawing.Color.Transparent;
            this.controlClose.HoveredState.FillColor = System.Drawing.Color.Maroon;
            this.controlClose.HoveredState.Parent = this.controlClose;
            this.controlClose.IconColor = System.Drawing.Color.White;
            this.controlClose.Location = new System.Drawing.Point(755, 0);
            this.controlClose.Name = "controlClose";
            this.controlClose.ShadowDecoration.Parent = this.controlClose;
            this.controlClose.Size = new System.Drawing.Size(25, 19);
            this.controlClose.TabIndex = 28;
            this.controlClose.TabStop = false;
            this.controlClose.Click += new System.EventHandler(this.controlClose_Click);
            // 
            // siticoneTransparentDrag1
            // 
            this.siticoneTransparentDrag1.DragEndTransparencyValue = 1D;
            this.siticoneTransparentDrag1.DragStartTransparencyValue = 0.9D;
            this.siticoneTransparentDrag1.TargetDragControl = this;
            // 
            // siticoneTransparentDrag2
            // 
            this.siticoneTransparentDrag2.DragEndTransparencyValue = 1D;
            this.siticoneTransparentDrag2.DragStartTransparencyValue = 0.9D;
            this.siticoneTransparentDrag2.TargetDragControl = this.panelControlBox;
            // 
            // lblTitleLog
            // 
            this.lblTitleLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitleLog.AutoSize = false;
            this.lblTitleLog.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleLog.Font = new System.Drawing.Font("Oswald Regular", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLog.ForeColor = System.Drawing.Color.LightGray;
            this.lblTitleLog.IsContextMenuEnabled = false;
            this.lblTitleLog.IsSelectionEnabled = false;
            this.lblTitleLog.Location = new System.Drawing.Point(-9, 284);
            this.lblTitleLog.Name = "lblTitleLog";
            this.lblTitleLog.Size = new System.Drawing.Size(256, 39);
            this.lblTitleLog.TabIndex = 29;
            this.lblTitleLog.Text = "UNION FANSUB";
            this.lblTitleLog.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.CheckedState.Parent = this.lblTitle;
            this.lblTitle.CustomImages.Parent = this.lblTitle;
            this.lblTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(107)))), ((int)(((byte)(118)))));
            this.lblTitle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.lblTitle.Font = new System.Drawing.Font("Oswald Regular", 22F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.HoveredState.Parent = this.lblTitle;
            this.lblTitle.Location = new System.Drawing.Point(22, 272);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.ShadowDecoration.Parent = this.lblTitle;
            this.lblTitle.Size = new System.Drawing.Size(211, 49);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.TabStop = false;
            this.lblTitle.Text = "UNION FANSUB";
            // 
            // linkLabel1
            // 
            this.linkLabel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.linkLabel1.BorderThickness = 2;
            this.linkLabel1.CheckedState.Parent = this.linkLabel1;
            this.linkLabel1.CustomImages.Parent = this.linkLabel1;
            this.linkLabel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.HoveredState.BorderColor = System.Drawing.Color.SkyBlue;
            this.linkLabel1.HoveredState.ForeColor = System.Drawing.Color.SkyBlue;
            this.linkLabel1.HoveredState.Parent = this.linkLabel1;
            this.linkLabel1.Location = new System.Drawing.Point(543, 262);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.ShadowDecoration.Parent = this.linkLabel1;
            this.linkLabel1.Size = new System.Drawing.Size(167, 45);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.Text = "REGISTRARSE";
            this.linkLabel1.Click += new System.EventHandler(this.clicRegister_LinkClicked_1);
            // 
            // btnregister
            // 
            this.btnregister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnregister.BorderThickness = 2;
            this.btnregister.CheckedState.Parent = this.btnregister;
            this.btnregister.CustomImages.Parent = this.btnregister;
            this.btnregister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnregister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.HoveredState.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnregister.HoveredState.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnregister.HoveredState.Parent = this.btnregister;
            this.btnregister.Location = new System.Drawing.Point(330, 211);
            this.btnregister.Name = "btnregister";
            this.btnregister.ShadowDecoration.Parent = this.btnregister;
            this.btnregister.Size = new System.Drawing.Size(380, 45);
            this.btnregister.TabIndex = 3;
            this.btnregister.Text = "ACCEDER";
            this.btnregister.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Animated = false;
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.Parent = this.txtPass;
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtPass.FocusedState.Parent = this.txtPass;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPass.HoveredState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPass.HoveredState.Parent = this.txtPass;
            this.txtPass.Location = new System.Drawing.Point(330, 159);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 20, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPass.PlaceholderText = "CONTRASEÑA";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.Parent = this.txtPass;
            this.txtPass.Size = new System.Drawing.Size(380, 36);
            this.txtPass.TabIndex = 2;
            this.toolTipLogin.SetToolTip(this.txtPass, "Ingresa tu contraseña ");
            // 
            // txtUser
            // 
            this.txtUser.Animated = false;
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.Parent = this.txtUser;
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtUser.FocusedState.Parent = this.txtUser;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtUser.HoveredState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUser.HoveredState.Parent = this.txtUser;
            this.txtUser.Location = new System.Drawing.Point(330, 99);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 20, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUser.PlaceholderText = "USUARIO";
            this.txtUser.SelectedText = "";
            this.txtUser.ShadowDecoration.Parent = this.txtUser;
            this.txtUser.Size = new System.Drawing.Size(380, 36);
            this.txtUser.TabIndex = 1;
            this.toolTipLogin.SetToolTip(this.txtUser, "Ingresa tu nombre de usuario");
            // 
            // linkpass
            // 
            this.linkpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.linkpass.BorderThickness = 2;
            this.linkpass.CheckedState.Parent = this.linkpass;
            this.linkpass.CustomImages.Parent = this.linkpass;
            this.linkpass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.linkpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkpass.ForeColor = System.Drawing.Color.White;
            this.linkpass.HoveredState.BorderColor = System.Drawing.Color.SandyBrown;
            this.linkpass.HoveredState.ForeColor = System.Drawing.Color.SandyBrown;
            this.linkpass.HoveredState.Parent = this.linkpass;
            this.linkpass.Location = new System.Drawing.Point(330, 262);
            this.linkpass.Name = "linkpass";
            this.linkpass.ShadowDecoration.Parent = this.linkpass;
            this.linkpass.Size = new System.Drawing.Size(185, 45);
            this.linkpass.TabIndex = 4;
            this.linkpass.Text = "¿HA OLVIDADO SU CONTRASEÑA?";
            this.linkpass.Click += new System.EventHandler(this.clicForgetPass_LinkClicked);
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this;
            // 
            // siticoneElipse2
            // 
            this.siticoneElipse2.BorderRadius = 15;
            this.siticoneElipse2.TargetControl = this.lblTitle;
            // 
            // toolTipLogin
            // 
            this.toolTipLogin.AllowLinksHandling = true;
            this.toolTipLogin.BackColor = System.Drawing.Color.Black;
            this.toolTipLogin.BorderColor = System.Drawing.Color.Black;
            this.toolTipLogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLogin.ForeColor = System.Drawing.Color.White;
            this.toolTipLogin.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // foroLink
            // 
            this.foroLink.BackColor = System.Drawing.Color.Transparent;
            this.foroLink.CheckedState.Parent = this.foroLink;
            this.foroLink.HoveredState.Image = global::FE.Properties.Resources.icoForo;
            this.foroLink.HoveredState.ImageSize = new System.Drawing.Size(45, 40);
            this.foroLink.HoveredState.Parent = this.foroLink;
            this.foroLink.Image = global::FE.Properties.Resources.icoForo;
            this.foroLink.ImageRotate = 0F;
            this.foroLink.ImageSize = new System.Drawing.Size(40, 35);
            this.foroLink.IndicateFocus = false;
            this.foroLink.Location = new System.Drawing.Point(706, 30);
            this.foroLink.Name = "foroLink";
            this.foroLink.PressedState.Image = global::FE.Properties.Resources.icoForo;
            this.foroLink.PressedState.ImageSize = new System.Drawing.Size(45, 40);
            this.foroLink.PressedState.Parent = this.foroLink;
            this.foroLink.Size = new System.Drawing.Size(37, 44);
            this.foroLink.TabIndex = 48;
            this.foroLink.TabStop = false;
            this.toolTipLogin.SetToolTip(this.foroLink, "Foro");
            this.foroLink.UseTransparentBackground = true;
            this.foroLink.Click += new System.EventHandler(this.foroLink_Click);
            // 
            // gitHub
            // 
            this.gitHub.BackColor = System.Drawing.Color.Transparent;
            this.gitHub.CheckedState.Parent = this.gitHub;
            this.gitHub.HoveredState.Image = global::FE.Properties.Resources.icoGitHub;
            this.gitHub.HoveredState.ImageSize = new System.Drawing.Size(45, 40);
            this.gitHub.HoveredState.Parent = this.gitHub;
            this.gitHub.Image = global::FE.Properties.Resources.icoGitHub;
            this.gitHub.ImageRotate = 0F;
            this.gitHub.ImageSize = new System.Drawing.Size(40, 35);
            this.gitHub.IndicateFocus = false;
            this.gitHub.Location = new System.Drawing.Point(663, 30);
            this.gitHub.Name = "gitHub";
            this.gitHub.PressedState.Image = global::FE.Properties.Resources.icoGitHub;
            this.gitHub.PressedState.ImageSize = new System.Drawing.Size(45, 40);
            this.gitHub.PressedState.Parent = this.gitHub;
            this.gitHub.Size = new System.Drawing.Size(37, 44);
            this.gitHub.TabIndex = 47;
            this.gitHub.TabStop = false;
            this.toolTipLogin.SetToolTip(this.gitHub, "GitHub");
            this.gitHub.UseTransparentBackground = true;
            this.gitHub.Click += new System.EventHandler(this.gitHub_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.Image = global::FE.Properties.Resources.gifLogin;
            this.pictureBox3.Location = new System.Drawing.Point(0, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(257, 341);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.foroLink);
            this.Controls.Add(this.gitHub);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelControlBox);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Union Fansub";
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLogin;
        private Siticone.UI.WinForms.SiticonePanel panelControlBox;
        private Siticone.UI.WinForms.SiticoneControlBox controlClose;
        private Siticone.UI.WinForms.SiticoneControlBox controlMinimize;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Siticone.UI.WinForms.SiticoneLabel lblTitleLog;
        private Siticone.UI.WinForms.SiticoneGradientButton lblTitle;
        private Siticone.UI.WinForms.SiticoneRoundedButton linkLabel1;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnregister;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox txtPass;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox txtUser;
        private Siticone.UI.WinForms.SiticoneRoundedButton linkpass;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse2;
        private Siticone.UI.WinForms.SiticoneToolTip toolTipLogin;
        private Siticone.UI.WinForms.SiticoneImageButton gitHub;
        private Siticone.UI.WinForms.SiticoneImageButton foroLink;
    }
}

