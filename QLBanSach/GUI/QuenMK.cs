using BLL;
using DTO;
using GUI.FormMaster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }
        
        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn quay lại trang đăng nhập tài khoản không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Close();
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
            }
        }

        private void XoaThongTin()
        {
            txtUsername.Content = "";
            txtEmail.Content = "";
            txtNoiDung.Content = "";
            txtSoDienThoai.Content = "";
            dtpNgayGui.Value = DateTime.Now;
        }
        private void LayLaiMK()
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            ForgotPassBLL forgotPassBLL = new ForgotPassBLL();
            string users = txtUsername.Content.Trim();
            dtpNgayGui.Value = DateTime.Now;
            quenMatKhau.Username = txtUsername.Content.Trim();
            quenMatKhau.NgayGui = dtpNgayGui.Value;
            quenMatKhau.NoiDung = txtNoiDung.Content.Trim();
            quenMatKhau.Email = txtEmail.Content.Trim();
            quenMatKhau.SoDienThoai = txtSoDienThoai.Content.Trim();

            string password = forgotPassBLL.GetPassword(users);
            string layLaiThanhCong = forgotPassBLL.GuiThongTin(quenMatKhau);
            switch(layLaiThanhCong) 
            {
                case "error_forgotPass":
                    MessageBox.Show("Tên tài khoản không có trong hệ thống!\nVui lòng kiểm tra lại tên tài khoản.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                case "forgotPass_null":
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin tài khoản!");
                    return;
                case "forgotPass_Access":
                    MessageBox.Show("Bạn đã gửi yêu cầu lấy lại mật khẩu thành công.\n Bạn vui lòng chờ trong chốc lát!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    XoaThongTin();
                  
                    if (!string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Mật khẩu của bạn là: =>  " +"' "+ password +" '");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không lấy được mật khẩu!");
                    }
                    return;
                case "forgotPass_Fail":
                    MessageBox.Show("Lỗi không thể gửi được yêu cầu!");
                    return;
                default:
                    MessageBox.Show("Lỗi không xác định được: " + layLaiThanhCong);
                    return;
            }

        }
        private void CheckUsername()
        {
            ForgotPassBLL forgotPassBLL = new ForgotPassBLL();
            string users = txtUsername.Content.Trim();
            if (string.IsNullOrEmpty(users))
            {
                MessageBox.Show("Vui lòng nhập username.", 
                    "Thông báo", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                btn_Access.Visible = false;
                btn_Error.Visible = false;
                lbl_Loi.Visible = false;
                return;
            }
            string check_OK = forgotPassBLL.CheckUsername(users);
            switch(check_OK)
            {
                case "check_Access":
                    lbl_Loi.Visible = true;
                    lbl_Loi.Text = "Tên người dùng tồn tại.";
                    btn_Access.Visible = true;
                    btn_Error.Visible = false;
                    lbl_Loi.ForeColor = Color.LimeGreen;
                    return;
                case "error_Check":
                    lbl_Loi.Visible = true;
                    lbl_Loi.Text = "Tên tài khoản bạn nhập chưa tồn tại trên hệ thống!";
                    btn_Error.Visible = true;
                    btn_Access.Visible  = false;
                    lbl_Loi.ForeColor = Color.Red;
                    return;
                case "null_Username":
                    MessageBox.Show("Lỗi username null");
                    return;
                default:
                    MessageBox.Show("Lỗi không xác định được: " +  check_OK);
                    return;
            }
        }
        //private void CheckPassword()
        //{
        //    ForgotPassBLL forgotPassBLL = new ForgotPassBLL();
        //    string users = txtUsername.Content.Trim();
           
        //    string check_OK = forgotPassBLL.CheckPassword(users);
        //    switch (check_OK)
        //    {
        //        case password:
        //            MessageBox.Show("Mật khẩu của bạn là: " + check_OK);
        //            return;
        //        case "error_Check":
        //            MessageBox.Show("Tên tài khoản bạn nhập chưa tồn tại trên hệ thống!");
        //            return;
        //        case "null_Username":
        //            MessageBox.Show("Lỗi username null");
        //            return;
        //        default:
        //            MessageBox.Show("Lỗi không xác định được: " + check_OK);
        //            return;
        //    }
        //}

        private void btn_Gui_Click(object sender, EventArgs e)
        {
            if(txtUsername.Content == "")
            {
                btn_Access.Visible = false;
                btn_Error.Visible = false;
                lbl_Loi.Visible = false;
            }    
            LayLaiMK();
            
        }

        private void QuenMK_Load(object sender, EventArgs e)
        {
            btn_Access.Visible = false;
            btn_Error.Visible = false;
            lbl_Loi.Visible = false;
        }

       

        private void txtNoiDung_Click(object sender, EventArgs e)
        {
            CheckUsername();
        }

        private void txtSoDienThoai_Click(object sender, EventArgs e)
        {
            CheckUsername();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            CheckUsername();
        }
    }
}
