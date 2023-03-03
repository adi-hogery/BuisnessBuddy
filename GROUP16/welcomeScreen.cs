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
    public partial class welcomeScreen : Form
    {
        public welcomeScreen()
        {
            InitializeComponent();
           // System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = "C:\\Users\\avirange\\Downloads\\WhatsApp-Ptt-2023-01-10-at-19.02.11.wav";
            //player.Play();
        }

        private void welcomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            //checkParameters

            int searchNum = int.Parse(empNumCON.Text);
            Employee emp = Program.seekEmployee(searchNum);
            if (emp == null)
            {
                String message = ("אתה לא עובד פה!");
                String title = ("אחייייייייי");
                MessageBox.Show(message, title);
            }
            else
            {
                if (emp.get_Password().Equals(empPassCON.Text))
                {
                    homePage a = new homePage(searchNum);
                    a.Show();
                    this.Hide();

                    // need to change to future event!!!!!!!!!!!!!!!!!!!!!!!
                    SqlCommand c = new SqlCommand();
                    c.CommandText = "EXECUTE dbo.SP_ShowAEventPerEmp @emp";
                    c.Parameters.AddWithValue("@emp", int.Parse(this.empNumCON.Text));
                    SQL_CON SC = new SQL_CON();
                    SC.execute_non_query(c);
                    SqlDataAdapter da = new SqlDataAdapter(c);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("יש לך אירועים עתידיים", "שים לב");
                    }
                }
                else
                {
                    String message = ("סיסמה שגויה");
                    String title = ("אחייייייייי");
                    MessageBox.Show(message, title);
                }
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void empNumCON_TextChanged(object sender, EventArgs e)
        {
            if (!this.empNumCON.Text.All(Char.IsDigit))
            {
                MessageBox.Show("אנא הכנס ספרות בלבד", "שגיאה");
                this.empNumCON.Text = "";
            }
        }
    }
}
