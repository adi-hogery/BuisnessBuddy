using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace GROUP16
{
    public class Graphic
    {
        private int GraphicNum;
        private bool MadeBY;
        private bool IsConfirmed;
        private string filePath;

        public Graphic(int GraphicNum, bool MadeBY, bool IsConfirmed, string filePath, bool is_new)
        {
            this.GraphicNum = GraphicNum;
            this.MadeBY = MadeBY;
            this.IsConfirmed = IsConfirmed;
            this.filePath = filePath;
            if (is_new)
            {
                this.create_graphic();
                Program.Graphics.Add(this);
               
            }
        }
        //gets methods
        public int getGraphicNum()
        {
            return this.GraphicNum;
        }
        public bool getMadeBY()
        {
            return this.MadeBY;
        }
        public bool getIsConfirmed()
        {
            return this.IsConfirmed;
        }

        //sets methods
        public void setGraphicNum(int GraphicNum)
        {
            this.GraphicNum = GraphicNum;
        }
        public void setMadeBY(bool MadeBY)
        {
            this.MadeBY = MadeBY;
        }
        public void setIsConfirmed(bool IsConfirmed)
        {
            this.IsConfirmed = IsConfirmed;
        }

        public void create_graphic()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_GRAPHIC @GraphicNum , @MadeBY ,@IsConfirmed ";
            c.Parameters.AddWithValue("@GraphicNum", this.GraphicNum);
            c.Parameters.AddWithValue("@MadeBY", this.MadeBY);
            c.Parameters.AddWithValue("@IsConfirmed", this.IsConfirmed);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_graphic()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_GRAPHIC @GraphicNum,@MadeBY ,@IsConfirmed";
            c.Parameters.AddWithValue("@GraphicNum", this.GraphicNum);
            c.Parameters.AddWithValue("@MadeBY", this.MadeBY);
            c.Parameters.AddWithValue("@IsConfirmed", this.IsConfirmed);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }



    }

    }
