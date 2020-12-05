using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace FE.Forms
{

    public partial class Premium : Form
    {
        string userpremium;
        accountsList premiumdata = new accountsList();
        
        public Premium(string actualuser)
        {
            InitializeComponent();
            userpremium = actualuser;

            
        }

        private void btnPremiumEnter_Click(object sender, EventArgs e)
        {

            if (txtCode.Text == "rule")
            {
                pnlPremiumActive.Visible = true;
                premiumdata.validateCode(userpremium);

            }

        }
    }
}
