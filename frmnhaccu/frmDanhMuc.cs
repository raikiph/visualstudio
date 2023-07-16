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
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }
        //ham show danh muc
        private void ShowDanhMuc()
        {
            DataTable dtDanhMuc = new DataTable();
            Function.Connect();
            string sqlDM = "SELECT * FROM DANHMUC";
            if (Function.TruyVan(sqlDM, dtDanhMuc))
            {
                dtgvDanhMuc.DataSource = dtDanhMuc;
                dtgvDanhMuc.Columns[0].HeaderText = "Ma Danh Muc";
                dtgvDanhMuc.Columns[0].Width = 50;
                dtgvDanhMuc.Columns[1].HeaderText = "Ten Danh Muc";
                dtgvDanhMuc.Columns[1].Width = 100;
                dtgvDanhMuc.EnableHeadersVisualStyles = false;
                dtgvDanhMuc.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCyan;
            }
        }
        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            pnlDanhMuc.Enabled = false;
            ShowDanhMuc();
        }

       
        private void Reset()
        {
            txtMaDanhMuc.Text = "";
            txtTenDanhMuc.Text = "";
        }
      
        public bool KiemTraThongTin()
        {
            if (txtMaDanhMuc.Text == "")
            {
                MessageBox.Show("Ban chua nhap ma danh muc", "Thong bao", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtMaDanhMuc.Focus();
                return false;
            }
            if (txtTenDanhMuc.Text == "")
            {
                MessageBox.Show("Ban chua nhap ten danh muc", "Thong bao", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtTenDanhMuc.Focus();
                return false;
            }
            return true;
        }
      

        private void dtgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //hien thi du lieu len datagirdview
            txtMaDanhMuc.Text = dtgvDanhMuc.CurrentRow.Cells["MaDanhMuc"].Value.ToString();
            txtTenDanhMuc.Text = dtgvDanhMuc.CurrentRow.Cells["TenDanhMuc"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Reset();
            pnlDanhMuc.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaDanhMuc.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiem tra nut lenh them co sang
            if (btnThem.Enabled == true)
            {
                //code cua them
                if (KiemTraThongTin())
                {
                    Function.Connect();
                    string sqlInsert = "INSERT INTO DANHMUC(MADANHMUC, TENDANHMUC) \n" +
                    "VALUES('" + txtMaDanhMuc.Text + "','" + txtTenDanhMuc.Text + "')";
                    try
                    {
                        Function.RunSQL(sqlInsert);
                        MessageBox.Show("Ban da them thanh cong '" + txtTenDanhMuc.Text + "'", "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show danh muc
                ShowDanhMuc();
                // Ngat ket noi
                Function.DisConnect();
            }
            else
            {
                //code cua Upadate
                if (KiemTraThongTin())
                {
                    Function.Connect();
                    string sqlUpdate = "Update DANHMUC set TENDANHMUC = '" + txtTenDanhMuc.Text + "'\n" +
                    "WHERE MADANHMUC = '" + txtMaDanhMuc.Text + "'";
                    try
                    {
                        Function.RunSQL(sqlUpdate);
                        MessageBox.Show("Ban da cap nhat thanh cong mat hang'" + txtTenDanhMuc.Text + "'");
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show danh muc
                ShowDanhMuc();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnlDanhMuc.Enabled = true;
            txtMaDanhMuc.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiem tra ma danh muc
            if (txtMaDanhMuc.Text == "")
            {
                MessageBox.Show("Ban chua chon ma danh muc", "Thong Bao", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                // Ket noi
                Function.Connect();
                // Cau lenh sql xoa
                string sqlDelete = "delete from DANHMUC where MADANHMUC = '" + txtMaDanhMuc.Text + "'";
                if (MessageBox.Show("Ban co chac xoa danh muc nay?", "Xac nhan xoa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Goi ham Run SQl
                        Function.RunSQL(sqlDelete);
                        MessageBox.Show("Da xoa thanh cong!", "THong bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exx)
                    {
                        // Thong bao loi
                        MessageBox.Show(exx.Message);
                    }
                }
                // Goi ham show danh muc
                ShowDanhMuc();
                // Ngat ket noi
                Function.DisConnect();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
            pnlDanhMuc.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
        }


    }
}
