using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GROUP16
{
    public partial class EventForm : Form
    {
        int empNum;
        //create a connectionstring:
        // string connString = "server=localhost;user id=root;database=db_calendar;sslmode=none";
        public static System.Collections.Generic.List<Employee> participants = new List<Employee>();
        public EventForm(int empNum)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.eventNum.Text = (Program.Events.Count + 1).ToString();
            this.eventNum.ReadOnly = true;
            this.eventCategory.DataSource = Enum.GetValues(typeof(EventCategory));
            this.addButton.Hide();
            this.removeButton.Hide();
            this.dataGridView1.Hide();
            this.dataGridView1.ReadOnly = true;
            this.invitedEmployees.Hide();
            this.nameTextBox.Hide();
            this.nameTextBox.ReadOnly = true;
            this.Halufi.Hide();
            this.label5.Hide();
            this.label6.Hide();
            this.invitedEmployees.ReadOnly = true;
            this.label7.Hide();
            this.label8.Hide();

            string s = Calendar.static_year.ToString() + "-" + Calendar.static_month.ToString() + "-" + UserControlDays.static_day;
            DateTime d = DateTime.Parse(s);
            eventDate.Text = d.ToString("yyyy-MM-dd hh:mm:ss");
        }

        public EventForm(int empNum,int eventNum,DateTime dt, string desc, string category )
        {
            InitializeComponent();
            this.empNum = empNum;
            this.eventNum.Text = (Program.Events.Count + 1).ToString();
            this.eventNum.ReadOnly = true;
            this.eventCategory.DataSource = Enum.GetValues(typeof(EventCategory));
            this.addButton.Hide();
            this.removeButton.Hide();
            this.dataGridView1.Hide();
            this.dataGridView1.ReadOnly = true;
            this.label5.Hide();
            this.invitedEmployees.ReadOnly = true;
            this.eventDate.Text = dt.ToString();
            this.eventNum.Text = eventNum.ToString();
            this.DescriptionEV.Text = desc;
            this.Halufi.Hide();
            this.nameTextBox.ReadOnly = true;
            this.dataGridView1.Show();
            this.addButton.Show();
            this.removeButton.Show();


            Employee emp = Program.seekEmployee(this.empNum);
            if (Program.getPermission(emp) > 1)
            {
                this.saveBTN.Hide();
                this.DescriptionEV.ReadOnly = true;
                this.Halufi.Text = category;
                this.Halufi.ReadOnly = true;
                this.eventCategory.Hide();
                this.Halufi.Show();
                this.eventDate.ReadOnly = true;
                this.dataGridView1.Hide();
                this.addButton.Hide();
                this.removeButton.Hide();
                this.nameTextBox.Hide();

            }
            

            SqlCommand c2 = new SqlCommand();
            c2.CommandText = "EXECUTE dbo.SP_ShowEmp_InEvent @EventNum";
            c2.Parameters.AddWithValue("@EventNum", int.Parse(this.eventNum.Text));
            SQL_CON SC2 = new SQL_CON();
            SC2.execute_non_query(c2);
            SqlDataAdapter da = new SqlDataAdapter(c2);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            this.invitedEmployees.DataSource = dt2;
            this.invitedEmployees.Show();
        }


        private void EventForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_16DataSet5.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter.Fill(this.sAD_16DataSet5.EMPLOYEES);
            

        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            if (this.DescriptionEV.Text.Length < 1)
            {
                MessageBox.Show("תיאור אין??");
            }
            else
            {
                if (!isDate(eventDate.Text))
                {
                    String message = ("אנא הכנס תאריך ושעה תקינים לפי התבנית הבאה: YYYY-MM-DD");
                    String title = ("שגיאה");
                    MessageBox.Show(message, title);
                }
                else
                {
                    if (Program.seekEvent(int.Parse(eventNum.Text)) == null)
                    {
                        Event E = new Event(int.Parse(eventNum.Text), DateTime.Parse(eventDate.Text), DescriptionEV.Text, (EventCategory)Enum.Parse(typeof(EventCategory), eventCategory.Text), true);
                        MessageBox.Show("אירוע נוצר בהצלחה");
                        this.addButton.Show();
                        this.removeButton.Show();
                        this.dataGridView1.Show();
                        this.invitedEmployees.Show();
                        this.nameTextBox.Show();
                        this.label5.Show();
                        this.label6.Show();
                        this.label7.Show();
                        this.label8.Show();

                    }
                    else
                    {
                        Event E = Program.seekEvent(int.Parse(eventNum.Text));
                        E.setCategory((EventCategory)Enum.Parse(typeof(EventCategory), eventCategory.Text));
                        E.setDescription(DescriptionEV.Text);
                        E.setEventDate(DateTime.Parse(eventDate.Text));
                        E.Update_event();
                        MessageBox.Show("האירוע עודכן בהצלחה");

                    }

                }
            }
        }


        public bool isDate(string tempDate)
        {
            DateTime fromDateValue;
            var formats = new[] { "dd/MM/yyyy", "yyyy-MM-dd" , "dd/MM/yyyy hh:mm:ss", "yyyy-MM-dd hh:mm:ss" };
            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void eventDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex != -1)
            {
                DataGridViewRow row = this.dataGridView1.Rows[rowIndex];
                nameTextBox.Text = row.Cells[0].Value.ToString();
            }
            dataGridView1.EndEdit();

        }

        private void addToGrid(Employee emp)
        {
            Event E = Program.seekEvent(int.Parse(this.eventNum.Text));
            E.addEmp(int.Parse(this.eventNum.Text), emp.get_num());
            

            SqlCommand c2 = new SqlCommand();
            c2.CommandText = "EXECUTE dbo.SP_ShowEmp_InEvent @EventNum";
            c2.Parameters.AddWithValue("@EventNum",int.Parse(this.eventNum.Text));
            SQL_CON SC2 = new SQL_CON();
            SC2.execute_non_query(c2);
            SqlDataAdapter da = new SqlDataAdapter(c2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.invitedEmployees.DataSource = dt;
            this.invitedEmployees.Show();
        }

        private void removeFromGrid(Employee emp)
        {
            Event E = Program.seekEvent(int.Parse(this.eventNum.Text));
            E.removeEmp(int.Parse(this.eventNum.Text), emp.get_num());

            SqlCommand c2 = new SqlCommand();
            c2.CommandText = "EXECUTE dbo.SP_ShowEmp_InEvent @EventNum";
            c2.Parameters.AddWithValue("@EventNum", int.Parse(this.eventNum.Text));
            SQL_CON SC2 = new SQL_CON();
            SC2.execute_non_query(c2);
            SqlDataAdapter da = new SqlDataAdapter(c2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.invitedEmployees.DataSource = dt;
            this.invitedEmployees.Show();
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            if (this.nameTextBox.Text.Length < 1)
            {
                MessageBox.Show("אבל תבחר עובד קודם");
            }
            else
            {
                Employee E = Program.seekEmployee(int.Parse(nameTextBox.Text));
                if (E != null)
                {
                    if (!participants.Contains(E))
                    {
                        participants.Add(E);
                        MessageBox.Show("עובד נוסף בהצלחה");
                        addToGrid(E);
                    }
                    else
                    {
                        MessageBox.Show("העובד כבר משתתף באירוע זה");
                    }

                }
            }
            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Employee E = Program.seekEmployee(int.Parse(nameTextBox.Text));
            if (E != null)
            {
                if (participants.Contains(E))
                {
                    participants.Remove(E);
                    MessageBox.Show("עובד הוסר בהצלחה");
                    removeFromGrid(E);
                }
                else
                {
                    MessageBox.Show("העובד איננו משתתף באירוע זה");
                }

            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void invitedEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex != -1)
            {
                DataGridViewRow row = this.invitedEmployees.Rows[rowIndex];
                nameTextBox.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}