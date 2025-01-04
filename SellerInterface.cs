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
    public partial class SellerInterface : Form
    {
        public SellerInterface()
        {
            InitializeComponent();
        }

        private void SellerInterface_Load(object sender, EventArgs e)
        {

        }
        private void AddPr_Click(object sender, EventArgs e)
        {
            SellerInvMgmt invMgmtForm = new SellerInvMgmt();
            invMgmtForm.Show();
            this.Hide();
        }

        private void UpdPr_Click(object sender, EventArgs e)
        {
            SellerInvMgmt invMgmtForm = new SellerInvMgmt();
            invMgmtForm.Show();
            this.Hide();
        }

        private void DelPr_Click(object sender, EventArgs e)
        {
            SellerInvMgmt invMgmtForm = new SellerInvMgmt();
            invMgmtForm.Show();
            this.Hide();
        }

        private void Inv_Click(object sender, EventArgs e)
        {
            SellerInvMgmt invMgmtForm = new SellerInvMgmt();
            invMgmtForm.Show();
            this.Hide();
        }

        private void ViewOrders_Click(object sender, EventArgs e)
        {
            SellerOrderFulfillment OForm = new SellerOrderFulfillment();
            OForm.Show();
            this.Hide();
        }

        private void OrderStat_Click(object sender, EventArgs e)
        {
            SellerOrderFulfillment OForm = new SellerOrderFulfillment();
            OForm.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
