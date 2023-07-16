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
            this.MenuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTietHoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHeThong,
            this.MenuQuanLy,
            this.thongKeToolStripMenuItem,
            this.troGiupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuHeThong
            // 
            this.MenuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTaiKhoan,
            this.MenuQLTK,
            this.thoatToolStripMenuItem1});
            this.MenuHeThong.Name = "MenuHeThong";
            this.MenuHeThong.Size = new System.Drawing.Size(69, 20);
            this.MenuHeThong.Text = "He thong";
            // 
            // MenuQuanLy
            // 
            this.MenuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNhanVien,
            this.khachHangToolStripMenuItem,
            this.MenuSanPham,
            this.hoaDonToolStripMenuItem});
            this.MenuQuanLy.Name = "MenuQuanLy";
            this.MenuQuanLy.Size = new System.Drawing.Size(60, 20);
            this.MenuQuanLy.Text = "Quan ly";
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thongKeToolStripMenuItem.Text = "Thong ke";
            // 
            // troGiupToolStripMenuItem
            // 
            this.troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            this.troGiupToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.troGiupToolStripMenuItem.Text = "Tro giup";
            // 
            // MenuNhanVien
            // 
            this.MenuNhanVien.Name = "MenuNhanVien";
            this.MenuNhanVien.Size = new System.Drawing.Size(152, 22);
            this.MenuNhanVien.Text = "Nhan Vien";
            // 
            // khachHangToolStripMenuItem
            // 
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.khachHangToolStripMenuItem.Text = "Khach Hang";
            // 
            // MenuSanPham
            // 
            this.MenuSanPham.Name = "MenuSanPham";
            this.MenuSanPham.Size = new System.Drawing.Size(152, 22);
            this.MenuSanPham.Text = "San pham";
            // 
            // hoaDonToolStripMenuItem
            // 
            this.hoaDonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTietHoaDonToolStripMenuItem});
            this.hoaDonToolStripMenuItem.Name = "hoaDonToolStripMenuItem";
            this.hoaDonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hoaDonToolStripMenuItem.Text = "Hoa don";
            // 
            // chiTietHoaDonToolStripMenuItem
            // 
            this.chiTietHoaDonToolStripMenuItem.Name = "chiTietHoaDonToolStripMenuItem";
            this.chiTietHoaDonToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.chiTietHoaDonToolStripMenuItem.Text = "Chi tiet hoa don";
            // 
            // MenuTaiKhoan
            // 
            this.MenuTaiKhoan.Name = "MenuTaiKhoan";
            this.MenuTaiKhoan.Size = new System.Drawing.Size(167, 22);
            this.MenuTaiKhoan.Text = "Them tai khoan";
            // 
            // MenuQLTK
            // 
            this.MenuQLTK.Name = "MenuQLTK";
            this.MenuQLTK.Size = new System.Drawing.Size(167, 22);
            this.MenuQLTK.Text = "Quan ly tai khoan";
            // 
            // thoatToolStripMenuItem1
            // 
            this.thoatToolStripMenuItem1.Name = "thoatToolStripMenuItem1";
            this.thoatToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.thoatToolStripMenuItem1.Text = "Thoat";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 261);
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
        private System.Windows.Forms.ToolStripMenuItem MenuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem MenuQLTK;
        private System.Windows.Forms.ToolStripMenuItem MenuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem MenuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSanPham;
        private System.Windows.Forms.ToolStripMenuItem hoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTietHoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem1;
    }
}