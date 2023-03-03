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
    public partial class Calendar : Form
    {
        int empNum;
        int month, year;
        //static variable so we could pass it the another form for month and year
        public static int static_month, static_year;
        public Calendar(int empNum)
        {
            InitializeComponent();
            this.empNum=empNum;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            // get today's date 
            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            this.dateHeader.Text = monthName + " " + year;

            static_month = month;
            static_year = year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //get the number of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // convert the startOfTheMonth to int
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            // creating empty user control,
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlCalendar ucBlank = new UserControlCalendar();
                flowLayoutPanel1.Controls.Add(ucBlank);
            }
            for (int i = 1; i < days + 1; i++)
            {
                UserControlDays ucd = new UserControlDays(this.empNum);
                ucd.days(i);
                flowLayoutPanel1.Controls.Add(ucd);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            homePage a = new homePage(empNum);
            a.Show();
            this.Hide();
        }

        private void prevMonth_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            if (month == 1)
            {
                year--;
                month = 12;
            }
            else
            {
                month--;
            }
            static_month = month;
            static_year = year;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            this.dateHeader.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //get the number of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // convert the startOfTheMonth to int
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            // creating empty user control,
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlCalendar ucBlank = new UserControlCalendar();
                flowLayoutPanel1.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucd = new UserControlDays(this.empNum);
                ucd.days(i);
                flowLayoutPanel1.Controls.Add(ucd);
            }
        }

        private void NextMonth_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            if (month == 12)
            {
                year++;
                month = 1;
            }
            else
            {
                month++;
            }
            static_month = month;
            static_year = year;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            this.dateHeader.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            //get the number of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // convert the startOfTheMonth to int
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            // creating empty user control,
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlCalendar ucBlank = new UserControlCalendar();
                flowLayoutPanel1.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucd = new UserControlDays(this.empNum);
                ucd.days(i);
                flowLayoutPanel1.Controls.Add(ucd);
            }
        }
    }
}
