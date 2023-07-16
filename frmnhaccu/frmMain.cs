using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmnhaccu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        public ToolStripMenuItem MnHeThong
        {
            get { return MenuHeThong; }
            set { MenuHeThong = value; }
        }
        public ToolStripMenuItem ThemTaiKhoan
        {
            get { return MenuThemTaiKhoan; }
            set { MenuThemTaiKhoan = value; }
        }
        public ToolStripMenuItem QLTaiKhoan
        {
            get { return MenuQLTaiKhoan; }
            set { MenuQLTaiKhoan = value; }
        }
        public ToolStripMenuItem MnQuanLy
        {
            get { return MenuQuanLy; }
            set { MenuQuanLy = value; }
        }
        public ToolStripMenuItem MnDanhMuc
        {
            get { return MenuDanhMuc; }
            set { MenuDanhMuc = value; }
        }
        public ToolStripMenuItem MnSanPham
        {
            get { return MenuSanPham; }
            set { MenuSanPham = value; }
        }
        public ToolStripMenuItem MnNhanVien
        {
            get { return MenuNhanVien; }
            set { MenuNhanVien = value; }
        }
        public ToolStripMenuItem MnKhachHang
        {
            get { return MenuKhachHang; }
            set { MenuKhachHang = value; }
        }
        public ToolStripMenuItem MmChiTietHD
        {
            get { return MenuChiTietHD; }
            set { MenuChiTietHD = value; }
        }
        public ToolStripMenuItem MnHoaDon
        {
            get { return MenuHoaDon; }
            set { MenuHoaDon = value; }
        }
        public ToolStripMenuItem MnInBaoCao
        {
            get { return MenuInBaoCao; }
            set { MenuInBaoCao = value; }
        }
        public ToolStripMenuItem MnThongKe
        {
            get { return MenuThongKe; }
            set { MenuThongKe = value; }
        }
        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMuc frmDM= new frmDanhMuc();
            frmDM.Show();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frmSP = new frmSanPham();
            frmSP.Show();
        }

        private void MenuThemTaiKhoan_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan frmTTK = new frmThemTaiKhoan();
            frmTTK.Show();
        }

        private void MenuQLTaiKhoan_Click(object sender, EventArgs e)
        {
            frmPhanQuyen frmQL = new frmPhanQuyen();
            frmQL.Show();
        }

        private void MenuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV= new frmNhanVien();
            frmNV.Show();
        }

        private void MenuHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHD = new frmHoaDon();
            frmHD.Show();
        }

        private void MenuKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.Show();
        }

        private void MenuChiTietHD_Click(object sender, EventArgs e)
        {
            frmChiTietHD frmCTHD = new frmChiTietHD();
            frmCTHD.Show();
        }

        private void MenuInBaoCao_Click(object sender, EventArgs e)
        {
            frmReport frmINBAOCAO = new frmReport();
            frmINBAOCAO.Show();
        }
    }
}
