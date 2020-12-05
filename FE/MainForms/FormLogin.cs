using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using ErrorMessage.MainForms;
using Union_Fansub.MainForms;
using System.Drawing.Text;
using BE;

namespace FE
{
    public partial class FormLogin : Form
    {
        accountsList validateAccounts = new accountsList();
        PrivateFontCollection pfp = new PrivateFontCollection();


        public FormLogin()
        {
            InitializeComponent();
            //Quitamos el encabezado de Win.
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            pfp.AddFontFile("Oswald-Regular.ttf");
            fontLoad();
        }

        private void fontLoad()
        {
            lblTitle.Font = new Font(pfp.Families[0], 20, FontStyle.Regular);
            lblLogin.Font = new Font(pfp.Families[0], 19, FontStyle.Regular);

        }
      

        //Close Form
        private void controlClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimize Form
        private void controlMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Enter Register
        private void clicRegister_LinkClicked_1(object sender, EventArgs e)
        {
            FormRegister f = new FormRegister();
            f.Visible = true;
            this.Close();
        }

        //Enter ForgetPass
        private void clicForgetPass_LinkClicked(object sender, EventArgs e)
        {
            FormForgetPass f = new FormForgetPass();
            f.Visible = true;
        }

        //Enter Links
        private void gitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/santiagosw");
        }
        private void foroLink_Click(object sender, EventArgs e)
        {
            Process.Start("http://foro.unionfansub.com/");

        }


        #region ValidateLogin
        private void btnlogin_Click(object sender, EventArgs e)
        {

            if ((txtUser.Text == "") || (txtPass.Text == ""))
            {
               txtUser.PlaceholderForeColor = Color.Maroon;
               txtPass.PlaceholderForeColor = Color.Maroon;
            }
            if ((txtUser.Text != "") && (txtPass.Text != ""))
            {
                if (validateAccounts.validate(txtUser.Text,txtPass.Text) == true)
                {
                    string premium = validateAccounts.premiumState(txtUser.Text);
                    //Enter Menu
                    Form f = new FormMainMenu(txtUser.Text, premium);
                    f.Visible = true;
                    this.Close();
                }
                else
                {
                    FormLogError f = new FormLogError();
                    f.Visible = true;

                }

            }
        }

        #endregion

        
    }

}
