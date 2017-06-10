using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Qlbs.Class;

namespace Qlbs.Model
{
    class NhaCungCapMod
    {
        SqlCommand cmd = new SqlCommand();
        ConnectSql conn = new ConnectSql();

        public DataTable getData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from tb_NhaCC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                conn.CloseConn();
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return dt;
        }

        public bool addData(NhaCungCap nccobj)
        {
            cmd.CommandText = "Insert into tb_NhaCC values ('" + nccobj.Ma + "',N'" + nccobj.Ten + "', N'" + nccobj.Diachi + "', '" + nccobj.Sdt + "', '" + nccobj.Fax + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }

        public bool updateData(NhaCungCap nccobj)
        {
            cmd.CommandText = "Update tb_NhaCC set TenNCC = N'" + nccobj.Ten + "', Sdt = '" + nccobj.Sdt + "', Diachi = N'" + nccobj.Diachi + "', Fax = '" + nccobj.Fax + "'Where MaNhaCC = '" + nccobj.Ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }

        public bool deleteData(string ma)
        {
            cmd.CommandText = "delete tb_NhaCC where MaNhaCC = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }


    }
}
