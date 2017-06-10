using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlbs.Class
{
    class NhaCungCap
    {
        string ma, ten, diachi, sdt, fax;

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

        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
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

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public NhaCungCap()
        {

        }

        public NhaCungCap(string ma, string ten, string sdt, string fax, string diachi)
        {
            this.ma = ma;
            this.ten = ma;
            this.sdt = sdt;
            this.fax = fax;
            this.diachi = diachi;
        }
    }
}
