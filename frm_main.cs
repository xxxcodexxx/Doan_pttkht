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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btnQuanlynv_Click(object sender, EventArgs e)
        {
            frm_nhanvien form_nv = new frm_nhanvien();
            form_nv.Show();
        }

        private void btnQuanlyhh_Click(object sender, EventArgs e)
        {
            frm_hanghoa form_hh = new frm_hanghoa();
            form_hh.Show();
        }

        private void btnNhacc_Click(object sender, EventArgs e)
        {
            frm_nhacc form_ncc = new frm_nhacc();
            form_ncc.Show();
        }

        private void btnQuanlykh_Click(object sender, EventArgs e)
        {
            frm_qlkh form_kh = new frm_qlkh();
            form_kh.Show();
        }

        private void btnQuanlyhd_Click(object sender, EventArgs e)
        {
            frm_hoadon form_hd = new frm_hoadon();
            form_hd.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dr =  MessageBox.Show("Bạn muốn thoát chương trình? ", "Thông Báo", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
                Application.Exit();

        }
        private void btnQllh_Click(object sender, EventArgs e)
        {
            frm_loaihang form_loaih = new frm_loaihang();
            form_loaih.Show();
        }
        
    }
}
