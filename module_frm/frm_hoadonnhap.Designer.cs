namespace Qlbs.module_frm
{
    partial class frm_hoadonnhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_hoadonnhap));
            this.btnInhd = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgDanhshh = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuuhd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBot = new System.Windows.Forms.Button();
            this.btnThemhd = new System.Windows.Forms.Button();
            this.lblThanhtien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbldonvi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboHangHoa = new System.Windows.Forms.ComboBox();
            this.txtSolghd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTaomoihd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvDSHD = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cboNvl = new System.Windows.Forms.ComboBox();
            this.cboKh = new System.Windows.Forms.ComboBox();
            this.cboNhacc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhshh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInhd
            // 
            this.btnInhd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInhd.AutoSize = true;
            this.btnInhd.Enabled = false;
            this.btnInhd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhd.Image = ((System.Drawing.Image)(resources.GetObject("btnInhd.Image")));
            this.btnInhd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInhd.Location = new System.Drawing.Point(280, 171);
            this.btnInhd.Name = "btnInhd";
            this.btnInhd.Size = new System.Drawing.Size(78, 29);
            this.btnInhd.TabIndex = 48;
            this.btnInhd.Text = "In";
            this.btnInhd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInhd.UseVisualStyleBackColor = true;
            this.btnInhd.Click += new System.EventHandler(this.btnInhd_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.AutoSize = true;
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(488, 171);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 29);
            this.btnHuy.TabIndex = 47;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dtgDanhshh);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(618, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 222);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hàng hóa";
            // 
            // dtgDanhshh
            // 
            this.dtgDanhshh.AllowUserToAddRows = false;
            this.dtgDanhshh.AllowUserToDeleteRows = false;
            this.dtgDanhshh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDanhshh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhshh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDanhshh.Location = new System.Drawing.Point(3, 19);
            this.dtgDanhshh.Name = "dtgDanhshh";
            this.dtgDanhshh.ReadOnly = true;
            this.dtgDanhshh.Size = new System.Drawing.Size(404, 200);
            this.dtgDanhshh.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.AutoSize = true;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(172, 171);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 29);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuuhd
            // 
            this.btnLuuhd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuuhd.AutoSize = true;
            this.btnLuuhd.Enabled = false;
            this.btnLuuhd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuhd.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuhd.Image")));
            this.btnLuuhd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuhd.Location = new System.Drawing.Point(382, 171);
            this.btnLuuhd.Name = "btnLuuhd";
            this.btnLuuhd.Size = new System.Drawing.Size(78, 29);
            this.btnLuuhd.TabIndex = 45;
            this.btnLuuhd.Text = "Lưu";
            this.btnLuuhd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuhd.UseVisualStyleBackColor = true;
            this.btnLuuhd.Click += new System.EventHandler(this.btnLuuhd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnBot);
            this.groupBox3.Controls.Add(this.btnThemhd);
            this.groupBox3.Controls.Add(this.lblThanhtien);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbldonvi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cboHangHoa);
            this.groupBox3.Controls.Add(this.txtSolghd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDongia);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(615, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 439);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // btnBot
            // 
            this.btnBot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBot.AutoSize = true;
            this.btnBot.Enabled = false;
            this.btnBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBot.Image = ((System.Drawing.Image)(resources.GetObject("btnBot.Image")));
            this.btnBot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBot.Location = new System.Drawing.Point(248, 171);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(68, 29);
            this.btnBot.TabIndex = 39;
            this.btnBot.Text = "Bớt";
            this.btnBot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBot.UseVisualStyleBackColor = true;
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // btnThemhd
            // 
            this.btnThemhd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemhd.AutoSize = true;
            this.btnThemhd.Enabled = false;
            this.btnThemhd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemhd.ForeColor = System.Drawing.Color.Black;
            this.btnThemhd.Image = ((System.Drawing.Image)(resources.GetObject("btnThemhd.Image")));
            this.btnThemhd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemhd.Location = new System.Drawing.Point(167, 171);
            this.btnThemhd.Name = "btnThemhd";
            this.btnThemhd.Size = new System.Drawing.Size(69, 29);
            this.btnThemhd.TabIndex = 39;
            this.btnThemhd.Text = "Thêm";
            this.btnThemhd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemhd.UseVisualStyleBackColor = true;
            this.btnThemhd.Click += new System.EventHandler(this.btnThemhd_Click);
            // 
            // lblThanhtien
            // 
            this.lblThanhtien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThanhtien.AutoSize = true;
            this.lblThanhtien.Location = new System.Drawing.Point(164, 136);
            this.lblThanhtien.Name = "lblThanhtien";
            this.lblThanhtien.Size = new System.Drawing.Size(16, 17);
            this.lblThanhtien.TabIndex = 15;
            this.lblThanhtien.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Thành tiền";
            // 
            // lbldonvi
            // 
            this.lbldonvi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldonvi.AutoSize = true;
            this.lbldonvi.Location = new System.Drawing.Point(303, 105);
            this.lbldonvi.Name = "lbldonvi";
            this.lbldonvi.Size = new System.Drawing.Size(0, 17);
            this.lbldonvi.TabIndex = 11;
            this.lbldonvi.TextChanged += new System.EventHandler(this.lbldonvi_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "(VNĐ)";
            // 
            // cboHangHoa
            // 
            this.cboHangHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboHangHoa.Enabled = false;
            this.cboHangHoa.FormattingEnabled = true;
            this.cboHangHoa.Location = new System.Drawing.Point(167, 24);
            this.cboHangHoa.Name = "cboHangHoa";
            this.cboHangHoa.Size = new System.Drawing.Size(130, 24);
            this.cboHangHoa.TabIndex = 0;
            this.cboHangHoa.SelectedIndexChanged += new System.EventHandler(this.cboHangHoa_SelectedIndexChanged);
            // 
            // txtSolghd
            // 
            this.txtSolghd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSolghd.Enabled = false;
            this.txtSolghd.Location = new System.Drawing.Point(167, 102);
            this.txtSolghd.Name = "txtSolghd";
            this.txtSolghd.Size = new System.Drawing.Size(130, 23);
            this.txtSolghd.TabIndex = 2;
            this.txtSolghd.TextChanged += new System.EventHandler(this.txtSolghd_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số lượng";
            // 
            // txtDongia
            // 
            this.txtDongia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDongia.Enabled = false;
            this.txtDongia.Location = new System.Drawing.Point(167, 63);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(130, 23);
            this.txtDongia.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hàng hóa";
            // 
            // btnTaomoihd
            // 
            this.btnTaomoihd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTaomoihd.AutoSize = true;
            this.btnTaomoihd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaomoihd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaomoihd.ForeColor = System.Drawing.Color.Black;
            this.btnTaomoihd.Image = ((System.Drawing.Image)(resources.GetObject("btnTaomoihd.Image")));
            this.btnTaomoihd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaomoihd.Location = new System.Drawing.Point(61, 171);
            this.btnTaomoihd.Name = "btnTaomoihd";
            this.btnTaomoihd.Size = new System.Drawing.Size(78, 29);
            this.btnTaomoihd.TabIndex = 44;
            this.btnTaomoihd.Text = "Thêm";
            this.btnTaomoihd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaomoihd.UseVisualStyleBackColor = true;
            this.btnTaomoihd.Click += new System.EventHandler(this.btnTaomoihd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvDSHD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 222);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dtgvDSHD
            // 
            this.dtgvDSHD.AllowUserToAddRows = false;
            this.dtgvDSHD.AllowUserToDeleteRows = false;
            this.dtgvDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSHD.Location = new System.Drawing.Point(3, 19);
            this.dtgvDSHD.Name = "dtgvDSHD";
            this.dtgvDSHD.ReadOnly = true;
            this.dtgvDSHD.Size = new System.Drawing.Size(575, 200);
            this.dtgvDSHD.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.cboNvl);
            this.groupBox1.Controls.Add(this.cboKh);
            this.groupBox1.Controls.Add(this.cboNhacc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMahd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 143);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Enabled = false;
            this.txtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayLap.Location = new System.Drawing.Point(102, 73);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(127, 23);
            this.txtNgayLap.TabIndex = 20;
            // 
            // cboNvl
            // 
            this.cboNvl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboNvl.Enabled = false;
            this.cboNvl.FormattingEnabled = true;
            this.cboNvl.Location = new System.Drawing.Point(401, 30);
            this.cboNvl.Name = "cboNvl";
            this.cboNvl.Size = new System.Drawing.Size(159, 24);
            this.cboNvl.TabIndex = 2;
            // 
            // cboKh
            // 
            this.cboKh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboKh.Enabled = false;
            this.cboKh.FormattingEnabled = true;
            this.cboKh.Location = new System.Drawing.Point(401, 75);
            this.cboKh.Name = "cboKh";
            this.cboKh.Size = new System.Drawing.Size(159, 24);
            this.cboKh.TabIndex = 4;
            // 
            // cboNhacc
            // 
            this.cboNhacc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboNhacc.AutoSize = true;
            this.cboNhacc.Location = new System.Drawing.Point(278, 78);
            this.cboNhacc.Name = "cboNhacc";
            this.cboNhacc.Size = new System.Drawing.Size(96, 17);
            this.cboNhacc.TabIndex = 6;
            this.cboNhacc.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhân viên lập";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập";
            // 
            // txtMahd
            // 
            this.txtMahd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMahd.Enabled = false;
            this.txtMahd.Location = new System.Drawing.Point(102, 30);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(130, 23);
            this.txtMahd.TabIndex = 1;
            this.txtMahd.TextChanged += new System.EventHandler(this.txtMahd_TextChanged_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã  hóa đơn";
            // 
            // frm_hoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 439);
            this.Controls.Add(this.btnInhd);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuuhd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTaomoihd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_hoadonnhap";
            this.Text = "THÔNG TIN HÓA ĐƠN NHẬP";
            this.Load += new System.EventHandler(this.frm_hoadonnhap_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhshh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInhd;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgDanhshh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuuhd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBot;
        private System.Windows.Forms.Button btnThemhd;
        private System.Windows.Forms.Label lblThanhtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbldonvi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboHangHoa;
        private System.Windows.Forms.TextBox txtSolghd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTaomoihd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDSHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtNgayLap;
        private System.Windows.Forms.ComboBox cboNvl;
        private System.Windows.Forms.ComboBox cboKh;
        private System.Windows.Forms.Label cboNhacc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.Label label1;
    }
}