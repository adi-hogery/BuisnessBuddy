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
    public partial class schedule : Form
    {
        int empNum;
        public schedule(int empnum)
        {
            InitializeComponent();
            this.empNum = empnum;
            // need to change to future event!!!!!!!!!!!!!!!!!!!!!!!
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_ShowAEventPerEmp @emp";
            c.Parameters.AddWithValue("@emp", this.empNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
            SqlDataAdapter da = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.eventsGrid.DataSource = dt;
            this.eventsGrid.Show();
            this.eventsGrid.ReadOnly=true;
            this.addEvent.Hide();

            Employee emp = Program.seekEmployee(empNum);
            if(Program.getPermission(emp) < 2)
            {
                this.addEvent.Show();
            }
        }

        private void backFromSchedule_Click(object sender, EventArgs e)
        {
            homePage h = new homePage(this.empNum);
            h.Show();
            this.Hide();
        }

        private void disFromSchedule_Click(object sender, EventArgs e)
        {
            welcomeScreen w = new welcomeScreen();
            w.Show();
            this.Hide();
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            Calendar c = new Calendar(this.empNum);
            c.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex != -1)
            {
                DataGridViewRow row = this.eventsGrid.Rows[rowIndex];
                DateTime dt = DateTime.Parse(row.Cells[1].Value.ToString());
                string desc = row.Cells[2].Value.ToString();
                string category = row.Cells[3].Value.ToString();
                EventForm ef = new EventForm(this.empNum, int.Parse(row.Cells[0].Value.ToString()), dt, desc, category );
                ef.Show();
            }
        }
    }
}
