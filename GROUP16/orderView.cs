using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Diagnostics;

namespace GROUP16
{
    public partial class orderView : Form
    {
        int empNum;
        public orderView(int employeeNum, int orderNum)
        {
            InitializeComponent();
            this.empNum = employeeNum;
            Employee e = Program.seekEmployee(empNum);

            Order o = Program.seekOrder(orderNum);
            this.ordPrice.ReadOnly = true;
            this.orderNum.Text = o.get_OrderNumber().ToString();
            string formatted = o.get_DueDate().ToString("yyyy-MM-dd");

            this.dueDate.Text = formatted;
            this.priority.Text = o.get_OrderPriority().ToString();
            this.amount.Text = o.get_Amount().ToString();
            this.ordAddress.Text = o.get_OrderAddress();
            this.ordPrice.Text = o.get_Price().ToString();
            this.ordLength.Text = o.get_StickerLength().ToString();
            this.ordWidth.Text = o.get_StickerWidth().ToString();
            this.knifeType.Text = o.get_KnifeType().ToString();
            this.ordGraphic.Text = o.get_GraphicDesign().getGraphicNum().ToString();
            this.ordCustomer.Text = o.get_CustomerNum().get_custNumber().ToString();
            this.statusTextBox.Text = o.get_OrderStatus().ToString();
            this.statusTextBox.ReadOnly = true;
            this.ordCustomer.ReadOnly = true;
            this.paperType.DataSource = Enum.GetValues(typeof(PaperType));
            fillPaperType();
            this.discountTextBox.Hide();
            this.giveDiscount.Hide();
            this.mlay.Hide();
            this.viewInvoice.Hide();
            // C:\Users\avirange\Desktop\GROUP16 09.01 (2)\GROUP16 09.01\GROUP16 09.01\GROUP16 04.01\GROUP16\GROUP16\bin\Debug\2229943.pdf
            string path = "C:\\Users\\avirange\\Desktop\\GROUP16\\GROUP16\\bin\\Debug\\" + this.orderNum.Text + ".pdf";
            bool fileExist = File.Exists(path);
            Employee emp = Program.seekEmployee(this.empNum);
            if (fileExist)
            {
                this.viewInvoice.Show();
                this.button1.Hide();
            }
            if(Program.getPermission(emp) < 3)
            {
                this.button1.Show();
            }

        }



