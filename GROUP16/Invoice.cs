using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GROUP16
{
    public class Invoice
    {
        private int InvoiceNum;
        private double Price;
        private DateTime DeliveryDate;
        private bool Signed;
        private string Path;
        private int OrderNum;


        public Invoice(int num, double inPrice, DateTime d, bool signed, string path, int orderNumber, bool is_new)
        {

            this.InvoiceNum = num;
            this.Price = inPrice;
            this.OrderNum = orderNumber;
            this.Signed = false;
            this.Path = path;
            this.DeliveryDate = d;

            if (is_new)
            {
                this.create_Invoice();
                Program.Invoices.Add(this);
            }

        }


        public void create_Invoice()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_INVOICE @InvoiceNum, @Price,@DeliveryDate, @Signed, @Path, @OrderNum";
            c.Parameters.AddWithValue("@InvoiceNum", this.InvoiceNum);
            c.Parameters.AddWithValue("@Price", this.Price);
            c.Parameters.AddWithValue("@DeliveryDate", this.DeliveryDate);
            c.Parameters.AddWithValue("@Signed", this.Signed.ToString());
            c.Parameters.AddWithValue("@Path", this.Path);
            c.Parameters.AddWithValue("@OrderNum", this.OrderNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Invoice()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_INVOICE @InvoiceNum, @Price,@DeliveryDate, @Signed, @Path, @OrderNum";
            c.Parameters.AddWithValue("@InvoiceNum", this.InvoiceNum);
            c.Parameters.AddWithValue("@Price", this.Price);
            c.Parameters.AddWithValue("@DeliveryDate", this.DeliveryDate);
            c.Parameters.AddWithValue("@Signed", this.Signed);
            c.Parameters.AddWithValue("@Path", this.Path);
            c.Parameters.AddWithValue("@OrderNum", this.OrderNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public int get_num()
        {
            return this.InvoiceNum;
        }
        public double get_Price()
        {
            return this.Price;
        }
        public DateTime get_deliveryDate()
        {
            return this.DeliveryDate;
        }
        public string get_Path()
        {
            return this.Path;
        }
        public int get_orderNum()
        {
            return this.OrderNum;
        }
        public bool get_Signed()
        {
            return this.Signed;
        }
        public Invoice GetInvoice()
        {
            return this;
        }

        //sets methods
        public void set_num(int inNum)
        {
            this.InvoiceNum = inNum;
        }
        public void set_Price(double Price)
        {
            this.Price = Price;
        }
        public void set_dDate(DateTime delivery)
        {
            this.DeliveryDate = delivery;
        }
        public void set_Path(string Path)
        {
            this.Path = Path;
        }
        public void set_OrderNum(int orNum)
        {
            this.OrderNum = orNum;
        }
        public void set_Address(bool sign)
        {
            this.Signed = sign;
        }

        public void set_Signed(bool sign)
        {
            this.Signed = sign;
        }

    }
    }

