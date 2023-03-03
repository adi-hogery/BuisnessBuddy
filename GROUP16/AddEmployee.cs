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
    public partial class AddEmployee : Form
    {
        int empNum;
        public AddEmployee(int num)
        {
            InitializeComponent();
            empNum = num;
            int newNumber = Program.Employees.Count() + 2000;
            comboBoxGender.DataSource = Enum.GetValues(typeof(Gender));
            comboBoxRole.DataSource = Enum.GetValues(typeof(Role));
            this.newEmpNum.Text = (newNumber).ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private int checkParameters()
        {
            if (employeeName.Text.Length == 0 || employeePass.Text.Length == 0 || employeeAddress.Text.Length == 0)
            {
                String message = ("עליך למלא את כל השדות");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            if (!employeeEmail.Text.Contains("@") || !employeeEmail.Text.Contains("."))
            {
                String message = ("האימייל שהכנסת אינו תקין, אנא בדוק שהכתובת מכילה @, נקודה ואותיות באנגלית בלבד ");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            if (!employeePhone.Text.All(Char.IsDigit) || employeePhone.Text.Length != 10)
            {
                String message = ("מספר הפלאפון חייב להכיל 10 ספרות, אנא בדוק שוב");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            string s = String.Concat(employeeName.Text.Where(c => !Char.IsWhiteSpace(c)));
            if (!s.All(Char.IsLetter))
            {
                if (!employeeName.Text.Contains(" "))
                {
                    String message = ("שם העובד חייב להכיל שם פרטי ושם משפחה עם אותיות בלבד, אנא בדוק שנית");
                    String title = ("שגיאה");
                    MessageBox.Show(message, title);
                    return (0);
                }
            }
            
            if (!IsDate(employeeBirthday.Text) || DateTime.Parse(employeeBirthday.Text) > DateTime.Now)
            {
                String message = ("אנא הכנס תאריך תקין לפי התבנית הבאה: YYYY-MM-DD" + "\n" +"אנא בדוק שהתאריך תקין");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            return (1);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkParameters() == 1)
            {
                int newNumber = Program.Employees.Count() + 2000;
                Employee E = new Employee(newNumber, employeeName.Text, employeePass.Text, employeePhone.Text, employeeEmail.Text,
                    (Gender)Enum.Parse(typeof(Gender), comboBoxGender.Text),
                    (Role)Enum.Parse(typeof(Role), comboBoxRole.Text), DateTime.Parse(employeeBirthday.Text), employeeAddress.Text, "true", true);//יצירת עובד חדש
                MessageBox.Show("עובד נוצר בהצלחה");
                ManageEmployee ME = new ManageEmployee(this.empNum);
                ME.Show();
                this.Hide();
            }

        }


        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void exitFromAdd_Click(object sender, EventArgs e)
        {
            ManageEmployee a = new ManageEmployee(empNum);
            a.Show();
            this.Hide();
        }

        private void disFromAddEmp_Click(object sender, EventArgs e)
        {
            welcomeScreen a = new welcomeScreen();
            a.Show();
            this.Hide();
        }

        private void newEmpNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void empPass_Click(object sender, EventArgs e)
        {

        }

        private void employeeEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeePhone_TextChanged(object sender, EventArgs e)
        {
            if (!this.employeePhone.Text.All(Char.IsDigit))
            {
                MessageBox.Show("אנא הכנס ספרות בלבד", "שגיאה");
                this.employeePhone.Text = "";
            }
        }


        public static bool IsDate(string tempDate)
        {
            DateTime fromDateValue;
            var formats = new[] { "dd/MM/yyyy", "yyyy-MM-dd" };
            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}