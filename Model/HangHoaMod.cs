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
    class HangHoaMod
    {

        ConnectSql con = new ConnectSql();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from tb_HangHoa";
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

        public DataTable GetData(string dieukien)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from tb_HangHoa " + dieukien;
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

        public bool AddData(HangHoa hhObj)
        {
            cmd.CommandText = "Insert into tb_HangHoa values ('" + hhObj.Ma + "', N'" + hhObj.TenHangHoa + "','" + hhObj.Loai + "','"+hhObj.Nhacc+ "'," + hhObj.SoLuong + "," + hhObj.Soluongton + "," + hhObj.DonGia + ",CONVERT(DATE,'" + hhObj.Hsd + "',103),CONVERT(DATE,'" + hhObj.Hsd + "',103),N'" + hhObj.Donvi + "' )";
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

        public bool UpdData(HangHoa hhObj)
        {
            cmd.CommandText = "Update tb_HangHoa set TenHH =  N'" + hhObj.TenHangHoa + "', Soluong = " + hhObj.SoLuong + ", Dongia = " + hhObj.DonGia + ", Loai = '" + hhObj.Loai + "', NhaCC = '" + hhObj.Nhacc + "', Soluongton = " + hhObj.Soluongton + ", NgaySX = CONVERT(DATE,'" + hhObj.Ngaysx + "',103), HSD = CONVERT(DATE,'" + hhObj.Hsd + "',103), Donvi = N'" + hhObj.Donvi + "' Where MaHH = '" + hhObj.Ma + "'";
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
        public bool UpdNhapHang(HangHoa hhObj, int SL)
        {
            cmd.CommandText = "Update tb_HangHoa set  Soluongton = " + hhObj.Soluongton + SL + ",Soluongton = " + hhObj.SoLuong + SL + " Where MaHH = '" + hhObj.Ma + "'";
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


        public bool UpdSL(string mahh, int SL, int SLN)
        {
            cmd.CommandText = "Update tb_HangHoa set  Soluongton = " + SL + ", Soluong = " + SLN +" Where MaHH = '" + mahh + "'";
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
            cmd.CommandText = "Delete tb_HangHoa Where MaHH = '" + ma + "'";
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
