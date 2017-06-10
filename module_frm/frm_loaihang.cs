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
    public partial class frm_loaihang : Form
    {
        public frm_loaihang()
        {
            InitializeComponent();
        }
        
        LoaiHangctrl lh = new LoaiHangctrl();
        LoaiHang lhobj = new LoaiHang();
        int flag = 0;

        private void frm_loaihang_Load(object sender, EventArgs e)
        {
            DataTable dtLoaiHang = new DataTable();
            dtLoaiHang = lh.getData();
            dtgvLh.DataSource = dtLoaiHang;
            bingding();
        }
        void bingding()
        {
            txtMah.DataBindings.Clear();
            txtMah.DataBindings.Add("Text", dtgvLh.DataSource, "Maloai");
            txtTenh.DataBindings.Clear();
            txtTenh.DataBindings.Add("Text", dtgvLh.DataSource, "Tenloai");
        }

        void dis_en(bool e)
        {
            txtMah.Enabled = e;
            txtTenh.Enabled = e;
            btnadd.Enabled = !e;
            btnEdit.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
        }

        void ganDulieu(LoaiHang lhobj)
        {
            lhobj.Ma = txtMah.Text.Trim();
            lhobj.Ten = txtTenh.Text.Trim();
        }
        private void clearData()
        {
            txtMah.Text = "";
            txtTenh.Text = "";
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
                if (lh.deleteData(txtMah.Text.Trim()))
                    MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //xóa dữ liệu

            }
            else
                return;
            frm_loaihang_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDulieu(lhobj);
            if (flag == 0)
            {
                if (lh.addData(lhobj))
                    MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them moi du lieu
                else
                    MessageBox.Show("Thêm Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lh.updateData(lhobj))
                    MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //suu du lieu
            }
            frm_loaihang_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frm_loaihang_Load(sender, e);
            dis_en(false);
        }
    }
}
