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
    class HoaDonNhapMod
    {

        ConnectSql con = new ConnectSql();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select hd.MaHD, hd.NgayNhap, nv.TenNV, cc.TenNCC from tb_HoaDonNhap hd, tb_NhaCC cc, tb_NhanVien nv where cc.MaNhaCC = hd.MaNhaCC and nv.MaNV = hd.NhanVien";
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

        public bool AddData(HoaDonNhap hdObj)
        {
            cmd.CommandText = "insert into tb_HoaDonNhap (MaHD, MaNhaCC, NgayNhap, NhanVien) values ('" + hdObj.Mahd + "','" + hdObj.Nhacc + "', CONVERT (date,'" + hdObj.Ngaylap + "',103),'" + hdObj.Nguoilap + "')";
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
            cmd.CommandText = "Delete tb_ChiTietHDN Where MaHD = '" + ma + "' Delete tb_HoaDonNhap Where MaHD = '" + ma + "'";
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
