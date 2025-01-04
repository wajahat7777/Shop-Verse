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
    public partial class CustInterface : Form
    {
        public CustInterface()
        {
            InitializeComponent();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void PrSearch_Click(object sender, EventArgs e)
        {
            CustProductSearch custProductSearch = new CustProductSearch();  
            custProductSearch.Show();
            this.Hide();
        }

        private void ViewCart_Click(object sender, EventArgs e)
        {
            CustShoppingCart custShoppingCart = new CustShoppingCart(); 
            custShoppingCart.Show();
            this.Hide();
        }

        private void ReviewOrd_Click(object sender, EventArgs e)
        {
            CustReview custReview = new CustReview();   
            custReview.Show();
            this.Hide();
        }

        private void ProfileMgmt_Click(object sender, EventArgs e)
        {
            CustProfileManagement custProfileManagement = new CustProfileManagement();  
            custProfileManagement.Show();
            this.Hide();

        }
    }
}
