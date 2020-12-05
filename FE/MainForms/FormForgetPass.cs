using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Data.SqlClient;
using System.Diagnostics;
using FE;

namespace Union_Fansub.MainForms
{
    public partial class FormForgetPass : Form
    {
        PrivateFontCollection pfp = new PrivateFontCollection();
        public FormForgetPass()
        {
            InitializeComponent();
            pfp.AddFontFile("Oswald-Regular.ttf");
            fontLoad();
        }

        private void fontLoad()
        {
            lblTitleForget.Font = new Font(pfp.Families[0], 15, FontStyle.Regular);
        }


        #region Enviar Mail
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Instanciamos un System.Net.Mail como mmsg y introducimos un Subject
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage(); 
            if (txtEmail.Text != "")
            {
                mmsg.To.Add(txtEmail.Text);
                mmsg.Subject = "Recuperacion de Contraseña - Union Fansub";
                mmsg.Body = "" +
                    "<body>" +
                        "<h1>Parece que has perdido tu contraseña </h1>" +
                        "<h4>Entra al siguiente link para recuperarla:</h4>" +
                        "<span>http://foro.unionfansub.com/member.php?action=lostpw</span>" +
                    "</body>";

                mmsg.IsBodyHtml = true;
                mmsg.From = new System.Net.Mail.MailAddress("satir2509@gmail.com", "Recuperacion de Contraseña");

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                cliente.Credentials = new System.Net.NetworkCredential("satir2509@gmail.com", "harunonoka1");
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com";

                if ((txtEmail.Text != "") || (txtEmail.Text != ""))
                {
                    cliente.Send(mmsg);
                    FormLogin f = new FormLogin();
                    f.Visible = false;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error al enviar");
                }
            }
           
        }
        #endregion

    }
}
