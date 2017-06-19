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
    public partial class frm_qlkh : Form
    {
        private int flagLuu = 0;
        KhachHangctrl khc = new KhachHangctrl();
        public frm_qlkh()
        {
            InitializeComponent();
        }

        private void frm_qlkh_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = khc.getData();
            dtgkh.DataSource = dtKhachHang;
            bingDing();
            dis_En(false);
        }

        private void bingDing()
        {
            txtMakh.DataBindings.Clear();
            txtMakh.DataBindings.Add("Text", dtgkh.DataSource, "MaThe");
            txtTenkh.DataBindings.Clear();
            txtTenkh.DataBindings.Add("Text", dtgkh.DataSource, "TenKH");
            txtDiachikh.DataBindings.Clear();
            txtDiachikh.DataBindings.Add("Text", dtgkh.DataSource, "Diachi");
            txtSdtkh.DataBindings.Clear();
            txtSdtkh.DataBindings.Add("Text", dtgkh.DataSource, "Sdt");
            txtGtkh.DataBindings.Clear();
            txtGtkh.DataBindings.Add("Text", dtgkh.DataSource, "Gioitinh");
            txtNskh.DataBindings.Clear();
            txtNskh.DataBindings.Add("Text", dtgkh.DataSource, "Ngaysinh");
        }

        void dis_En(bool e)
        {
            txtMakh.Enabled = e;
            txtTenkh.Enabled = e;
            txtDiachikh.Enabled = e;
            txtSdtkh.Enabled = e;
            txtGtkh.Enabled = e;
            txtNskh.Enabled = e;
            btnadd.Enabled = !e;
            btnEdit.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            

        }

        void getDulieu(KhachHang khobj)
        {
            khobj.Mathe = txtMakh.Text.Trim();
            if (txtGtkh.SelectedIndex == 0)
            {
                khobj.Gt = "Nam";
            }
            else
                khobj.Gt = "Nữ";
            khobj.Tenkh = txtTenkh.Text.Trim();
            khobj.Sdt = txtSdtkh.Text.Trim();
            khobj.Diachi = txtDiachikh.Text.Trim();
            khobj.Ns = txtNskh.Text.Trim();
        }

        void loadGt()
        {
            txtGtkh.Items.Add("Nam");
            txtGtkh.Items.Add("Nữ");
            txtGtkh.SelectedItem = 0;
        }

        private void clearData()
        {
            txtMakh.Text = "";
            txtTenkh.Text = "";
            txtDiachikh.Text = "";
            txtSdtkh.Text = "";
            txtNskh.Value = DateTime.Now.Date;
            loadGt();
            txtGtkh.Text = "";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            
            flagLuu = 0;
            clearData();
            dis_En(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            dis_En(true);
            loadGt();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            frm_qlkh_Load(sender, e);
            dis_En(false);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            dis_En(true);
            loadGt();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            flagLuu = 1;
            dis_En(true);
            loadGt();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xóa  Thông Tin Khách Hàng?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khc.deleteData(txtMakh.Text.Trim()))
                    MessageBox.Show("Xóa Thông Tin Khách Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa Thông Tin Khách Hàng Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //xóa dữ liệu

            }
            else
            {
                return;
            }
            frm_qlkh_Load(sender, e);
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            KhachHang khobj = new KhachHang();
            getDulieu(khobj);
            if (flagLuu == 0)
            {
                if (khc.addData(khobj))
                    MessageBox.Show("Thêm Thông Tin Khách Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //them moi du lieu
                else
                    MessageBox.Show("Thêm Thông Tin Khách Hàng Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (khc.updateData(khobj))
                    MessageBox.Show("Sửa Thông Tin Khách Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa Thông Tin Khách Hàng Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //suu du lieu
            }
            frm_qlkh_Load(sender, e);
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu nhập phải là số!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void txtSdtkh_KeyPress(object sender, KeyPressEventArgs e)
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
            SqlDataAdapter adp = new SqlDataAdapter("Select * from tb_KhachHang where TenKH like N'%" + txtKeysearch.Text + "%'", conn);
            DataSet ds = new DataSet();
            adp.Fill(ds,"tb_KhachHang");
            dtgkh.DataSource = ds.Tables["tb_KhachHang"];
            conn.Close();
        }
        
    }
}
