using Microsoft.Reporting.Map.WebForms.BingMaps;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
           
            InitializeComponent();
           
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            Login F = new Login();
            F.Show();
            this.Hide();
        }

        private void SellerButton_Click(object sender, EventArgs e)
        {
            Login F1 = new Login();
            F1.Show();
            this.Hide();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdInterface F2 = new AdInterface();
            F2.Show();
            this.Hide();
        }

        private void LogisticsButton_Click(object sender, EventArgs e)
        {
            LogInterface F3 = new LogInterface();
            F3.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
