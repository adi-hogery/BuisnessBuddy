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
    public partial class addOrder : Form
    {
        int empNum;
        int custNum;
        double disc = 0;
        public addOrder(int num, int customerNum)
        {
            InitializeComponent();
            this.empNum = num;
            //generate order Number!!!!!
            this.priority.Text = "5";
            this.amount.Text = "0";
            this.ordLength.Text = "0";
            this.ordWidth.Text = "0";
            this.ordPrice.ReadOnly = true;
            this.discountTextBox.Text = this.disc.ToString();
            this.custNum = customerNum;
            this.ordCustomer.Text = customerNum.ToString();
            int newNumber = Program.Orders.Count() + 2230020;
            this.orderNum.Text = newNumber.ToString();
            this.giveDiscount.Hide();
            this.discountTextBox.Hide();
            this.ordCustomer.ReadOnly = true;
            this.PaperType.DataSource = Enum.GetValues(typeof(PaperType));
            knifeTypeFill();
            Employee e = Program.seekEmployee(empNum);
            if(Program.getPermission(e) == 1)
            {
                this.giveDiscount.Show();
                this.discountTextBox.Show();
            }
        }


        private void knifeTypeFill()
        {
            for(int i=1; i<11; i++)
            {
                this.knieTypeCombo.Items.Add(i.ToString());
            }
        }
        private void addOrder_Load(object sender, EventArgs e)
        {

        }

        private int checkParameters()
        {
            if(int.Parse(priority.Text)<1 || int.Parse(priority.Text) > 10 || !priority.Text.All(Char.IsDigit))
            {
                String message = ("הזן עדיפות בין 1 ל10");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            if (!String.IsNullOrEmpty(this.ordGraphic.Text))
            {
                if (Program.seekGraphic(int.Parse(this.ordGraphic.Text)) == null)
                {
                    String message = ("גרפיקה לא קיימת");
                    String title = ("שגיאה");
                    MessageBox.Show(message, title);
                    return (0);
                }
            }
            else
            {
                MessageBox.Show("אנא הזן מספר גרפיקה");
            }
            if (int.Parse(amount.Text) < 1 || double.Parse(ordLength.Text) < 0 || double.Parse(ordWidth.Text) < 0 || double.Parse(ordPrice.Text) < 0)
            {
                String message = ("אנא הזן מספרים חיוביים בלבד");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            if (ordAddress.Text.Length == 0)
            {
                String message = ("הזן כתובת");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            if (!IsDate(dueDate.Text) || DateTime.Parse(dueDate.Text)< DateTime.Now)
            {
                String message = (" אנא הכנס תאריך תקין לפי התבנית הבאה: YYYY-MM-DD"+"\n"+" בדוק שהכנסת תאריך עתידי");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            if (int.Parse(this.discountTextBox.Text)>99 || int.Parse(this.discountTextBox.Text)<0)
            {
                MessageBox.Show("שים אחוזים אל תתחכם");
                return (0);
            }
            // chceck if graphic is already exist!!!!!!!!!!!!!!!!!!!!!!!!!
            return (1);
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            if (checkParameters() == 1)
            {
                int newNumber = Program.Orders.Count() + 2230020;
                int invoiceNum = Program.Invoices.Count() + 10030;
                double priceCalc = Program.calcPrice(double.Parse(this.ordLength.Text), double.Parse(this.ordWidth.Text), int.Parse(this.amount.Text), this.disc);
                DateTime d = DateTime.Parse("1900-01-01 00:00:00");

                string forInvoice = "NULL PATH";
                Invoice i = new Invoice(invoiceNum, double.Parse(this.ordPrice.Text), d, false, forInvoice, newNumber, true);
                Graphic gra = Program.seekGraphic(int.Parse(this.ordGraphic.Text));
                Customer cust = Program.seekCustomer(int.Parse(this.ordCustomer.Text));

                Order O = new Order(newNumber, (Status)Enum.Parse(typeof(Status), "NO"), DateTime.Parse(this.dueDate.Text), int.Parse(this.priority.Text), int.Parse(this.amount.Text),
                    this.ordAddress.Text, d, priceCalc, disc, double.Parse(this.ordLength.Text), double.Parse(this.ordWidth.Text),
                    int.Parse(this.knieTypeCombo.Text), empNum, gra, i, cust, true);//יצירת הזמנה חדש            }

                
                

                int n = Program.seekStickerNum(this.PaperType.Text);
                SqlCommand c = new SqlCommand();
                c.CommandText = "Execute dbo.SP_add_PaperOrder @OrderNumber ,@ProductNumber";
                c.Parameters.AddWithValue("@OrderNumber", newNumber);
                c.Parameters.AddWithValue("@ProductNumber", n);
                SQL_CON SC = new SQL_CON();
                SqlDataReader rdr = SC.execute_query(c);

                MessageBox.Show("!!תן לו בעניבה");
                MessageBox.Show("!!תן לו בחליפה");
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                //player.SoundLocation = "C:\\Users\\avirange\\Downloads\\YudaYuda.wav";
                //player.Play();
            }
        }

        private void disFromCreateOrder_Click(object sender, EventArgs e)
        {
            welcomeScreen a = new welcomeScreen();
            a.Show();
            this.Hide();
        }

        private void exitFromCreateOrder_Click(object sender, EventArgs e)
        {
            searchCustomer sc = new searchCustomer(empNum,int.Parse(this.ordCustomer.Text));
            sc.Show();
            this.Hide();
        }

        private void ordLength_TextChanged(object sender, EventArgs e)
        {
            if (!ordLength.Text.All(Char.IsDigit))
            {
                String message = ("אנא הכנס ספרות בלבד");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                ordLength.Text = "0";
            }
           
        }

        private void ordWidth_TextChanged(object sender, EventArgs e)
        {
            if (!ordWidth.Text.All(Char.IsDigit))
            {
                String message = ("אנא הכנס ספרות בלבד");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                ordWidth.Text = "0";
            }
           
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            if (!amount.Text.All(Char.IsDigit))
            {
                String message = ("אנא הכנס ספרות בלבד");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                amount.Text = "0";
            }
            
        }

        private void ordPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcPriceButton_Click(object sender, EventArgs e)
        {
            double priceCalc = Program.calcPrice(double.Parse(this.ordLength.Text), double.Parse(this.ordWidth.Text), int.Parse(this.amount.Text), disc);
            this.ordPrice.Text = priceCalc.ToString();
        }

        private void giveDiscount_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(discountTextBox.Text))
            {
                if (!this.discountTextBox.Text.All(Char.IsDigit))
                {
                    MessageBox.Show("שים אחוזים אל תתחכם");
                }
                else
                {
                    this.disc = double.Parse(this.discountTextBox.Text);
                    double priceCalc = Program.calcPrice(double.Parse(this.ordLength.Text), double.Parse(this.ordWidth.Text), int.Parse(this.amount.Text), double.Parse(this.discountTextBox.Text));
                    this.ordPrice.Text = priceCalc.ToString();


                    if (int.Parse(this.discountTextBox.Text) > 99 || int.Parse(this.discountTextBox.Text) < 0)
                    {
                        MessageBox.Show("שים אחוזים אל תתחכם");

                    }
                }
            }
            else
            {
                MessageBox.Show("שים אחוזים ואז תלחץ אל תעשה סתם");
            }
        }
            private void label13_Click(object sender, EventArgs e)
        {

        }

        private void PaperType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void knifeType_TextChanged(object sender, EventArgs e)
        {

        }

        private void dueDate_TextChanged(object sender, EventArgs e)
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

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.discountTextBox.Text))
            {
                discountTextBox.Text = "0";
            }
        }
    }

        //private void amount_TextChanged(object sender, EventArgs e)
        //{
        //    this.ordPrice.Text = (Program.calcPrice(double.Parse(this.ordLength.Text), double.Parse(this.ordWidth.Text), int.Parse(this.amount.Text))).ToString() ;
        //}

        //private void ordLength_TextChanged(object sender, EventArgs e)
        //{
        //    this.ordPrice.Text = (Program.calcPrice(double.Parse(this.ordLength.Text), double.Parse(this.ordWidth.Text), int.Parse(this.amount.Text))).ToString();
        //}

        //private void ordWidth_TextChanged(object sender, EventArgs e)
        //{
        //    this.ordPrice.Text = (Program.calcPrice(double.Parse(this.ordLength.Text), double.Parse(this.ordWidth.Text), int.Parse(this.amount.Text))).ToString();
        //}
    }

