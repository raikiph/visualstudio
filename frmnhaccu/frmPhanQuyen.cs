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
    public partial class frmPhanQuyen : Form
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }
        private void ShowPhanQuyen()
        {
            DataTable dtPhanQuyen = new DataTable();
            Function.Connect();
            string sqlPQ = "SELECT DISTINCT PQ.IDPQ, ND.TAIKHOAN, CN.TENCN \n" +
            "FROM NGUOIDUNG AS ND JOIN PHANQUYEN AS PQ ON ND.IDNGUOIDUNG = PQ.IDNGUOIDUNG \n" +
            "JOIN CHUCNANG AS CN ON CN.IDCN =  PQ.IDCN \n" +
            "ORDER BY ND.TAIKHOAN DESC";
            if (Function.TruyVan(sqlPQ, dtPhanQuyen))
            {
                dtgvPhanQuyen.DataSource = dtPhanQuyen;
                dtgvPhanQuyen.Columns[0].HeaderText = "ID CHUC NANG";
                dtgvPhanQuyen.Columns[0].Width = 50;
                dtgvPhanQuyen.Columns[1].HeaderText = "Tai Khoan";
                dtgvPhanQuyen.Columns[1].Width = 50;
                dtgvPhanQuyen.Columns[2].HeaderText = "Chuc Nang";
                dtgvPhanQuyen.Columns[2].Width = 100;
                dtgvPhanQuyen.EnableHeadersVisualStyles = false;
                dtgvPhanQuyen.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCyan;
            }
        }
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            ShowPhanQuyen();
            Function.Connect();
            string sqlTaiKhoan = "SELECT * FROM NGUOIDUNG WHERE NHOM = 'Nguoi dung'";
            string sqlChucNang = "SELECT * FROM CHUCNANG";
            Function.FillCombo(sqlTaiKhoan, cboTaiKhoan, "IDNGUOIDUNG", "TAIKHOAN");
            Function.FillCombo(sqlChucNang, cboChucNang, "IDCN", "TENCN");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Function.Connect();
            string sqlInsert = "INSERT INTO PHANQUYEN(IDPQ, IDNGUOIDUNG, IDCN) \n" +
                    "VALUES('" + txtIdPhanQuyen.Text + "','" + txtIdNguoiDung.Text + "', \n" +
                    "'" + txtIdChucNang.Text + "')";
            try
            {
                Function.RunSQL(sqlInsert);
                MessageBox.Show("Ban da phan quyen thanh cong", "Thong bao",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
            // Goi ham show san pham
            ShowPhanQuyen();
            // Ngat ket noi
            Function.DisConnect();
        }

        private void dtgvPhanQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdChucNang.Text = cboChucNang.SelectedValue.ToString();
        }

        private void cboTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdNguoiDung.Text = cboTaiKhoan.SelectedValue.ToString();

        }
    }
}
