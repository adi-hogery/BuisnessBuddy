using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GROUP16
{
    public class StickerPaper
    {
        private int ProductNumber;
        private PaperType ProductName;
        private double ProductWidth;
        private double Quantity;

        public StickerPaper(int ProductNumber, PaperType ProductName, double ProductWidth, double Quantity,bool is_new)
        { 
            this.ProductNumber = ProductNumber;
            this.ProductName = ProductName;
            this.ProductWidth = ProductWidth;
            this.Quantity = Quantity;

            if (is_new)
            {
                this.create_StickerPaper();
                Program.StickerPapers.Add(this);
            }
        }

        //gets methods
        public int getProductNumber()
        {
            return this.ProductNumber;
        }
        public PaperType getPaperType()
        {
            return this.ProductName;
        }
        public double getProductWidth()
        {
            return this.ProductWidth;
        }
        public double getQuantity()
        {
            return this.Quantity;
        }

        //sets methods
        public void setProductNumber(int ProductNumber)
        {
            this.ProductNumber = ProductNumber;
        }
        public void setPaperType(PaperType ProductName)
        {
            this.ProductName = ProductName;
        }
        public void setProductWidth(double ProductWidth)
        {
            this.ProductWidth = ProductWidth;
        }
        public void setQuantity(double Quantity)
        {
            this.Quantity = Quantity;
        }

        public void create_StickerPaper()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_STICKERPAPERS @ProductNumber, @ProductName,@ProductWidth, @Quantity";
            c.Parameters.AddWithValue("@ProductNumber", this.ProductNumber);
            c.Parameters.AddWithValue("@ProductName", this.ProductName.ToString());
            c.Parameters.AddWithValue("@ProductWidth", this.ProductWidth);
            c.Parameters.AddWithValue("@Quantity", this.Quantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_StickerPaper()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_STICKERPAPERS @ProductNumber, @ProductName ,@ProductWidth ,@Quantity";
            c.Parameters.AddWithValue("@ProductNumber", this.ProductNumber);
            c.Parameters.AddWithValue("@ProductName", this.ProductName.ToString());
            c.Parameters.AddWithValue("@ProductWidth", this.ProductWidth);
            c.Parameters.AddWithValue("@Quantity", this.Quantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public bool updateInventoryFromOrder(int numOfStickers, double stickerLength, double stickerWidth)
        {
            
            int inRow = (int)(this.getProductWidth() / stickerWidth);
            int howManyRows = (int)(numOfStickers / inRow) + 1;
            double used = stickerLength * howManyRows / 100;
            if (this.getQuantity() > used)
            {
                this.setQuantity(this.getQuantity() - used);

                SqlCommand c = new SqlCommand();
                c.CommandText = "dbo.SP_Update_STICKERPAPERS_quantity_Number @ProductNum ,@Quantity";
                c.Parameters.AddWithValue("@ProductNum", this.getProductNumber());
                c.Parameters.AddWithValue("@Quantity", this.getQuantity());
                SQL_CON SC = new SQL_CON();
                SqlDataReader rdr = SC.execute_query(c);
                if (this.getQuantity() < 1500)
                {
                    MessageBox.Show("המלאי ממוצר " + this.getProductNumber().ToString() + " כרגע הוא: " + this.getQuantity().ToString() +" נא ליצור קשר עם ספק");
                }
                return true;
            }
            else
            {
                String message = ("אין לך מספיק מלאי");
                String title = ("איךךךךךך");
                MessageBox.Show(message, title);
                return false;
            }
        }

    }
}
