namespace GUI.FormMaster
{
    partial class ThongTinTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinTaiKhoan));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnlThongTinTaiKhoan = new System.Windows.Forms.Panel();
            this.txtMaND = new System.Windows.Forms.TextBox();
            this.lblMaND = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNamSinh = new System.Windows.Forms.DateTimePicker();
            this.btn_SuaTT = new System.Windows.Forms.Button();
            this.txtQuyenHan = new System.Windows.Forms.TextBox();
            this.lblQuyenHan = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlThongTinTaiKhoan.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlHeader.TabIndex = 0;
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
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtMaND);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblMaND);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtDiaChi);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblDiaChi);
            this.pnlThongTinTaiKhoan.Controls.Add(this.cbGioiTinh);
            this.pnlThongTinTaiKhoan.Controls.Add(this.dtpNamSinh);
            this.pnlThongTinTaiKhoan.Controls.Add(this.btn_SuaTT);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtQuyenHan);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblQuyenHan);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtSoDienThoai);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblSoDienThoai);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblGioiTinh);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblNamSinh);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtHoTen);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblHoTen);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtPass);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblPassword);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtUser);
            this.pnlThongTinTaiKhoan.Controls.Add(this.lblUsername);
            this.pnlThongTinTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTinTaiKhoan.Location = new System.Drawing.Point(0, 67);
            this.pnlThongTinTaiKhoan.Name = "pnlThongTinTaiKhoan";
            this.pnlThongTinTaiKhoan.Size = new System.Drawing.Size(627, 423);
            this.pnlThongTinTaiKhoan.TabIndex = 1;
            // 
            // txtMaND
            // 
            this.txtMaND.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMaND.Location = new System.Drawing.Point(304, 10);
            this.txtMaND.Name = "txtMaND";
            this.txtMaND.ReadOnly = true;
            this.txtMaND.Size = new System.Drawing.Size(156, 23);
            this.txtMaND.TabIndex = 20;
            // 
            // lblMaND
            // 
            this.lblMaND.AutoSize = true;
            this.lblMaND.Location = new System.Drawing.Point(181, 13);
            this.lblMaND.Name = "lblMaND";
            this.lblMaND.Size = new System.Drawing.Size(59, 17);
            this.lblMaND.TabIndex = 19;
            this.lblMaND.Text = "Mã ND :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(304, 294);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(156, 23);
            this.txtDiaChi.TabIndex = 18;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(181, 298);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 17);
            this.lblDiaChi.TabIndex = 17;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không Xác Định"});
            this.cbGioiTinh.Location = new System.Drawing.Point(304, 215);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(156, 24);
            this.cbGioiTinh.TabIndex = 16;
            // 
            // dtpNamSinh
            // 
            this.dtpNamSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNamSinh.Location = new System.Drawing.Point(304, 172);
            this.dtpNamSinh.Name = "dtpNamSinh";
            this.dtpNamSinh.Size = new System.Drawing.Size(156, 23);
            this.dtpNamSinh.TabIndex = 15;
            // 
            // btn_SuaTT
            // 
            this.btn_SuaTT.BackColor = System.Drawing.Color.Silver;
            this.btn_SuaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaTT.Location = new System.Drawing.Point(229, 371);
            this.btn_SuaTT.Name = "btn_SuaTT";
            this.btn_SuaTT.Size = new System.Drawing.Size(127, 29);
            this.btn_SuaTT.TabIndex = 14;
            this.btn_SuaTT.Text = "Sửa Thông Tin";
            this.btn_SuaTT.UseVisualStyleBackColor = false;
            this.btn_SuaTT.Click += new System.EventHandler(this.btn_SuaTT_Click);
            // 
            // txtQuyenHan
            // 
            this.txtQuyenHan.Location = new System.Drawing.Point(304, 331);
            this.txtQuyenHan.Name = "txtQuyenHan";
            this.txtQuyenHan.Size = new System.Drawing.Size(156, 23);
            this.txtQuyenHan.TabIndex = 13;
            this.txtQuyenHan.Click += new System.EventHandler(this.txtQuyenHan_Click);
            // 
            // lblQuyenHan
            // 
            this.lblQuyenHan.AutoSize = true;
            this.lblQuyenHan.Location = new System.Drawing.Point(181, 337);
            this.lblQuyenHan.Name = "lblQuyenHan";
            this.lblQuyenHan.Size = new System.Drawing.Size(84, 17);
            this.lblQuyenHan.TabIndex = 12;
            this.lblQuyenHan.Text = "Quyền Hạn:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(304, 259);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(156, 23);
            this.txtSoDienThoai.TabIndex = 11;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(181, 261);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(102, 17);
            this.lblSoDienThoai.TabIndex = 10;
            this.lblSoDienThoai.Text = "Số Điện Thoại:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(181, 217);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(69, 17);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(181, 174);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(73, 17);
            this.lblNamSinh.TabIndex = 6;
            this.lblNamSinh.Text = "Năm Sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(304, 128);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(156, 23);
            this.txtHoTen.TabIndex = 5;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(181, 132);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(59, 17);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ Tên:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(304, 84);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(156, 23);
            this.txtPass.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(181, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(304, 46);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(156, 23);
            this.txtUser.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(181, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(627, 490);
            this.Controls.Add(this.pnlThongTinTaiKhoan);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinTaiKhoan";
            this.Load += new System.EventHandler(this.ThongTinTaiKhoan_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlThongTinTaiKhoan.ResumeLayout(false);
            this.pnlThongTinTaiKhoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnlThongTinTaiKhoan;
        private System.Windows.Forms.TextBox txtQuyenHan;
        private System.Windows.Forms.Label lblQuyenHan;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNamSinh;
        private System.Windows.Forms.Button btn_SuaTT;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtMaND;
        private System.Windows.Forms.Label lblMaND;
    }
}