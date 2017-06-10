using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlbs.Class
{
    class Nhanvien
    {
        string ma, ten, gioitinh, sdt, diachi, cmnd;
        string ns;

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

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
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

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
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

        public Nhanvien()
        {

        }
        public Nhanvien(string ma, string ten, string gt, string dc, string cmnd, string ns)
        {
            this.ma = ma;
            this.ten = ten;
            gioitinh = gt;
            diachi = dc;
            this.cmnd = cmnd;
            this.ns = ns;
        }
    }
}

