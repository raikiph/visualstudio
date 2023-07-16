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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void ShowHoaDon()
        {
            DataTable dtHoaDon = new DataTable();
            Function.Connect();
            string sqlHoaDon = "SELECT * FROM HOADON";
            if (Function.TruyVan(sqlHoaDon, dtHoaDon))
            {
                dtgvHoaDon.DataSource = dtHoaDon;
                dtgvHoaDon.Columns[0].HeaderText = "Ma Hoa Don";
                dtgvHoaDon.Columns[0].Width = 50;
                dtgvHoaDon.Columns[1].HeaderText = "Ma Nhan Vien";
                dtgvHoaDon.Columns[1].Width = 50;
                dtgvHoaDon.Columns[2].HeaderText = "Ngay Ban";
                dtgvHoaDon.Columns[2].Width = 100;
                dtgvHoaDon.Columns[3].HeaderText = "Ma Khach Hang";
                dtgvHoaDon.Columns[3].Width = 50;
                dtgvHoaDon.EnableHeadersVisualStyles = false;
                dtgvHoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }
        private void Reset()
        {
            txtMaHD.Text = "";
            txtNgayBan.Text = "";
            cboMaKH.Text = "";
            cboMaNV.Text = "";
        }
        private bool KiemTraThongTin()
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Ban chua nhap Ma Hoa Don !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (txtNgayBan.Text == "")
            {
                MessageBox.Show("Ban chua Nhap Ngay Ban !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (cboMaNV.Text == "")
            {
                MessageBox.Show("Ban chua chon Ma Khach Hang !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (cboMaKH.Text == "")
            {
                MessageBox.Show("Ban chua chon Ten Khach Hang !", "Thong bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            pnlHoaDon.Enabled = false;
            ShowHoaDon();
            string sqlKH = "SELECT * FROM KHACHHANG";
            Function.FillCombo(sqlKH, cboMaKH, "MAKH", "TENKH");
            string sqlNV = "SELECT * FROM NHANVIEN";
            Function.FillCombo(sqlNV, cboMaNV, "MANV", "TENNV");
        }


        private void dtgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dtgvHoaDon.CurrentRow.Cells["MAHD"].Value.ToString();
            txtNgayBan.Text = dtgvHoaDon.CurrentRow.Cells["NGAYBAN"].Value.ToString();

            string MaNV, sqlnv;
            // lay du lieu tu dgvMatHang len combobox
            MaNV = dtgvHoaDon.CurrentRow.Cells["MANV"].Value.ToString();
            sqlnv = "SELECT TENNV FROM NHANVIEN WHERE MANV=N'" + MaNV + "'";
            cboMaNV.Text = Function.GetFieldValues(sqlnv);

            string MaKH, sqlkh;
            // lay du lieu tu dgvMatHang len combobox
            MaKH = dtgvHoaDon.CurrentRow.Cells["MAKH"].Value.ToString();
            sqlkh = "SELECT TENKH FROM KHACHHANG WHERE MAKH=N'" + MaKH + "'";
            cboMaKH.Text = Function.GetFieldValues(sqlkh);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Reset();
            pnlHoaDon.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaHD.Focus();
            txtNgayBan.Text = "****/**/**";
            txtThongBao.Visible = true;
            txtThongBao.Text = "Nhập vào định dạng năm/tháng/ngày";
            txtThongBao.ForeColor = Color.Red;
            txtThongBao.BackColor = System.Drawing.Color.Cyan;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnlHoaDon.Enabled = true;
            txtMaHD.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtThongBao.Visible = true;
            txtThongBao.Text = "Nhập vào định dạng năm/tháng/ngày";
            txtThongBao.ForeColor = Color.Red;
            txtThongBao.BackColor = System.Drawing.Color.Cyan;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
            pnlHoaDon.Enabled = false;
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
                    string sqlInsert = "INSERT INTO HOADON(MAHD, MANV, NGAYBAN, MAKH) \n" +
                    "VALUES('" + txtMaHD.Text + "','" + cboMaNV.SelectedValue.ToString() + "', \n" +
                    "'" + txtNgayBan.Text + "','" + cboMaKH.SelectedValue.ToString() + "')";
                    try
                    {
                        Function.RunSQL(sqlInsert);
                        MessageBox.Show("Ban da them thanh cong '" + txtMaHD.Text + "'", "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show san pham
                ShowHoaDon();
                // Ngat ket noi
                Function.DisConnect();
            }

            else
            {
                //code cua Upadate

                if (KiemTraThongTin())
                {
                    Function.Connect();
                    string sqlUpdate = "Update HOADON set MANV = '" + cboMaNV.SelectedValue.ToString() + "',\n" +
                    "MAKH = '" + cboMaKH.SelectedValue.ToString() + "',\n" +
                    "NGAYBAN = '" + txtNgayBan.Text + "' \n" +
                    "WHERE MAHD = '" + txtMaHD.Text + "'";
                    try
                    {
                        Function.RunSQL(sqlUpdate);
                        MessageBox.Show("Ban da cap nhat thanh cong Hoa Don'" + txtMaHD.Text + "'");
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show san pham
                ShowHoaDon();
                // Ngat ket noi
                Function.DisConnect();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Ban chua chon Ma Hoa Don", "Thong Bao", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                // Ket noi
                Function.Connect();
                // Cau lenh sql xoa
                string sqlDelete = "delete from HOADON where MAHD = '" + txtMaHD.Text + "'";
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
                ShowHoaDon();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
