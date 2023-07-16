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
    public partial class frmThemTaiKhoan : Form
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void dtgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdNguoiDung.Text = dtgvTaiKhoan.CurrentRow.Cells["IDNGUOIDUNG"].Value.ToString();
            txtHoTen.Text = dtgvTaiKhoan.CurrentRow.Cells["HOTEN"].Value.ToString();
            txtTaiKhoan.Text = dtgvTaiKhoan.CurrentRow.Cells["TAIKHOAN"].Value.ToString();
            txtMatKhau.Text = dtgvTaiKhoan.CurrentRow.Cells["MATKHAU"].Value.ToString();
            string Nhom, sql;
            // lay du lieu tu dgvMatHang len combobox
            Nhom = dtgvTaiKhoan.CurrentRow.Cells["IDNGUOIDUNG"].Value.ToString();
            sql = "SELECT NHOM FROM NGUOIDUNG WHERE IDNGUOIDUNG=N'" + Nhom + "'";
            cboNhom.Text = Function.GetFieldValues(sql);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pnlTaiKhoan.Enabled = true;
            Reset();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtIdNguoiDung.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnlTaiKhoan.Enabled = true;
            txtIdNguoiDung.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiem tra id nguoi dung
            if (txtIdNguoiDung.Text == "")
            {
                MessageBox.Show("Ban chua chon id nguoi dung", "Thong Bao", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                // Ket noi
                Function.Connect();
                // Cau lenh sql xoa
                string sqlDelete = "delete from NGUOIDUNG where IDNGUOIDUNG = '" + txtIdNguoiDung.Text + "'";
                if (MessageBox.Show("Ban co chac xoa tai khoan nay?", "Xac nhan xoa", MessageBoxButtons.YesNo,
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
                ShowTaiKhoan();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                if (KiemTraThongTin())
                {
                    Function.Connect();
                    string sqlInsert = "INSERT INTO NGUOIDUNG(IDNGUOIDUNG, HOTEN, TAIKHOAN, MATKHAU, NHOM)\n" +
                    "VALUES('" + txtIdNguoiDung.Text + "','" + txtHoTen.Text + "', \n" +
                    "'" + txtTaiKhoan.Text + "', '" + txtMatKhau.Text + "', '" + cboNhom.SelectedValue.ToString() + "')";
                    try
                    {
                        Function.RunSQL(sqlInsert);
                        MessageBox.Show("Ban da them thanh cong tai khoan '" + txtTaiKhoan.Text + "'", "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show san pham
                ShowTaiKhoan();
                // Ngat ket noi
                Function.DisConnect();
            }
            else
            {
                //code cua Upadate

                if (KiemTraThongTin())
                {
                    Function.Connect();
                    string sqlUpdate = "Update NGUOIDUNG set HOTEN = '" + txtHoTen.Text + "',\n" +
                    "NHOM = '" + cboNhom.SelectedValue.ToString() + "',\n" +
                    "TAIKHOAN = '" + txtTaiKhoan.Text + "', MATKHAU = '" + txtMatKhau.Text + "'\n" +
                    "WHERE IDNGUOIDUNG = '" + txtIdNguoiDung.Text + "'";
                    try
                    {
                        Function.RunSQL(sqlUpdate);
                        MessageBox.Show("Ban da cap nhat thanh cong tai khoan'" + txtTaiKhoan.Text + "'");
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show san pham
                ShowTaiKhoan();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
            pnlTaiKhoan.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            pnlTaiKhoan.Enabled = false;
            ShowTaiKhoan();
            string sql = "SELECT * FROM NGUOIDUNG";
            Function.FillCombo(sql, cboNhom, "NHOM", "NHOM");
        }

        private void ShowTaiKhoan()
        {
            DataTable dtTaiKhoan = new DataTable();
            Function.Connect();
            string sqlND = "SELECT * FROM NGUOIDUNG";
            if (Function.TruyVan(sqlND, dtTaiKhoan))
            {
                dtgvTaiKhoan.DataSource = dtTaiKhoan;
                dtgvTaiKhoan.Columns[0].HeaderText = "ID Nguoi Dung";
                dtgvTaiKhoan.Columns[0].Width = 50;
                dtgvTaiKhoan.Columns[1].HeaderText = "Ho Ten";
                dtgvTaiKhoan.Columns[1].Width = 100;
                dtgvTaiKhoan.Columns[2].HeaderText = "Tai Khoan";
                dtgvTaiKhoan.Columns[2].Width = 100;
                dtgvTaiKhoan.Columns[3].HeaderText = "Mat Khau";
                dtgvTaiKhoan.Columns[3].Width = 100;
                dtgvTaiKhoan.Columns[4].HeaderText = "Nhom";
                dtgvTaiKhoan.Columns[4].Width = 50;
                dtgvTaiKhoan.EnableHeadersVisualStyles = false;
                dtgvTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCyan;
            }
        }


        private void Reset()
        {
            txtIdNguoiDung.Text = "";
            txtHoTen.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cboNhom.Text = "";
        }
        private bool KiemTraThongTin()
        {
            if (txtIdNguoiDung.Text == "")
            {
                MessageBox.Show("Ban chua nhap Id nguoi dung !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdNguoiDung.Focus();
                return false;
            }
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Ban chua nhap ho ten !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Ban chua nhap tai khoan !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return false;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Ban chua nhap mat khau !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }
            if (cboNhom.Text == "")
            {
                MessageBox.Show("Ban chua chon nhom !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
