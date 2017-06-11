using Qlbs.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlbs.Model
{
    class KhachHangModel
    {
        SqlCommand cmd = new SqlCommand();
        ConnectSql conn = new ConnectSql();

        public DataTable getData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from tb_KhachHang";
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

        public bool addData(KhachHang khobj)
        {
            cmd.CommandText = "Insert into tb_KhachHang values ('"+khobj.Mathe+"',N'" + khobj.Tenkh + "', N'" + khobj.Gt + "',CONVERT(DATE,'" + khobj.Ns + "',103),N'" + khobj.Diachi + "', '" + khobj.Sdt + "','"+khobj.Diem+"')";
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

        public bool updateData(KhachHang khobj)
        {
            cmd.CommandText = "Update tb_KhachHang set TenKH = N'" + khobj.Tenkh + "', Diachi = N'" + khobj.Diachi + "', Sdt = '" + khobj.Sdt + "', Gioitinh = N'"+khobj.Gt+ "', NgaySinh = CONVERT(DATE,'" + khobj.Ns + "',103), Diem = '"+khobj.Diem+"' Where MaThe = '" + khobj.Mathe + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return true;
        }

        //public bool searchData(string key)
        //{
        //    string sqlSearch = "Select * from tb_KhachHang Where TenKH like N'%"+key+"%'";
        //    SqlCommand cmd = new SqlCommand(sqlSearch, Con);
        //    cmd.ExecuteNonQuery();
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(dr);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = conn.Connection;
        //    try
        //    {
        //        conn.OpenConn();
        //        cmd.ExecuteNonQuery();
        //        conn.CloseConn();
        //    }
        //    catch (Exception ex)
        //    {
        //        string mess = ex.Message;
        //        cmd.Dispose();
        //        conn.CloseConn();
        //    }
        //    return true;
        //}

        public bool deleteData(string mathe)
        {
            cmd.CommandText = "delete tb_KhachHang where MaThe = '" + mathe + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return true;
        }
    }
}
