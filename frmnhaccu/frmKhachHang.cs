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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            pnlKhachHang.Enabled = false;
            ShowKhachHang();
        }
        private void dtgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhachHang.Text = dtgvKhachHang.CurrentRow.Cells["MAKH"].Value.ToString();
            txtTenKhachHang.Text = dtgvKhachHang.CurrentRow.Cells["TENKH"].Value.ToString();
            txtDiaChi.Text = dtgvKhachHang.CurrentRow.Cells["DIACHI"].Value.ToString();
            txtDienThoai.Text = dtgvKhachHang.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Reset();
            pnlKhachHang.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaKhachHang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnlKhachHang.Enabled = true;
            txtMaKhachHang.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Ban chua chon Ma Khach hang", "Thong Bao", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                // Ket noi
                Function.Connect();
                // Cau lenh sql xoa
                string sqlDelete = "delete from KHACHHANG where MAKH = '" + txtMaKhachHang.Text + "'";
                if (MessageBox.Show("Ban co chac xoa Khach Hang nay?", "Xac nhan xoa", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Goi ham Run SQl
                        Function.RunSQL(sqlDelete);
                        MessageBox.Show("Da xoa thanh cong!", "THong bao", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception exx)
                    {
                        // Thong bao loi
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show mat hang
                ShowKhachHang();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
            pnlKhachHang.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                //code cua them
                if (KiemTraThongTin())
                {
                    Function.Connect();
                    string sqlInsert = "INSERT INTO KHACHHANG(MAKH, TENKH, DIACHI, DIENTHOAI) \n" +
                    "VALUES('" + txtMaKhachHang.Text + "','" + txtTenKhachHang.Text + "', \n" +
                    "'" + txtDiaChi.Text + "', '" + txtDienThoai.Text + "')";
                    try
                    {
                        Function.RunSQL(sqlInsert);
                        MessageBox.Show("Ban da them thanh cong Khach Hang '" + txtTenKhachHang.Text + "'", "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show san pham
                ShowKhachHang();
                // Ngat ket noi
                Function.DisConnect();
            }
            else
            {
                //code cua Upadate

                if (KiemTraThongTin())
                {
                    Function.Connect();
                    string sqlUpdate = "Update KHACHHANG set TENKH = '" + txtTenKhachHang.Text + "',\n" +
                    "DIACHI = '" + txtDiaChi.Text + "', DIENTHOAI = '" + txtDienThoai.Text + "'\n" +
                    "WHERE MANV = '" + txtMaKhachHang.Text + "'";
                    try
                    {
                        Function.RunSQL(sqlUpdate);
                        MessageBox.Show("Ban da cap nhat thanh cong Khach Hang'" + txtTenKhachHang.Text + "'");
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show san pham
                ShowKhachHang();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
        private void ShowKhachHang()
        {
            DataTable dtKhachHang = new DataTable();
            Function.Connect();
            string sqlKhachHang = "SELECT * FROM KHACHHANG";
            if (Function.TruyVan(sqlKhachHang, dtKhachHang))
            {
                dtgvKhachHang.DataSource = dtKhachHang;
                dtgvKhachHang.Columns[0].HeaderText = "Ma Khach hang";
                dtgvKhachHang.Columns[0].Width = 50;
                dtgvKhachHang.Columns[1].HeaderText = "Ten Khach Hang";
                dtgvKhachHang.Columns[1].Width = 100;
                dtgvKhachHang.Columns[2].HeaderText = "Dia Chi";
                dtgvKhachHang.Columns[2].Width = 200;
                dtgvKhachHang.Columns[3].HeaderText = "Dien Thoai";
                dtgvKhachHang.Columns[3].Width = 100;
                dtgvKhachHang.EnableHeadersVisualStyles = false;
                dtgvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }
        private void Reset()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }
        private bool KiemTraThongTin()
        {
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Ban chua nhap Ma Khach Hang !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                return false;
            }
            if (txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Ban chua nhap Ten Khach Hang !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhachHang.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Ban chua nhap Dia Chi Khach Hang !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Ban chua nhap So Dien Thoai Khach Hang !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return false;
            }
            return true;
        }


    }
}
