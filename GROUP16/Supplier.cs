using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GROUP16
{
    public class Supplier
    {
        private int SupNumber;
        private string Phone;
        private string Email;
        private string SupAddress;
        private Boolean IsActive;
        private string Contact;

        public Supplier(int SupNumber, string Phone, string Email, string SupAddress, String IsActive, string Contact, bool is_new)
        {
            this.SupNumber = SupNumber;
            this.Phone = Phone;
            this.Email = Email;
            this.SupAddress = SupAddress;
            this.Contact= Contact;
            if (IsActive == "false")
            {
                this.IsActive = false;
            }
            else
            {
                this.IsActive = true;
            }
            if (is_new)
            {
                this.create_supplier();
                Program.Suppliers.Add(this);
            }
        }

        //gets methods
        public int getSupNumber()
        {
            return this.SupNumber;
        }
        public string getPhone()
        {
            return this.Phone;
        }
        public string getEmail()
        {
            return this.Email;
        }
        public string getSupAddress()
        {
            return this.SupAddress;
        }
        public bool getIsActive()
        {
            return this.IsActive;
        }
        public string getContact()
        {
            return this.Contact;
        }
        //sets methods
        public void setSupNumber(int SupNumber)
        {
            this.SupNumber = SupNumber;
        }
        public void setPhone(string Phone)
        {
            this.Phone = Phone;
        }
        public void setEmail(string Email)
        {
            this.Email = Email;
        }
        public void setSupAddress(string SupAddress)
        {
            this.SupAddress = SupAddress;
        }
        public void setIsActive(bool IsActive)
        {
            this.IsActive = IsActive;
        }
        public void setContact(string Contact)
        {
            this.Contact = Contact;
        }


        public void create_supplier()
        {
            string act;
            if (this.IsActive)
            {
                act = "True";
            }
            else
            {
                act = "False";
            }
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_SUPPLIER @SupNumber, @phone,@Email, @SupAddress,@IsActive,@Contact";
            c.Parameters.AddWithValue("@SupNumber", this.SupNumber);
            c.Parameters.AddWithValue("@phone", this.Phone);
            c.Parameters.AddWithValue("@Email", this.Email);
            c.Parameters.AddWithValue("@SupAddress", this.SupAddress);
            c.Parameters.AddWithValue("@IsActive", act);
            c.Parameters.AddWithValue("@Contact", this.Contact);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_supplier()
        {
            string act;
            if (this.IsActive)
            {
                act = "True";
            }
            else
            {
                act = "False";
            }
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_SUPPLIER @SupNumber, @phone,@Email, @SupAddress,@IsActive,@Contact";
            c.Parameters.AddWithValue("@SupNumber", this.SupNumber);
            c.Parameters.AddWithValue("@phone", this.Phone);
            c.Parameters.AddWithValue("@Email", this.Email);
            c.Parameters.AddWithValue("@SupAddress", this.SupAddress);
            c.Parameters.AddWithValue("@IsActive", act);
            c.Parameters.AddWithValue("@Contact", this.Contact);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}