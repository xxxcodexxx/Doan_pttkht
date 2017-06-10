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
    class LoaiHangctrl
    {

        LoaiHangMod lhm = new LoaiHangMod();

        public DataTable getData()
        {
            return lhm.getData();
        }

        public bool addData(LoaiHang lh)
        {
            return lhm.addData(lh);
        }

        public bool updateData(LoaiHang lh)
        {
            return lhm.updateData(lh);
        }

        public bool deleteData(string ma)
        {
            return lhm.deleteData(ma);
        }
    }
}
