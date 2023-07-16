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
        public ToolStripMenuItem QLTaiKhoan
        {
            get { return MenuTaiKhoan; }
            set { MenuTaiKhoan = value; }
        }
        public ToolStripMenuItem MnQuanLy
        {
            get { return MenuQuanLy; }
            set { MenuQuanLy = value; }
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
    }
}
