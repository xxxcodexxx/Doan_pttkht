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

namespace Qlbs
{
    public partial class frm_nhanvien : Form
    {
        NhanVienctrl nvc = new NhanVienctrl();
        Nhanvien nvobj = new Nhanvien();
        int flag = 0;
        public frm_nhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = nvc.getData();
            dvdDSNV.DataSource = dtNhanVien;
            bingding();
        }

        void bingding()
        {
            txtManv.DataBindings.Clear();
            txtManv.DataBindings.Add("Text", dvdDSNV.DataSource, "MaNV");
            txtTennv.DataBindings.Clear();
            txtTennv.DataBindings.Add("Text", dvdDSNV.DataSource, "TenNV");
            txtNsnv.DataBindings.Clear();
            txtNsnv.DataBindings.Add("Text", dvdDSNV.DataSource, "NgaySinh");
            txtgt.DataBindings.Clear();
            txtgt.DataBindings.Add("Text", dvdDSNV.DataSource, "Gioitinh");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", dvdDSNV.DataSource, "Sdt");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dvdDSNV.DataSource, "Diachi");
            txtCmnd.DataBindings.Clear();
            txtCmnd.DataBindings.Add("Text", dvdDSNV.DataSource, "CMND");
        }

        void dis_en(bool e)
        {
            txtManv.Enabled = e;
            txtTennv.Enabled = e;
            txtSdt.Enabled = e;
            txtNsnv.Enabled = e;
            txtDiachi.Enabled = e;
            txtCmnd.Enabled = e;
            txtgt.Enabled = e;
            btnadd.Enabled = !e;
            btnEdit.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
        }

        void ganDulieu(Nhanvien nvobj)
        {
            nvobj.Ma = txtManv.Text.Trim();
            nvobj.Ten = txtTennv.Text.Trim();
            nvobj.Cmnd = txtCmnd.Text.Trim();
            nvobj.Sdt = txtSdt.Text.Trim();
            nvobj.Diachi = txtDiachi.Text.Trim();
            nvobj.Ns = txtNsnv.Text.Trim();
            nvobj.Gioitinh = txtgt.Text.Trim();
        }
        private void clearData()
        {
            txtManv.Text = "";
            txtTennv.Text = "";
            txtDiachi.Text = "";
            txtSdt.Text = "";
            txtNsnv.Value = DateTime.Now.Date;
            loadControl();
            txtgt.Text = "";
        }
        void loadControl()
        {
            txtgt.Items.Add("Nam");
            txtgt.Items.Add("Nữ");

            txtNsnv.Text = DateTime.Now.Date.ToShortDateString();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
            clearData();
            loadControl();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xóa dữ liệu?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                if(nvc.deleteData(txtManv.Text.Trim()))
                    MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //xóa dữ liệu

            }
            else
                return;
            frmNhanvien_Load(sender, e);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDulieu(nvobj);
            if(flag == 0)
            {
                if (nvc.addData(nvobj))
                    MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them moi du lieu
                else
                    MessageBox.Show("Thêm Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(nvc.updateData(nvobj))
                    MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //suu du lieu
            }
            frmNhanvien_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanvien_Load(sender, e);
            dis_en(false);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu nhập phải là số!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu nhập phải là số!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
    }
}
