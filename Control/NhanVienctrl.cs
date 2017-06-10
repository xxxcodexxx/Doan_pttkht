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
    class NhanVienctrl
    {
        NhanVienModel nvm = new NhanVienModel();

        public DataTable getData()
        {
            return nvm.getData();
        }

        public bool addData(Nhanvien nv)
        {
            return nvm.addData(nv);
        }

        public bool updateData(Nhanvien nv)
        {
            return nvm.updateData(nv);
        }

        public bool deleteData(string ma)
        {
            return nvm.deleteData(ma);
        }

    }
}
