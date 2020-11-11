namespace FE.ChildForms
{
    partial class Exit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exit));
            this.panelControlBox = new Siticone.UI.WinForms.SiticonePanel();
            this.controlMinimize = new Siticone.UI.WinForms.SiticoneControlBox();
            this.controlClose = new Siticone.UI.WinForms.SiticoneControlBox();
            this.lblTitle = new Siticone.UI.WinForms.SiticoneLabel();
            this.btnExit = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.btnStay = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneTransparentDrag1 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.siticoneTransparentDrag2 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
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
            this.panelControlBox.TabIndex = 31;
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
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(227, 92);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 20);
            this.lblTitle.TabIndex = 50;
            this.lblTitle.Text = "¿SEGURO QUIERES CERRAR SESION?\r\n";
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExit.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnExit.BorderThickness = 2;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoveredState.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnExit.HoveredState.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnExit.HoveredState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(227, 143);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(126, 45);
            this.btnExit.TabIndex = 52;
            this.btnExit.Text = "SI";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStay
            // 
            this.btnStay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStay.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnStay.BorderThickness = 2;
            this.btnStay.CheckedState.Parent = this.btnStay;
            this.btnStay.CustomImages.Parent = this.btnStay;
            this.btnStay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStay.ForeColor = System.Drawing.Color.White;
            this.btnStay.HoveredState.BorderColor = System.Drawing.Color.Maroon;
            this.btnStay.HoveredState.ForeColor = System.Drawing.Color.Maroon;
            this.btnStay.HoveredState.Parent = this.btnStay;
            this.btnStay.Location = new System.Drawing.Point(388, 143);
            this.btnStay.Name = "btnStay";
            this.btnStay.ShadowDecoration.Parent = this.btnStay;
            this.btnStay.Size = new System.Drawing.Size(127, 45);
            this.btnStay.TabIndex = 53;
            this.btnStay.Text = "No";
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
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
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = global::FE.Properties.Resources.gfBye;
            this.siticonePictureBox1.Location = new System.Drawing.Point(-69, 12);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(314, 239);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 54;
            this.siticonePictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.AcceptButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CancelButton = this.btnStay;
            this.ClientSize = new System.Drawing.Size(559, 250);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelControlBox);
            this.Controls.Add(this.siticonePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel panelControlBox;
        private Siticone.UI.WinForms.SiticoneControlBox controlMinimize;
        private Siticone.UI.WinForms.SiticoneControlBox controlClose;
        private Siticone.UI.WinForms.SiticoneLabel lblTitle;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnExit;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnStay;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag2;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
    }
}