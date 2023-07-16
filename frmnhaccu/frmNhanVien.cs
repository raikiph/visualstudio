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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNhanVien.Text = dtgvNhanVien.CurrentRow.Cells["MANV"].Value.ToString();
            txtTenNhanVien.Text = dtgvNhanVien.CurrentRow.Cells["TENNV"].Value.ToString();
            txtDiaChi.Text = dtgvNhanVien.CurrentRow.Cells["DIACHI"].Value.ToString();
            txtDienThoai.Text = dtgvNhanVien.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
            txtNgaySinh.Text = dtgvNhanVien.CurrentRow.Cells["NGAYSINH"].Value.ToString();

            string Manv, sql;
            // lay du lieu tu dgvMatHang len combobox
            Manv = dtgvNhanVien.CurrentRow.Cells["MANV"].Value.ToString();
            sql = "SELECT PHAI FROM NHANVIEN WHERE MANV=N'" + Manv + "'";
            cboPhai.Text = Function.GetFieldValues(sql);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Reset();
            pnlNhanVien.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaNhanVien.Focus();
            txtNgaySinh.Text = "****/**/**";
            txtThongBao.Visible = true;
            txtThongBao.Text = "Nhập vào định dạng năm/tháng/ngày";
            txtThongBao.ForeColor = Color.Red;
            txtThongBao.BackColor = System.Drawing.Color.Cyan;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnlNhanVien.Enabled = true;
            txtMaNhanVien.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtThongBao.Visible = true;
            txtThongBao.Text = "Nhập vào định dạng năm/tháng/ngày";
            txtThongBao.ForeColor = Color.Red;
            txtThongBao.BackColor = System.Drawing.Color.Cyan;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Ban chua chon Ma Nhan Vien", "Thong Bao", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                // Ket noi
                Function.Connect();
                // Cau lenh sql xoa
                string sqlDelete = "delete from NHANVIEN where MANV = '" + txtMaNhanVien.Text + "'";
                if (MessageBox.Show("Ban co chac xoa Nhan Vien nay?", "Xac nhan xoa", MessageBoxButtons.YesNo,
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
                ShowNhanVien();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
            pnlNhanVien.Enabled = false;
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
                    string sqlInsert = "INSERT INTO NHANVIEN(MANV, TENNV, PHAI, DIACHI, DIENTHOAI,\n" +
                        "NGAYSINH) \n" +
                    "VALUES('" + txtMaNhanVien.Text + "','" + txtTenNhanVien.Text + "', \n" +
                    "'" + cboPhai.SelectedItem.ToString() + "','" + txtDiaChi.Text + "', \n" +
                    "'" + txtDienThoai.Text + "', '" + txtNgaySinh.Text + "')";
                    try
                    {
                        Function.RunSQL(sqlInsert);
                        MessageBox.Show("Ban da them thanh cong '" + txtTenNhanVien.Text + "'", "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show san pham
                ShowNhanVien();
                // Ngat ket noi
                Function.DisConnect();
            }
            else
            {
                //code cua Upadate

                if (KiemTraThongTin())
                {
                    Function.Connect();
                    string sqlUpdate = "Update NHANVIEN set TENNV = '" + txtTenNhanVien.Text + "',\n" +
                    "PHAI = '" + cboPhai.SelectedItem.ToString() + "', DIACHI = '" + txtDiaChi.Text + "',\n" +
                    "DIENTHOAI =  '" + txtDienThoai.Text + "', NGAYSINH = '" + txtNgaySinh.Text + "'\n" +
                    "WHERE MANV = '" + txtMaNhanVien.Text + "'";
                    try
                    {
                        Function.RunSQL(sqlUpdate);
                        MessageBox.Show("Ban da cap nhat thanh cong Nhan Vien'" + txtTenNhanVien.Text + "'");
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show san pham
                ShowNhanVien();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            cboPhai.Items.Add("Nam");
            cboPhai.Items.Add("Nu");
            cboPhai.SelectedIndex = 0;
            pnlNhanVien.Enabled = false;
            ShowNhanVien();
        }
        private void ShowNhanVien()
        {
            DataTable dtNhanVien = new DataTable();
            Function.Connect();
            string sqlNhanVien = "SELECT * FROM NHANVIEN";
            if (Function.TruyVan(sqlNhanVien, dtNhanVien))
            {
                dtgvNhanVien.DataSource = dtNhanVien;
                dtgvNhanVien.Columns[0].HeaderText = "Ma Nhan Vien";
                dtgvNhanVien.Columns[0].Width = 50;
                dtgvNhanVien.Columns[1].HeaderText = "Ten Nhan Vien";
                dtgvNhanVien.Columns[1].Width = 100;
                dtgvNhanVien.Columns[2].HeaderText = "Phai";
                dtgvNhanVien.Columns[2].Width = 50;
                dtgvNhanVien.Columns[3].HeaderText = "Dia Chi";
                dtgvNhanVien.Columns[3].Width = 200;
                dtgvNhanVien.Columns[4].HeaderText = "Dien Thoai";
                dtgvNhanVien.Columns[4].Width = 100;
                dtgvNhanVien.Columns[5].HeaderText = "Ngay Sinh";
                dtgvNhanVien.Columns[5].Width = 100;
                dtgvNhanVien.EnableHeadersVisualStyles = false;
                dtgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }
        private void Reset()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtNgaySinh.Text = "";
        }

        private bool KiemTraThongTin()
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Ban chua nhap Ma Nhan Vien !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return false;
            }
            if (txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Ban chua nhap Ten Nhan Vien !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return false;
            }
            if (cboPhai.Text == "")
            {
                MessageBox.Show("Ban chua chon Phai !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhai.Focus();
                return false;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Ban chua nhap So Dien Thoai !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Ban chua nhap Dia Chi !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            if (txtNgaySinh.Text == "")
            {
                MessageBox.Show("Ban chua nhap Ngay Sinh !", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.Focus();
                return false;
            }
            return true;
        }

        private void cboPhai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
