using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GROUP16
{
    public class Customer
    {
        private int custNumber;
        private string custName;
        private string custPhone;
        private string custEmail;

        public Customer(int custNumber, string custName, string PhoneNumber, string custEmail, bool is_new)
        {
            this.custNumber = custNumber;
            this.custName = custName;
            this.custPhone = PhoneNumber;
            this.custEmail = custEmail;
            if (is_new)
            {
                this.create_customer();
                Program.Customers.Add(this);
            }
            
        }

        //gets
        public int get_custNumber()
        {
            return this.custNumber;
        }

        public string get_custName()
        {
            return this.custName;
        }

        public string get_custPhone()
        {
            return this.custPhone;
        }

        public string get_custEmail()
        {
            return this.custEmail;
        }
        // sets
        public void set_num(int custNum)
        {

            this.custNumber = custNum;
        }

        public void set_name(string custName)
        {
            this.custName = custName;
        }
        public void set_PhoneNumber(string PhoneNumber)
        {
            this.custPhone = PhoneNumber;
        }
        public void set_Email(string Email)
        {
            this.custEmail = Email;
        }

        public void create_customer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_CUSTOMER @CustomerNumber, @CustomerName,@phone, @Email";
            c.Parameters.AddWithValue("@CustomerNumber", this.custNumber);
            c.Parameters.AddWithValue("@CustomerName", this.custName);
            c.Parameters.AddWithValue("@phone", this.custPhone);
            c.Parameters.AddWithValue("@Email", this.custEmail);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_customer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_CUSTOMER @custNumber, @custName, @custPhone, @custEmail";
            c.Parameters.AddWithValue("@custNumber", this.custNumber);
            c.Parameters.AddWithValue("@custName", this.custName);
            c.Parameters.AddWithValue("@custPhone", this.custPhone);
            c.Parameters.AddWithValue("@custEmail", this.custEmail);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
