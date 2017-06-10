using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlbs.Class
{
    class ChiTietHoaDonXuat
    {

        string mahd, mahh;
        int soluong, dongia;

        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }

        public string Mahh
        {
            get { return mahh; }
            set { mahh = value; }
        }

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public int Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }



        public ChiTietHoaDonXuat() { }

        public ChiTietHoaDonXuat(string mahd, string mahh, int soluong, int dongia)
        {
            this.mahd = mahd;
            this.mahh = mahh;
            this.soluong = soluong;
            this.dongia = dongia;
        }


    }
}
