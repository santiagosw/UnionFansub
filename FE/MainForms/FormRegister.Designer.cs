namespace FE
{
    partial class FormRegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.lblRegister = new System.Windows.Forms.Label();
            this.panelControlBox = new Siticone.UI.WinForms.SiticonePanel();
            this.controlMinimize = new Siticone.UI.WinForms.SiticoneControlBox();
            this.controlClose = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransparentDrag1 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.siticoneTransparentDrag2 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.lblTitleReg = new Siticone.UI.WinForms.SiticoneLabel();
            this.RegUser = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.RegPass = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.btnregister = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.RegEmail = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.accountready = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneElipse2 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.lblTitle = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.toolTipRegister = new Siticone.UI.WinForms.SiticoneToolTip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Oswald Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.LightGray;
            this.lblRegister.Location = new System.Drawing.Point(330, 30);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(110, 36);
            this.lblRegister.TabIndex = 13;
            this.lblRegister.Text = "REGISTER";
            this.toolTipRegister.SetToolTip(this.lblRegister, "Cree un usuario con email y contraseña. :O\r\n");
            // 
            // panelControlBox
            // 
            this.panelControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelControlBox.Controls.Add(this.controlMinimize);
            this.panelControlBox.Controls.Add(this.controlClose);
            this.panelControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panelControlBox.Location = new System.Drawing.Point(0, 0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.ShadowDecoration.Parent = this.panelControlBox;
            this.panelControlBox.Size = new System.Drawing.Size(780, 19);
            this.panelControlBox.TabIndex = 27;
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
            this.controlMinimize.TabIndex = 30;
            this.controlMinimize.TabStop = false;
            this.controlMinimize.Click += new System.EventHandler(this.controlMinimize_Click);
            // 
            // controlClose
            // 
            this.controlClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlClose.FillColor = System.Drawing.Color.Transparent;
            this.controlClose.HoveredState.FillColor = System.Drawing.Color.Red;
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
            // lblTitleReg
            // 
            this.lblTitleReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitleReg.AutoSize = false;
            this.lblTitleReg.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleReg.Font = new System.Drawing.Font("Oswald Regular", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleReg.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitleReg.IsContextMenuEnabled = false;
            this.lblTitleReg.IsSelectionEnabled = false;
            this.lblTitleReg.Location = new System.Drawing.Point(12, 276);
            this.lblTitleReg.Name = "lblTitleReg";
            this.lblTitleReg.Size = new System.Drawing.Size(226, 42);
            this.lblTitleReg.TabIndex = 30;
            this.lblTitleReg.Text = "UNION FANSUB";
            this.lblTitleReg.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegUser
            // 
            this.RegUser.Animated = false;
            this.RegUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegUser.DefaultText = "";
            this.RegUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegUser.DisabledState.Parent = this.RegUser;
            this.RegUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.RegUser.FocusedState.BorderColor = System.Drawing.Color.White;
            this.RegUser.FocusedState.Parent = this.RegUser;
            this.RegUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.RegUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.RegUser.HoveredState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegUser.HoveredState.Parent = this.RegUser;
            this.RegUser.Location = new System.Drawing.Point(331, 139);
            this.RegUser.Margin = new System.Windows.Forms.Padding(3, 20, 3, 4);
            this.RegUser.Name = "RegUser";
            this.RegUser.PasswordChar = '\0';
            this.RegUser.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.RegUser.PlaceholderText = "USUARIO";
            this.RegUser.SelectedText = "";
            this.RegUser.ShadowDecoration.Parent = this.RegUser;
            this.RegUser.Size = new System.Drawing.Size(380, 36);
            this.RegUser.TabIndex = 2;
            // 
            // RegPass
            // 
            this.RegPass.Animated = false;
            this.RegPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegPass.DefaultText = "";
            this.RegPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegPass.DisabledState.Parent = this.RegPass;
            this.RegPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.RegPass.FocusedState.BorderColor = System.Drawing.Color.White;
            this.RegPass.FocusedState.Parent = this.RegPass;
            this.RegPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.RegPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.RegPass.HoveredState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegPass.HoveredState.Parent = this.RegPass;
            this.RegPass.Location = new System.Drawing.Point(331, 199);
            this.RegPass.Margin = new System.Windows.Forms.Padding(3, 20, 3, 4);
            this.RegPass.Name = "RegPass";
            this.RegPass.PasswordChar = '*';
            this.RegPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.RegPass.PlaceholderText = "CONTRASEÑA";
            this.RegPass.SelectedText = "";
            this.RegPass.ShadowDecoration.Parent = this.RegPass;
            this.RegPass.Size = new System.Drawing.Size(380, 36);
            this.RegPass.TabIndex = 3;
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
            this.btnregister.Location = new System.Drawing.Point(331, 262);
            this.btnregister.Name = "btnregister";
            this.btnregister.ShadowDecoration.Parent = this.btnregister;
            this.btnregister.Size = new System.Drawing.Size(185, 45);
            this.btnregister.TabIndex = 4;
            this.btnregister.Text = "CONFIRMAR";
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // RegEmail
            // 
            this.RegEmail.Animated = false;
            this.RegEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegEmail.DefaultText = "";
            this.RegEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegEmail.DisabledState.Parent = this.RegEmail;
            this.RegEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.RegEmail.FocusedState.BorderColor = System.Drawing.Color.White;
            this.RegEmail.FocusedState.Parent = this.RegEmail;
            this.RegEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.RegEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.RegEmail.HoveredState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegEmail.HoveredState.Parent = this.RegEmail;
            this.RegEmail.Location = new System.Drawing.Point(331, 80);
            this.RegEmail.Margin = new System.Windows.Forms.Padding(3, 20, 3, 4);
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.PasswordChar = '\0';
            this.RegEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.RegEmail.PlaceholderText = "EMAIL";
            this.RegEmail.SelectedText = "";
            this.RegEmail.ShadowDecoration.Parent = this.RegEmail;
            this.RegEmail.Size = new System.Drawing.Size(380, 36);
            this.RegEmail.TabIndex = 1;
            // 
            // accountready
            // 
            this.accountready.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accountready.BorderThickness = 2;
            this.accountready.CheckedState.Parent = this.accountready;
            this.accountready.CustomImages.Parent = this.accountready;
            this.accountready.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accountready.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.accountready.ForeColor = System.Drawing.Color.White;
            this.accountready.HoveredState.BorderColor = System.Drawing.Color.Maroon;
            this.accountready.HoveredState.ForeColor = System.Drawing.Color.Maroon;
            this.accountready.HoveredState.Parent = this.accountready;
            this.accountready.Location = new System.Drawing.Point(543, 262);
            this.accountready.Name = "accountready";
            this.accountready.ShadowDecoration.Parent = this.accountready;
            this.accountready.Size = new System.Drawing.Size(167, 45);
            this.accountready.TabIndex = 5;
            this.accountready.Text = "CANCELAR";
            this.accountready.Click += new System.EventHandler(this.accountready_LinkClicked);
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
            // lblTitle
            // 
            this.lblTitle.CheckedState.Parent = this.lblTitle;
            this.lblTitle.CustomImages.Parent = this.lblTitle;
            this.lblTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.lblTitle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(107)))), ((int)(((byte)(118)))));
            this.lblTitle.Font = new System.Drawing.Font("Oswald Regular", 22F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.HoveredState.ForeColor = System.Drawing.Color.White;
            this.lblTitle.HoveredState.Parent = this.lblTitle;
            this.lblTitle.Location = new System.Drawing.Point(22, 272);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.ShadowDecoration.Parent = this.lblTitle;
            this.lblTitle.Size = new System.Drawing.Size(211, 49);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.TabStop = false;
            this.lblTitle.Text = "UNION FANSUB";
            // 
            // toolTipRegister
            // 
            this.toolTipRegister.AllowLinksHandling = true;
            this.toolTipRegister.AutomaticDelay = 200;
            this.toolTipRegister.BackColor = System.Drawing.Color.Black;
            this.toolTipRegister.BorderColor = System.Drawing.Color.Black;
            this.toolTipRegister.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipRegister.ForeColor = System.Drawing.Color.White;
            this.toolTipRegister.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Image = global::FE.Properties.Resources.gifRegister;
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegister
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.accountready);
            this.Controls.Add(this.RegEmail);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.RegPass);
            this.Controls.Add(this.RegUser);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelControlBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRegister);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegister";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register ";
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRegister;
        private Siticone.UI.WinForms.SiticonePanel panelControlBox;
        private Siticone.UI.WinForms.SiticoneControlBox controlClose;
        private Siticone.UI.WinForms.SiticoneControlBox controlMinimize;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag2;
        private Siticone.UI.WinForms.SiticoneLabel lblTitleReg;
        private Siticone.UI.WinForms.SiticoneGradientButton lblTitle;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox RegPass;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox RegUser;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnregister;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox RegEmail;
        private Siticone.UI.WinForms.SiticoneRoundedButton accountready;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse2;
        private Siticone.UI.WinForms.SiticoneToolTip toolTipRegister;
    }
}