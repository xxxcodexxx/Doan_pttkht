using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Qlbs.Control;
using Qlbs.Class;

namespace Qlbs.module_frm
{
    public partial class frm_nhacc : Form
    {
        NhaCCctrl ncc = new NhaCCctrl();
        NhaCungCap nccobj = new NhaCungCap();
        int flag = 0;
        public frm_nhacc()
        {
            InitializeComponent();
        }

        private void frm_nhacc_Load(object sender, EventArgs e)
        {

            DataTable dtNhanCC = new DataTable();
            dtNhanCC = ncc.getData();
            dtgvNhacc.DataSource = dtNhanCC;
            bingding();
        }

        void bingding()
        {
            txtManhacc.DataBindings.Clear();
            txtManhacc.DataBindings.Add("Text", dtgvNhacc.DataSource, "MaNhaCC");
            txtTenNhacc.DataBindings.Clear();
            txtTenNhacc.DataBindings.Add("Text", dtgvNhacc.DataSource, "TenNCC");
            txtDiachiNhacc.DataBindings.Clear();
            txtDiachiNhacc.DataBindings.Add("Text", dtgvNhacc.DataSource, "Diachi");
            txtSdtNcc.DataBindings.Clear();
            txtSdtNcc.DataBindings.Add("Text", dtgvNhacc.DataSource, "Sdt");
            txtFax.DataBindings.Clear();
            txtFax.DataBindings.Add("Text", dtgvNhacc.DataSource, "Fax");
        }

        void dis_en(bool e)
        {
            txtManhacc.Enabled = e;
            txtTenNhacc.Enabled = e;
            txtSdtNcc.Enabled = e;
            txtFax.Enabled = e;
            txtDiachiNhacc.Enabled = e;
            btnadd.Enabled = !e;
            btnEdit.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
        }

        void ganDulieu(NhaCungCap nccobj)
        {
            nccobj.Ma = txtManhacc.Text.Trim();
            nccobj.Ten = txtTenNhacc.Text.Trim();
            nccobj.Sdt = txtSdtNcc.Text.Trim();
            nccobj.Diachi = txtDiachiNhacc.Text.Trim();
            nccobj.Fax = txtFax.Text.Trim();
        }
        private void clearData()
        {
            txtManhacc.Text = "";
            txtTenNhacc.Text = "";
            txtSdtNcc.Text = "";
            txtDiachiNhacc.Text = "";
            txtFax.Text = "";
        }
        private void txtNsnv_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
            clearData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn muốn xóa dữ liệu?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (ncc.deleteData(txtManhacc.Text.Trim()))
                    MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //xóa dữ liệu

            }
            else
                return;
            frm_nhacc_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDulieu(nccobj);
            if (flag == 0)
            {
                if (ncc.addData(nccobj))
                    MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them moi du lieu
                else
                    MessageBox.Show("Thêm Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ncc.updateData(nccobj))
                    MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //suu du lieu
            }
            frm_nhacc_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frm_nhacc_Load(sender, e);
            dis_en(false);
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu nhập phải là số!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void txtSdtNcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu nhập phải là số!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
    }
}
