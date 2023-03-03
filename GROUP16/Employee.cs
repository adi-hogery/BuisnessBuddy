using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GROUP16
{
    public class Employee
    {
        private int EmployeeNum;
        private string EmployeeName;
        private string Password;
        private string PhoneNumber;
        private string Email;
        private Gender Gender;
        private Role EmployeeRole;
        private DateTime Birthday;
        private string Address;
        private Boolean Activation;



        public Employee(int EmployeeNum, string EmployeeName, string Password, string PhoneNumber, string Email, Gender Gender, Role EmployeeRole, DateTime Birthday, string Address, string Activation, bool is_new)
        {
            this.EmployeeNum = EmployeeNum;
            this.EmployeeName = EmployeeName;
            this.Password = Password;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Gender = Gender;
            this.EmployeeRole = EmployeeRole;
            this.Birthday = Birthday;
            this.Address = Address;
            if (Activation == "false")
            {
                this.Activation = false;
            }
            else
            {
                this.Activation = true;
            }

            if (is_new)
            {
               this.create_Employee();
                Program.Employees.Add(this);

            }
        }
//gets method
        public string get_name()
        {
            return this.EmployeeName;
        }
        public int get_num()
        {
            return this.EmployeeNum;
        }
        public string get_Password()
        {
            return this.Password;
        }
        public string get_PhoneNumber()
        {
            return this.PhoneNumber;
        }
        public string get_Email()
        {
            return this.Email;
        }
        public Gender get_Gender()
        {
            return this.Gender;
        }
        public Role get_EmployeeRole()
        {
            return this.EmployeeRole;
        }
        public DateTime get_Birthday()
        {
            return this.Birthday;
        }
        public string get_Address()
        {
            return this.Address;
        }
        public bool get_Activation()
        {
            return this.Activation;
        }

        //sets methods
        public void set_name(string EmployeeName)
        {
            this.EmployeeName = EmployeeName;
        }
        public void set_num(int EmployeeNum)
        {
             this.EmployeeNum= EmployeeNum;
        }
        public void set_Password(string Password)
        {
            this.Password = Password;
        }
        public void set_PhoneNumber(string PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }
        public void set_Email(string Email)
        {
            this.Email = Email;
        }
        public void set_Gender(Gender Gender)
        {
            this.Gender = Gender;
        }
        public void set_EmployeeRole(Role EmployeeRole)
        {
            this.EmployeeRole = EmployeeRole;
        }
        public void set_Birthday(DateTime Birthday)
        {
            this.Birthday = Birthday;
        }
        public void set_Address(string Address)
        {
            this.Address = Address;
        }
        public void set_Activation(Boolean Activation)
        {
            this.Activation = Activation;
        }



        public void create_Employee()
        {
            string act;
            if (this.Activation)
            {
                act = "True";
            }
            else
            {
                act = "False";
            }

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Employee @EmployeeNum, @EmployeeName, @Password, @PhoneNum, @Email, @Gender, @EmployeeRole, @Birthday, @Address, @Activation";
            c.Parameters.AddWithValue("@EmployeeNum", this.EmployeeNum);
            c.Parameters.AddWithValue("@EmployeeName", this.EmployeeName);
            c.Parameters.AddWithValue("@Password", this.Password);
            c.Parameters.AddWithValue("@PhoneNum", this.PhoneNumber);
            c.Parameters.AddWithValue("@Email", this.Email);
            c.Parameters.AddWithValue("@Gender", this.Gender.ToString());
            c.Parameters.AddWithValue("@EmployeeRole", this.EmployeeRole.ToString());
            c.Parameters.AddWithValue("@Birthday", this.Birthday);
            c.Parameters.AddWithValue("@Address", this.Address);
            c.Parameters.AddWithValue("@Activation", act);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_Employee()
        {
            string act;
            if (this.Activation)
            {
                act = "True";
            }
            else
            {
                act = "False";
            }

            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.SP_Update_Employee  @empNum , @name , @pass , @phone, @email , @gender , @role, @birthday, @address , @active";
            c.Parameters.AddWithValue("@empNum", this.EmployeeNum);
            c.Parameters.AddWithValue("@name", this.EmployeeName);
            c.Parameters.AddWithValue("@pass", this.Password);
            c.Parameters.AddWithValue("@phone", this.PhoneNumber);
            c.Parameters.AddWithValue("@email", this.Email);
            c.Parameters.AddWithValue("@gender", this.Gender.ToString());
            c.Parameters.AddWithValue("@role", this.EmployeeRole.ToString());
            c.Parameters.AddWithValue("@birthday", this.Birthday);
            c.Parameters.AddWithValue("@address", this.Address);
            c.Parameters.AddWithValue("@active", act);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void add_EMPEVENT(Event E)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.SP_add_EMPEVENT  @EventNum , @EmployeeNum";
            c.Parameters.AddWithValue("@EventNum", E.getEventNum());
            c.Parameters.AddWithValue("@EmployeeNum", this.EmployeeNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
