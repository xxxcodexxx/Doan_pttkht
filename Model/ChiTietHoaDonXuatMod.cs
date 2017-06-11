using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qlbs.Class;

namespace Qlbs.Model
{
    class ChiTietHoaDonXuatMod
    {

        ConnectSql con = new ConnectSql();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData(string mahd)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select ct.MaHD, hh.TenHH HangHoa, ct.SoLuong, ct.DonGia, ct.SoLuong*ct.DonGia ThanhTien from tb_ChiTietHDB ct, tb_HangHoa hh where ct.MaHH = hh.MaHH and MaHD = '" + mahd + "'";
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

        public bool AddData(DataTable dt)
        {
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmd.CommandText = "insert into tb_ChiTietHDN (MaHD,MaHH,DonGia,SoLuong) values ('" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "'," + dt.Rows[i][2].ToString() + "," + dt.Rows[i][3].ToString() + ")";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Connection;
                    con.OpenConn();
                    cmd.ExecuteNonQuery();
                }
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

        public bool DelData(string mahd)
        {
            cmd.CommandText = "Delete tb_HoaDonBan Where MaHD = '" + mahd + "'";
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
