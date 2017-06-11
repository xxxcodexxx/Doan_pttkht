using Qlbs.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlbs.Control
{
    class ChiTietHoaDonNhapctrl
    {
        ChiTietHoaDonNhapMod cthdnMod = new ChiTietHoaDonNhapMod();
        public DataTable GetData(string mahd)
        {
            return cthdnMod.GetData(mahd);
        }
        public bool AddData(DataTable dt)
        {
            return cthdnMod.AddData(dt);
        }
        public bool DelData(string ma)
        {
            return cthdnMod.DelData(ma);
        }
    }
}
