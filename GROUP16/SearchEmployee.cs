using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP16
{

    public partial class SearchEmployee : Form
    {
        int empNum;
        public SearchEmployee(int num)
        {
            InitializeComponent();
            this.empNum = num;
            this.upEmpNameText.Hide();
            this.upEmpPassText.Hide();
            this.upEmpPhoneText.Hide();
            this.upEmpEmailText.Hide();
            this.upEmpGenderText.Hide();
            this.upEmpRoleText.Hide();
            this.upEmpBirthdayText.Hide();
            this.upEmpAddressText.Hide();
            this.checkBoxActive.Hide();
            this.button1.Hide();

            this.upEmpName.Hide();
            this.empPass.Hide();
            this.empPhone.Hide();
            this.empEmail.Hide();
            this.empGender.Hide();
            this.empRole.Hide();
            this.birthday.Hide();
            this.address.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void exitSearchEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee a = new ManageEmployee(this.empNum);
            a.Show();
            this.Hide();
            
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_16DataSet1.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter.Fill(this.sAD_16DataSet1.EMPLOYEES);


        }


        private void searchEmployeeButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchEmployeeByNum.Text))
            {
                MessageBox.Show("אנא הזן מספר עובד לחיפוש");
            }
            else
            {
                if (!searchEmployeeByNum.Text.All(Char.IsDigit))
                {
                    MessageBox.Show("אנא הכנס ספרות בלבד!");
                }
                else
                {
                    int searchNum = int.Parse(searchEmployeeByNum.Text);

                    Employee emp = Program.seekEmployee(searchNum);
                    if (emp == null)
                    {
                        String message = ("אין עובד כזה");
                        String title = ("שוממעעעעעעעעע");
                        MessageBox.Show(message, title);
                    }
                    else
                    {
                        this.upEmpGenderText.DataSource = Enum.GetValues(typeof(Gender));
                        this.upEmpRoleText.DataSource = Enum.GetValues(typeof(Role));
                        this.upEmpNameText.Text = emp.get_name();
                        this.upEmpPassText.Text = emp.get_Password();
                        this.upEmpPhoneText.Text = emp.get_PhoneNumber();
                        this.upEmpEmailText.Text = emp.get_Email();
                        this.upEmpGenderText.Text = emp.get_Gender().ToString();
                        this.upEmpRoleText.Text = emp.get_EmployeeRole().ToString();
                        string formatted = emp.get_Birthday().ToString("yyyy-MM-dd");

                        this.upEmpBirthdayText.Text = formatted;

                        this.upEmpAddressText.Text = emp.get_Address();

                        this.upEmpNameText.Show();
                        this.upEmpPassText.Show();
                        this.upEmpPhoneText.Show();
                        this.upEmpEmailText.Show();
                        this.upEmpGenderText.Show();
                        this.upEmpRoleText.Show();
                        this.upEmpBirthdayText.Show();
                        this.upEmpAddressText.Show();
                        if (emp.get_Activation())
                            this.checkBoxActive.Checked = true;
                        this.checkBoxActive.Show();
                        this.button1.Show();

                        this.upEmpName.Show();
                        this.empPass.Show();
                        this.empPhone.Show();
                        this.empEmail.Show();
                        this.empGender.Show();
                        this.empRole.Show();
                        this.birthday.Show();
                        this.address.Show();
                    }
                }
            }
        }

        private int checkParameters()
        {
            if (upEmpNameText.Text.Length == 0 || upEmpPassText.Text.Length == 0 || upEmpAddressText.Text.Length == 0)
            {
                String message = ("עליך למלא את כל השדות");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            if (!upEmpEmailText.Text.Contains("@") || !upEmpEmailText.Text.Contains(".") || upEmpEmailText.Text.EndsWith(".") || upEmpEmailText.Text.StartsWith(".") || upEmpEmailText.Text.Contains(" "))
            {
                String message = ("האימייל שהכנסת אינו תקין, אנא בדוק שהכתובת מכילה @, נקודה ואותיות באנגלית בלבד ");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            if (!upEmpPhoneText.Text.All(Char.IsDigit) || upEmpPhoneText.Text.Length != 10)
            {
                String message = ("מספר הפלאפון חייב להכיל 10 ספרות, אנא בדוק שוב");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            string s = String.Concat(upEmpNameText.Text.Where(c => !Char.IsWhiteSpace(c)));
            if (!s.All(Char.IsLetter))
            {
                if (!upEmpNameText.Text.Contains(" ")){
                    String message = ("שם העובד חייב להכיל שם פרטי ושם משפחה עם אותיות בלבד, אנא בדוק שנית");
                    String title = ("שגיאה");
                    MessageBox.Show(message, title);
                    return (0);
                }
            }
            if (!IsDate(upEmpBirthdayText.Text) || DateTime.Parse(upEmpBirthdayText.Text) > DateTime.Now)
            {
                String message = ("אנא הכנס תאריך תקין לפי התבנית הבאה: YYYY-MM-DD" + "\n" + "אנא בדוק שהתאריך תקין");
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
                int searchNum = int.Parse(this.searchEmployeeByNum.Text);
                Employee emp = Program.seekEmployee(searchNum);
                if (emp != null)
                {
                    emp.set_Address(this.upEmpAddressText.Text);
                    emp.set_Birthday(DateTime.Parse(this.upEmpBirthdayText.Text));
                    emp.set_Email(this.upEmpEmailText.Text);
                    emp.set_name(this.upEmpNameText.Text);
                    emp.set_Password(this.upEmpPassText.Text);
                    emp.set_PhoneNumber(this.upEmpPhoneText.Text);
                    Gender G = (Gender)Enum.Parse(typeof(Gender), this.upEmpGenderText.Text.ToString());
                    emp.set_Gender(G);
                    Role R = (Role)Enum.Parse(typeof(Role), this.upEmpRoleText.Text.ToString());
                    emp.set_EmployeeRole(R);

                    if (this.checkBoxActive.Checked == true)
                    {
                        emp.set_Activation(true);
                    }

                    else
                    {
                        emp.set_Activation(false);
                    }

                    String message = ("העובד עודכן בהצלחה");
                    String title = ("שוממעעעעעעעעע");
                    MessageBox.Show(message, title);

                    emp.Update_Employee();
                }
                else
                {
                    MessageBox.Show("אנא בדוק שלא שינית את מספר העובד");
                }
            }
        }

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void disFromSearchEmp_Click(object sender, EventArgs e)
        {
            welcomeScreen a = new welcomeScreen();
            a.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void upEmpEmailText_TextChanged(object sender, EventArgs e)
        {

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

        private void upEmpBirthdayText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


