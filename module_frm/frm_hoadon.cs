using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlbs.module_frm
{
    public partial class frm_hoadon : Form
    {
        public frm_hoadon()
        {
            InitializeComponent();
        }

        private void btnHoadn_Click(object sender, EventArgs e)
        {
            frm_hoadonnhap form_hdnhap = new frm_hoadonnhap();
            form_hdnhap.Show();
        }

        private void btnHoadx_Click(object sender, EventArgs e)
        {
            frm_hoadonban form_hdxuat = new frm_hoadonban();
            form_hdxuat.Show();
        }
    }
}
