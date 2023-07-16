using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace frmnhaccu
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            pnlSanPham.Enabled = false;
            ShowSanPham();
            string sql = "SELECT * FROM DANHMUC";
            Function.FillCombo(sql, cboSanPham, "MADANHMUC", "TENDANHMUC");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Reset();
            pnlSanPham.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaSanPham.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnlSanPham.Enabled = true;
            txtMaSanPham.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiem tra chat lieu da duoc chon chua
            if (txtMaSanPham.Text == "")
            {
                MessageBox.Show("Ban chua chon Ma San Pham", "Thong Bao", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                // Ket noi
                Function.Connect();
                // Cau lenh sql xoa
                string sqlDelete = "delete from SANPHAM where MASANPHAM = '" + txtMaSanPham.Text + "'";
                if (MessageBox.Show("Ban co chac xoa mat hang nay?", "Xac nhan xoa", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Goi ham Run SQl
                        Function.RunSQL(sqlDelete);
                        MessageBox.Show("Da xoa thanh cong!", "Thong bao", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception exx)
                    {
                        // Thong bao loi
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show mat hang
                ShowSanPham();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                //code cua them
                if (KiemTraThongTin())
                {
                    Function.Connect();
                    string sqlInsert = "INSERT INTO SANPHAM(MASANPHAM, TENSANPHAM, MADANHMUC, SOLUONG, DONGIANHAP,\n" +
                        "DONGIABAN, GHICHU) \n" +
                    "VALUES('" + txtMaSanPham.Text + "','" + txtTenSanPham.Text + "', \n" +
                    "'" + cboSanPham.SelectedValue.ToString() + "','" + txtSoLuong.Text + "', \n" +
                    "'" + txtDonGiaNhap.Text + "','" + txtDonGiaBan.Text + "', '" + txtGhiChu.Text + "')";
                    try
                    {
                        Function.RunSQL(sqlInsert);
                        MessageBox.Show("Ban da them thanh cong '" + txtTenSanPham.Text + "'", "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show san pham
                ShowSanPham();
                // Ngat ket noi
                Function.DisConnect();
            }
            else
            {
                //code cua Upadate

                if (KiemTraThongTin())
                {
                    Function.Connect();
                    string sqlUpdate = "Update SANPHAM set TENSANPHAM = '" + txtTenSanPham.Text + "',\n" +
                    "MADANHMUC = '" + cboSanPham.SelectedValue.ToString() + "',\n" +
                    "SOLUONG = '" + txtSoLuong.Text + "', DONGIANHAP = '" + txtDonGiaNhap.Text + "',\n" +
                    "DONGIABAN =  '" + txtDonGiaBan.Text + "', GHICHU = '" + txtGhiChu.Text + "'\n" +
                    "WHERE MASANPHAM = '" + txtMaSanPham.Text + "'";
                    try
                    {
                        Function.RunSQL(sqlUpdate);
                        MessageBox.Show("Ban da cap nhat thanh cong mat hang'" + txtTenSanPham.Text + "'");
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show san pham
                ShowSanPham();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
            pnlSanPham.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
        }
        private void Reset()
        {
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaBan.Text = "";
            txtDonGiaNhap.Text = "";
            txtGhiChu.Text = "";
        }
        private void ShowSanPham()
        {
            DataTable dtSanPham = new DataTable();
            Function.Connect();
            string sqlSP = "SELECT * FROM SANPHAM";
            if (Function.TruyVan(sqlSP, dtSanPham))
            {
                dtgvSanPham.DataSource = dtSanPham;
                dtgvSanPham.Columns[0].HeaderText = "Ma San Pham";
                dtgvSanPham.Columns[0].Width = 50;
                dtgvSanPham.Columns[1].HeaderText = "Ten San Pham";
                dtgvSanPham.Columns[1].Width = 120;
                dtgvSanPham.Columns[2].HeaderText = "Ma Chat Lieu";
                dtgvSanPham.Columns[2].Width = 75;
                dtgvSanPham.Columns[3].HeaderText = "So luong";
                dtgvSanPham.Columns[3].Width = 50;
                dtgvSanPham.Columns[4].HeaderText = "Don Gia Nhap";
                dtgvSanPham.Columns[4].Width = 150;
                dtgvSanPham.Columns[5].HeaderText = "Don Gia Ban";
                dtgvSanPham.Columns[5].Width = 150;
                dtgvSanPham.Columns[6].HeaderText = "Ghi Chu";
                dtgvSanPham.Columns[6].Width = 150;
                dtgvSanPham.EnableHeadersVisualStyles = false;
                dtgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }
        private bool KiemTraThongTin()
        {
            if (txtMaSanPham.Text == "")
            {
                MessageBox.Show("Ban chua nhap Ma San Pham !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSanPham.Focus();
                return false;
            }
            if (txtTenSanPham.Text == "")
            {
                MessageBox.Show("Ban chua nhap Ten San Pham !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTenSanPham.Focus();
                return false;
            }
            if (cboSanPham.Text == "")
            {
                MessageBox.Show("Ban chua chon Ten Danh Muc !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Ban chua nhap So Luong !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return false;
            }
            if (txtDonGiaBan.Text == "")
            {
                MessageBox.Show("Ban chua nhap Don Gia Ban !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDonGiaBan.Focus();
                return false;
            }
            if (txtDonGiaNhap.Text == "")
            {
                MessageBox.Show("Ban chua nhap Don Gia Nhap !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDonGiaNhap.Focus();
                return false;
            }
            return true;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

       

        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            decimal number = decimal.Parse(txtDonGiaNhap.Text, NumberStyles.Currency);
            txtDonGiaNhap.Text = number.ToString("N0");
        }

        private void txtDonGiaBan_TextChanged(object sender, EventArgs e)
        {
            decimal number = decimal.Parse(txtDonGiaBan.Text, NumberStyles.Currency);
            txtDonGiaBan.Text = number.ToString("N0");
        }

        private void dtgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // lay du lieu tu dtgv len textbox
            txtMaSanPham.Text = dtgvSanPham.CurrentRow.Cells["MASANPHAM"].Value.ToString();
            txtTenSanPham.Text = dtgvSanPham.CurrentRow.Cells["TENSANPHAM"].Value.ToString();
            txtSoLuong.Text = dtgvSanPham.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txtDonGiaNhap.Text = dtgvSanPham.CurrentRow.Cells["DONGIANHAP"].Value.ToString();
            txtDonGiaBan.Text = dtgvSanPham.CurrentRow.Cells["DONGIABAN"].Value.ToString();
            txtGhiChu.Text = dtgvSanPham.CurrentRow.Cells["GHICHU"].Value.ToString();
            string Madanhmuc, sql;
            // lay du lieu tu dgvMatHang len combobox
            Madanhmuc = dtgvSanPham.CurrentRow.Cells["MADANHMUC"].Value.ToString();
            sql = "SELECT TENDANHMUC FROM DANHMUC WHERE MADANHMUC=N'" + Madanhmuc + "'";
            cboSanPham.Text = Function.GetFieldValues(sql);
        }
    }
}
