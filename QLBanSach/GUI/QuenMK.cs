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
            
            dtpNgayGui.Value = DateTime.Now;
            quenMatKhau.Username = txtUsername.Content.Trim();
            quenMatKhau.NgayGui = dtpNgayGui.Value;
            quenMatKhau.NoiDung = txtNoiDung.Content.Trim();
            quenMatKhau.Email = txtEmail.Content.Trim();
            quenMatKhau.SoDienThoai = txtSoDienThoai.Content.Trim();
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
                    return;
                case "forgotPass_Fail":
                    MessageBox.Show("Lỗi không thể gửi được yêu cầu!");
                    return;
                default:
                    MessageBox.Show("Lỗi không xác định được: " + layLaiThanhCong);
                    return;
            }


        }

        private void btn_Gui_Click(object sender, EventArgs e)
        {
            LayLaiMK();
        }

        private void QuenMK_Load(object sender, EventArgs e)
        {

        }
    }
}
