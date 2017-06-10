using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlbs.Class
{
    class KhachHang
    {
        
        string tenkh, diachi, sdt, gt, ns, mathe;
        int diem;

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Gt
        {
            get
            {
                return gt;
            }

            set
            {
                gt = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string Tenkh
        {
            get
            {
                return tenkh;
            }

            set
            {
                tenkh = value;
            }
        }

        public string Mathe
        {
            get
            {
                return mathe;
            }

            set
            {
                mathe = value;
            }
        }

        public string Ns
        {
            get
            {
                return ns;
            }

            set
            {
                ns = value;
            }
        }

        public int Diem
        {
            get
            {
                return diem;
            }

            set
            {
                diem = value;
            }
        }

        public KhachHang()
        {
        }
        public KhachHang(string mathe,string ten, string dc, string sdt, string gt, string ns, int diem)
        {
            this.mathe = mathe;
            ten = tenkh;
            dc = diachi;
            this.sdt = sdt;
            this.gt = gt;
            this.ns = ns;
            this.diem = diem;
        }
    }
}
