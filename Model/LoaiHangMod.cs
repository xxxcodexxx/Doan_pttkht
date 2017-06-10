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
    class LoaiHangMod
    {
        SqlCommand cmd = new SqlCommand();
        ConnectSql conn = new ConnectSql();

        public DataTable getData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from tb_Loai";
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

        public bool addData(LoaiHang lhobj)
        {
            cmd.CommandText = "Insert into tb_Loai values ('" + lhobj.Ma + "',N'" + lhobj.Ten + "')";
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

        public bool updateData(LoaiHang lhobj)
        {
            cmd.CommandText = "Update tb_loai set TenLoai = N'" + lhobj.Ten + "'Where Maloai = '" + lhobj.Ma + "'";
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
            cmd.CommandText = "delete tb_Loai where Maloai = '" + ma + "'";
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
