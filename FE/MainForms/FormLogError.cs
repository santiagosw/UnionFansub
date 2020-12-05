using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Text;
using FE;

namespace ErrorMessage.MainForms
{
    public partial class FormLogError : Form
    {
        PrivateFontCollection pfp = new PrivateFontCollection();
        public FormLogError()
        {
            InitializeComponent();
            pfp.AddFontFile("Oswald-Regular.ttf");
            fontLoad();
        }

        private void fontLoad()
        {
            lblTitle.Font = new Font(pfp.Families[0], 14, FontStyle.Regular);
        }

        //Volver Login
        private void backLogin_Click(object sender, EventArgs e)
        {
             FormLogin f = new FormLogin();
            f.Visible = false;
            this.Close();
        }


    }
}
