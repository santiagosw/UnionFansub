namespace FE
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pbAd = new Siticone.UI.WinForms.SiticonePictureBox();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnPremium = new FontAwesome.Sharp.IconButton();
            this.btnManga = new FontAwesome.Sharp.IconButton();
            this.btnShow = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.controlMinimize = new Siticone.UI.WinForms.SiticoneControlBox();
            this.controlClose = new Siticone.UI.WinForms.SiticoneControlBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblUserShow = new System.Windows.Forms.Label();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.siticoneTransparentDrag1 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.siticoneTransparentDrag2 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.toolTipMenu = new Siticone.UI.WinForms.SiticoneToolTip();
            this.pnlDesktop = new Siticone.UI.WinForms.SiticonePanel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAd)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.pbAd);
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnPremium);
            this.panelMenu.Controls.Add(this.btnManga);
            this.panelMenu.Controls.Add(this.btnShow);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 556);
            this.panelMenu.TabIndex = 0;
            // 
            // pbAd
            // 
            this.pbAd.BackColor = System.Drawing.Color.Transparent;
            this.pbAd.Image = ((System.Drawing.Image)(resources.GetObject("pbAd.Image")));
            this.pbAd.Location = new System.Drawing.Point(-14, 323);
            this.pbAd.Name = "pbAd";
            this.pbAd.ShadowDecoration.Parent = this.pbAd;
            this.pbAd.Size = new System.Drawing.Size(237, 167);
            this.pbAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAd.TabIndex = 7;
            this.pbAd.TabStop = false;
            this.pbAd.UseTransparentBackground = true;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSetting.ForeColor = System.Drawing.Color.LightGray;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.btnSetting.IconColor = System.Drawing.Color.LightGray;
            this.btnSetting.IconSize = 32;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 496);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Rotation = 0D;
            this.btnSetting.Size = new System.Drawing.Size(220, 60);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "Cerrar Sesion ";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnPremium
            // 
            this.btnPremium.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPremium.FlatAppearance.BorderSize = 0;
            this.btnPremium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPremium.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPremium.ForeColor = System.Drawing.Color.LightGray;
            this.btnPremium.IconChar = FontAwesome.Sharp.IconChar.Splotch;
            this.btnPremium.IconColor = System.Drawing.Color.LightGray;
            this.btnPremium.IconSize = 32;
            this.btnPremium.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPremium.Location = new System.Drawing.Point(0, 262);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPremium.Rotation = 0D;
            this.btnPremium.Size = new System.Drawing.Size(220, 60);
            this.btnPremium.TabIndex = 5;
            this.btnPremium.Text = "Premium";
            this.btnPremium.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPremium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPremium.UseVisualStyleBackColor = true;
            this.btnPremium.Click += new System.EventHandler(this.btnPremium_Click);
            // 
            // btnManga
            // 
            this.btnManga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManga.FlatAppearance.BorderSize = 0;
            this.btnManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManga.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnManga.ForeColor = System.Drawing.Color.LightGray;
            this.btnManga.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnManga.IconColor = System.Drawing.Color.LightGray;
            this.btnManga.IconSize = 32;
            this.btnManga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManga.Location = new System.Drawing.Point(0, 202);
            this.btnManga.Name = "btnManga";
            this.btnManga.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnManga.Rotation = 0D;
            this.btnManga.Size = new System.Drawing.Size(220, 60);
            this.btnManga.TabIndex = 3;
            this.btnManga.Text = "Manga";
            this.btnManga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManga.UseVisualStyleBackColor = true;
            this.btnManga.Click += new System.EventHandler(this.btnManga_Click);
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnShow.ForeColor = System.Drawing.Color.LightGray;
            this.btnShow.IconChar = FontAwesome.Sharp.IconChar.Tv;
            this.btnShow.IconColor = System.Drawing.Color.LightGray;
            this.btnShow.IconSize = 32;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(0, 142);
            this.btnShow.Name = "btnShow";
            this.btnShow.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnShow.Rotation = 0D;
            this.btnShow.Size = new System.Drawing.Size(220, 60);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Anime";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHome.ForeColor = System.Drawing.Color.LightGray;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.LightGray;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 82);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Rotation = 0D;
            this.btnHome.Size = new System.Drawing.Size(220, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Dashboard";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnInicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 82);
            this.panelLogo.TabIndex = 1;
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(223, 85);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelTitleBar.Controls.Add(this.siticoneControlBox1);
            this.panelTitleBar.Controls.Add(this.controlMinimize);
            this.panelTitleBar.Controls.Add(this.controlClose);
            this.panelTitleBar.Controls.Add(this.lblBienvenido);
            this.panelTitleBar.Controls.Add(this.lblUserShow);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1005, 52);
            this.panelTitleBar.TabIndex = 1;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.Gainsboro;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(955, 0);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(25, 19);
            this.siticoneControlBox1.TabIndex = 32;
            // 
            // controlMinimize
            // 
            this.controlMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlMinimize.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlMinimize.FillColor = System.Drawing.Color.Transparent;
            this.controlMinimize.HoveredState.FillColor = System.Drawing.Color.Gainsboro;
            this.controlMinimize.HoveredState.Parent = this.controlMinimize;
            this.controlMinimize.IconColor = System.Drawing.Color.White;
            this.controlMinimize.Location = new System.Drawing.Point(930, 0);
            this.controlMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.controlMinimize.Name = "controlMinimize";
            this.controlMinimize.ShadowDecoration.Parent = this.controlMinimize;
            this.controlMinimize.Size = new System.Drawing.Size(25, 19);
            this.controlMinimize.TabIndex = 31;
            // 
            // controlClose
            // 
            this.controlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlClose.FillColor = System.Drawing.Color.Transparent;
            this.controlClose.HoveredState.FillColor = System.Drawing.Color.Maroon;
            this.controlClose.HoveredState.Parent = this.controlClose;
            this.controlClose.IconColor = System.Drawing.Color.White;
            this.controlClose.Location = new System.Drawing.Point(980, 0);
            this.controlClose.Margin = new System.Windows.Forms.Padding(0);
            this.controlClose.Name = "controlClose";
            this.controlClose.ShadowDecoration.Parent = this.controlClose;
            this.controlClose.Size = new System.Drawing.Size(25, 19);
            this.controlClose.TabIndex = 30;
            this.controlClose.Click += new System.EventHandler(this.controlClose_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBienvenido.Location = new System.Drawing.Point(785, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Padding = new System.Windows.Forms.Padding(0, 17, 0, 0);
            this.lblBienvenido.Size = new System.Drawing.Size(91, 33);
            this.lblBienvenido.TabIndex = 22;
            this.lblBienvenido.Text = "Bienvenido/a:";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserShow
            // 
            this.lblUserShow.AutoSize = true;
            this.lblUserShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUserShow.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserShow.ForeColor = System.Drawing.Color.White;
            this.lblUserShow.Location = new System.Drawing.Point(876, 0);
            this.lblUserShow.Name = "lblUserShow";
            this.lblUserShow.Padding = new System.Windows.Forms.Padding(0, 15, 90, 0);
            this.lblUserShow.Size = new System.Drawing.Size(129, 42);
            this.lblUserShow.TabIndex = 21;
            this.lblUserShow.Text = "user";
            this.lblUserShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipMenu.SetToolTip(this.lblUserShow, "Nombre de usuario");
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitleChildForm.Location = new System.Drawing.Point(52, 21);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(59, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Dashboard";
            this.toolTipMenu.SetToolTip(this.lblTitleChildForm, "Pestaña actual");
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.DarkGray;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.DarkGray;
            this.iconCurrentChildForm.IconSize = 30;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(19, 14);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(30, 30);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            this.toolTipMenu.SetToolTip(this.iconCurrentChildForm, "Pestaña actual");
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
            this.siticoneTransparentDrag2.TargetDragControl = this.panelTitleBar;
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 15;
            this.siticoneElipse1.TargetControl = this;
            // 
            // toolTipMenu
            // 
            this.toolTipMenu.AllowLinksHandling = true;
            this.toolTipMenu.AutomaticDelay = 200;
            this.toolTipMenu.BackColor = System.Drawing.Color.Black;
            this.toolTipMenu.BorderColor = System.Drawing.Color.Black;
            this.toolTipMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipMenu.ForeColor = System.Drawing.Color.White;
            this.toolTipMenu.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.Gray;
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(220, 52);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.ShadowDecoration.Parent = this.pnlDesktop;
            this.pnlDesktop.Size = new System.Drawing.Size(1005, 504);
            this.pnlDesktop.TabIndex = 4;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1225, 556);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainMenu";
            this.Opacity = 0.9D;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAd)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnManga;
        private FontAwesome.Sharp.IconButton btnShow;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnSetting;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblUserShow;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneControlBox controlMinimize;
        private Siticone.UI.WinForms.SiticoneControlBox controlClose;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag2;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneToolTip toolTipMenu;
        private FontAwesome.Sharp.IconButton btnPremium;
        private Siticone.UI.WinForms.SiticonePanel pnlDesktop;
        private Siticone.UI.WinForms.SiticonePictureBox pbAd;
    }
}