using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GROUP16
{
    public class Colors
    {
        private ColorType ColorName;

        public Colors(ColorType ColorName, bool is_new)
        {
            this.ColorName = ColorName;
            if (is_new)
            {
                this.create_color();
                Program.Colors.Add(this);
            }
        }

        public ColorType getColorName()
        {
            return this.ColorName;
        }
        public void setColorName(ColorType ColorName)
        {
            this.ColorName = ColorName;
        }

        public void create_color()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_COLOR @color";
            c.Parameters.AddWithValue("@ColorName", this.ColorName.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
