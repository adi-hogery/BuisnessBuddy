using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP16
{
    public partial class Customer_sPage : Form
    {
        int empNum;
        public Customer_sPage(int num)
        {
            InitializeComponent();
            this.empNum = num;
            
        }



        private void Customer_sPage_Load(object sender, EventArgs e)
        {

        }

        private void disFromCustPage_Click(object sender, EventArgs e)
        {
            welcomeScreen a = new welcomeScreen();
            a.Show();
            this.Hide();
        }

        private void backFromCustomers_Click(object sender, EventArgs e)
        {
            //get back to previous page
            homePage hp = new homePage(empNum);
            hp.Show();
            this.Hide();
        }

        private void CreateCust_Click(object sender, EventArgs e)
        {
            addCustomer ac = new addCustomer(empNum);
            ac.Show();
            this.Hide();
        }

        private void CreateCus_Click(object sender, EventArgs e)
        {
            addCustomer a = new addCustomer(empNum);
            a.Show();
            this.Hide();
        }

        private void SearchCust_Click(object sender, EventArgs e)
        {
            searchCustomer sc = new searchCustomer(empNum);
            sc.Show();
            this.Hide();
        }
    }
}
