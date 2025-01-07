using BLL;
using DTO;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
            if (btn_Error.Visible == true)
            {
                MessageBox.Show("Tên tài khoản không tồn tại trong hệ thống.\n Mời bạn nhập lại tên tài khoản chính xác!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            else
                switch (layLaiThanhCong)
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
                            MessageBox.Show("Mật khẩu của bạn là: =>  " + "'" + password + "'");
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
            switch (check_OK)
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
                    btn_Access.Visible = false;
                    lbl_Loi.ForeColor = Color.Red;
                    return;
                case "null_Username":
                    MessageBox.Show("Lỗi username null");
                    return;
                default:
                    MessageBox.Show("Lỗi không xác định được: " + check_OK);
                    return;
            }
        }

        private void CheckSdt()
        {
            ForgotPassBLL forgotPassBLL = new ForgotPassBLL();
            string sdt = txtSoDienThoai.Content.Trim();
            string users = txtUsername.Content.Trim();
            string check_OK = forgotPassBLL.CheckSdt(users);
            if (KiemTraSDT(sdt))
            {

                if (string.IsNullOrEmpty(sdt) && string.IsNullOrEmpty(check_OK) && sdt.Trim() == check_OK.Trim())
                {
                    btn_Sdt_Yes.Visible = true;
                    btn_Sdt_No.Visible = false;

                }
                else if (string.IsNullOrEmpty(sdt) && string.IsNullOrEmpty(check_OK) && sdt.Trim() != check_OK.Trim())
                {
                    MessageBox.Show("Bạn nhập sai số điện thoại.");
                    btn_Sdt_No.Visible = true;
                    btn_Sdt_Yes.Visible = false;
                }
                else
                    MessageBox.Show("Bạn nhập sai Username.");
            }
            else if (string.IsNullOrEmpty(sdt))
            {
                btn_Sdt_No.Visible = false;
                btn_Sdt_Yes.Visible = false;
            }
            else
                MessageBox.Show("Lỗi không nhập đúng định dạng số điện thoại.");

        }
        //Kiểm tra số điện thoại
        private bool KiemTraSDT(string sdt)
        {
            string dieuKien = @"^[0-9]{10,13}$";
            return Regex.IsMatch(sdt, dieuKien);
        }
        private void btn_Gui_Click(object sender, EventArgs e)
        {
            if (txtUsername.Content == "")
            {
                btn_Access.Visible = false;
                btn_Error.Visible = false;
                lbl_Loi.Visible = false;
            }
            if (txtSoDienThoai.Content == "")
            {
                btn_Sdt_Yes.Visible = false;
                btn_Sdt_No.Visible = false;
            }
            CheckUsername();
            CheckSdt();
            if (btn_Access.Visible == true && btn_Sdt_Yes.Visible == true)
            {
                LayLaiMK();
            }

        }

        private void QuenMK_Load(object sender, EventArgs e)
        {
            btn_Access.Visible = false;
            btn_Error.Visible = false;
            lbl_Loi.Visible = false;
            btn_Sdt_Yes.Visible = false;
            btn_Sdt_No.Visible = false;
        }



        private void txtNoiDung_Click(object sender, EventArgs e)
        {
            CheckUsername();
            CheckSdt();
        }

        private void txtSoDienThoai_Click(object sender, EventArgs e)
        {
            CheckUsername();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            CheckUsername();
            CheckSdt();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            CheckSdt();
        }
    }
}
