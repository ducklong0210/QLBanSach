namespace GUI
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.lblHeaderRegister = new System.Windows.Forms.Label();
            this.grbRegister = new System.Windows.Forms.GroupBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnBackLogin = new CuoreUI.Controls.cuiButton();
            this.picBackRegister = new System.Windows.Forms.PictureBox();
            this.grbRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderRegister
            // 
            this.lblHeaderRegister.AutoSize = true;
            this.lblHeaderRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblHeaderRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.lblHeaderRegister.Location = new System.Drawing.Point(270, 9);
            this.lblHeaderRegister.Name = "lblHeaderRegister";
            this.lblHeaderRegister.Size = new System.Drawing.Size(218, 29);
            this.lblHeaderRegister.TabIndex = 1;
            this.lblHeaderRegister.Text = "Đăng ký tài khoản";
            // 
            // grbRegister
            // 
            this.grbRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.grbRegister.Controls.Add(this.cbGioiTinh);
            this.grbRegister.Controls.Add(this.dtpNgaySinh);
            this.grbRegister.Controls.Add(this.btnRegister);
            this.grbRegister.Controls.Add(this.txtSoDienThoai);
            this.grbRegister.Controls.Add(this.lblSoDienThoai);
            this.grbRegister.Controls.Add(this.txtDiaChi);
            this.grbRegister.Controls.Add(this.lblDiaChi);
            this.grbRegister.Controls.Add(this.lblGioiTinh);
            this.grbRegister.Controls.Add(this.lblNamSinh);
            this.grbRegister.Controls.Add(this.txtFullname);
            this.grbRegister.Controls.Add(this.lblFullname);
            this.grbRegister.Controls.Add(this.txtpassword);
            this.grbRegister.Controls.Add(this.lblPassword);
            this.grbRegister.Controls.Add(this.txtUsername);
            this.grbRegister.Controls.Add(this.lblUsername);
            this.grbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.grbRegister.Location = new System.Drawing.Point(57, 41);
            this.grbRegister.Name = "grbRegister";
            this.grbRegister.Size = new System.Drawing.Size(572, 362);
            this.grbRegister.TabIndex = 2;
            this.grbRegister.TabStop = false;
            this.grbRegister.Text = "Điền Thông Tin Tài Khoản";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không Xác Định"});
            this.cbGioiTinh.Location = new System.Drawing.Point(277, 181);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(200, 28);
            this.cbGioiTinh.TabIndex = 4;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgaySinh.CustomFormat = "";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(277, 141);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 26);
            this.dtpNgaySinh.TabIndex = 3;
            this.dtpNgaySinh.Value = new System.DateTime(2024, 11, 27, 19, 30, 15, 0);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(175)))), ((int)(((byte)(225)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(242, 312);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(109, 33);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "&Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoDienThoai.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSoDienThoai.Location = new System.Drawing.Point(277, 264);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 26);
            this.txtSoDienThoai.TabIndex = 6;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(138, 270);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(120, 20);
            this.lblSoDienThoai.TabIndex = 12;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDiaChi.Location = new System.Drawing.Point(277, 224);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 26);
            this.txtDiaChi.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(139, 227);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(74, 20);
            this.lblDiaChi.TabIndex = 10;
            this.lblDiaChi.Text = "Địa chỉ :";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(139, 185);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(86, 20);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới tính :";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamSinh.Location = new System.Drawing.Point(139, 144);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(93, 20);
            this.lblNamSinh.TabIndex = 6;
            this.lblNamSinh.Text = "Năm sinh :";
            // 
            // txtFullname
            // 
            this.txtFullname.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtFullname.Location = new System.Drawing.Point(277, 104);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(200, 26);
            this.txtFullname.TabIndex = 2;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.Location = new System.Drawing.Point(139, 104);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(96, 20);
            this.lblFullname.TabIndex = 4;
            this.lblFullname.Text = "Họ và tên :";
            // 
            // txtpassword
            // 
            this.txtpassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtpassword.Location = new System.Drawing.Point(277, 68);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(200, 26);
            this.txtpassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(139, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(96, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtUsername.Location = new System.Drawing.Point(276, 31);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(138, 31);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username :";
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnBackLogin.CheckButton = false;
            this.btnBackLogin.Checked = false;
            this.btnBackLogin.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBackLogin.CheckedForeColor = System.Drawing.Color.White;
            this.btnBackLogin.CheckedImageTint = System.Drawing.Color.White;
            this.btnBackLogin.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBackLogin.Content = "Trở Lại";
            this.btnBackLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackLogin.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnBackLogin.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBackLogin.HoveredImageTint = System.Drawing.Color.White;
            this.btnBackLogin.HoverForeColor = System.Drawing.Color.White;
            this.btnBackLogin.HoverOutline = System.Drawing.Color.Empty;
            this.btnBackLogin.Image = null;
            this.btnBackLogin.ImageAutoCenter = true;
            this.btnBackLogin.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBackLogin.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBackLogin.ImageTint = System.Drawing.Color.White;
            this.btnBackLogin.Location = new System.Drawing.Point(653, 1);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.btnBackLogin.NormalOutline = System.Drawing.Color.Empty;
            this.btnBackLogin.OutlineThickness = 1.6F;
            this.btnBackLogin.PressedBackground = System.Drawing.Color.Transparent;
            this.btnBackLogin.PressedForeColor = System.Drawing.Color.White;
            this.btnBackLogin.PressedImageTint = System.Drawing.Color.White;
            this.btnBackLogin.PressedOutline = System.Drawing.Color.Empty;
            this.btnBackLogin.Rounding = new System.Windows.Forms.Padding(8);
            this.btnBackLogin.Size = new System.Drawing.Size(66, 40);
            this.btnBackLogin.TabIndex = 0;
            this.btnBackLogin.TextOffset = new System.Drawing.Point(0, 0);
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click_1);
            // 
            // picBackRegister
            // 
            this.picBackRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.picBackRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackRegister.Location = new System.Drawing.Point(0, 0);
            this.picBackRegister.Name = "picBackRegister";
            this.picBackRegister.Size = new System.Drawing.Size(720, 429);
            this.picBackRegister.TabIndex = 0;
            this.picBackRegister.TabStop = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(720, 429);
            this.Controls.Add(this.btnBackLogin);
            this.Controls.Add(this.grbRegister);
            this.Controls.Add(this.lblHeaderRegister);
            this.Controls.Add(this.picBackRegister);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(736, 468);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Tài Khoản";
            this.grbRegister.ResumeLayout(false);
            this.grbRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackRegister;
        private System.Windows.Forms.Label lblHeaderRegister;
        private System.Windows.Forms.GroupBox grbRegister;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private CuoreUI.Controls.cuiButton btnBackLogin;
    }
}