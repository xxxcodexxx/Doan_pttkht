using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qlbs.Model;

namespace Qlbs.Class
{
    class HoaDonXuat
    {

        string mahd, ngaylap, nguoilap, mathe;

        public string KhachHang
        {
            get { return mathe; }
            set { mathe = value; }
        }

        public string NguoiLap
        {
            get { return nguoilap; }
            set { nguoilap = value; }
        }

        public string NgayLap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }

        

        public HoaDonXuat() { }

        public HoaDonXuat(string mahd, string ngaylap, string nguoilap, string mathe)
        {
            this.mahd = mahd;
            this.nguoilap = nguoilap;
            this.ngaylap = ngaylap;
            this.mathe = mathe;
        }
        
    }
}
