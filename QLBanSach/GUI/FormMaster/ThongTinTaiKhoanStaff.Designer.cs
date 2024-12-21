namespace GUI.FormMaster
{
    partial class ThongTinTaiKhoanStaff
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
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.dtpNamSinh = new System.Windows.Forms.DateTimePicker();
            this.btn_SuaTT = new System.Windows.Forms.Button();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnlThongTinTaiKhoan = new System.Windows.Forms.Panel();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlThongTinTaiKhoan.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaNV
            // 
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMaNV.Location = new System.Drawing.Point(363, 10);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(156, 23);
            this.txtMaNV.TabIndex = 20;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(181, 13);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(58, 17);
            this.lblMaNV.TabIndex = 19;
            this.lblMaNV.Text = "Mã NV :";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(363, 305);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(156, 23);
            this.txtQueQuan.TabIndex = 18;
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(181, 309);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(82, 17);
            this.lblQueQuan.TabIndex = 17;
            this.lblQueQuan.Text = "Quê Quán: ";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Cursor = System.Windows.Forms.Cursors.No;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Hoạt Động",
            "Tạm Ngưng",
            "Đã Nghỉ",
            "Không Xác Định"});
            this.cbTrangThai.Location = new System.Drawing.Point(363, 203);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(156, 24);
            this.cbTrangThai.TabIndex = 16;
            // 
            // dtpNamSinh
            // 
            this.dtpNamSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNamSinh.Location = new System.Drawing.Point(363, 154);
            this.dtpNamSinh.Name = "dtpNamSinh";
            this.dtpNamSinh.Size = new System.Drawing.Size(156, 23);
            this.dtpNamSinh.TabIndex = 15;
            // 
            // btn_SuaTT
            // 
            this.btn_SuaTT.BackColor = System.Drawing.Color.Silver;
            this.btn_SuaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaTT.Location = new System.Drawing.Point(242, 390);
            this.btn_SuaTT.Name = "btn_SuaTT";
            this.btn_SuaTT.Size = new System.Drawing.Size(127, 29);
            this.btn_SuaTT.TabIndex = 14;
            this.btn_SuaTT.Text = "&Sửa Thông Tin";
            this.btn_SuaTT.UseVisualStyleBackColor = false;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(363, 257);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(156, 23);
            this.txtCCCD.TabIndex = 11;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(181, 259);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(144, 17);
            this.lblCCCD.TabIndex = 10;
            this.lblCCCD.Text = "Căn Cước Công Dân :";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(181, 205);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(86, 17);
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Trạng Thái :";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(181, 156);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(73, 17);
            this.lblNamSinh.TabIndex = 6;
            this.lblNamSinh.Text = "Năm Sinh:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(363, 105);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(156, 23);
            this.txtTenNV.TabIndex = 3;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(181, 106);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(107, 17);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Tên Nhân Viên:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(363, 56);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(156, 23);
            this.txtPass.TabIndex = 1;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(181, 57);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(43, 17);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Pass:";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Location = new System.Drawing.Point(565, 0);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(62, 37);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Exit";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(179, 21);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(270, 30);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Thông Tin Tài Khoản";
            // 
            // pnlThongTinTaiKhoan
            // 
            this.pnlThongTinTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtSoDienThoai);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblSoDienThoai);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtMaNV);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblMaNV);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtQueQuan);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblQueQuan);
            this.pnlThongTinTaiKhoan.Controls.Add(this.cbTrangThai);
            this.pnlThongTinTaiKhoan.Controls.Add(this.dtpNamSinh);
            this.pnlThongTinTaiKhoan.Controls.Add(this.btn_SuaTT);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtCCCD);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblCCCD);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblTrangThai);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblNamSinh);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtTenNV);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblTenNV);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtPass);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblPass);
            this.pnlThongTinTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTinTaiKhoan.Location = new System.Drawing.Point(0, 67);
            this.pnlThongTinTaiKhoan.Name = "pnlThongTinTaiKhoan";
            this.pnlThongTinTaiKhoan.Size = new System.Drawing.Size(627, 443);
            this.pnlThongTinTaiKhoan.TabIndex = 3;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(363, 349);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(156, 23);
            this.txtSoDienThoai.TabIndex = 22;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(181, 353);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(110, 17);
            this.lblSoDienThoai.TabIndex = 21;
            this.lblSoDienThoai.Text = "Số Điện Thoại : ";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlHeader.Controls.Add(this.btn_Thoat);
            this.pnlHeader.Controls.Add(this.lbl_Title);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(627, 67);
            this.pnlHeader.TabIndex = 2;
            // 
            // ThongTinTaiKhoanStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 510);
            this.Controls.Add(this.pnlThongTinTaiKhoan);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinTaiKhoanStaff";
            this.Text = "ThongTinTaiKhoanStaff";
            this.Load += new System.EventHandler(this.ThongTinTaiKhoanStaff_Load);
            this.pnlThongTinTaiKhoan.ResumeLayout(false);
            this.pnlThongTinTaiKhoan.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNamSinh;
        private System.Windows.Forms.Button btn_SuaTT;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnlThongTinTaiKhoan;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
    }
}