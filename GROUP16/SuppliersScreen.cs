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
    public partial class SuppliersScreen : Form
    {
        int empNum;
        public SuppliersScreen(int empNum)
        {
            InitializeComponent();
            this.empNum = empNum;
           
            }

        private void AddSupp_Click(object sender, EventArgs e)
        {
            AddSuppScreen s = new AddSuppScreen(this.empNum, false);
            s.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backToInventory_Click(object sender, EventArgs e)
        {
            OrganizeInventoryScreen s = new OrganizeInventoryScreen(this.empNum);
            s.Show();
            this.Hide();
        }

       // private void SearchSup_Click(object sender, EventArgs e)
        //{
          //  SearchSuppScreen s = new SearchSuppScreen(this.empNum);
          //   s.Show();
         //   this.Hide();
     //   }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            welcomeScreen a = new welcomeScreen();
            a.Show();
            this.Hide();

        }
    }


}
