using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace frmnhaccu
{
    class Function
    {
         // khai bao bien ket noi
        public static SqlConnection conn;
        // Ham ket noi
        public static void Connect()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-OH3I6B7\SQLEXPRESS;Initial Catalog=QLNC;Integrated Security=True";
            conn.Open();
        }
        // Ham ngat ket noi
        public static void DisConnect()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        // Ham Run SQL
        public static void RunSQL(string sql) // thuc hien lenh sql
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = Function.conn; // gan ket noi
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose(); // giai phong bo nho
            cmd = null;
        }
        // Ham lay du lieu tu co so du lieu
        public static Boolean TruyVan(string strSQL, DataTable dt)
        {
            Boolean kq = false;
            SqlDataAdapter da;
            try
            {
                da = new SqlDataAdapter(strSQL,conn);
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                    kq = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao");
            }
            return kq;
        }
       //Dien du lieu vao combobox
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Truong gia tri
            cbo.DisplayMember = ten; //Truong hien thi
        }
        //Lay du lieu tu luoi len combobox
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
    }
    }

