using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Qlbs.Class;
using Qlbs.Control;

namespace Qlbs.module_frm
{
    public partial class frm_hoadonnhap : Form
    {
        HoaDonNhapctrl hdCtr = new HoaDonNhapctrl();
        ChiTietHoaDonXuatctrl ctCtr = new ChiTietHoaDonXuatctrl();
        HangHoactrl hhctrl = new HangHoactrl();
        DataTable dtDSCT = new System.Data.DataTable();
        int vitriclick = 0;

        public frm_hoadonnhap()
        {
            InitializeComponent();
        }

        private void LoadcboNhacc()
        {
            NhaCCctrl khctr = new NhaCCctrl();
            cboKh.DataSource = khctr.getData();
            cboKh.DisplayMember = "TenNCC";
            cboKh.ValueMember = "MaNhaCC";
            cboKh.SelectedIndex = 0;
        }
        private void LoadcboNV()
        {
            NhanVienctrl nvctr = new NhanVienctrl();
            cboNvl.DataSource = nvctr.getData();
            cboNvl.DisplayMember = "TenNV";
            cboNvl.ValueMember = "MaNV";
            cboNvl.SelectedIndex = 0;
        }
        private void LoadcboHH()
        {
            HangHoactrl hhctrl = new HangHoactrl();
            cboHangHoa.DataSource = hhctrl.GetData();
            cboHangHoa.DisplayMember = "TenHH";
            cboHangHoa.ValueMember = "MaHH";

        }
        
        private void frm_hoadonnhap_Load(object sender, EventArgs e)
        {
            Dis_Enl(false);
            DataTable dt = new System.Data.DataTable();
            dt = hdCtr.GetData();
            dtgvDSHD.DataSource = dt;
            bingding();
            txtNgayLap.Enabled = false;
        }
        private void bingding()
        {
            txtMahd.DataBindings.Clear();
            txtMahd.DataBindings.Add("Text", dtgvDSHD.DataSource, "MaHD");
            txtNgayLap.DataBindings.Clear();
            txtNgayLap.DataBindings.Add("Text", dtgvDSHD.DataSource, "NgayNhap");
            cboNvl.DataBindings.Clear();
            cboNvl.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenNV");
            cboKh.DataBindings.Clear();
            cboKh.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenNCC");
        }

        private void bingding1()
        {
            txtDongia.DataBindings.Clear();
            txtDongia.DataBindings.Add("Text", dtgDanhshh.DataSource, "DonGia");
            txtSolghd.DataBindings.Clear();
            txtSolghd.DataBindings.Add("Text", dtgDanhshh.DataSource, "SoLuong");
            cboHangHoa.DataBindings.Clear();
            cboHangHoa.DataBindings.Add("Text", dtgDanhshh.DataSource, "HangHoa");
            lblThanhtien.DataBindings.Clear();
            lblThanhtien.DataBindings.Add("Text", dtgDanhshh.DataSource, "ThanhTien");

        }

        private void Dis_Enl(bool e)
        {
            txtMahd.Enabled = e;
            cboNvl.Enabled = e;
            cboKh.Enabled = e;
            txtDongia.Enabled = e;
            btnTaomoihd.Enabled = !e;
            btnXoa.Enabled = !e;
            btnInhd.Enabled = !e;
            btnLuuhd.Enabled = e;
            btnHuy.Enabled = e;
            btnBot.Enabled = e;
            btnThemhd.Enabled = e;
            cboHangHoa.Enabled = e;
            txtSolghd.Enabled = e;
            txtNgayLap.Enabled = e;


        }

        void getDulieu(HoaDonNhap hdnobj)
        {
            hdnobj.Mahd = txtMahd.Text.Trim();
            hdnobj.Ngaylap = txtNgayLap.Text.Trim();
            hdnobj.Nguoilap = cboNvl.Text.Trim();
            hdnobj.Nhacc = cboKh.Text.Trim();
        }

        private void clearData()
        {
            txtMahd.Text = "";
            txtNgayLap.Text = DateTime.Now.Date.ToShortDateString();
            cboNvl.Text = "";
            cboKh.Text = "";
        }
        private void addData(HoaDonNhap hdnObj)
        {
            hdnObj.Mahang = cboHangHoa.SelectedValue.ToString();
            hdnObj.Mahd = txtMahd.Text.Trim();
            hdnObj.Ngaylap = txtNgayLap.Text.Trim();
            hdnObj.Nguoilap = cboNvl.SelectedValue.ToString();
            hdnObj.Nhacc = cboKh.SelectedValue.ToString();
            hdnObj.Soluong = int.Parse(txtSolghd.Text.Trim());
        }

