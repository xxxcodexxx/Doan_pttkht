using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlbs.Class
{
    class HoaDonNhap
    {

        string mahd, nhacc, mahang, ngaylap, nguoilap;
        int soluong;

        public string Mahang
        {
            get { return mahang; }
            set { mahang = value; }
        }

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public string Nhacc
        {
            get { return nhacc; }
            set { nhacc = value; }
        }

        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }

        public string Ngaylap
        {
            get
            {
                return ngaylap;
            }

            set
            {
                ngaylap = value;
            }
        }

        public string Nguoilap
        {
            get
            {
                return nguoilap;
            }

            set
            {
                nguoilap = value;
            }
        }

        public HoaDonNhap() { }

        public HoaDonNhap(string mahd, string ngaylap, string nhacc, string nguoilap, int soluong, string mahang)
        {
            this.mahd = mahd;
            this.soluong = soluong;
            this.nhacc = nhacc;
            this.mahang = mahang;
            this.ngaylap = ngaylap;
            this.nguoilap = nguoilap;
        }
    }
}
