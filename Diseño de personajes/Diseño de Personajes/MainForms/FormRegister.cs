using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using BE;

namespace FE
{   
    
    public partial class FormRegister : Form
    {
        accountsList accounts = new accountsList();
        PrivateFontCollection pfp = new PrivateFontCollection();
        public FormRegister()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            pfp.AddFontFile("Oswald-Regular.ttf");
            fontLoad();
        }

        private void fontLoad()
        {
            lblTitle.Font = new Font(pfp.Families[0], 20, FontStyle.Regular);
            lblRegister.Font = new Font(pfp.Families[0], 19, FontStyle.Regular);
        }

        //Close Program
        private void controlClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //Minimize Program
        private void controlMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Back Login
        private void accountready_LinkClicked(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Visible = true;
            this.Close();
        }

        
        

        //Write in XML
        private void btnregister_Click(object sender, EventArgs e)
        {
            if ((RegEmail.Text == "") || (RegUser.Text == "") || (RegPass.Text == ""))
            {
                RegEmail.PlaceholderForeColor = Color.Maroon;
                RegUser.PlaceholderForeColor = Color.Maroon;
                RegPass.PlaceholderForeColor = Color.Maroon;
                this.Refresh();

            }
            if ((RegEmail.Text != "") && (RegUser.Text != "") && (RegPass.Text != ""))
            {
                accounts.savedata(RegEmail.Text, RegUser.Text, RegPass.Text);
                FormLogin f = new FormLogin();
                f.Visible = true;
                this.Close();

            }
           

        }

    }
}
