namespace ErrorMessage.MainForms
{
    partial class FormLogError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogError));
            this.panelControlBox = new Siticone.UI.WinForms.SiticonePanel();
            this.controlMinimize = new Siticone.UI.WinForms.SiticoneControlBox();
            this.controlClose = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransparentDrag1 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.siticoneTransparentDrag2 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.lblTitle = new Siticone.UI.WinForms.SiticoneLabel();
            this.backLogin = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.toolTipError = new Siticone.UI.WinForms.SiticoneToolTip();
            this.siticoneCirclePictureBox1 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
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
            this.panelControlBox.Size = new System.Drawing.Size(513, 19);
            this.panelControlBox.TabIndex = 29;
            // 
            // controlMinimize
            // 
            this.controlMinimize.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlMinimize.FillColor = System.Drawing.Color.Transparent;
            this.controlMinimize.HoveredState.FillColor = System.Drawing.Color.Gainsboro;
            this.controlMinimize.HoveredState.Parent = this.controlMinimize;
            this.controlMinimize.IconColor = System.Drawing.Color.White;
            this.controlMinimize.Location = new System.Drawing.Point(463, 0);
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
            this.controlClose.Location = new System.Drawing.Point(488, 0);
            this.controlClose.Name = "controlClose";
            this.controlClose.ShadowDecoration.Parent = this.controlClose;
            this.controlClose.Size = new System.Drawing.Size(25, 19);
            this.controlClose.TabIndex = 28;
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
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Oswald Regular", 15F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(200, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 29);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "INFORMACION DE SESION INCORRECTA\r\n";
            // 
            // backLogin
            // 
            this.backLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.backLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.backLogin.BorderThickness = 2;
            this.backLogin.CheckedState.Parent = this.backLogin;
            this.backLogin.CustomImages.Parent = this.backLogin;
            this.backLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.backLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backLogin.ForeColor = System.Drawing.Color.White;
            this.backLogin.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(175)))), ((int)(((byte)(140)))));
            this.backLogin.HoveredState.ForeColor = System.Drawing.Color.Peru;
            this.backLogin.HoveredState.Parent = this.backLogin;
            this.backLogin.Location = new System.Drawing.Point(220, 107);
            this.backLogin.Name = "backLogin";
            this.backLogin.ShadowDecoration.Parent = this.backLogin;
            this.backLogin.Size = new System.Drawing.Size(239, 45);
            this.backLogin.TabIndex = 41;
            this.backLogin.Text = "OK";
            this.backLogin.Click += new System.EventHandler(this.backLogin_Click);
            // 
            // toolTipError
            // 
            this.toolTipError.AllowLinksHandling = true;
            this.toolTipError.AutomaticDelay = 200;
            this.toolTipError.BackColor = System.Drawing.Color.Black;
            this.toolTipError.BorderColor = System.Drawing.Color.Black;
            this.toolTipError.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipError.ForeColor = System.Drawing.Color.White;
            this.toolTipError.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.Image = global::FE.Properties.Resources.giferrorreg;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(-73, 3);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(249, 222);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox1.TabIndex = 43;
            this.siticoneCirclePictureBox1.TabStop = false;
            // 
            // FormLogError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(513, 212);
            this.Controls.Add(this.backLogin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelControlBox);
            this.Controls.Add(this.siticoneCirclePictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogError";
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticonePanel panelControlBox;
        private Siticone.UI.WinForms.SiticoneControlBox controlMinimize;
        private Siticone.UI.WinForms.SiticoneControlBox controlClose;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag2;
        private Siticone.UI.WinForms.SiticoneLabel lblTitle;
        private Siticone.UI.WinForms.SiticoneRoundedButton backLogin;
        private Siticone.UI.WinForms.SiticoneToolTip toolTipError;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
    }
}