        private void fillPaperType()
        {
            SQL_CON SC2 = new SQL_CON();
            SqlCommand command = new SqlCommand();
            command.CommandText = "Execute dbo.Get_PaperOrder @OrderNumber";
            command.Parameters.AddWithValue("@OrderNumber", int.Parse(this.orderNum.Text));
            SqlDataReader rdr = SC2.execute_query(command);
            while (rdr.Read())
            {
                PaperType p;
                if (rdr.GetValue(0).ToString() == "White PVC")
                {
                    p = (PaperType)Enum.Parse(typeof(PaperType), "WPVC");
                }
                else
                {
                    if (rdr.GetValue(0).ToString() == "Black PVC")
                    {
                        p = (PaperType)Enum.Parse(typeof(PaperType), "BPVC");
                    }
                    else
                    {
                        p = (PaperType)Enum.Parse(typeof(PaperType), rdr.GetValue(0).ToString());
                    }
                }
                string simpleValue = p.ToString();
                this.paperType.Text = simpleValue;
            }
        }
        private int checkParameters()
        {
            if (String.IsNullOrEmpty(priority.Text) || String.IsNullOrEmpty(ordAddress.Text)|| String.IsNullOrEmpty(ordGraphic.Text))
            {
                MessageBox.Show("אנא בדוק שלא השארת שדות ריקים");
                return (0);
            }
            if (String.IsNullOrEmpty(amount.Text) || String.IsNullOrEmpty(ordLength.Text) || String.IsNullOrEmpty(ordWidth.Text))
            {
                MessageBox.Show("אנא בדוק שלא השארת שדות ריקים");
                return (0);
            }
            if (String.IsNullOrEmpty(ordCustomer.Text) || String.IsNullOrEmpty(knifeType.Text) || String.IsNullOrEmpty(ordWidth.Text))
            {
                MessageBox.Show("אנא בדוק שלא השארת שדות ריקים");
                return (0);
            }
            if (int.Parse(priority.Text) < 1 || int.Parse(priority.Text) > 10 || !priority.Text.All(Char.IsDigit))
                {
                    String message = ("הזן עדיפות בין 1 ל10");
                    String title = ("שגיאה");
                    MessageBox.Show(message, title);
                    return (0);
                }             
            
            if (Program.seekGraphic(int.Parse(this.ordGraphic.Text)) == null)
            {
                String message = ("גרפיקה לא קיימת");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
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
            if (!knifeType.Text.All(Char.IsDigit))
            {
                String message = ("אנא הזן ספרות בלבד");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            if (!IsDate(dueDate.Text) || DateTime.Parse(dueDate.Text) < DateTime.Now)
            {
                String message = ("אנא הכנס תאריך תקין לפי התבנית הבאה: YYYY-MM-DD");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }
            if (int.Parse(this.discountTextBox.Text) > 99 || int.Parse(this.discountTextBox.Text) < 0)
            {
                MessageBox.Show("שים אחוזים אל תתחכם");
                return (0);
            }
                // chceck if graphic is already exist!!!!!!!!!!!!!!!!!!!!!!!!!
                return (1);
        }


        private void updateOrder_Click(object sender, EventArgs e)
        {
            if (checkParameters() == 1)
            {
                int searchNum = int.Parse(this.orderNum.Text);
                Order o = Program.seekOrder(searchNum);

                o.set_DueDate(DateTime.Parse(this.dueDate.Text));
                o.set_OrderPriority(int.Parse(this.priority.Text));
                o.set_Amount(int.Parse(this.amount.Text));
                o.set_OrderAddress(this.ordAddress.Text);
                o.set_Price(double.Parse(this.ordPrice.Text));
                o.set_StickerLength(double.Parse(this.ordLength.Text));
                o.set_StickerWidth(double.Parse(this.ordWidth.Text));
                o.set_KnifeType(int.Parse(this.knifeType.Text));
                Graphic gra = Program.seekGraphic(int.Parse(this.ordGraphic.Text));
                o.set_GraphicDesign(gra);
                Customer cust = Program.seekCustomer(int.Parse(this.ordCustomer.Text));
                o.set_CustomerNum(cust);

                o.Update_Order();
                MessageBox.Show("הזמנה עודכנה בהצלחה");

                int n = Program.seekStickerNum(this.paperType.Text);
                SqlCommand c = new SqlCommand();
                c.CommandText = "Execute dbo.SP_Update_PaperOrder @OrderNumber ,@ProductNumber";
                c.Parameters.AddWithValue("@OrderNumber", int.Parse(this.orderNum.Text));
                c.Parameters.AddWithValue("@ProductNumber", n);
                SQL_CON SC = new SQL_CON();
                SqlDataReader rdr = SC.execute_query(c);
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
            ordersPage op = new ordersPage(this.empNum);
            op.Show();
            this.Hide();
        }

        private void ordCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (PdfDocument document = new PdfDocument())
            {
                //Add a page to the document
                PdfPage page = document.Pages.Add();

                //Create PDF graphics for a page
                PdfGraphics graphics = page.Graphics;

                //Set the standard font
                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

                //Adds page settings
                document.PageSettings.Orientation = PdfPageOrientation.Landscape;
                document.PageSettings.Margins.All = 50;

                //PdfBitmap image = new PdfBitmap("C:\\Users\\avirange\\Downloads\\stickerInA.jpg.png");
                //graphics.DrawImage(image, 115, 0, 500, 500);
                //PdfBitmap signeture = new PdfBitmap("C:\\Users\\avirange\\Downloads\\signature.jpg.jpeg");
                //graphics.DrawImage(signeture, 20, 540, 400, 150);


                //Draw the text
                string OrderInvoice = "\n" + "\n" +
                    "Invoice \n" +
                    "\n" +

                     "Order Number:  " + this.orderNum.Text + "\n" + "\n" +
                     "Due Date:  " + this.dueDate.Text + "\n" + "\n" +
                    "Amount:  " + this.amount.Text + "\n" + "\n" +
                     "Address:  " + this.ordAddress.Text + "\n" + "\n" +
                     "Price:  " + this.ordPrice.Text + "ILS" + "\n" + "\n" +
                    "Length:  " + this.ordLength.Text + "\n" + "\n" +
                    "Width:  " + this.ordWidth.Text + "\n" + "\n" +
                    "knife Type:  " + this.knifeType.Text + "\n" + "\n" +
                     "Graphic:  " + this.ordGraphic.Text + "\n" + "\n" +
                     "Customer:  " + this.ordCustomer.Text + "\n" + "\n";
                graphics.DrawString(OrderInvoice, font, PdfBrushes.Black, new PointF(0, 0));

                //Save the document
                string File = this.orderNum.Text + ".pdf";
                document.Save(File);
                MessageBox.Show("חשבונית נוצרה ונשמרה בתיקיית חשבוניות");
                this.viewInvoice.Show();
            }
        }

        private void viewInvoice_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\avirange\\Desktop\\GROUP16\\GROUP16\\bin\\Debug\\" + this.orderNum.Text + ".pdf";
            ProcessStartInfo startInfo = new ProcessStartInfo(path);
            Process.Start(startInfo);
            //System.Diagnostics.Process.Start(filename);
        }

       // private void mlay_Click(object sender, EventArgs e)
       // {
         //   int prodNum = Program.seekStickerNum(this.paperType.Text);
         //   Program.updateInventoryFromOrder(prodNum, int.Parse(this.amount.Text), int.Parse(this.ordLength.Text), int.Parse(this.ordWidth.Text));
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void orderView_Load(object sender, EventArgs e)
        {

        }

        private void statusChange_Click(object sender, EventArgs e)
        {

            Order o = Program.seekOrder(int.Parse(this.orderNum.Text));
            if (o.get_OrderStatus().ToString() == "NO")
            {
                o.set_OrderStatus((Status)Enum.Parse(typeof(Status), "Graphic"));
            }
            else
            {
                if (o.get_OrderStatus().ToString() == "Graphic")
                {
                    o.set_OrderStatus((Status)Enum.Parse(typeof(Status), "HP"));
                }
                else
                {
                    if (o.get_OrderStatus().ToString() == "HP")
                    {
                        int prodNum = Program.seekStickerNum(this.paperType.Text);
                        StickerPaper SP = Program.seekStickerPaper(prodNum);
                        if(SP.updateInventoryFromOrder(int.Parse(this.amount.Text), int.Parse(this.ordLength.Text), int.Parse(this.ordWidth.Text)))
                        {
                            o.set_OrderStatus((Status)Enum.Parse(typeof(Status), "Cut"));
                        }
                    }
                    else
                    {
                        if (o.get_OrderStatus().ToString() == "Cut")
                        {
                            o.set_OrderStatus((Status)Enum.Parse(typeof(Status), "Roll"));
                            this.button1.PerformClick();
                        }
                        else
                        {
                            if (o.get_OrderStatus().ToString() == "Roll")
                            {
                                o.set_OrderStatus((Status)Enum.Parse(typeof(Status), "Delivery"));
                                //create invoice
                                Customer c = Program.seekCustomer(int.Parse(this.ordCustomer.Text));
                                string to = c.get_custEmail();
                                string body = "לקוח יקר, ברגעים אלו הזמנתך נשלחה לאריזה, נהג יצור איתך קשר בקרוב!" + "\n" + " תודה על הסבלנות, מדבקה ברגע";
                                SendingEmail s = new SendingEmail(1252, to, "ההזמנה בדרך אלייך", body, false, true);
                                s.Show();
                                s.Hide();
                            }
                            else
                            {
                                if (o.get_OrderStatus().ToString() == "Delivery")
                                {
                                    o.set_OrderStatus((Status)Enum.Parse(typeof(Status), "Completed"));
                                    this.statusChange.Hide();
                                    o.set_DeliveryDate(DateTime.Now);
                                    o.Update_Order();
                                    Customer c = Program.seekCustomer(int.Parse(this.ordCustomer.Text));
                                    string path = "C:\\Users\\avirange\\Desktop\\GROUP16\\GROUP16\\bin\\Debug\\" + this.orderNum.Text + ".pdf";
                                    string to = c.get_custEmail();
                                    o.get_InvoiceNumOrder().set_Signed(true);
                                    string body = "לקוח יקר, היה כבוד גדול לתת לך שירות, מקווים לראותך שוב בקרוב";
                                    SendingEmail s = new SendingEmail(1252, to, "מדבקה ברגע", body, path, false);
                                    s.Show();
                                    s.Hide();
                                }
                            }
                        }
                    }
                }

            }
            o.Update_Order();
            this.statusTextBox.Text = o.get_OrderStatus().ToString();
            this.statusChange.Hide();
        }

        private void orderNum_TextChanged(object sender, EventArgs e)
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

        private void ordGraphic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

