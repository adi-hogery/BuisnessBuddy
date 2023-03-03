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
using System.Net.Mail;
using System.Net;

namespace GROUP16
{
    public partial class ExistingInventory : Form
    {
        int empNum;
        int supplierNum;

        public ExistingInventory(int num)
        {
            InitializeComponent();
            this.empNum = num;
            this.UpdateQuantity.Hide();
            this.label1.Hide();
            this.label2.Hide();
            this.productNumber.Hide();
            this.InStock.Hide();
            this.relevantSupp.Hide();
            this.relevantSupp.ReadOnly=true;
            this.shopSuppPage.Hide();
            this.label3.Hide();
            this.label4.Hide();
            this.amountToOrder.Hide();
            this.makeOrder.Hide();
            this.productNumber.ReadOnly = true;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void ExitInventory_Click(object sender, EventArgs e)
        {
            
       
                welcomeScreen a = new welcomeScreen();
                a.Show();
                this.Hide();
         
        }

        public void redShow()
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) < 1500)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                }
            }
        }
        private void ExistingInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_16DataSet2.SUPPLIERS' table. You can move, or remove it, as needed.
            this.sUPPLIERSTableAdapter.Fill(this.sAD_16DataSet2.SUPPLIERS);
            // TODO: This line of code loads data into the 'sAD_16DataSet2.STICKERPAPERS' table. You can move, or remove it, as needed.
            this.sTICKERPAPERSTableAdapter.Fill(this.sAD_16DataSet2.STICKERPAPERS);
            redShow();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[rowIndex];
                this.productNumber.Text = row.Cells[0].Value.ToString();
                this.InStock.Text = row.Cells[3].Value.ToString();
                this.label1.Show();
                this.label2.Show();
                this.productNumber.Show();
                this.InStock.Show();
                this.UpdateQuantity.Show();
                this.label3.Show();
                this.label4.Show();
                this.amountToOrder.Show();
                this.makeOrder.Show();

                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE dbo.SP_Show_Suppliers @productNumber";
                c.Parameters.AddWithValue("@productNumber", int.Parse(this.productNumber.Text));
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
                SqlDataAdapter da = new SqlDataAdapter(c);
                DataTable dt = new DataTable(); 
                da.Fill(dt);
                this.relevantSupp.DataSource = dt; // relevantSupp = name of grid
                this.relevantSupp.Show();
                //this.searchOrderByOrder.Text = row.Cells[0].Value.ToString();
            }
        }

        private void backFromExisting_Click(object sender, EventArgs e)
        {
            homePage H = new homePage(this.empNum);
            H.Show();
            this.Hide();
        }

        private void InStock_TextChanged(object sender, EventArgs e)
        {
            if (!InStock.Text.All(Char.IsDigit))
            {
                if (!this.InStock.Text.Contains(".")){
                    String message = ("אנא הכנס ספרות בלבד");
                    String title = ("שגיאה");
                    MessageBox.Show(message, title);
                    this.InStock.Text = "0";
                }
            }

        }

        private void UpdateQuantity_Click(object sender, EventArgs e)
        {
            StickerPaper s = Program.seekStickerPaper(int.Parse(this.productNumber.Text));
            s.setQuantity(double.Parse(this.InStock.Text));
            
            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.SP_Update_STICKERPAPERS_quantity_Number @ProductNum ,@Quantity";
            c.Parameters.AddWithValue("@ProductNum", s.getProductNumber());
            c.Parameters.AddWithValue("@Quantity", double.Parse(this.InStock.Text));
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);


            SqlCommand newC = new SqlCommand();
            newC.CommandText = "EXECUTE dbo.Get_all_STICKERPAPERS";
            SQL_CON newSC = new SQL_CON();
            newSC.execute_non_query(newC);
            SqlDataAdapter newDa = new SqlDataAdapter(newC);
            DataTable newDT = new DataTable();
            newDa.Fill(newDT);
            this.dataGridView1.DataSource = newDT;
            this.dataGridView1.Show();
            redShow();



        }

        private void makeOrder_Click(object sender, EventArgs e)
        {
            Supplier s = Program.seekSupplier(supplierNum);
            if (s != null)
            {
                string body = "I would like to make an order for product " + this.productNumber.Text + "," + "\n"  
                                +"in length of" + this.amountToOrder.Text +  " meters, Thank you very much!";
                string sendTo = s.getEmail();
                string subject = "Inventory Demand";
                SendingEmail SM = new SendingEmail(this.empNum, sendTo, subject, body, false, false);
                SM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("אנא בחר ספק");
            }
        }

        private void relevantSupp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {
                Employee emp = Program.seekEmployee(this.empNum);
                if (Program.getPermission(emp) < 3)
                {
                    this.shopSuppPage.Show();
                }
                DataGridViewRow row = this.relevantSupp.Rows[rowIndex];
                this.supplierNum = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void shopSuppPage_Click(object sender, EventArgs e)
        {
            AddSuppScreen a = new AddSuppScreen(this.empNum, this.supplierNum, false);
            a.Show();
            this.Hide();
        }

        private void productNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void amountToOrder_TextChanged(object sender, EventArgs e)
        {
            if (!amountToOrder.Text.All(Char.IsDigit))
            {
                MessageBox.Show("אנא הכנס ספרות בלבד");
                this.amountToOrder.Text = "0";
            }
        }
    }
}

