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
    public partial class searchCustomer : Form
    {
        int empNum;
        public searchCustomer(int num)
        {
            InitializeComponent();
            empNum = num;

            this.label3.Hide();
            this.label4.Hide();
            this.label5.Hide();
            this.custName.Hide();
            this.custPhone.Hide();
            this.custEmail.Hide();
            this.updateCustomerButton.Hide();
            this.createOrderFromCust.Hide();
        }


        public searchCustomer(int num, int customerNum)
        {
            InitializeComponent();
            empNum = num;
            Customer c = Program.seekCustomer(customerNum);
            this.searchCustByNum.Text = customerNum.ToString();
            this.custName.Text = c.get_custName();
            this.custPhone.Text = c.get_custPhone();
            this.custEmail.Text = c.get_custEmail();
        }

        private void disFromSearchCus_Click(object sender, EventArgs e)
        {
            welcomeScreen a = new welcomeScreen();
            a.Show();
            this.Hide();
        }

        private void exitFromSerachCust_Click(object sender, EventArgs e)
        {
            Customer_sPage c = new Customer_sPage(empNum);
            c.Show();
            this.Hide();
        }

        private void searchCustButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchCustByNum.Text))
            {
                MessageBox.Show("אנא הזן מספר עובד");
            }
            else
            {
                int searchNum = int.Parse(searchCustByNum.Text);

                Customer cust = Program.seekCustomer(searchNum);
                if (cust == null)
                {
                    String message = ("אין לקוח כזה");
                    String title = ("שוממעעעעעעעעע");
                    MessageBox.Show(message, title);
                }
                else
                {
                    this.label3.Show();
                    this.label4.Show();
                    this.label5.Show();
                    this.custName.Show();
                    this.custPhone.Show();
                    this.custEmail.Show();
                    this.updateCustomerButton.Show();
                    this.createOrderFromCust.Show();

                    this.custName.Text = cust.get_custName();
                    this.custPhone.Text = cust.get_custPhone();
                    this.custEmail.Text = cust.get_custEmail();
                }
            }
        }


        private int checkParameters()
        {
            string s = String.Concat(custName.Text.Where(c => !Char.IsWhiteSpace(c)));
            if (!s.All(Char.IsLetter) || s.Length<1)
            {
                if (!custName.Text.Contains(" "))
                {
                    String message = ("שם העובד חייב להכיל שם פרטי ושם משפחה עם אותיות בלבד, אנא בדוק שנית");
                    String title = ("שגיאה");
                    MessageBox.Show(message, title);
                    return (0);
                }
            }
            
            if (!custPhone.Text.All(Char.IsDigit) || custPhone.Text.Length != 10)
            {
                String message = ("מספר הפלאפון חייב להכיל 10 ספרות, אנא בדוק שוב");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            if (!custEmail.Text.Contains("@") || !custEmail.Text.Contains("."))
            {
                String message = ("האימייל שהכנסת אינו תקין, אנא בדוק שהכתובת מכילה @, נקודה ואותיות באנגלית בלבד ");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }

            return (1);
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            if (checkParameters() == 1)
            {
                int searchNum = int.Parse(this.searchCustByNum.Text);
                Customer cust = Program.seekCustomer(searchNum);

                cust.set_name(this.custName.Text);
                cust.set_PhoneNumber(this.custPhone.Text);
                cust.set_Email(this.custEmail.Text);
                cust.update_customer();
                MessageBox.Show("לקוח עודכן בהצלחה");
            }
        }

        private void createOrderFromCust_Click(object sender, EventArgs e)
        {
            addOrder ao = new addOrder(empNum, int.Parse(this.searchCustByNum.Text));
            ao.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchCustomer_Load(object sender, EventArgs e)
        {

        }

        private void custName_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchCustByNum_TextChanged(object sender, EventArgs e)
        {
            if (!this.searchCustByNum.Text.All(Char.IsDigit))
            {
                MessageBox.Show("אנא הזן מספרים בלבד");
                this.searchCustByNum.Text = "0";
            }
        }
    }
}