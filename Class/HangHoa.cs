using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlbs.Class
{
    class HangHoa
    {

        string ma, ten, loai, nhacc, ngaysx, hsd, donvi;
        int dongia, soluong, soluongton;

        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public string TenHangHoa
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Loai
        {
            get
            {
                return loai;
            }

            set
            {
                loai = value;
            }
        }

        public string Nhacc
        {
            get
            {
                return nhacc;
            }

            set
            {
                nhacc = value;
            }
        }

        public string Ngaysx
        {
            get
            {
                return ngaysx;
            }

            set
            {
                ngaysx = value;
            }
        }

        public string Hsd
        {
            get
            {
                return hsd;
            }

            set
            {
                hsd = value;
            }
        }

        public int Soluongton
        {
            get
            {
                return soluongton;
            }

            set
            {
                soluongton = value;
            }
        }

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string Donvi
        {
            get
            {
                return donvi;
            }

            set
            {
                donvi = value;
            }
        }

        public HangHoa() { }
        public HangHoa(string ma, string ten, string loai, string nhacc, string ngaysx, string hsd, string donvi, int dongia, int soluong)
        {
            this.ma = ma;
            this.ten = ten;
            this.loai = loai;
            this.nhacc = nhacc;
            this.ngaysx = ngaysx;
            this.hsd = hsd;
            this.Donvi = donvi;
            this.dongia = dongia;
            this.soluong = soluong;
        }
    }
}
