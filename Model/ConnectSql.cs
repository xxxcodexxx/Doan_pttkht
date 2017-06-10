using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Qlbs.Model
{
    class ConnectSql
    {
        private SqlConnection Conn;
        private SqlCommand cmd;
        private string error;
        private string Strcon = null;

        public SqlConnection Connection
        {
            get
            {
                return Conn;
            }
        }

        public SqlCommand Cmd
        {
            get
            {
                return cmd;
            }

            set
            {
                cmd = value;
            }
        }
        
        public string Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }


        public ConnectSql()
        {
            Strcon = @"Data Source=XCODE;Initial Catalog=QLST;User ID = XCODE279; Password = 123;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Conn = new SqlConnection(Strcon);
        }

        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }

        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }

        //public DataTable getThongtin()
        //{
        //    DataTable dt = new DataTable();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select * from ThongTin";
        //    cmd.Connection = Conn;

        //    try
        //    {
        //        OpenConn();
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        sda.Fill(dt);
        //        CloseConn();
        //    }
        //    catch(Exception ex)
        //    {
        //        error = ex.Message;
        //    }

        //    return dt;
        //}


    }
}
