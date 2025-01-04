using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AdInterface : Form
    {
        public AdInterface()
        {
            Application.Run(new SellerReports());
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MainMenu F = new MainMenu();
            F.Show();
            this.Close();
        }

        private void AdOrderMgmtButton_Click(object sender, EventArgs e)
        {

        }

        private void PrCatMgmt_Click(object sender, EventArgs e)
        {

        }

        private void ReviewModButton_Click(object sender, EventArgs e)
        {

        }

        private void AdSellCust_Click(object sender, EventArgs e)
        {

        }

        private void AdReportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
