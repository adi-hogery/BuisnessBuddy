using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GROUP16
{
    public class Order
    {
        private int OrderNumber;
        private Status OrderStatus;
        private DateTime DueDate;
        private int OrderPriority;
        private int Amount;
        private string OrderAddress;
        private DateTime DeliveryDate;
        private double Price;
        private double Discount;
        private double StickerLength;
        private double StickerWidth;
        private int KnifeType;
        private int CreateBy;
        private Graphic GraphicDesign;
        private Invoice InvoiceNum;
        private Customer CustomerNum;


        public Order(int OrderNumber, Status OrderStatus, DateTime DueDate, int OrderPriority, int Amount, string OrderAddress, DateTime DeliveryDate, double Price, double Discount, double StickerLength, double StickerWidth, int KnifeType, int CreateBy, Graphic GraphicDesign, Invoice InvoiceNum, Customer CustomerNum, bool is_new)
        {
            this.OrderNumber = OrderNumber;
            this.OrderStatus = OrderStatus;
            this.DueDate = DueDate;
            this.OrderPriority = OrderPriority;
            this.Amount = Amount;
            this.OrderAddress = OrderAddress;
            this.DeliveryDate = DeliveryDate;
            this.Price = Price;
            this.Discount = Discount;
            this.StickerLength = StickerLength;
            this.StickerWidth = StickerWidth;
            this.KnifeType = KnifeType;
            this.CreateBy = CreateBy;
            this.GraphicDesign = GraphicDesign;
            this.InvoiceNum = InvoiceNum;
            this.CustomerNum = CustomerNum;

            if (is_new)
            {
                this.create_Order();
                Program.Orders.Add(this);

            }
        }

        //gets method
        public int get_OrderNumber()
        {
            return this.OrderNumber;
        }
        public Status get_OrderStatus()
        {
            return this.OrderStatus;
        }
        public DateTime get_DueDate()
        {
            return this.DueDate;
        }
        public int get_OrderPriority()
        {
            return this.OrderPriority;
        }
        public int get_Amount()
        {
            return this.Amount;
        }
        public string get_OrderAddress()
        {
            return this.OrderAddress;
        }
        public DateTime get_DeliveryDate()
        {
            return this.DeliveryDate;
        }
        public double get_Price()
        {
            return this.Price;
        }
        public double get_Discount()
        {
            return this.Discount;
        }
        public double get_StickerLength()
        {
            return this.StickerLength;
        }
        public double get_StickerWidth()
        {
            return this.StickerWidth;
        }
        public int get_KnifeType()
        {
            return this.KnifeType;
        }
        public int get_CreateBy()
        {
            return this.CreateBy;
        }
        public Graphic get_GraphicDesign()
        {
            return this.GraphicDesign;
        }
        public Invoice get_InvoiceNumOrder()
        {
            return this.InvoiceNum;
        }
        public Customer get_CustomerNum()
        {
            return this.CustomerNum;
        }
        //sets methods
        public void set_OrderNumber(int OrderNumber)
        {
            this.OrderNumber = OrderNumber;
        }
        public void set_OrderStatus(Status OrderStatus)
        {
            this.OrderStatus = OrderStatus;
        }
        public void set_DueDate(DateTime DueDate)
        {
            this.DueDate = DueDate;
        }
        public void set_OrderPriority(int OrderPriority)
        {
            this.OrderPriority = OrderPriority;
        }
        public void set_Amount(int Amount)
        {
            this.Amount = Amount;
        }
        public void set_OrderAddress(string OrderAddress)
        {
            this.OrderAddress = OrderAddress;
        }
        public void set_DeliveryDate(DateTime DeliveryDate)
        {
            this.DeliveryDate = DeliveryDate;
        }
        public void set_Price(double Price)
        {
            this.Price = Price;
        }
        public void set_Discount(double Discount)
        {
            this.Discount = Discount;
        }
        public void set_StickerLength(double StickerLength)
        {
            this.StickerLength = StickerLength;
        }
        public void set_StickerWidth(double StickerWidth)
        {
            this.StickerWidth = StickerWidth;
        }
        public void set_KnifeType(int KnifeType)
        {
            this.KnifeType = KnifeType;
        }
        public void set_CreateBy(int CreateBy)
        {
            this.CreateBy = CreateBy;
        }
        public void set_GraphicDesign(Graphic GraphicDesign)
        {
            this.GraphicDesign = GraphicDesign;
        }
        public void set_InvoiceNum(Invoice inv)
        {
            this.InvoiceNum = inv;
        }
        public void set_CustomerNum(Customer CustomerNum)
        {
            this.CustomerNum = CustomerNum;
        }


        public void create_Order()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_ORDER @OrderNumber, @OrderStatus ,@DueDate , @OrderPriority ,@Amount , @OrderAddress ,@DeliveryDate , @Price ,@Discount ,@StickerLength ,@StickerWidth, @KnifeType , @CreateBy , @GraphicDesign , @InvoiceNum ,@CustomerNum ";
            c.Parameters.AddWithValue("@OrderNumber", this.OrderNumber);
            c.Parameters.AddWithValue("@OrderStatus", this.OrderStatus.ToString());
            c.Parameters.AddWithValue("@DueDate", this.DueDate);
            c.Parameters.AddWithValue("@OrderPriority", this.OrderPriority);
            c.Parameters.AddWithValue("@Amount", this.Amount);
            c.Parameters.AddWithValue("@OrderAddress", this.OrderAddress);
            c.Parameters.AddWithValue("@DeliveryDate", this.DeliveryDate);
            c.Parameters.AddWithValue("@Price", this.Price);
            c.Parameters.AddWithValue("@Discount", this.Discount);
            c.Parameters.AddWithValue("@StickerLength", this.StickerLength);
            c.Parameters.AddWithValue("@StickerWidth", this.StickerWidth);
            c.Parameters.AddWithValue("@KnifeType", this.KnifeType);
            c.Parameters.AddWithValue("@CreateBy", this.CreateBy);
            c.Parameters.AddWithValue("@GraphicDesign", this.GraphicDesign.getGraphicNum());
            c.Parameters.AddWithValue("@InvoiceNum", this.InvoiceNum.get_num());
            c.Parameters.AddWithValue("@CustomerNum", this.CustomerNum.get_custNumber());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_Order()
        {
           
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_ORDER @OrderNumber, @OrderStatus ,@DueDate , @OrderPriority ,@Amount , @OrderAddress ,@DeliveryDate , @Price ,@Discount ,@StickerLength ,@StickerWidth, @KnifeType , @CreateBy , @GraphicDesign , @InvoiceNum ,@CustomerNum ";
            c.Parameters.AddWithValue("@OrderNumber", this.OrderNumber);
            c.Parameters.AddWithValue("@OrderStatus", this.OrderStatus.ToString());
            c.Parameters.AddWithValue("@DueDate", this.DueDate);
            c.Parameters.AddWithValue("@OrderPriority", this.OrderPriority);
            c.Parameters.AddWithValue("@Amount", this.Amount);
            c.Parameters.AddWithValue("@OrderAddress", this.OrderAddress);
            c.Parameters.AddWithValue("@DeliveryDate", this.DeliveryDate);
            c.Parameters.AddWithValue("@Price", this.Price);
            c.Parameters.AddWithValue("@Discount", this.Discount);
            c.Parameters.AddWithValue("@StickerLength", this.StickerLength);
            c.Parameters.AddWithValue("@StickerWidth", this.StickerWidth);
            c.Parameters.AddWithValue("@KnifeType", this.KnifeType);
            c.Parameters.AddWithValue("@CreateBy", this.CreateBy);
            c.Parameters.AddWithValue("@GraphicDesign", this.GraphicDesign.getGraphicNum());
            c.Parameters.AddWithValue("@InvoiceNum", this.InvoiceNum.get_num());
            c.Parameters.AddWithValue("@CustomerNum", this.CustomerNum.get_custNumber());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
