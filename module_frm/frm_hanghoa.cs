using Qlbs.Class;
using Qlbs.Control;
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
    public partial class frm_hanghoa : Form
    {
        HangHoactrl hhCtr = new HangHoactrl();
        private int flagLuu = 0;
        public frm_hanghoa()
        {
            InitializeComponent();
        }

        private void frm_hanghoa_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = hhCtr.GetData();
            dtgvDS.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }

        private void binhding()
        {
            txtMahh.DataBindings.Clear();
            txtMahh.DataBindings.Add("Text", dtgvDS.DataSource, "MaHH");
            txtTenhh.DataBindings.Clear();
            txtTenhh.DataBindings.Add("Text", dtgvDS.DataSource, "TenHH");
            txtLoaih.DataBindings.Clear();
            txtLoaih.DataBindings.Add("Text", dtgvDS.DataSource, "Loai");
            txtSlton.DataBindings.Clear();
            txtSlton.DataBindings.Add("Text", dtgvDS.DataSource, "Soluongton");
            txtDg.DataBindings.Clear();
            txtDg.DataBindings.Add("Text", dtgvDS.DataSource, "Dongia");
            txtSlco.DataBindings.Clear();
            txtSlco.DataBindings.Add("Text", dtgvDS.DataSource, "Soluong");
            txtNgsx.DataBindings.Clear();
            txtNgsx.DataBindings.Add("Text", dtgvDS.DataSource, "NgaySX");
            txtHansd.DataBindings.Clear();
            txtHansd.DataBindings.Add("Text", dtgvDS.DataSource, "HSD");
            txtDonvi.DataBindings.Clear();
            txtDonvi.DataBindings.Add("Text", dtgvDS.DataSource, "Donvi");
        }

        private void clearData()
        {
            txtMahh.Text = "";
            txtTenhh.Text = "";
            txtLoaih.Text = "";
            txtSlco.Text = "";
            txtSlton.Text = "";
            txtDg.Text = "";
            txtDonvi.Text = "";
            txtNgsx.Value = DateTime.Now.Date;
            txtHansd.Value = DateTime.Now.Date;;
        }

        private void addData(HangHoa hh)
        {
            hh.Ma = txtMahh.Text.Trim();
            hh.TenHangHoa = txtTenhh.Text.Trim();
            hh.Loai = txtLoaih.Text.Trim();
            hh.Nhacc = txtNhacc.Text.Trim();
            //hh.Soluongton = int.Parse(txtSlton.Text.Trim());
            hh.DonGia = int.Parse(txtDg.Text.Trim());
            hh.SoLuong = int.Parse(txtSlco.Text.Trim());
            hh.Donvi = txtDonvi.Text.Trim();
            hh.Ngaysx = txtNgsx.Text.Trim();
            hh.Hsd = txtHansd.Text.Trim();
        }

        private void DisEnl(bool e)
        {
            btnadd.Enabled = !e;
            btnXoa.Enabled = !e;
            btnEdit.Enabled = !e;
            btnLuu.Enabled = e;
            txtLoaih.Enabled = e;
            txtDonvi.Enabled = e;
            btnHuy.Enabled = e;
            txtMahh.Enabled = e;
            txtTenhh.Enabled = e;
            txtDg.Enabled = e;
            txtNhacc.Enabled = e;
            txtSlco.Enabled = e;
            txtSlton.Enabled = false;
            txtHansd.Enabled = e;
            txtNgsx.Enabled = e;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa mặt hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hhCtr.DelData(txtMahh.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frm_hanghoa_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HangHoa hhObj = new HangHoa();
            addData(hhObj);
            if (flagLuu == 0)
            {
                if (hhCtr.AddData(hhObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (flagLuu == 1)
            {
                if (hhCtr.UpdData(hhObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (hhCtr.UpdData(hhObj))
                    MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Nhập hàng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frm_hanghoa_Load(sender, e);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frm_hanghoa_Load(sender, e);
            else
                return;
        }
    }
}
