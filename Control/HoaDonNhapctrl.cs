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
    class HoaDonNhapctrl
    {
        HoaDonNhapMod hdnMod = new HoaDonNhapMod();
        public DataTable GetData()
        {
            return hdnMod.GetData();
        }
        public bool AddData(HoaDonNhap hdnObj)
        {
            return hdnMod.AddData(hdnObj);
        }
        public bool DelData(string ma)
        {
            return hdnMod.DelData(ma);
        }
    }
}
