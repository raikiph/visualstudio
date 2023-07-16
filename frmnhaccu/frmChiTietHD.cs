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
    public partial class frmChiTietHD : Form
    {
        public frmChiTietHD()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            cboMaHD.Text = "";
            cboSanPham.Text = "";
            txtDonGia.Text = "";
            txtGiamGia.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
        }
        private bool KiemTraThongTin()
        {
            if (cboMaHD.Text == "")
            {
                MessageBox.Show("Ban chua chon Ma Hoa Don !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (cboSanPham.Text == "")
            {
                MessageBox.Show("Ban chua chon San Pham !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Ban chua nhap Don Gia !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (txtGiamGia.Text == "")
            {
                MessageBox.Show("Ban chua nhap Giam Gia !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Ban chua nhap So Luong !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void ShowChiTietHoaDon()
        {
            /*
             SELECT MAHD, SP.MASANPHAM, SP.TENSANPHAM, CT.SOLUONG, CT.DONGIA, CT.GIAMGIA, THANHTIEN = CT.SOLUONG * CT.DONGIA * CT.GIAMGIA
FROM SANPHAM AS SP JOIN CHITIETHD AS CT ON SP.MASANPHAM = CT.MASANPHAM      
             */
            DataTable dtChitietHoaDon = new DataTable();
            Function.Connect();
            string sqlCTHD = " SELECT CT.MAHD, SP.MASANPHAM, SP.TENSANPHAM, CT.SOLUONG, CT.DONGIA, CT.GIAMGIA, \n" +
                "THANHTIEN = CT.SOLUONG * CT.DONGIA * CT.GIAMGIA \n" +
                "FROM SANPHAM AS SP JOIN CHITIETHD AS CT ON SP.MASANPHAM = CT.MASANPHAM";
            if (Function.TruyVan(sqlCTHD, dtChitietHoaDon))
            {
                dtgvCTHD.DataSource = dtChitietHoaDon;
                dtgvCTHD.Columns[0].HeaderText = "Ma Hoa Don";
                dtgvCTHD.Columns[0].Width = 50;
                dtgvCTHD.Columns[1].HeaderText = "Ma San Pham";
                dtgvCTHD.Columns[1].Width = 100;
                dtgvCTHD.Columns[2].HeaderText = "Ten San Pham";
                dtgvCTHD.Columns[2].Width = 100;
                dtgvCTHD.Columns[3].HeaderText = "So Luong";
                dtgvCTHD.Columns[3].Width = 50;
                dtgvCTHD.Columns[4].HeaderText = "Don Gia";
                dtgvCTHD.Columns[4].Width = 100;
                dtgvCTHD.Columns[5].HeaderText = "Giam Gia";
                dtgvCTHD.Columns[5].Width = 50;
                dtgvCTHD.Columns[6].HeaderText = "Thanh Tien";
                dtgvCTHD.Columns[6].Width = 100;
                dtgvCTHD.EnableHeadersVisualStyles = false;
                dtgvCTHD.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }
        

      
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Reset();
            pnlCTHD.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            cboMaHD.Focus();
            txtThongBao.Visible = true;
            txtThongBao.Text = "Nhập vào định dạng số thập phân có dấu chấm (.)";
            txtThongBao.ForeColor = Color.Red;
            txtThongBao.BackColor = System.Drawing.Color.Cyan;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnlCTHD.Enabled = true;
            cboMaHD.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtThongBao.Visible = true;
            txtThongBao.Text = "Nhập vào định dạng số thập phân có dấu chấm (.)";
            txtThongBao.ForeColor = Color.Red;
            txtThongBao.BackColor = System.Drawing.Color.Cyan;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          if (cboMaHD.Text == "")
            {
                MessageBox.Show("Ban chua chon Ma Hoa Don", "Thong Bao", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                // Ket noi
                Function.Connect();
                // Cau lenh sql xoa
                string sqlDelete = "delete from CHITIETHD where MAHD = '" + cboMaHD.Text + "'";
                if (MessageBox.Show("Ban co chac xoa hoa don nay?", "Xac nhan xoa", MessageBoxButtons.YesNo,
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
                ShowChiTietHoaDon();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
            pnlCTHD.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            txtThongBao.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (btnThem.Enabled == true)
            {
                //code cua them
                if (KiemTraThongTin())
                {
                    Function.Connect();
                    string sqlInsert = "INSERT INTO CHITIETHD(MAHD, MASANPHAM, SOLUONG, DONGIA, GIAMGIA) \n" +
                    "VALUES('" + cboMaHD.SelectedValue.ToString() + "', \n" +
                    "'" + cboSanPham.SelectedValue.ToString() + "', \n" +
                    "'" + txtSoLuong.Text + "' , '" + txtDonGia.Text + "' ,  '" + txtGiamGia.Text + "')";
                    try
                    {
                        Function.RunSQL(sqlInsert);
                        MessageBox.Show("Ban da them thanh cong '" + cboMaHD.Text + "'", "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show san pham
                ShowChiTietHoaDon();
                // Ngat ket noi
                Function.DisConnect();
            }

            else
            {
                //code cua Upadate

                if (KiemTraThongTin())
                {
                    Function.Connect();
                    string sqlUpdate = "Update CHITIETHD set \n" +
                    "MASANPHAM = '" + cboSanPham.SelectedValue.ToString() + "', \n" +
                    "SOLUONG = '" + txtSoLuong.Text + "', DONGIA = '" + txtDonGia.Text + "', \n" +
                    "GIAMGIA = '" + txtGiamGia.Text + "' \n" +
                    "WHERE MAHD = '" + cboMaHD.SelectedValue.ToString() + "'";
                    try
                    {
                        Function.RunSQL(sqlUpdate);
                        MessageBox.Show("Ban da cap nhat thanh cong Hoa Don'" + cboMaHD.Text + "'");
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show san pham
                ShowChiTietHoaDon();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            pnlCTHD.Enabled = false;
            ShowChiTietHoaDon();
            Function.Connect();

            string sqlHDF = "SELECT * FROM HOADON";
            Function.FillCombo(sqlHDF, cboMaHD, "MAHD", "MAHD");

            string sqlSPF = "SELECT * FROM SANPHAM";
            Function.FillCombo(sqlSPF, cboSanPham, "MASANPHAM", "TENSANPHAM");
        }

        private void dtgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoLuong.Text = dtgvCTHD.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txtDonGia.Text = dtgvCTHD.CurrentRow.Cells["DONGIA"].Value.ToString();
            txtGiamGia.Text = dtgvCTHD.CurrentRow.Cells["GIAMGIA"].Value.ToString();
            txtThanhTien.Text = dtgvCTHD.CurrentRow.Cells["THANHTIEN"].Value.ToString();

            string MaHD, sqlHD;
            // lay du lieu tu dgvMatHang len combobox
            MaHD = dtgvCTHD.CurrentRow.Cells["MAHD"].Value.ToString();
            sqlHD = "SELECT MAHD FROM HOADON WHERE MAHD=N'" + MaHD + "'";
            cboMaHD.Text = Function.GetFieldValues(sqlHD);

            string MaSP, sqlSP;
            // lay du lieu tu dgvMatHang len combobox
            MaSP = dtgvCTHD.CurrentRow.Cells["MASANPHAM"].Value.ToString();
            sqlSP = "SELECT TENSANPHAM FROM SANPHAM WHERE MASANPHAM=N'" + MaSP + "'";
            cboSanPham.Text = Function.GetFieldValues(sqlSP);
        }
    }
}
