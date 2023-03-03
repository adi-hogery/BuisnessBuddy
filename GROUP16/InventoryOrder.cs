using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GROUP16
{
    public class InventoryOrder
    {
        private int OrderNumber;
        private DateTime DateOfOrder;
        private bool Arrived;
        private double TotalPrice;
        private DateTime DeliveryDate;
        private Employee MadeBy;
        private Supplier Supplier;

        public InventoryOrder(int OrderNumber, DateTime DateOfOrder, bool Arrived, double TotalPrice, DateTime DeliveryDate,Employee MadeBy, Supplier Supplier, bool is_new)
        {
            this.OrderNumber = OrderNumber;
            this.DateOfOrder = DateOfOrder;
            this.Arrived = Arrived;
            this.TotalPrice = TotalPrice;
            this.DeliveryDate = DeliveryDate;
            this.MadeBy = MadeBy;
            this.MadeBy = MadeBy;
            if (is_new)
            {
                this.create_InventoryOrder();
                Program.InventoryOrders.Add(this);
            }
        }

        //gets methods
        public int getOrderNumber()
        {
            return this.OrderNumber;
        }
        public DateTime getDateOfOrder()
        {
            return this.DateOfOrder;
        }
        public bool getArrived()
        {
            return this.Arrived;
        }
        public double getTotalPrice()
        {
            return this.TotalPrice;
        }
        public DateTime getDeliveryDate()
        {
            return this.DeliveryDate;
        }
        public Employee getMadeBy()
        {
            return this.MadeBy;
        }
        public Supplier getSupplier()
        {
            return this.Supplier;
        }


        //sets methods
        public void setOrderNumber(int OrderNumber)
        {
            this.OrderNumber = OrderNumber;
        }
        public void setDateOfOrder(DateTime DateOfOrder)
        {
            this.DateOfOrder = DateOfOrder;
        }
        public void setArrived(bool Arrived)
        {
            this.Arrived = Arrived;
        }
        public void setTotalPrice(double TotalPrice)
        {
            this.TotalPrice = TotalPrice;
        }
        public void setDeliveryDate(DateTime DeliveryDate)
        {
            this.DeliveryDate = DeliveryDate;
        }
        public void setMadeBy(Employee MadeBy)
        {
            this.MadeBy = MadeBy;
        }
        public void setSupplier(Supplier Supplier)
        {
            this.Supplier = Supplier;
        }

        public void create_InventoryOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE  dbo.SP_add_INVENTORYORDER @OrderNumber , @DateOfOrder ,@Arrived, @TotalPrice ,@DeliveryDate,@MadeBy , @Supplier";
            c.Parameters.AddWithValue("@OrderNumber", this.OrderNumber);
            c.Parameters.AddWithValue("@DateOfOrder", this.DateOfOrder);
            c.Parameters.AddWithValue("@Arrived", this.Arrived);
            c.Parameters.AddWithValue("@TotalPrice", this.TotalPrice);
            c.Parameters.AddWithValue("@DeliveryDate", this.DeliveryDate);
            c.Parameters.AddWithValue("@MadeBy", this.MadeBy.get_num());
            c.Parameters.AddWithValue("@Supplier", this.Supplier.getSupNumber());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_InventoryOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_INVENTORYORDER @OrderNumber , @DateOfOrder ,@Arrived, @TotalPrice ,@DeliveryDate,@MadeBy , @Supplier";
            c.Parameters.AddWithValue("@OrderNumber", this.OrderNumber);
            c.Parameters.AddWithValue("@DateOfOrder", this.DateOfOrder);
            c.Parameters.AddWithValue("@Arrived", this.Arrived);
            c.Parameters.AddWithValue("@TotalPrice", this.TotalPrice);
            c.Parameters.AddWithValue("@DeliveryDate", this.DeliveryDate);
            c.Parameters.AddWithValue("@MadeBy", this.MadeBy.get_num());
            c.Parameters.AddWithValue("@Supplier", this.Supplier.getSupNumber());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
