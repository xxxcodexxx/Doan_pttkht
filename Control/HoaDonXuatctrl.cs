using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Qlbs.Model;
using Qlbs.Class;

namespace Qlbs.Control
{
    class HoaDonXuatctrl
    {
        HoaDonXuatMod hdxMod = new HoaDonXuatMod();
        public DataTable GetData()
        {
            return hdxMod.GetData();
        }
        public bool AddData(HoaDonXuat hdObj)
        {
            return hdxMod.AddData(hdObj);
        }
        public bool DelData(string ma)
        {
            return hdxMod.DelData(ma);
        }

    }
}
