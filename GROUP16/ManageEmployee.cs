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
    public partial class ManageEmployee : Form
    {
        int empNum;
        public ManageEmployee(int num)
        {
            InitializeComponent();
            empNum = num;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) //create 
        {
            AddEmployee a = new AddEmployee(this.empNum);
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) //search
        {
            SearchEmployee s = new SearchEmployee(this.empNum);
            s.Show();
            this.Hide();

        }

        private void disFromManageEmp_Click(object sender, EventArgs e)
        {
            welcomeScreen a = new welcomeScreen();
            a.Show();
            this.Hide();
        }

        private void exitFromManEmp_Click(object sender, EventArgs e)
        {
            homePage a = new homePage(empNum);
            a.Show();
            this.Hide();
        }
    }
}