        private bool checktrung(string mahh)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                    return true;
            return false;
        }

        private void capnhatSL(string mahh, int SL)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                {
                    int soluong = int.Parse(dtDSCT.Rows[i][3].ToString()) + SL;
                    dtDSCT.Rows[i][3] = soluong;
                    double dongia = double.Parse(dtDSCT.Rows[i][2].ToString());
                    dtDSCT.Rows[i][4] = (dongia * soluong).ToString();
                    break;
                }
        }

        private bool kiemtraSL(string mahh, int sl)
        {
            DataTable dt = new DataTable();
            dt = hhctrl.GetData("Where MaHH = '" + cboHangHoa.SelectedValue.ToString() + "' and SoLuong>= " + sl);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }


        private void btnTaomoihd_Click(object sender, EventArgs e)
        {
            Dis_Enl(true);
            clearData();
            LoadcboNV();
            LoadcboHH();
            LoadcboNhacc();
            dtDSCT.Rows.Clear();
            dtDSCT.Columns.Add("MaHD");
            dtDSCT.Columns.Add("HangHoa");
            dtDSCT.Columns.Add("DonGia");
            dtDSCT.Columns.Add("SoLuong");
            dtDSCT.Columns.Add("ThanhTien");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdCtr.DelData(txtMahd.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frm_hoadonnhap_Load(sender, e);
        }

        private void btnInhd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hóa đơn của khách hàng" + cboKh.DisplayMember.ToString() + " có tổng tiền là: " + lblThanhtien, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnLuuhd_Click(object sender, EventArgs e)
        {
            HoaDonNhap hdnObj = new HoaDonNhap();
            addData(hdnObj);
            if (hdCtr.AddData(hdnObj))
            {
                if (ctCtr.AddData(dtDSCT) && hhctrl.UpdNhapHang(dtDSCT))
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm chi tiết không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Thêm hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            frm_hoadonnhap_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frm_hoadonnhap_Load(sender, e);
            else
                return;
        }


        private void btnThemhd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMahd.Text))
            {
                if (kiemtraSL(cboHangHoa.SelectedValue.ToString(), int.Parse(txtSolghd.Text.Trim())))
                {
                    if (!checktrung(cboHangHoa.SelectedValue.ToString()))
                    {
                        DataRow dr = dtDSCT.NewRow();
                        dr[0] = txtMahd.Text.Trim();
                        dr[1] = cboHangHoa.SelectedValue.ToString();
                        dr[2] = txtDongia.Text;
                        dr[3] = txtSolghd.Text;
                        dr[4] = (double.Parse(txtDongia.Text) * int.Parse(txtSolghd.Text)).ToString();
                        dtDSCT.Rows.Add(dr);
                    }
                    else
                    {
                        capnhatSL(cboHangHoa.SelectedValue.ToString(), int.Parse(txtSolghd.Text));
                    }
                    dtgvDSHD.DataSource = dtDSCT;
                }
                else
                {
                    MessageBox.Show("Số lượng không dủ", "Lỗi");
                    txtSolghd.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được trống", "Lỗi");
                txtMahd.Focus();
            }
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            if (vitriclick < dtDSCT.Rows.Count)
            {
                dtDSCT.Rows.RemoveAt(vitriclick);
                dtgDanhshh.DataSource = dtDSCT;
            }
        }
        private void cboHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hhctrl.GetData("Where MaHH = '" + cboHangHoa.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                double gia = double.Parse(dt.Rows[0][6].ToString());

                txtDongia.Text = gia.ToString();

                //lblThanhtien.Text = (double.Parse(txtDongia.Text) * int.Parse(txtSolghd.Text)).ToString();
            }
        }

        private void txtSolghd_TextChanged(object sender, EventArgs e)
        {
            lblThanhtien.Text = (double.Parse(txtDongia.Text) * int.Parse(txtSolghd.Text)).ToString();
        }

        private void dtgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitriclick = e.RowIndex;
        }

        private void txtMahd_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctCtr.GetData(txtMahd.Text.Trim());
                dtgDanhshh.DataSource = dt;

            }
            catch
            {
                dtgDanhshh.DataSource = null;
            }
            bingding1();
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu nhập phải là số!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void txtSolghd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu nhập phải là số!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void lbldonvi_TextChanged(object sender, EventArgs e)
        {
            HangHoactrl hhctrl = new HangHoactrl();
            DataTable dt = new DataTable();
            dt = hhctrl.GetData("Where MaHH = '" + cboHangHoa.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                string dv = dt.Rows[0][9].ToString();
                lbldonvi.Text = dv;
            }
        }
    }
}
