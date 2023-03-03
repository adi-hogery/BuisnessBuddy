using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GROUP16
{
    public class Event
    {
        private int EventNum;
        private DateTime EventDate;
        private string Description;
        private EventCategory Category;

        public Event(int EventNum, DateTime EventDate, string Description, EventCategory Category, bool is_new)
        {
            this.EventNum = EventNum;
            this.EventDate = EventDate;
            this.Description = Description;
            this.Category = Category;
            if (is_new)
            {
                this.create_Event();
                Program.Events.Add(this);
            }
        }

        //gets methods
        public int getEventNum()
        {
            return this.EventNum;
        }
        public DateTime getEventDate()
        {
            return this.EventDate;
        }
        public string getDescription()
        {
            return this.Description;
        }
        public EventCategory getCategory()
        {
            return this.Category;
        }

        //sets methods
        public void setEventNum(int EventNum)
        {
            this.EventNum = EventNum;
        }
        public void setEventDate(DateTime EventDate)
        {
            this.EventDate = EventDate;
        }
        public void setDescription(string Description)
        {
            this.Description = Description;
        }
        public void setCategory(EventCategory Category)
        {
            this.Category = Category;
        }

        public void create_Event()
        {
            string s = "";
            if (this.Category.ToString() == "BM")
            {
                s = "Business meeting";
            }
            if (this.Category.ToString() == "PM")
            {
                s = "Private Meeting";
            }
            if (this.Category.ToString() == "SE")
            {
                s = "Social Events";
            }
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_EVENT @EventNum, @EventDate , @Description,@Category";
            c.Parameters.AddWithValue("@EventNum", this.EventNum);
            c.Parameters.AddWithValue("@EventDate", this.EventDate);
            c.Parameters.AddWithValue("@Description", this.Description);
            c.Parameters.AddWithValue("@Category", s);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_event()
        {
            string s = "";
            if (this.Category.ToString() == "BM")
            {
                s = "Business meeting";
            }
            if (this.Category.ToString() == "PM")
            {
                s = "Private Meeting";
            }
            if (this.Category.ToString() == "SE")
            {
                s = "Social Events";
            }

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_EVENT @EventNum, @EventDate , @Description,@Category";
            c.Parameters.AddWithValue("@EventNum", this.EventNum);
            c.Parameters.AddWithValue("@EventDate", this.EventDate);
            c.Parameters.AddWithValue("@Description", this.Description);
            c.Parameters.AddWithValue("@Category", s);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void addEmp(int eve, int emp)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "Execute dbo.SP_add_EMPEVENT @EventNum ,@EmployeeNum";
            c.Parameters.AddWithValue("@EventNum", eve);
            c.Parameters.AddWithValue("@EmployeeNum", emp);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
        }

        public void removeEmp(int eve, int emp)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "Execute dbo.SP_DELETE_EMPEVENT @EventNum ,@EmpNum";
            c.Parameters.AddWithValue("@EventNum", eve);
            c.Parameters.AddWithValue("@EmpNum", emp);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
        }
    }
}
