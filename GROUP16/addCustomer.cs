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
    public partial class addCustomer : Form
    {
        int empNum;
        public addCustomer(int num)
        {
            InitializeComponent();
            this.empNum = num;
            int customerNumber = Program.Customers.Count + 30000;
            this.custNum.Text = (customerNumber).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int checkParameters()
        {
            if (custName.Text.Length == 0 || custEmail.Text.Length == 0 || custPhone.Text.Length == 0)
            {
                String message = ("אנא מלא את כל השדות");
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
            if (!custPhone.Text.All(Char.IsDigit) || custPhone.Text.Length != 10)
            {
                String message = ("מספר הפלאפון חייב להכיל 10 ספרות, אנא בדוק שוב");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            string s = String.Concat(custName.Text.Where(c => !Char.IsWhiteSpace(c)));
            if (!s.All(Char.IsLetter))
            {
                if (!custName.Text.Contains(" "))
                {
                    String message = ("שם העובד חייב להכיל שם פרטי ושם משפחה עם אותיות בלבד, אנא בדוק שנית");
                    String title = ("שגיאה");
                    MessageBox.Show(message, title);
                    return (0);
                }
            }
            
            return (1);

        }

        private void disFromCreateCustomer_Click_1(object sender, EventArgs e)
        {
            welcomeScreen a = new welcomeScreen();
            a.Show();
            this.Hide();
        }

        private void createCusBot_Click_1(object sender, EventArgs e)
        {
            if (checkParameters() == 1)
            {
                int customerNumber = Program.Customers.Count + 30000;
                Customer C = new Customer(customerNumber, custName.Text, custPhone.Text, custEmail.Text, true);
                MessageBox.Show("לקוח נוצר בהצלחה");
            }
            //create customer
        }

        private void exitFromNewCust_Click_1(object sender, EventArgs e)
        {
            Customer_sPage c = new Customer_sPage(empNum);
            c.Show();
            this.Hide();
        }

        private void addCustomer_Load(object sender, EventArgs e)
        {

        }

        private void custName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void custEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void custPhone_TextChanged(object sender, EventArgs e)
        {
            if (!this.custPhone.Text.All(Char.IsDigit))
            {
                MessageBox.Show("אנא הכנס ספרות בלבד", "שגיאה");
                this.custPhone.Text = "";
            }
        }
    }
}