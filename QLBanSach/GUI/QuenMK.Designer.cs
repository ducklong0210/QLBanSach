namespace GUI
{
    partial class QuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMK));
            this.dtpNgayGui = new System.Windows.Forms.DateTimePicker();
            this.btn_Gui = new CuoreUI.Controls.cuiButton();
            this.txtNoiDung = new CuoreUI.Controls.cuiTextBox2();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtEmail = new CuoreUI.Controls.cuiTextBox2();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new CuoreUI.Controls.cuiTextBox2();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblNgayGui = new System.Windows.Forms.Label();
            this.txtUsername = new CuoreUI.Controls.cuiTextBox2();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBackLogin = new CuoreUI.Controls.cuiButton();
            this.lbl_Loi = new System.Windows.Forms.Label();
            this.btn_Error = new CuoreUI.Controls.cuiButton();
            this.btn_Access = new CuoreUI.Controls.cuiButton();
            this.picBackForgotPass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackForgotPass)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayGui
            // 
            this.dtpNgayGui.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dtpNgayGui.Checked = false;
            this.dtpNgayGui.Cursor = System.Windows.Forms.Cursors.No;
            this.dtpNgayGui.Enabled = false;
            this.dtpNgayGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayGui.Location = new System.Drawing.Point(285, 139);
            this.dtpNgayGui.Name = "dtpNgayGui";
            this.dtpNgayGui.Size = new System.Drawing.Size(216, 29);
            this.dtpNgayGui.TabIndex = 1;
            // 
            // btn_Gui
            // 
            this.btn_Gui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Gui.CheckButton = false;
            this.btn_Gui.Checked = false;
            this.btn_Gui.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btn_Gui.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Gui.CheckedImageTint = System.Drawing.Color.White;
            this.btn_Gui.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btn_Gui.Content = "Gửi";
            this.btn_Gui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gui.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Gui.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.btn_Gui.ForeColor = System.Drawing.Color.White;
            this.btn_Gui.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btn_Gui.HoveredImageTint = System.Drawing.Color.White;
            this.btn_Gui.HoverForeColor = System.Drawing.Color.White;
            this.btn_Gui.HoverOutline = System.Drawing.Color.Empty;
            this.btn_Gui.Image = null;
            this.btn_Gui.ImageAutoCenter = true;
            this.btn_Gui.ImageExpand = new System.Drawing.Point(0, 0);
            this.btn_Gui.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Gui.ImageTint = System.Drawing.Color.White;
            this.btn_Gui.Location = new System.Drawing.Point(220, 421);
            this.btn_Gui.Name = "btn_Gui";
            this.btn_Gui.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btn_Gui.NormalOutline = System.Drawing.Color.Empty;
            this.btn_Gui.OutlineThickness = 1.6F;
            this.btn_Gui.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btn_Gui.PressedForeColor = System.Drawing.Color.White;
            this.btn_Gui.PressedImageTint = System.Drawing.Color.White;
            this.btn_Gui.PressedOutline = System.Drawing.Color.Empty;
            this.btn_Gui.Rounding = new System.Windows.Forms.Padding(8);
            this.btn_Gui.Size = new System.Drawing.Size(87, 45);
            this.btn_Gui.TabIndex = 5;
            this.btn_Gui.TextOffset = new System.Drawing.Point(0, 0);
            this.btn_Gui.Click += new System.EventHandler(this.btn_Gui_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNoiDung.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoiDung.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtNoiDung.BorderSize = 1;
            this.txtNoiDung.Content = "";
            this.txtNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.ForeColor = System.Drawing.Color.Gray;
            this.txtNoiDung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNoiDung.Location = new System.Drawing.Point(285, 298);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.txtNoiDung.PasswordChar = false;
            this.txtNoiDung.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtNoiDung.PlaceholderText = "";
            this.txtNoiDung.Rounding = 8;
            this.txtNoiDung.Size = new System.Drawing.Size(216, 102);
            this.txtNoiDung.TabIndex = 4;
            this.txtNoiDung.TextOffset = new System.Drawing.Size(0, 0);
            this.txtNoiDung.UnderlinedStyle = false;
            this.txtNoiDung.Click += new System.EventHandler(this.txtNoiDung_Click);
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.Location = new System.Drawing.Point(106, 305);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(100, 24);
            this.lblNoiDung.TabIndex = 29;
            this.lblNoiDung.Text = "Nội Dung :";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Content = "";
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(285, 242);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(15, 12, 15, 0);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Rounding = 8;
            this.txtEmail.Size = new System.Drawing.Size(216, 39);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextOffset = new System.Drawing.Size(0, 0);
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(106, 255);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 24);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "Email :";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoDienThoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDienThoai.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtSoDienThoai.BorderSize = 1;
            this.txtSoDienThoai.Content = "";
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.ForeColor = System.Drawing.Color.Gray;
            this.txtSoDienThoai.Location = new System.Drawing.Point(285, 186);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDienThoai.Multiline = false;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Padding = new System.Windows.Forms.Padding(15, 12, 15, 0);
            this.txtSoDienThoai.PasswordChar = false;
            this.txtSoDienThoai.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtSoDienThoai.PlaceholderText = "";
            this.txtSoDienThoai.Rounding = 8;
            this.txtSoDienThoai.Size = new System.Drawing.Size(216, 39);
            this.txtSoDienThoai.TabIndex = 2;
            this.txtSoDienThoai.TextOffset = new System.Drawing.Size(0, 0);
            this.txtSoDienThoai.UnderlinedStyle = false;
            this.txtSoDienThoai.Click += new System.EventHandler(this.txtSoDienThoai_Click);
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(100, 196);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(140, 24);
            this.lblSoDienThoai.TabIndex = 25;
            this.lblSoDienThoai.Text = "Số Điện Thoại :";
            // 
            // lblNgayGui
            // 
            this.lblNgayGui.AutoSize = true;
            this.lblNgayGui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblNgayGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayGui.Location = new System.Drawing.Point(100, 141);
            this.lblNgayGui.Name = "lblNgayGui";
            this.lblNgayGui.Size = new System.Drawing.Size(98, 24);
            this.lblNgayGui.TabIndex = 24;
            this.lblNgayGui.Text = "Ngày Gửi :";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Content = "";
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(285, 71);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(15, 12, 15, 0);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Rounding = 8;
            this.txtUsername.Size = new System.Drawing.Size(216, 39);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextOffset = new System.Drawing.Size(0, 0);
            this.txtUsername.UnderlinedStyle = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(101, 81);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(107, 24);
            this.lblUser.TabIndex = 22;
            this.lblUser.Text = "Username :";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(187, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(210, 29);
            this.lblHeader.TabIndex = 21;
            this.lblHeader.Text = "Lấy Lại Mật Khẩu";
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
            this.btnBackLogin.Location = new System.Drawing.Point(544, 1);
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
            this.btnBackLogin.TabIndex = 6;
            this.btnBackLogin.TextOffset = new System.Drawing.Point(0, 0);
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // lbl_Loi
            // 
            this.lbl_Loi.AutoSize = true;
            this.lbl_Loi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lbl_Loi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lbl_Loi.ForeColor = System.Drawing.Color.Red;
            this.lbl_Loi.Location = new System.Drawing.Point(290, 110);
            this.lbl_Loi.Name = "lbl_Loi";
            this.lbl_Loi.Size = new System.Drawing.Size(20, 15);
            this.lbl_Loi.TabIndex = 30;
            this.lbl_Loi.Text = "loi";
            // 
            // btn_Error
            // 
            this.btn_Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Error.CheckButton = false;
            this.btn_Error.Checked = false;
            this.btn_Error.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Error.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Error.CheckedImageTint = System.Drawing.Color.White;
            this.btn_Error.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Error.Content = "";
            this.btn_Error.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Error.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Error.HoveredImageTint = System.Drawing.Color.White;
            this.btn_Error.HoverForeColor = System.Drawing.Color.White;
            this.btn_Error.HoverOutline = System.Drawing.Color.Empty;
            this.btn_Error.Image = global::GUI.Properties.Resources.remove;
            this.btn_Error.ImageAutoCenter = true;
            this.btn_Error.ImageExpand = new System.Drawing.Point(0, 0);
            this.btn_Error.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Error.ImageTint = System.Drawing.Color.White;
            this.btn_Error.Location = new System.Drawing.Point(267, 108);
            this.btn_Error.Name = "btn_Error";
            this.btn_Error.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Error.NormalOutline = System.Drawing.Color.Empty;
            this.btn_Error.OutlineThickness = 1.6F;
            this.btn_Error.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Error.PressedForeColor = System.Drawing.Color.White;
            this.btn_Error.PressedImageTint = System.Drawing.Color.White;
            this.btn_Error.PressedOutline = System.Drawing.Color.Empty;
            this.btn_Error.Rounding = new System.Windows.Forms.Padding(8);
            this.btn_Error.Size = new System.Drawing.Size(22, 21);
            this.btn_Error.TabIndex = 32;
            this.btn_Error.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // btn_Access
            // 
            this.btn_Access.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Access.CheckButton = false;
            this.btn_Access.Checked = false;
            this.btn_Access.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Access.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Access.CheckedImageTint = System.Drawing.Color.White;
            this.btn_Access.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Access.Content = "";
            this.btn_Access.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Access.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Access.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Access.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Access.HoveredImageTint = System.Drawing.Color.White;
            this.btn_Access.HoverForeColor = System.Drawing.Color.White;
            this.btn_Access.HoverOutline = System.Drawing.Color.Empty;
            this.btn_Access.Image = global::GUI.Properties.Resources._checked;
            this.btn_Access.ImageAutoCenter = true;
            this.btn_Access.ImageExpand = new System.Drawing.Point(0, 0);
            this.btn_Access.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Access.ImageTint = System.Drawing.Color.White;
            this.btn_Access.Location = new System.Drawing.Point(267, 108);
            this.btn_Access.Name = "btn_Access";
            this.btn_Access.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Access.NormalOutline = System.Drawing.Color.Empty;
            this.btn_Access.OutlineThickness = 1.6F;
            this.btn_Access.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btn_Access.PressedForeColor = System.Drawing.Color.White;
            this.btn_Access.PressedImageTint = System.Drawing.Color.White;
            this.btn_Access.PressedOutline = System.Drawing.Color.Empty;
            this.btn_Access.Rounding = new System.Windows.Forms.Padding(8);
            this.btn_Access.Size = new System.Drawing.Size(22, 21);
            this.btn_Access.TabIndex = 31;
            this.btn_Access.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // picBackForgotPass
            // 
            this.picBackForgotPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.picBackForgotPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackForgotPass.Location = new System.Drawing.Point(0, 0);
            this.picBackForgotPass.Name = "picBackForgotPass";
            this.picBackForgotPass.Size = new System.Drawing.Size(612, 477);
            this.picBackForgotPass.TabIndex = 19;
            this.picBackForgotPass.TabStop = false;
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 477);
            this.Controls.Add(this.btn_Error);
            this.Controls.Add(this.btn_Access);
            this.Controls.Add(this.lbl_Loi);
            this.Controls.Add(this.dtpNgayGui);
            this.Controls.Add(this.btn_Gui);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.lblNgayGui);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnBackLogin);
            this.Controls.Add(this.picBackForgotPass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuenMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            this.Load += new System.EventHandler(this.QuenMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackForgotPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayGui;
        private CuoreUI.Controls.cuiButton btn_Gui;
        private CuoreUI.Controls.cuiTextBox2 txtNoiDung;
        private System.Windows.Forms.Label lblNoiDung;
        private CuoreUI.Controls.cuiTextBox2 txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private CuoreUI.Controls.cuiTextBox2 txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblNgayGui;
        private CuoreUI.Controls.cuiTextBox2 txtUsername;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblHeader;
        private CuoreUI.Controls.cuiButton btnBackLogin;
        private System.Windows.Forms.PictureBox picBackForgotPass;
        private System.Windows.Forms.Label lbl_Loi;
        private CuoreUI.Controls.cuiButton btn_Access;
        private CuoreUI.Controls.cuiButton btn_Error;
    }
}