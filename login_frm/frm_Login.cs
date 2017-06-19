using Qlbs.module_frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlbs.login_frm
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin" && txtpass.Text == "admin")
            {
                this.Hide();
                frm_main frm = new frm_main();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Sai!", "Thông Báo", MessageBoxButtons.OKCancel);
                txtuser.Focus();
            }
        }

        private void btn_dk_Click(object sender, EventArgs e)
        {
            frm_DangKy frm_dk = new frm_DangKy();
            frm_dk.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
