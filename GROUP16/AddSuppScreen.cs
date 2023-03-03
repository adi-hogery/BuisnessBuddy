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
    public partial class AddSuppScreen : Form
    {
        int empNum;
        bool fromHome;
        public AddSuppScreen(int empNum, bool fromHome)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.fromHome = fromHome;
            int SuppNum = Program.Suppliers.Count + 1;
            this.SuppNum.Text = (SuppNum).ToString();
            this.ShowProdView.Hide();
            this.prodComboBox.DataSource = Enum.GetValues(typeof(PaperType));
            this.prodComboBox.Hide();
            this.addProdToSupp.Hide();
            this.removeProdFromSupp.Hide();
            this.label6.Hide();


        }

        public AddSuppScreen(int empNum, int suppFromGrid, bool fromHome)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.fromHome = fromHome;
            this.SuppNum.Text = (suppFromGrid).ToString();
            Supplier s = Program.seekSupplier(suppFromGrid);
            this.supPhone.Text = s.getPhone();
            this.supEmail.Text = s.getEmail();
            this.SupContact.Text = s.getContact();
            this.isActiveSup.Checked = s.getIsActive();
            this.SuppAddress.Text = s.getSupAddress();
            this.prodComboBox.DataSource = Enum.GetValues(typeof(PaperType));
            this.prodComboBox.Hide();

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Show_Products @SupNumber";
            c.Parameters.AddWithValue("@SupNumber", suppFromGrid);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
            SqlDataAdapter da = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.ShowProdView.DataSource = dt;
            this.ShowProdView.Show();
            this.prodComboBox.Show();
        }

        private int checkParameters()
        {
            if (SupContact.Text.Length == 0 || supEmail.Text.Length == 0 || supPhone.Text.Length == 0 || SuppAddress.Text.Length == 0)
            {
                String message = ("אנא מלא את כל השדות");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            if (!supPhone.Text.All(Char.IsDigit) || supPhone.Text.Length != 10)
            {
                String message = ("מספר הפלאפון חייב להכיל 10 ספרות, אנא בדוק שוב");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }

            if (!supEmail.Text.Contains("@") || !supEmail.Text.Contains("."))
            {
                String message = ("האימייל שהכנסת אינו תקין, אנא בדוק שהכתובת מכילה @, נקודה ואותיות באנגלית בלבד ");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }

            if (!SupContact.Text.All(Char.IsLetter))
            {
                if (!SupContact.Text.Contains(" "))
                {
                    String message = ("שם העובד חייב להכיל שם פרטי ושם משפחה עם אותיות בלבד, אנא בדוק שנית");
                    String title = ("שגיאה");
                    MessageBox.Show(message, title);
                    return (0);
                }
            }
                return (1);
        }

        private void Addsup_Click(object sender, EventArgs e)
        {
            if (checkParameters() == 1)
            {
                if (Program.seekSupplier(int.Parse(this.SuppNum.Text)) == null)
                {
                    Supplier S = new Supplier((int.Parse(this.SuppNum.Text)), supPhone.Text, supEmail.Text, SuppAddress.Text, "true", SupContact.Text, true);//יצירת ספק חדש
                    MessageBox.Show("העובד נוצר בהצלחה");
                }
                else
                {
                    Supplier S = Program.seekSupplier(int.Parse(this.SuppNum.Text));
                    S.setPhone(this.supPhone.Text);
                    S.setEmail(this.supEmail.Text);
                    S.setSupAddress(this.SuppAddress.Text);
                    S.setContact(this.SupContact.Text);
                    S.setIsActive(this.isActiveSup.Checked);
                    S.Update_supplier();
                    MessageBox.Show("העובד עודכן בהצלחה");

                }
            }

        }

        private void BackToSupScreen_Click(object sender, EventArgs e)
        {
            if (this.fromHome)
            {
                homePage a = new homePage(empNum);
                a.Show();
                this.Hide();
            }
            else
            {
                ExistingInventory ei = new ExistingInventory(this.empNum);
                ei.Show();
                this.Hide();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            welcomeScreen a = new welcomeScreen();
            a.Show();
            this.Hide();
        }



        private void isNewSupp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.isNewSupp.Checked)
            {
                this.dataGridView1.Hide();
                this.SuppNum.Text = (Program.Suppliers.Count + 1).ToString();
                this.SupContact.Text = "";
                this.supEmail.Text = "";
                this.supPhone.Text = "";
                this.SuppAddress.Text = "";
                this.ShowProdView.Hide();
                this.prodComboBox.Hide();
                this.addProdToSupp.Hide();
                this.label7.Hide();
                this.label6.Hide();
                this.removeProdFromSupp.Hide();
                this.isActiveSup.Checked = true;
            }
            else
            {
                this.dataGridView1.Show();
                this.SuppNum.Text = "";
                this.SupContact.Text = "";
                this.supEmail.Text = "";
                this.supPhone.Text = "";
                this.SuppAddress.Text = "";
                this.label7.Show();
            }

        }


        private void AddSuppScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_16DataSet4.SUPPLIERS' table. You can move, or remove it, as needed.
            this.sUPPLIERSTableAdapter2.Fill(this.sAD_16DataSet4.SUPPLIERS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {

                DataGridViewRow row = this.dataGridView1.Rows[rowIndex];
                this.SuppNum.Text = row.Cells[0].Value.ToString();
                this.SupContact.Text = row.Cells[5].Value.ToString();
                this.supEmail.Text = row.Cells[2].Value.ToString();
                this.supPhone.Text = row.Cells[1].Value.ToString();
                this.SuppAddress.Text = row.Cells[3].Value.ToString();
                this.isActiveSup.Checked = Boolean.Parse(row.Cells[4].Value.ToString());


                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE dbo.SP_Show_Products @SupNumber";
                c.Parameters.AddWithValue("@SupNumber", int.Parse(this.SuppNum.Text));
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
                SqlDataAdapter da = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.ShowProdView.DataSource = dt;
                this.ShowProdView.Show();
                this.prodComboBox.Show();
                this.addProdToSupp.Show();
                this.removeProdFromSupp.Show();
                this.label6.Show();
            }
        }

        private void isActiveSup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addProdToSupp_Click(object sender, EventArgs e)
        {
            int n = Program.seekStickerNum(this.prodComboBox.Text);
            SqlCommand c = new SqlCommand();
            c.CommandText = "Execute dbo.SP_add_StickerSupp @SupNumber ,@ProductNumber";
            c.Parameters.AddWithValue("@SupNumber", int.Parse(this.SuppNum.Text));
            c.Parameters.AddWithValue("@ProductNumber", n);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            SqlCommand c2 = new SqlCommand();
            c2.CommandText = "EXECUTE dbo.SP_Show_Products @SupNumber";
            c2.Parameters.AddWithValue("@SupNumber", int.Parse(this.SuppNum.Text));
            SQL_CON SC2 = new SQL_CON();
            SC2.execute_non_query(c2);
            SqlDataAdapter da = new SqlDataAdapter(c2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.ShowProdView.DataSource = dt;
            MessageBox.Show("מוצר נוסף לרשימת הספק");
        }

        private void removeProdFromSupp_Click(object sender, EventArgs e)
        {
            int n = Program.seekStickerNum(this.prodComboBox.Text);
            SqlCommand c = new SqlCommand();
            c.CommandText = "Execute dbo.SP_DELETE_StickerSupp @SupNumber ,@ProductNumber";
            c.Parameters.AddWithValue("@SupNumber", int.Parse(this.SuppNum.Text));
            c.Parameters.AddWithValue("@ProductNumber", n);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            SqlCommand c2 = new SqlCommand();
            c2.CommandText = "EXECUTE dbo.SP_Show_Products @SupNumber";
            c2.Parameters.AddWithValue("@SupNumber", int.Parse(this.SuppNum.Text));
            SQL_CON SC2 = new SQL_CON();
            SC2.execute_non_query(c2);
            SqlDataAdapter da = new SqlDataAdapter(c2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.ShowProdView.DataSource = dt;
            MessageBox.Show("מוצר הוסר מרשימת הספק");
        }

        private void SupContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void supPhone_TextChanged(object sender, EventArgs e)
        {
            if (!this.supPhone.Text.All(Char.IsDigit))
            {
                MessageBox.Show("אנא הכנס ספרות בלבד", "שגיאה");
                this.supPhone.Text = "";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}