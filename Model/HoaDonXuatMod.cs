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
    class HoaDonXuatMod
    {
        ConnectSql con = new ConnectSql();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select hd.MaHD, hd.NgayLap, nv.TenNV, kh.TenKH from tb_HoaDonBan hd, tb_KhachHang kh, tb_NhanVien nv where kh.MaThe = hd.MaThe and nv.MaNV = hd.NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public bool AddData(HoaDonXuat hdObj)
        {
            cmd.CommandText = "insert into tb_HoaDonBan (MaHD, MaThe, NgayLap, NhanVien) values ('" + hdObj.Mahd + "','" + hdObj.KhachHang + "', CONVERT (date,'" + hdObj.NgayLap + "',103),'" + hdObj.NguoiLap + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete tb_ChiTietHDB Where MaHD = '" + ma + "' Delete tb_HoaDonBan Where MaHD = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
