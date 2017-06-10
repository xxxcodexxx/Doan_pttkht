using Qlbs.Class;
using Qlbs.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlbs.Control
{
    class ChiTietHoaDonXuatctrl
    {
        ChiTietHoaDonXuatMod cthdxMod = new ChiTietHoaDonXuatMod();
        public DataTable GetData(string mahd)
        {
            return cthdxMod.GetData(mahd);
        }
        public bool AddData(DataTable dt)
        {
            return cthdxMod.AddData(dt);
        }
        public bool DelData(string ma)
        {
            return cthdxMod.DelData(ma);
        }

    }
}
