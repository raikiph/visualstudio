﻿using System;
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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLNCDataSet.INCHITIET' table. You can move, or remove it, as needed.
            Function.Connect();
            string sql = "SELECT * FROM HOADON";
            Function.FillCombo(sql, cboMaHD, "MAHD", "MAHD");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.INCHITIETTableAdapter.Fill(this.QLNCDataSet.INCHITIET, cboMaHD.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
