namespace frmnhaccu
{
    partial class frmChiTietHD
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
            this.btnThem = new System.Windows.Forms.Button();
            this.txtThongBao = new System.Windows.Forms.TextBox();
            this.cboMaSanPham = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dtgvCTHD = new System.Windows.Forms.DataGridView();
            this.pnlCTHD = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHD)).BeginInit();
            this.pnlCTHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Image = global::frmnhaccu.Properties.Resources.Untitled_1_051;
            this.btnThem.Location = new System.Drawing.Point(699, 159);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 50);
            this.btnThem.TabIndex = 25;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtThongBao
            // 
            this.txtThongBao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongBao.ForeColor = System.Drawing.SystemColors.Window;
            this.txtThongBao.Location = new System.Drawing.Point(231, 78);
            this.txtThongBao.Multiline = true;
            this.txtThongBao.Name = "txtThongBao";
            this.txtThongBao.Size = new System.Drawing.Size(153, 53);
            this.txtThongBao.TabIndex = 18;
            // 
            // cboMaSanPham
            // 
            this.cboMaSanPham.AutoSize = true;
            this.cboMaSanPham.Location = new System.Drawing.Point(413, 13);
            this.cboMaSanPham.Name = "cboMaSanPham";
            this.cboMaSanPham.Size = new System.Drawing.Size(78, 13);
            this.cboMaSanPham.TabIndex = 11;
            this.cboMaSanPham.Text = "Tên Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã Hóa Đơn";
            // 
            // cboSanPham
            // 
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(493, 9);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(121, 21);
            this.cboSanPham.TabIndex = 10;
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(104, 9);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(121, 21);
            this.cboMaHD.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thành Tiền";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(514, 56);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giảm giá";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(125, 92);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(100, 20);
            this.txtGiamGia.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::frmnhaccu.Properties.Resources.close_02;
            this.btnThoat.Location = new System.Drawing.Point(855, 271);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 50);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::frmnhaccu.Properties.Resources.Untitled_1_07;
            this.btnLuu.Location = new System.Drawing.Point(699, 271);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 50);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::frmnhaccu.Properties.Resources.Untitled_1_06;
            this.btnHuy.Location = new System.Drawing.Point(855, 215);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 50);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::frmnhaccu.Properties.Resources.Untitled_1_03;
            this.btnXoa.Location = new System.Drawing.Point(699, 215);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 50);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đơn Giá";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(514, 102);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(100, 20);
            this.txtThanhTien.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(125, 54);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // dtgvCTHD
            // 
            this.dtgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTHD.Location = new System.Drawing.Point(36, 159);
            this.dtgvCTHD.Name = "dtgvCTHD";
            this.dtgvCTHD.Size = new System.Drawing.Size(657, 150);
            this.dtgvCTHD.TabIndex = 19;
            this.dtgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCTHD_CellContentClick);
            // 
            // pnlCTHD
            // 
            this.pnlCTHD.Controls.Add(this.txtThongBao);
            this.pnlCTHD.Controls.Add(this.cboMaSanPham);
            this.pnlCTHD.Controls.Add(this.label5);
            this.pnlCTHD.Controls.Add(this.cboSanPham);
            this.pnlCTHD.Controls.Add(this.cboMaHD);
            this.pnlCTHD.Controls.Add(this.label4);
            this.pnlCTHD.Controls.Add(this.txtDonGia);
            this.pnlCTHD.Controls.Add(this.label3);
            this.pnlCTHD.Controls.Add(this.txtGiamGia);
            this.pnlCTHD.Controls.Add(this.label2);
            this.pnlCTHD.Controls.Add(this.txtThanhTien);
            this.pnlCTHD.Controls.Add(this.label1);
            this.pnlCTHD.Controls.Add(this.txtSoLuong);
            this.pnlCTHD.Location = new System.Drawing.Point(35, 18);
            this.pnlCTHD.Name = "pnlCTHD";
            this.pnlCTHD.Size = new System.Drawing.Size(658, 135);
            this.pnlCTHD.TabIndex = 18;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::frmnhaccu.Properties.Resources.Untitled_1_04;
            this.btnSua.Location = new System.Drawing.Point(855, 159);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 50);
            this.btnSua.TabIndex = 24;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 367);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtgvCTHD);
            this.Controls.Add(this.pnlCTHD);
            this.Controls.Add(this.btnSua);
            this.Name = "frmChiTietHD";
            this.Text = "frmChiTietHD";
            this.Load += new System.EventHandler(this.frmChiTietHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHD)).EndInit();
            this.pnlCTHD.ResumeLayout(false);
            this.pnlCTHD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtThongBao;
        private System.Windows.Forms.Label cboMaSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dtgvCTHD;
        private System.Windows.Forms.Panel pnlCTHD;
        private System.Windows.Forms.Button btnSua;
    }
}