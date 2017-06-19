using Qlbs.Class;
using Qlbs.Control;
using Qlbs.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        DataTable dtDSCT = new System.Data.DataTable();
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

        private void load_ncc()
        {
            NhaCCctrl khctr = new NhaCCctrl();
            txtNhacc.DataSource = khctr.getData();
            txtNhacc.DisplayMember = "TenNCC";
            txtNhacc.ValueMember = "MaNhaCC";
            txtNhacc.SelectedIndex = 0;
        }

        private void load_loaihang()
        {
            LoaiHangctrl khctr = new LoaiHangctrl();
            txtLoaih.DataSource = khctr.getData();
            txtLoaih.DisplayMember = "Tenloai";
            txtLoaih.ValueMember = "Maloai";
            txtLoaih.SelectedIndex = 0;
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
            txtNhacc.DataBindings.Clear();
            txtNhacc.DataBindings.Add("Text", dtgvDS.DataSource, "NhaCC");
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
            txtHansd.Value = DateTime.Now.Date; ;
        }

        private void addData(HangHoa hh)
        {
            hh.Ma = txtMahh.Text.Trim();
            hh.TenHangHoa = txtTenhh.Text.Trim();
            hh.Loai = txtLoaih.SelectedValue.ToString();
            hh.Nhacc = txtNhacc.SelectedValue.ToString();
            hh.DonGia = int.Parse(txtDg.Text.Trim());
            hh.Donvi = txtDonvi.Text.Trim();
            hh.Hsd = txtNgsx.Text.Trim();
            hh.Hsd = txtHansd.Text.Trim();
        }
        private void addDataSl(HangHoa hh)
        {
            hh.SoLuong += int.Parse(txtSlco.Text.Trim());
            hh.Soluongton = hh.Soluongton + int.Parse(txtSlco.Text.Trim());
        }
        private void editData(HangHoa hh)
        {
            hh.Ma = txtMahh.Text.Trim();
            hh.TenHangHoa = txtTenhh.Text.Trim();
            hh.Loai = txtLoaih.SelectedValue.ToString();
            hh.Nhacc = txtNhacc.SelectedValue.ToString();
            hh.Soluongton = int.Parse(txtSlton.Text.Trim());
            hh.DonGia = int.Parse(txtDg.Text.Trim());
            hh.SoLuong = int.Parse(txtSlco.Text.Trim());
            hh.Donvi = txtDonvi.Text.Trim();
            hh.Hsd = txtNgsx.Text.Trim();
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
            btnNhapHang.Enabled = !e;
            txtMahh.Enabled = e;
            txtTenhh.Enabled = e;
            txtDg.Enabled = e;
            txtNhacc.Enabled = e;
            txtSlco.Enabled = false;
            txtSlton.Enabled = false;
            txtHansd.Enabled = e;
            txtNgsx.Enabled = e;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            load_loaihang();
            load_ncc();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            load_loaihang();
            load_ncc();
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

            HangHoaMod hhMod = new HangHoaMod();
            DataTable dthh = new DataTable();
            dthh = hhMod.GetData();
            DataTable dt = new DataTable();
            dt.Rows.Clear();
            dt.Columns.Add("MaHH");
            //for (int i = 0; i <= dt.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dthh.Rows.Count; j++)
            //    {
            //        if (dt.Rows[i][0].ToString() != dthh.Rows[j][0].ToString())
            //        {
                        if (flagLuu == 0)
                        {
                            addData(hhObj);
                            if (hhCtr.AddData(hhObj))
                                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (flagLuu == 1)
                        {
                            editData(hhObj);
                            if (hhCtr.UpdData(hhObj))
                                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            addDataSl(hhObj);
                            if (hhCtr.UpdData(hhObj) && hhCtr.UpdNhapHang(dtDSCT))
                                MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Nhập hàng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        frm_hanghoa_Load(sender, e);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Mã đã tồn tại", "Thông Báo", MessageBoxButtons.OKCancel);
                    //    txtMahh.Focus();
                   //}
            //    }

            //}


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frm_hanghoa_Load(sender, e);
            else
                return;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frm_hoadonnhap frm_nhap = new frm_hoadonnhap();
            frm_nhap.Show();
        }

        private void txtSlco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu nhập phải là số!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void txtDg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu nhập phải là số!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = XCODE; Initial Catalog = QLST; User ID = XCODE279; Password = 123; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("Select * from tb_HangHoa where TenHH like N'%" + txtKeysearch.Text + "%'", conn);
            DataSet ds = new DataSet();
            adp.Fill(ds, "tb_HangHoa");
            dtgvDS.DataSource = ds.Tables["tb_HangHoa"];
            conn.Close();
        }
    }
}
