using System.Drawing;

namespace GUI
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblHeaderLogin = new System.Windows.Forms.Label();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.llblFogotPass = new System.Windows.Forms.LinkLabel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.picLoginAvt = new System.Windows.Forms.PictureBox();
            this.btn_Login = new CuoreUI.Controls.cuiButton();
            this.txtUsername = new CuoreUI.Controls.cuiTextBox2();
            this.txtPassword = new CuoreUI.Controls.cuiTextBox2();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.lblDangKy = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginAvt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsername.Location = new System.Drawing.Point(284, 147);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 24);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword.Location = new System.Drawing.Point(283, 206);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 24);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password :";
            // 
            // lblHeaderLogin
            // 
            this.lblHeaderLogin.AutoSize = true;
            this.lblHeaderLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeaderLogin.Location = new System.Drawing.Point(155, 32);
            this.lblHeaderLogin.Name = "lblHeaderLogin";
            this.lblHeaderLogin.Size = new System.Drawing.Size(388, 29);
            this.lblHeaderLogin.TabIndex = 0;
            this.lblHeaderLogin.Text = "Welcome to Book Store Group 4";
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPass.Location = new System.Drawing.Point(455, 235);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(139, 21);
            this.chkShowPass.TabIndex = 2;
            this.chkShowPass.Text = "Show Password";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // llblFogotPass
            // 
            this.llblFogotPass.AutoSize = true;
            this.llblFogotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblFogotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblFogotPass.LinkColor = System.Drawing.SystemColors.Desktop;
            this.llblFogotPass.Location = new System.Drawing.Point(444, 338);
            this.llblFogotPass.MaximumSize = new System.Drawing.Size(161, 0);
            this.llblFogotPass.Name = "llblFogotPass";
            this.llblFogotPass.Size = new System.Drawing.Size(123, 18);
            this.llblFogotPass.TabIndex = 5;
            this.llblFogotPass.TabStop = true;
            this.llblFogotPass.Text = "Forgot Password";
            this.llblFogotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblFogotPass_LinkClicked);
            this.llblFogotPass.MouseLeave += new System.EventHandler(this.llblFogotPass_MouseLeave);
            this.llblFogotPass.MouseHover += new System.EventHandler(this.llblFogotPass_MouseHover);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.picLoginAvt);
            this.panelLogin.Location = new System.Drawing.Point(21, 150);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(242, 153);
            this.panelLogin.TabIndex = 1;
            // 
            // picLoginAvt
            // 
            this.picLoginAvt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLoginAvt.Image = global::GUI.Properties.Resources.book_login;
            this.picLoginAvt.Location = new System.Drawing.Point(0, 0);
            this.picLoginAvt.Name = "picLoginAvt";
            this.picLoginAvt.Size = new System.Drawing.Size(242, 153);
            this.picLoginAvt.TabIndex = 0;
            this.picLoginAvt.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.CheckButton = false;
            this.btn_Login.Checked = false;
            this.btn_Login.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btn_Login.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Login.CheckedImageTint = System.Drawing.Color.White;
            this.btn_Login.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btn_Login.Content = "SignIn";
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Login.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Login.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btn_Login.HoveredImageTint = System.Drawing.Color.White;
            this.btn_Login.HoverForeColor = System.Drawing.Color.White;
            this.btn_Login.HoverOutline = System.Drawing.Color.Empty;
            this.btn_Login.Image = null;
            this.btn_Login.ImageAutoCenter = true;
            this.btn_Login.ImageExpand = new System.Drawing.Point(0, 0);
            this.btn_Login.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Login.ImageTint = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(306, 279);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.btn_Login.NormalOutline = System.Drawing.Color.Empty;
            this.btn_Login.OutlineThickness = 1.6F;
            this.btn_Login.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btn_Login.PressedForeColor = System.Drawing.Color.White;
            this.btn_Login.PressedImageTint = System.Drawing.Color.White;
            this.btn_Login.PressedOutline = System.Drawing.Color.Empty;
            this.btn_Login.Rounding = new System.Windows.Forms.Padding(8);
            this.btn_Login.Size = new System.Drawing.Size(251, 40);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.TextOffset = new System.Drawing.Point(0, 0);
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Content = "";
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(425, 140);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(16, 7, 16, 0);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Rounding = 8;
            this.txtUsername.Size = new System.Drawing.Size(168, 31);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextOffset = new System.Drawing.Size(0, 0);
            this.txtUsername.UnderlinedStyle = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Content = "";
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(429, 201);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(16, 7, 16, 0);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Rounding = 8;
            this.txtPassword.Size = new System.Drawing.Size(168, 31);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextOffset = new System.Drawing.Size(0, 0);
            this.txtPassword.UnderlinedStyle = false;
            this.txtPassword.ContentChanged += new System.EventHandler(this.txtPassword_ContentChanged);
            // 
            // picLogin
            // 
            this.picLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogin.Image = global::GUI.Properties.Resources.background;
            this.picLogin.Location = new System.Drawing.Point(0, 0);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(730, 408);
            this.picLogin.TabIndex = 7;
            this.picLogin.TabStop = false;
            // 
            // lblDangKy
            // 
            this.lblDangKy.AutoSize = true;
            this.lblDangKy.BackColor = System.Drawing.SystemColors.Control;
            this.lblDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDangKy.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKy.Location = new System.Drawing.Point(294, 338);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(133, 18);
            this.lblDangKy.TabIndex = 4;
            this.lblDangKy.Text = "Create to Account?";
            this.lblDangKy.Click += new System.EventHandler(this.lblDangKy_Click_1);
            this.lblDangKy.MouseLeave += new System.EventHandler(this.lblDangKy_MouseLeave);
            this.lblDangKy.MouseHover += new System.EventHandler(this.lblDangKy_MouseHover);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 408);
            this.Controls.Add(this.lblDangKy);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.llblFogotPass);
            this.Controls.Add(this.chkShowPass);
            this.Controls.Add(this.lblHeaderLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoginAvt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.Label lblHeaderLogin;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.LinkLabel llblFogotPass;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox picLoginAvt;
        private CuoreUI.Controls.cuiButton btn_Login;
        private CuoreUI.Controls.cuiTextBox2 txtUsername;
        private CuoreUI.Controls.cuiTextBox2 txtPassword;
        private System.Windows.Forms.Label lblDangKy;
    }
}