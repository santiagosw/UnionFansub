namespace FE.Forms
{
    partial class Premium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Premium));
            this.lblTitle = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneSeparator1 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.siticoneShadowPanel1 = new Siticone.UI.WinForms.SiticoneShadowPanel();
            this.btnPremiumEnter = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.txtCode = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.lblAnimes = new System.Windows.Forms.Label();
            this.pnlPremiumActive = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneCirclePictureBox1 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneShadowPanel1.SuspendLayout();
            this.pnlPremiumActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderColor = System.Drawing.Color.White;
            this.lblTitle.CheckedState.Parent = this.lblTitle;
            this.lblTitle.CustomImages.Parent = this.lblTitle;
            this.lblTitle.FillColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Quicksand Medium", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.HoveredState.Parent = this.lblTitle;
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.ShadowDecoration.Parent = this.lblTitle;
            this.lblTitle.Size = new System.Drawing.Size(324, 51);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "¡UNETE A PREMIUM!";
            this.lblTitle.UseTransparentBackground = true;
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Location = new System.Drawing.Point(3, 44);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(321, 10);
            this.siticoneSeparator1.TabIndex = 37;
            // 
            // siticoneShadowPanel1
            // 
            this.siticoneShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel1.Controls.Add(this.btnPremiumEnter);
            this.siticoneShadowPanel1.Controls.Add(this.txtCode);
            this.siticoneShadowPanel1.Controls.Add(this.lblAnimes);
            this.siticoneShadowPanel1.Controls.Add(this.lblTitle);
            this.siticoneShadowPanel1.Controls.Add(this.siticoneSeparator1);
            this.siticoneShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel1.Location = new System.Drawing.Point(593, 56);
            this.siticoneShadowPanel1.Name = "siticoneShadowPanel1";
            this.siticoneShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel1.Size = new System.Drawing.Size(327, 329);
            this.siticoneShadowPanel1.TabIndex = 38;
            // 
            // btnPremiumEnter
            // 
            this.btnPremiumEnter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPremiumEnter.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnPremiumEnter.BorderThickness = 2;
            this.btnPremiumEnter.CheckedState.Parent = this.btnPremiumEnter;
            this.btnPremiumEnter.CustomImages.Parent = this.btnPremiumEnter;
            this.btnPremiumEnter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPremiumEnter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPremiumEnter.ForeColor = System.Drawing.Color.White;
            this.btnPremiumEnter.HoveredState.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnPremiumEnter.HoveredState.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnPremiumEnter.HoveredState.Parent = this.btnPremiumEnter;
            this.btnPremiumEnter.Location = new System.Drawing.Point(71, 222);
            this.btnPremiumEnter.Name = "btnPremiumEnter";
            this.btnPremiumEnter.ShadowDecoration.Parent = this.btnPremiumEnter;
            this.btnPremiumEnter.Size = new System.Drawing.Size(181, 45);
            this.btnPremiumEnter.TabIndex = 53;
            this.btnPremiumEnter.Text = "Validar Codigo";
            this.btnPremiumEnter.Click += new System.EventHandler(this.btnPremiumEnter_Click);
            // 
            // txtCode
            // 
            this.txtCode.Animated = false;
            this.txtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.DisabledState.Parent = this.txtCode;
            this.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtCode.FocusedState.Parent = this.txtCode;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCode.HoveredState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCode.HoveredState.Parent = this.txtCode;
            this.txtCode.Location = new System.Drawing.Point(34, 141);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 21, 3, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCode.PlaceholderText = "Codigo";
            this.txtCode.SelectedText = "";
            this.txtCode.ShadowDecoration.Parent = this.txtCode;
            this.txtCode.Size = new System.Drawing.Size(257, 38);
            this.txtCode.TabIndex = 39;
            // 
            // lblAnimes
            // 
            this.lblAnimes.AutoSize = true;
            this.lblAnimes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimes.ForeColor = System.Drawing.Color.White;
            this.lblAnimes.Location = new System.Drawing.Point(30, 101);
            this.lblAnimes.Name = "lblAnimes";
            this.lblAnimes.Size = new System.Drawing.Size(261, 19);
            this.lblAnimes.TabIndex = 38;
            this.lblAnimes.Text = "Ingresa el codigo de activacion";
            // 
            // pnlPremiumActive
            // 
            this.pnlPremiumActive.Controls.Add(this.label3);
            this.pnlPremiumActive.Controls.Add(this.label2);
            this.pnlPremiumActive.Controls.Add(this.label1);
            this.pnlPremiumActive.Controls.Add(this.siticoneCirclePictureBox1);
            this.pnlPremiumActive.Location = new System.Drawing.Point(593, 56);
            this.pnlPremiumActive.Name = "pnlPremiumActive";
            this.pnlPremiumActive.ShadowDecoration.Parent = this.pnlPremiumActive;
            this.pnlPremiumActive.Size = new System.Drawing.Size(327, 329);
            this.pnlPremiumActive.TabIndex = 39;
            this.pnlPremiumActive.Visible = false;
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox1.Image = global::FE.Properties.Resources.gfPremium;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(63, 19);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(200, 200);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.siticoneCirclePictureBox1.TabIndex = 0;
            this.siticoneCirclePictureBox1.TabStop = false;
            this.siticoneCirclePictureBox1.UseTransparentBackground = true;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(57)))));
            this.siticonePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePictureBox1.Image = global::FE.Properties.Resources.bgPremium2;
            this.siticonePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(1005, 504);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 35;
            this.siticonePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "¡YA ERES PREMIUM!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 34);
            this.label3.TabIndex = 56;
            this.label3.Text = "Vuelve a abrir sesion \r\npara actualizar los cambios";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Premium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1005, 504);
            this.Controls.Add(this.pnlPremiumActive);
            this.Controls.Add(this.siticoneShadowPanel1);
            this.Controls.Add(this.siticonePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Premium";
            this.Text = "Premium";
            this.siticoneShadowPanel1.ResumeLayout(false);
            this.siticoneShadowPanel1.PerformLayout();
            this.pnlPremiumActive.ResumeLayout(false);
            this.pnlPremiumActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.UI.WinForms.SiticoneButton lblTitle;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel1;
        private System.Windows.Forms.Label lblAnimes;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox txtCode;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnPremiumEnter;
        private Siticone.UI.WinForms.SiticonePanel pnlPremiumActive;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}