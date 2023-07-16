namespace frmnhaccu
{
    partial class frmPhanQuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdNguoiDung = new System.Windows.Forms.TextBox();
            this.txtIdChucNang = new System.Windows.Forms.TextBox();
            this.txtIdPhanQuyen = new System.Windows.Forms.TextBox();
            this.cboTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboChucNang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdNguoiDung
            // 
            this.txtIdNguoiDung.Location = new System.Drawing.Point(59, 215);
            this.txtIdNguoiDung.Name = "txtIdNguoiDung";
            this.txtIdNguoiDung.Size = new System.Drawing.Size(100, 20);
            this.txtIdNguoiDung.TabIndex = 16;
            this.txtIdNguoiDung.Visible = false;
            // 
            // txtIdChucNang
            // 
            this.txtIdChucNang.Location = new System.Drawing.Point(59, 178);
            this.txtIdChucNang.Name = "txtIdChucNang";
            this.txtIdChucNang.Size = new System.Drawing.Size(100, 20);
            this.txtIdChucNang.TabIndex = 15;
            this.txtIdChucNang.Visible = false;
            // 
            // txtIdPhanQuyen
            // 
            this.txtIdPhanQuyen.Location = new System.Drawing.Point(117, 25);
            this.txtIdPhanQuyen.Name = "txtIdPhanQuyen";
            this.txtIdPhanQuyen.Size = new System.Drawing.Size(100, 20);
            this.txtIdPhanQuyen.TabIndex = 14;
            // 
            // cboTaiKhoan
            // 
            this.cboTaiKhoan.FormattingEnabled = true;
            this.cboTaiKhoan.Location = new System.Drawing.Point(107, 100);
            this.cboTaiKhoan.Name = "cboTaiKhoan";
            this.cboTaiKhoan.Size = new System.Drawing.Size(121, 21);
            this.cboTaiKhoan.TabIndex = 12;
            this.cboTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cboTaiKhoan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ten tai khoan";
            // 
            // cboChucNang
            // 
            this.cboChucNang.FormattingEnabled = true;
            this.cboChucNang.Location = new System.Drawing.Point(107, 61);
            this.cboChucNang.Name = "cboChucNang";
            this.cboChucNang.Size = new System.Drawing.Size(121, 21);
            this.cboChucNang.TabIndex = 13;
            this.cboChucNang.SelectedIndexChanged += new System.EventHandler(this.cboChucNang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Id Phan Quyen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ten chuc nang";
            // 
            // dtgvPhanQuyen
            // 
            this.dtgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhanQuyen.Location = new System.Drawing.Point(237, 73);
            this.dtgvPhanQuyen.Name = "dtgvPhanQuyen";
            this.dtgvPhanQuyen.Size = new System.Drawing.Size(240, 150);
            this.dtgvPhanQuyen.TabIndex = 8;
            this.dtgvPhanQuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhanQuyen_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(59, 139);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.txtIdNguoiDung);
            this.Controls.Add(this.txtIdChucNang);
            this.Controls.Add(this.txtIdPhanQuyen);
            this.Controls.Add(this.cboTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboChucNang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvPhanQuyen);
            this.Controls.Add(this.btnThem);
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhanQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdNguoiDung;
        private System.Windows.Forms.TextBox txtIdChucNang;
        private System.Windows.Forms.TextBox txtIdPhanQuyen;
        private System.Windows.Forms.ComboBox cboTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboChucNang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvPhanQuyen;
        private System.Windows.Forms.Button btnThem;
    }
}