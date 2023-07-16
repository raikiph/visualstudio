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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
              {
            //ket noi csdl
            //KTraThongTin();
            Function.Connect();
            string taikhoan = txtTaiKhoan.Text.Trim(), matkhau = txtMatKhau.Text.Trim();
            string sql1 = "SELECT * FROM NGUOIDUNG WHERE TAIKHOAN='" + taikhoan + "' AND MATKHAU ='" + matkhau + "'";
            string sql2 = "SELECT * FROM NGUOIDUNG WHERE  TAIKHOAN='" + taikhoan + "' AND MATKHAU !='" + matkhau + "'";
            DataTable dtlg = new DataTable();
            //frmMain frm = new frmMain();
            //goi form main voi cac control

            if (Function.TruyVan(sql1, dtlg))
            {
                KTraThongTin();
                //dang nhap thanh cong
                MessageBox.Show("Dang nhap thanh cong!", "Thong bao",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                string nhomquyen = dtlg.Rows[0]["nhom"].ToString().Trim();
                string idnguoidung = dtlg.Rows[0]["idnguoidung"].ToString().Trim();
                //lấy giá trị của cột “idnguoidung” từ hàng đầu tiên của bảng “dtlg” 
                //và gán giá trị đó cho biến “idnguoidung”.
                if (nhomquyen == "Quan tri")
                {
                    //quan tri dang nhap
                    MessageBox.Show("Quan tri da dang nha thanh cong!", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //goi form main va mo full control
                    frmMain frm = new frmMain();
                    frm.Show();
                    //frmshow
                    //frm.MnBaocao.Enabled = false;
                    frm.MnHeThong.Enabled = true;
                    frm.QLTaiKhoan.Enabled = true;
                    frm.MnQuanLy.Enabled = true;
                    frm.MnSanPham.Enabled = true;
                    frm.MnNhanVien.Enabled = true;
                }
                else
                {
                    //nguoi dung dang nhap
                    MessageBox.Show("Nguoi dung da dang nhap thanh cong!", "Thong Bao",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string sql3 = "SELECT * FROM PHANQUYEN WHERE IDNGUOIDUNG = '" + idnguoidung + "'";
                    DataTable dtPQ = new DataTable();
                    if (Function.TruyVan(sql3, dtPQ))
                    {
                        // Tắt tất cả các control để so sánh các quyền có trong cơ sở dữ liệu

                        //frm.MnBaocao.Enabled = false;
                        //frM.Show()
                        frmMain frm = new frmMain();
                        frm.Show();
                        //frmshow
                        //frm.MnBaocao.Enabled = false;
                        frm.MnHeThong.Enabled = false;
                        frm.QLTaiKhoan.Enabled = false;
                        frm.MnQuanLy.Enabled = false;
                        frm.MnSanPham.Enabled = false;
                        frm.MnNhanVien.Enabled = false;
                        //so sanh cac quyen co trong dtPQ
                        foreach (DataRow row in dtPQ.Rows)
                        {
                            if (row["idcn"].ToString().Trim() == "1")
                            {
                                frm.MnHeThong.Enabled = true;
                                frm.QLTaiKhoan.Enabled = true;
                            }
                        }
                    }
                }
            }
            else if (Function.TruyVan(sql2, dtlg))
            {
                KTraThongTin();

                //sai mat khau
                MessageBox.Show("Ban nhap sai mat khau!", "Thong bao",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
            }
            else
            {
                //tai khoan khong ton tai
                MessageBox.Show("Tai khoan khong ton tai!", "Thong bao",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /*
        if (Function.TruyVan(sql1, dtlg))
        {
            string nhomquyen = dtlg.Rows[0]["nhom"].ToString().Trim();
            string idnguoidung = dtlg.Rows[0]["idnguoidung"].ToString().Trim();
            //lấy giá trị của cột “idnguoidung” từ hàng đầu tiên của bảng “dtlg” 
            //và gán giá trị đó cho biến “idnguoidung”.
        if (nhomquyen == "Quan tri")
        {
            //quan tri dang nhap
            MessageBox.Show("Quan tri da dang nha thanh cong!", "Thong bao",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //goi form main va mo full control
            frmMain frm = new frmMain();
            frm.Show();
            //frmshow
            //frm.MnBaocao.Enabled = false;

                
        }
        else
        {
            //nguoi dung dang nhap
            MessageBox.Show("Nguoi dung da dang nhap thanh cong!", "Thong Bao",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            string sql3 = "SELECT * FROM PHANQUYEN WHERE IDNGUOIDUNG = '" + idnguoidung + "'";
            DataTable dtPQ = new DataTable();
            if (Function.TruyVan(sql3, dtPQ))
            {
                // Tắt tất cả các control để so sánh các quyền có trong cơ sở dữ liệu
                //frm.MnBaocao.Enabled = false;
                //frM.Show()
                //so sanh cac quyen co trong dtPQ
                foreach(DataRow Row in dtPQ.Rows)
                {
                    //if (row["idcn"].ToString().Trim() == "1")
                    //{
                      //  frM.MnHethong.Enabled = true;
                      //  frM.MnThemTK.Enabled = true;
                    //}
                }
            }
        }
        }
    }
      */
        }

        private void ckbMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }


        private Boolean KTraThongTin()
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return false;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }

       
       

    }
}


      