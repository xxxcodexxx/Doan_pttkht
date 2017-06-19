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
    class NhanVienModel
    {
        SqlCommand cmd = new SqlCommand();
        ConnectSql conn = new ConnectSql();

        public DataTable getData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from tb_NhanVien where MaNV <> 'ADMIN'";
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

        public bool addData(Nhanvien nvobj)
        {
            cmd.CommandText = "Insert into tb_NhanVien values ('"+ nvobj.Ma +"',N'" + nvobj.Ten+ "',CONVERT(DATE,'"+nvobj.Ns+"',103), N'"+nvobj.Gioitinh+"', '"+nvobj.Sdt+"', N'"+nvobj.Diachi+"', '"+nvobj.Cmnd+"')";
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

        public bool updateData(Nhanvien nvobj)
        {
            cmd.CommandText = "Update tb_NhanVien set TenNV = N'" + nvobj.Ten + "', NgaySinh = CONVERT(DATE,'" + nvobj.Ns + "',103), Gioitinh = N'" + nvobj.Gioitinh + "', Sdt = '" + nvobj.Sdt + "', Diachi = N'" + nvobj.Diachi + "', CMND = '" + nvobj.Cmnd + "'Where MaNV = '"+nvobj.Ma+"'";
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
            cmd.CommandText = "delete tb_Nhanvien where MaNV = '"+ma+"'";
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
