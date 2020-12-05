namespace Union_Fansub.MainForms
{
    partial class FormForgetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgetPass));
            this.panelControlBox = new Siticone.UI.WinForms.SiticonePanel();
            this.controlMinimize = new Siticone.UI.WinForms.SiticoneControlBox();
            this.controlClose = new Siticone.UI.WinForms.SiticoneControlBox();
            this.btnEnviar = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.txtEmail = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneTransparentDrag1 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.siticoneCirclePictureBox1 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.lblTitleForget = new Siticone.UI.WinForms.SiticoneLabel();
            this.toolTipForget = new Siticone.UI.WinForms.SiticoneToolTip();
            this.siticoneTransparentDrag2 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panelControlBox.Size = new System.Drawing.Size(559, 19);
            this.panelControlBox.TabIndex = 30;
            // 
            // controlMinimize
            // 
            this.controlMinimize.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlMinimize.FillColor = System.Drawing.Color.Transparent;
            this.controlMinimize.HoveredState.FillColor = System.Drawing.Color.Gainsboro;
            this.controlMinimize.HoveredState.Parent = this.controlMinimize;
            this.controlMinimize.IconColor = System.Drawing.Color.White;
            this.controlMinimize.Location = new System.Drawing.Point(509, 0);
            this.controlMinimize.Name = "controlMinimize";
            this.controlMinimize.ShadowDecoration.Parent = this.controlMinimize;
            this.controlMinimize.Size = new System.Drawing.Size(25, 19);
            this.controlMinimize.TabIndex = 29;
            // 
            // controlClose
            // 
            this.controlClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlClose.FillColor = System.Drawing.Color.Transparent;
            this.controlClose.HoveredState.FillColor = System.Drawing.Color.Maroon;
            this.controlClose.HoveredState.Parent = this.controlClose;
            this.controlClose.IconColor = System.Drawing.Color.White;
            this.controlClose.Location = new System.Drawing.Point(534, 0);
            this.controlClose.Name = "controlClose";
            this.controlClose.ShadowDecoration.Parent = this.controlClose;
            this.controlClose.Size = new System.Drawing.Size(25, 19);
            this.controlClose.TabIndex = 28;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEnviar.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnEnviar.BorderThickness = 2;
            this.btnEnviar.CheckedState.Parent = this.btnEnviar;
            this.btnEnviar.CustomImages.Parent = this.btnEnviar;
            this.btnEnviar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(181)))), ((int)(((byte)(165)))));
            this.btnEnviar.HoveredState.ForeColor = System.Drawing.Color.Pink;
            this.btnEnviar.HoveredState.Parent = this.btnEnviar;
            this.btnEnviar.Location = new System.Drawing.Point(235, 190);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.ShadowDecoration.Parent = this.btnEnviar;
            this.btnEnviar.Size = new System.Drawing.Size(254, 45);
            this.btnEnviar.TabIndex = 46;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = false;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.HoveredState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.HoveredState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(235, 147);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 20, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceholderText = "EMAIL";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(254, 36);
            this.txtEmail.TabIndex = 47;
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this;
            // 
            // siticoneTransparentDrag1
            // 
            this.siticoneTransparentDrag1.DragEndTransparencyValue = 1D;
            this.siticoneTransparentDrag1.DragStartTransparencyValue = 0.9D;
            this.siticoneTransparentDrag1.TargetDragControl = this;
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.Image = global::FE.Properties.Resources.gifRegretPass;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(-104, 3);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(310, 341);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.siticoneCirclePictureBox1.TabIndex = 48;
            this.siticoneCirclePictureBox1.TabStop = false;
            // 
            // lblTitleForget
            // 
            this.lblTitleForget.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleForget.Font = new System.Drawing.Font("Oswald Regular", 15F);
            this.lblTitleForget.ForeColor = System.Drawing.Color.White;
            this.lblTitleForget.Location = new System.Drawing.Point(235, 85);
            this.lblTitleForget.Name = "lblTitleForget";
            this.lblTitleForget.Size = new System.Drawing.Size(254, 29);
            this.lblTitleForget.TabIndex = 49;
            this.lblTitleForget.Text = "¿HA OLVIDADO SU CONTRASEÑA?";
            this.toolTipForget.SetToolTip(this.lblTitleForget, "Ingrese su email para crear una nueva contraseña.");
            // 
            // toolTipForget
            // 
            this.toolTipForget.AllowLinksHandling = true;
            this.toolTipForget.AutomaticDelay = 200;
            this.toolTipForget.BackColor = System.Drawing.Color.Black;
            this.toolTipForget.BorderColor = System.Drawing.Color.Black;
            this.toolTipForget.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipForget.ForeColor = System.Drawing.Color.White;
            this.toolTipForget.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // siticoneTransparentDrag2
            // 
            this.siticoneTransparentDrag2.DragEndTransparencyValue = 1D;
            this.siticoneTransparentDrag2.DragStartTransparencyValue = 0.9D;
            this.siticoneTransparentDrag2.TargetDragControl = this.panelControlBox;
            // 
            // FormForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(559, 311);
            this.Controls.Add(this.lblTitleForget);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.panelControlBox);
            this.Controls.Add(this.siticoneCirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormForgetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForgetPass";
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticonePanel panelControlBox;
        private Siticone.UI.WinForms.SiticoneControlBox controlMinimize;
        private Siticone.UI.WinForms.SiticoneControlBox controlClose;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnEnviar;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox txtEmail;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private Siticone.UI.WinForms.SiticoneLabel lblTitleForget;
        private Siticone.UI.WinForms.SiticoneToolTip toolTipForget;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag2;
    }
}