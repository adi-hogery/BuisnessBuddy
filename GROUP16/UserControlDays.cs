using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP16
{
    public partial class UserControlDays : UserControl
    {
        int empNum;
        //create another static variable for day
        public static string static_day;
        public UserControlDays(int empNum)
        {
            InitializeComponent();
            this.empNum = empNum;
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int dayNum)
        {
            this.lableDays.Text = dayNum + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lableDays.Text;
            EventForm EF = new EventForm(this.empNum);
            EF.Show();
        }
    }
}