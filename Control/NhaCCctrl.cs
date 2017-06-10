using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Qlbs.Model;
using Qlbs.Class;
using System.Threading.Tasks;

namespace Qlbs.Control
{
    class NhaCCctrl
    {
        NhaCungCapMod ncc = new NhaCungCapMod();

        public DataTable getData()
        {
            return ncc.getData();
        }

        public bool addData(NhaCungCap nccobj)
        {
            return ncc.addData(nccobj);
        }

        public bool updateData(NhaCungCap nccobj)
        {
            return ncc.updateData(nccobj);
        }

        public bool deleteData(string ma)
        {
            return ncc.deleteData(ma);
        }

    }
}
