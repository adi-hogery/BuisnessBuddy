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
    public partial class ordersPage : Form
    {
        int empNum;
        public ordersPage(int num)
        {
            InitializeComponent();
            redShowLive();
            this.empNum = num;
            this.searchQueue.Hide();
            this.searchQueue.ReadOnly = true;
            this.liveQueue.ReadOnly = true;
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_live_ORDERS";
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
            SqlDataAdapter da = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.liveQueue.DataSource = dt;
            redShowLive();
            liveQueue.Show();
            backToLiveQueue.PerformClick();

            this.toDateOrder.Hide();
            this.fromDateOrder.Hide();
            this.label3.Hide();
            this.label4.Hide();
        }

        public void redShowLive()
        {

            for (int i = 0; i < liveQueue.RowCount - 1; i++)
            {
                if (DateTime.Compare(DateTime.Parse(liveQueue.Rows[i].Cells[2].Value.ToString()), DateTime.Now) <= 0)
                {
                    liveQueue.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                }
            }
        }
        public void redShowSearch()
        {

            for (int i=0; i<searchQueue.RowCount-1; i++)
            {
                if (DateTime.Compare(DateTime.Parse(searchQueue.Rows[i].Cells[2].Value.ToString()), DateTime.Now) <= 0)
                {
                    searchQueue.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    
                }
            }
        }

      

        private void ordersPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_16DataSet5.Get_live_ORDERS' table. You can move, or remove it, as needed.
            //this.get_live_ORDERSTableAdapter.Fill(this.sAD_16DataSet5.Get_live_ORDERS);
            // TODO: This line of code loads data into the 'sAD_16DataSet2.Get_all_Colors' table. You can move, or remove it, as needed.
            //this.get_all_ColorsTableAdapter.Fill(this.sAD_16DataSet2.Get_all_Colors);
            // TODO: This line of code loads data into the 'sAD_16DataSet2.relevantOrders' table. You can move, or remove it, as needed.
            //this.relevantOrdersTableAdapter.Fill(this.sAD_16DataSet2.relevantOrders);
            this.backToLiveQueue.PerformClick();
        }

        private void disFromOrdersPage_Click(object sender, EventArgs e)
        {
            welcomeScreen a = new welcomeScreen();
            a.Show();
            this.Hide();
        }

        private void exitFromOrdersPage_Click(object sender, EventArgs e)
        {
            homePage a = new homePage(empNum);
            a.Show();
            this.Hide();
        }

        private void orderSearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchOrderByOrder.Text) && String.IsNullOrEmpty(searchOrderByCustomer.Text))
            {
                MessageBox.Show("אנא מלא את אחד השדות");
            }
            else
            {
                if (this.searchOrderByOrder.Text.Length > 0 && searchOrderByOrder.Text.All(Char.IsDigit))
                {
                    if (Program.seekOrder(int.Parse(this.searchOrderByOrder.Text)) == null)
                    {
                        String message = ("הזמנה לא קיימת במערכת");
                        String title = ("שגיאה");
                        MessageBox.Show(message, title);
                    }
                    else
                    {
                        orderView ov = new orderView(this.empNum, int.Parse(this.searchOrderByOrder.Text));
                        ov.Show();
                        this.Hide();

                    }

                }
                else
                {
                    if (!searchOrderByOrder.Text.All(Char.IsDigit))
                    {
                        MessageBox.Show("אמרו לך מספר הזמנה נכון? שים מספרים");
                    }
                    else
                    {
                        if (this.searchOrderByCustomer.Text.Length > 0 && searchOrderByCustomer.Text.All(Char.IsDigit))
                        {
                            if (this.perDateCheckBox.Checked)
                            {
                                if (DateTime.Parse(this.fromDateOrder.Text) > DateTime.Parse(this.toDateOrder.Text))
                                {
                                    String message = ("התאריך הסופי לפני התאריך ההתחלתי");
                                    String title = ("אבל איךךךךךךך");
                                    MessageBox.Show(message, title);
                                }
                                else
                                {
                                    if (Program.seekCustomer(int.Parse(this.searchOrderByCustomer.Text)) == null)
                                    {
                                        String message = ("לקוח לא קיים במערכת");
                                        String title = ("שגיאה");
                                        MessageBox.Show(message, title);
                                    }
                                    else
                                    {

                                        SqlCommand c = new SqlCommand();
                                        c.CommandText = "EXECUTE dbo.SP_ShowAllOrder_ByCustomer @ordCust, @from, @to";
                                        c.Parameters.AddWithValue("@ordCust", int.Parse(this.searchOrderByCustomer.Text));
                                        c.Parameters.AddWithValue("@from", DateTime.Parse(this.fromDateOrder.Text));
                                        c.Parameters.AddWithValue("@to", DateTime.Parse(this.toDateOrder.Text));
                                        SQL_CON SC = new SQL_CON();
                                        SC.execute_non_query(c);
                                        SqlDataAdapter da = new SqlDataAdapter(c);
                                        DataTable dt = new DataTable();
                                        da.Fill(dt);
                                        this.searchQueue.DataSource = dt;
                                        this.searchQueue.Show();

                                        redShowSearch();
                                        this.liveQueue.Hide();
                                    }
                                }
                            }
                            else
                            {
                                if (Program.seekCustomer(int.Parse(this.searchOrderByCustomer.Text)) == null)
                                {
                                    String message = ("לקוח לא קיים במערכת");
                                    String title = ("שגיאה");
                                    MessageBox.Show(message, title);
                                }
                                else
                                {
                                    SqlCommand c = new SqlCommand();
                                    c.CommandText = "EXECUTE dbo.SP_ShowAllOrder_ByCustomer @ordCust, @from, @to";
                                    c.Parameters.AddWithValue("@ordCust", int.Parse(this.searchOrderByCustomer.Text));
                                    c.Parameters.AddWithValue("@from", DateTime.Parse("1900-01-01 00:00:00"));
                                    c.Parameters.AddWithValue("@to", DateTime.Parse("2100-01-01 00:00:00"));
                                    SQL_CON SC = new SQL_CON();
                                    SC.execute_non_query(c);
                                    SqlDataAdapter da = new SqlDataAdapter(c);
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    this.searchQueue.DataSource = dt;
                                    this.searchQueue.Show();
                                    this.liveQueue.Hide();
                                }
                            }
                        }
                        else
                        {
                            if (!searchOrderByCustomer.Text.All(Char.IsDigit) && searchOrderByCustomer.Text.Length > 0)
                            {
                                MessageBox.Show("אמרו לך מספר לקוח נכון? שים מספרים");
                            }
                            else
                            {
                                if (DateTime.Parse(this.fromDateOrder.Text) > DateTime.Parse(this.toDateOrder.Text))
                                {
                                    String message = ("התאריך הסופי לפני התאריך ההתחלתי");
                                    String title = ("אבל איךךךךךךך");
                                    MessageBox.Show(message, title);
                                }
                                SqlCommand c = new SqlCommand();
                                c.CommandText = "EXECUTE dbo.SP_ShowAllOrder_ByDates @from, @to";
                                c.Parameters.AddWithValue("@from", DateTime.Parse(this.fromDateOrder.Text));
                                c.Parameters.AddWithValue("@to", DateTime.Parse(this.toDateOrder.Text));
                                SQL_CON SC = new SQL_CON();
                                SC.execute_non_query(c);
                                SqlDataAdapter da = new SqlDataAdapter(c);
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                this.searchQueue.DataSource = dt;
                                this.searchQueue.Show();
                                this.liveQueue.Hide();
                            }
                        }
                    }
                }
            }
            redShowSearch();
        }

        private void backToLiveQueue_Click(object sender, EventArgs e)
        {
            redShowLive();
            this.liveQueue.Show();
            this.searchQueue.Hide();


        }

        private void liveQueue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       
            int rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {
                DataGridViewRow row = this.liveQueue.Rows[rowIndex];
                orderView ov = new orderView(this.empNum, int.Parse(row.Cells[0].Value.ToString()));
                ov.Show();
                this.Hide();
            }
            //this.searchOrderByOrder.Text = row.Cells[0].Value.ToString();         
        }

        private void searchQueue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {
                DataGridViewRow row = this.searchQueue.Rows[rowIndex];
                orderView ov = new orderView(this.empNum, int.Parse(row.Cells[0].Value.ToString()));
                ov.Show();
                this.Hide();
                //this.searchOrderByOrder.Text = row.Cells[0].Value.ToString();
            }
        }

        private void perDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.perDateCheckBox.Checked)
            {
                this.toDateOrder.Show();
                this.fromDateOrder.Show();
                this.label3.Show();
                this.label4.Show();
            }
            else
            {
                this.toDateOrder.Hide();
                this.fromDateOrder.Hide();
                this.label3.Hide();
                this.label4.Hide();
            }
        }
    }
}
