using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using FE.Forms;
using FE.ChildForms;

namespace FE
{
    public partial class FormMainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        string actualuser;
        string premiumState;
        public FormMainMenu(string userlogin, string premium)
        {
            //Form Size Initialize
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Sin encabezado de windows
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Music Background
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.toro);
            player.PlayLooping();

            //lblUser
            actualuser = userlogin;
            lblUserShow.Text = userlogin;
            premiumState = premium;

        }

        //Cerrar Programa
        private void controlClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //colorsIconsRGB
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(50, 50, 50);
                currentBtn.ForeColor = Color.LightGray;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.LightGray;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        //Open ChildForm (Cerrar Formualario actual y traer al seleccionado al frente)
        private void OpenChildForm(Form childForm)
        {
          
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
       
        }

        #region OpenChildForm
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Home());

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Anime());

        }

        private void btnManga_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Manga());
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Premium(actualuser));


        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            Exit f = new Exit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                FormLogin w = new FormLogin();
                w.Show();
                this.Close();
            }
        
        }

        #endregion

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
            if (premiumState == "Y")
            {
                btnPremium.Visible = false;
                pbAd.Visible = false;
            }

           
        }

       
    }
}
