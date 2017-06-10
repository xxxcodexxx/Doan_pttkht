namespace Qlbs.module_frm
{
    partial class frm_hoadon
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
            this.btnHoadn = new System.Windows.Forms.Button();
            this.btnHoadx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHoadn
            // 
            this.btnHoadn.Location = new System.Drawing.Point(141, 55);
            this.btnHoadn.Name = "btnHoadn";
            this.btnHoadn.Size = new System.Drawing.Size(112, 48);
            this.btnHoadn.TabIndex = 0;
            this.btnHoadn.Text = "Hóa đơn Nhập";
            this.btnHoadn.UseVisualStyleBackColor = true;
            this.btnHoadn.Click += new System.EventHandler(this.btnHoadn_Click);
            // 
            // btnHoadx
            // 
            this.btnHoadx.Location = new System.Drawing.Point(141, 109);
            this.btnHoadx.Name = "btnHoadx";
            this.btnHoadx.Size = new System.Drawing.Size(112, 49);
            this.btnHoadx.TabIndex = 1;
            this.btnHoadx.Text = "Hóa đơn Xuất";
            this.btnHoadx.UseVisualStyleBackColor = true;
            this.btnHoadx.Click += new System.EventHandler(this.btnHoadx_Click);
            // 
            // frm_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 261);
            this.Controls.Add(this.btnHoadx);
            this.Controls.Add(this.btnHoadn);
            this.Name = "frm_hoadon";
            this.Text = "frm_hoadon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHoadn;
        private System.Windows.Forms.Button btnHoadx;
    }
}