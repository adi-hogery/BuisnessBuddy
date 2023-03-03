using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP16
{
    public partial class homePage : Form
    {
        int empNum;
        public homePage(int num)
        {
            InitializeComponent();
            this.empNum = num;
            Employee emp = Program.seekEmployee(num);
            if(Program.getPermission(emp) > 2)
            {
                manageEmployees.Hide();
                this.suppButton.Hide();
            }

        }

        private void manageEmployees_Click(object sender, EventArgs e)
        {
            ManageEmployee a = new ManageEmployee(this.empNum);
            a.Show();
            this.Hide();

        }

        private void homePage_Load(object sender, EventArgs e)
        {
           
        }

        private void disFromHome_Click(object sender, EventArgs e)
        {
            welcomeScreen a = new welcomeScreen();
            a.Show();
            this.Hide();
        }

        private void custButton_Click(object sender, EventArgs e)
        {
            Customer_sPage c = new Customer_sPage(empNum);
            c.Show();
            this.Hide();
        }

        private void manageOrders_Click(object sender, EventArgs e)
        {
            ordersPage o = new ordersPage(this.empNum);
            o.Show();
            this.Hide();
        }

        private void inventoryManagement_Click(object sender, EventArgs e)
        {
            ExistingInventory Ex = new ExistingInventory(this.empNum);
            Ex.Show();
            this.Hide();
        }

        private void suppButton_Click(object sender, EventArgs e)
        {
            AddSuppScreen a = new AddSuppScreen(this.empNum, true);
            a.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sendingMail_Click(object sender, EventArgs e)
        {
            SendingEmail sm = new SendingEmail(this.empNum, true);
            sm.Show();
            this.Hide();

        }

        private void manageSchedule_Click(object sender, EventArgs e)
        {
            schedule s = new schedule(this.empNum);
            s.Show();
            this.Hide();
        }
    }
}
