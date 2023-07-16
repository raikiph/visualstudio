namespace frmnhaccu
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThemTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQLTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuChiTietHD = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.troGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHeThong,
            this.MenuQuanLy,
            this.MenuThongKe,
            this.troGiupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuHeThong
            // 
            this.MenuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuThemTaiKhoan,
            this.MenuQLTaiKhoan,
            this.thoatToolStripMenuItem});
            this.MenuHeThong.Name = "MenuHeThong";
            this.MenuHeThong.Size = new System.Drawing.Size(69, 20);
            this.MenuHeThong.Text = "He thong";
            // 
            // MenuThemTaiKhoan
            // 
            this.MenuThemTaiKhoan.Name = "MenuThemTaiKhoan";
            this.MenuThemTaiKhoan.Size = new System.Drawing.Size(167, 22);
            this.MenuThemTaiKhoan.Text = "Them tai khoan";
            this.MenuThemTaiKhoan.Click += new System.EventHandler(this.MenuThemTaiKhoan_Click);
            // 
            // MenuQLTaiKhoan
            // 
            this.MenuQLTaiKhoan.Name = "MenuQLTaiKhoan";
            this.MenuQLTaiKhoan.Size = new System.Drawing.Size(167, 22);
            this.MenuQLTaiKhoan.Text = "Quan ly tai khoan";
            this.MenuQLTaiKhoan.Click += new System.EventHandler(this.MenuQLTaiKhoan_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.thoatToolStripMenuItem.Text = "Thoat";
            // 
            // MenuQuanLy
            // 
            this.MenuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDanhMuc,
            this.MenuSanPham,
            this.MenuNhanVien,
            this.MenuHoaDon,
            this.MenuKhachHang});
            this.MenuQuanLy.Name = "MenuQuanLy";
            this.MenuQuanLy.Size = new System.Drawing.Size(60, 20);
            this.MenuQuanLy.Text = "Quan ly";
            // 
            // MenuDanhMuc
            // 
            this.MenuDanhMuc.Name = "MenuDanhMuc";
            this.MenuDanhMuc.Size = new System.Drawing.Size(137, 22);
            this.MenuDanhMuc.Text = "Danh muc";
            this.MenuDanhMuc.Click += new System.EventHandler(this.sanPhamToolStripMenuItem_Click);
            // 
            // MenuSanPham
            // 
            this.MenuSanPham.Name = "MenuSanPham";
            this.MenuSanPham.Size = new System.Drawing.Size(137, 22);
            this.MenuSanPham.Text = "San pham";
            this.MenuSanPham.Click += new System.EventHandler(this.nhanVienToolStripMenuItem_Click);
            // 
            // MenuNhanVien
            // 
            this.MenuNhanVien.Name = "MenuNhanVien";
            this.MenuNhanVien.Size = new System.Drawing.Size(152, 22);
            this.MenuNhanVien.Text = "Nhan Vien";
            this.MenuNhanVien.Click += new System.EventHandler(this.MenuNhanVien_Click);
            // 
            // MenuHoaDon
            // 
            this.MenuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuChiTietHD});
            this.MenuHoaDon.Name = "MenuHoaDon";
            this.MenuHoaDon.Size = new System.Drawing.Size(152, 22);
            this.MenuHoaDon.Text = "Hoa don";
            this.MenuHoaDon.Click += new System.EventHandler(this.MenuHoaDon_Click);
            // 
            // MenuChiTietHD
            // 
            this.MenuChiTietHD.Name = "MenuChiTietHD";
            this.MenuChiTietHD.Size = new System.Drawing.Size(159, 22);
            this.MenuChiTietHD.Text = "Chi tiet hoa don";
            this.MenuChiTietHD.Click += new System.EventHandler(this.MenuChiTietHD_Click);
            // 
            // MenuKhachHang
            // 
            this.MenuKhachHang.Name = "MenuKhachHang";
            this.MenuKhachHang.Size = new System.Drawing.Size(152, 22);
            this.MenuKhachHang.Text = "Khach hang";
            this.MenuKhachHang.Click += new System.EventHandler(this.MenuKhachHang_Click);
            // 
            // MenuThongKe
            // 
            this.MenuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuInBaoCao});
            this.MenuThongKe.Name = "MenuThongKe";
            this.MenuThongKe.Size = new System.Drawing.Size(68, 20);
            this.MenuThongKe.Text = "Thong ke";
            // 
            // MenuInBaoCao
            // 
            this.MenuInBaoCao.Name = "MenuInBaoCao";
            this.MenuInBaoCao.Size = new System.Drawing.Size(152, 22);
            this.MenuInBaoCao.Text = "In báo cáo";
            this.MenuInBaoCao.Click += new System.EventHandler(this.MenuInBaoCao_Click);
            // 
            // troGiupToolStripMenuItem
            // 
            this.troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            this.troGiupToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.troGiupToolStripMenuItem.Text = "Tro giup";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmnhaccu.Properties.Resources.TRƯỜNG_CAO_ĐẲNG_BÁN_CÔNG_CÔNG_NGHỆ___QUẢN_TRỊ_DOANH_NGHIỆP1;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuHeThong;
        private System.Windows.Forms.ToolStripMenuItem MenuThemTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem MenuQLTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem MenuThongKe;
        private System.Windows.Forms.ToolStripMenuItem troGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem MenuSanPham;
        private System.Windows.Forms.ToolStripMenuItem MenuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem MenuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem MenuChiTietHD;
        private System.Windows.Forms.ToolStripMenuItem MenuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem MenuInBaoCao;
    }
}