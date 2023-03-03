using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GROUP16
{
    static class Program
    {
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Order> Orders;
        public static System.Collections.Generic.List<Customer> Customers;
        public static System.Collections.Generic.List<StickerPaper> StickerPapers;
        public static System.Collections.Generic.List<InventoryOrder> InventoryOrders;
        public static System.Collections.Generic.List<Supplier> Suppliers;
        public static System.Collections.Generic.List<Invoice> Invoices;
        public static System.Collections.Generic.List<Graphic> Graphics;
        public static System.Collections.Generic.List<Event> Events;
        public static System.Collections.Generic.List<Colors> Colors;


        public static void Init_lists()
        {
            init_Invoices();
            init_GraphicDesigns();
            init_Employees();
            init_Customers();
            init_StickerPapers();
            init_Suppliers();
            init_Events();
            init_Colors();
            init_InventoryOrders();
            init_Orders();
        }


        public static int seekStickerNum(string s)
        {
            foreach (StickerPaper SP in StickerPapers)
            {
                if (SP.getPaperType().ToString() == s)
                    return SP.getProductNumber();
            }
            return 0;
        }
        public static Supplier seekSupplier(int num)
        {
            foreach (Supplier SP in Suppliers)
            {
                if (SP.getSupNumber() == num)
                    return SP;
            }
            return null;
        }
        public static StickerPaper seekStickerPaper(int num)
        {
            foreach (StickerPaper SP in StickerPapers)
            {
                if (SP.getProductNumber() == num)
                    return SP;
            }
            return null;
        }
        public static Employee seekEmployee(int num)
        {
            foreach (Employee e in Employees)
            {
                if (e.get_num() == num)
                    return e;
            }
            return null;
        }
        public static Graphic seekGraphic(int num)
        {
            foreach (Graphic g in Graphics)
            {
                if (g.getGraphicNum() == num)
                    return g;
            }
            return null;
        }

        public static Customer seekCustomer(int num)
        {
            foreach (Customer c in Customers)
            {
                if (c.get_custNumber() == num)
                    return c;
            }
            return null;
        }

        public static Order seekOrder(int num)
        {
            foreach (Order o in Orders)
            {
                if (o.get_OrderNumber() == num)
                    return o;
            }
            return null;
        }
        public static Event seekEvent(int num)
        {
            foreach (Event E in Events)
            {
                if (E.getEventNum() == num)
                    return E;
            }
            return null;
        }

        public static int getPermission(Employee emp)
        {
            if (emp.get_EmployeeRole().ToString().Equals("CEO"))
            {
                return (1);
            }
            if (emp.get_EmployeeRole().ToString().Equals("PM"))
            {
                return (2);
            }
            if (emp.get_EmployeeRole().ToString().Equals("Driver"))
            {
                return (3);
            }
            return (4);
        }

        

        public static void init_StickerPapers()
        {
            Program.StickerPapers = new List<StickerPaper>();
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_STICKERPAPERS";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            while (rdr.Read())
            {
                PaperType p;
                if (rdr.GetValue(1).ToString() == "White PVC")
                {
                    p = (PaperType)Enum.Parse(typeof(PaperType), "WPVC");
                }
                else
                {
                    if (rdr.GetValue(1).ToString() == "Black PVC")
                    {
                        p = (PaperType)Enum.Parse(typeof(PaperType), "BPVC");
                    }
                    else
                    {
                        p = (PaperType)Enum.Parse(typeof(PaperType), rdr.GetValue(1).ToString());
                    }
                }
                StickerPaper s = new StickerPaper(int.Parse(rdr.GetValue(0).ToString()), p, double.Parse(rdr.GetValue(2).ToString()), double.Parse(rdr.GetValue(3).ToString()), false);
                Program.StickerPapers.Add(s);

            }

        }
        public static void init_GraphicDesigns()
        {
            Program.Graphics = new List<Graphic>();
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_GRAPHICS";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            while (rdr.Read())
            {
                bool b;
                if (rdr.GetValue(1).ToString() == "TRUE")
                {
                    b = true;
                }
                else
                {
                    b = false;
                }
                bool bo;
                if (rdr.GetValue(2).ToString() == "TRUE")
                {
                    bo = true;
                }
                else
                {
                    bo = false;
                }
                Graphic g = new Graphic(int.Parse(rdr.GetValue(0).ToString()), b, bo,"null", false);
                Program.Graphics.Add(g);

            }
        }

        public static void init_Invoices()
        {
            Program.Invoices = new List<Invoice>();
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_INVOICES";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            while (rdr.Read())
            {
                bool b;
                if (rdr.GetValue(3).ToString() == "TRUE")
                {
                    b = true;
                }
                else
                {
                    b = false;
                }
                Invoice i = new Invoice(int.Parse(rdr.GetValue(0).ToString()), double.Parse(rdr.GetValue(1).ToString()), DateTime.Parse(rdr.GetValue(2).ToString()), b, rdr.GetValue(4).ToString(), int.Parse(rdr.GetValue(5).ToString()), false);
                Program.Invoices.Add(i);

            }
        }

        public static double calcPrice(double length, double width, int amount, double disc)
        {
            int para;
            double size = length * width;
            if (size > 100)
            {
                para = 3;
            }
            else
            {
                if (size < 100 && size > 50)
                {
                    para = 2;
                }
                else
                {
                    para = 1;
                }
            }
            double a = double.Parse(amount.ToString());
            double price = (a / 10) * para * (1 - (disc / 100));
            return (price);
        }


        public static void init_Orders()
        {
            Program.Orders = new List<Order>();
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_ORDERS";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            while (rdr.Read())
            {

                Status S;
                if (rdr.GetValue(1).ToString() == "New Order")
                {
                    S = (Status)Enum.Parse(typeof(Status), "NO");
                }
                else
                {
                    S = (Status)Enum.Parse(typeof(Status), rdr.GetValue(1).ToString());
                }
                DateTime D = new DateTime();
                if (rdr.GetValue(6).ToString().Length != 0)
                {
                    D = DateTime.Parse(rdr.GetValue(6).ToString());
                }
                Invoice inv = seekInvoice(int.Parse(rdr.GetValue(14).ToString()));
                Graphic gra = seekGraphic(int.Parse(rdr.GetValue(13).ToString()));
                Customer cus = seekCustomer(int.Parse(rdr.GetValue(15).ToString()));
                Order O = new Order(int.Parse(rdr.GetValue(0).ToString()), S, DateTime.Parse(rdr.GetValue(2).ToString()), int.Parse(rdr.GetValue(3).ToString()), int.Parse(rdr.GetValue(4).ToString()), rdr.GetValue(5).ToString(), D, double.Parse(rdr.GetValue(7).ToString()), double.Parse(rdr.GetValue(8).ToString()), double.Parse(rdr.GetValue(9).ToString()), double.Parse(rdr.GetValue(10).ToString()), int.Parse(rdr.GetValue(11).ToString()), int.Parse(rdr.GetValue(12).ToString()), gra , inv , cus, false);
                Orders.Add(O);

            }
        }


        public static Invoice seekInvoice(int num)
        {
            foreach (Invoice i in Invoices)
            {
                if (i.get_num() == num)
                    return i;
            }
            return null;
        }

        public static void init_Employees()
        {
            Program.Employees = new List<Employee>();
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            while (rdr.Read())
            {

                Gender G = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(5).ToString());
                Role R;
                if (rdr.GetValue(6).ToString() == "Production Manager")
                {
                    R = (Role)Enum.Parse(typeof(Role), "PM");
                }
                else
                {
                    if (rdr.GetValue(6).ToString() == "Graphic Designer")
                    {
                        R = (Role)Enum.Parse(typeof(Role), "GD");
                    }
                    else
                    {
                        R = (Role)Enum.Parse(typeof(Role), rdr.GetValue(6).ToString());
                    }
                }
                Employee E = new Employee(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), G, R, DateTime.Parse(rdr.GetValue(7).ToString()), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false);
                Employees.Add(E);

            }
        }

        public static void init_Customers()
        {
            Program.Customers = new List<Customer>();
            SqlCommand c = new SqlCommand();
            c.CommandText = " dbo.Get_all_CUSTOMERS";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            while (rdr.Read())
            {
                Customer C = new Customer(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), false);
                Customers.Add(C);
            }
        }

        public static void init_InventoryOrders()
        {
            Program.InventoryOrders = new List<InventoryOrder>();
            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.Get_all_INVENTORYORDERS";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            
            while (rdr.Read())
            {
                Employee e = seekEmployee(int.Parse(rdr.GetValue(5).ToString()));
                Supplier sup = seekSupplier(int.Parse(rdr.GetValue(6).ToString()));
                InventoryOrder IV = new InventoryOrder(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), bool.Parse(rdr.GetValue(2).ToString()), double.Parse(rdr.GetValue(3).ToString()), DateTime.Parse(rdr.GetValue(4).ToString()), e, sup, false);
                InventoryOrders.Add(IV);
            }
        }

        public static void init_Suppliers()
        {
            Program.Suppliers = new List<Supplier>();
            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.Get_all_SUPPLIERS";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            while (rdr.Read())
            {
                Supplier S = new Supplier(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(),false);
                Suppliers.Add(S);
            }
        }

        public static void init_Events()
        {
            Program.Events = new List<Event>();
            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.Get_all_EVENTS";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
           
            while (rdr.Read())
            {
                EventCategory EC = new EventCategory();
                if (rdr.GetValue(3).ToString() == "Business Meeting")
                {
                   EC= (EventCategory)Enum.Parse(typeof(EventCategory), "BM");
                }
                if (rdr.GetValue(3).ToString() == "Private Meeting")
                {
                    EC = (EventCategory)Enum.Parse(typeof(EventCategory), "PM");
                }
                if (rdr.GetValue(3).ToString() == "Social Events")
                {
                    EC = (EventCategory)Enum.Parse(typeof(EventCategory), "SE");
                }

                Event E = new Event(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(2).ToString(), EC, false);
                Events.Add(E);
            }
        }

        public static void init_Colors()
        {
            Program.Colors = new List<Colors>();
            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.Get_all_Colors";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            while (rdr.Read())
            {
                ColorType CT = (ColorType)Enum.Parse(typeof(ColorType), rdr.GetValue(0).ToString());
                Colors C = new Colors(CT, false);
                Colors.Add(C);
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Init_lists();
            Application.Run(new homePage(1252));
            //Application.Run(new welcomeScreen());
            
        }
    }

}