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
    class KhachHangctrl
    {
        KhachHangModel khm = new KhachHangModel();

        public DataTable getData()
        {
            return khm.getData();
        }

        public bool addData(KhachHang khobj)
        {
            return khm.addData(khobj);
        }

        public bool updateData(KhachHang khobj)
        {
            return khm.updateData(khobj);
        }

        public bool deleteData(string mathe)
        {
            return khm.deleteData(mathe);
        }
    }
}
