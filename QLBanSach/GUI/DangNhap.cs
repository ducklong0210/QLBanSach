using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using DTO;
using GUI.FormCustomer;
using GUI.FormMaster;
namespace GUI
{
    public partial class DangNhap : Form
    {
        private NguoiDung taiKhoan;
        private TaiKhoanBLL taiKhoanBLL;
        public DangNhap()
        {
            InitializeComponent();
            //Làm mất backgroud của lbl
            lblHeaderLogin.Parent = picLogin;
            lblHeaderLogin.BackColor = Color.Transparent;
            lblPassword.Parent = picLogin;
            lblPassword.BackColor = Color.Transparent;
            lblUsername.Parent = picLogin;
            lblUsername.BackColor = Color.Transparent;
            chkShowPass.Parent = picLogin;
            chkShowPass.BackColor = Color.Transparent;
            llblFogotPass.Parent = picLogin;
            llblFogotPass.BackColor = Color.Transparent;
            btn_Login.Parent = picLogin;
            btn_Login.BackColor = Color.Transparent;
            btn_Register.Parent = picLogin;
            btn_Register.BackColor = Color.Transparent;
           
        }

        // sự kiện đăng nhập
        NguoiDung user = new NguoiDung();
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        Info_Account_MngBLL info_Account = new Info_Account_MngBLL();
        NhanVien staff = new NhanVien();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            user.Username = txtUsername.Content;
            user.Pass = txtPassword.Content;
            staff.MaNV =txtUsername.Content;
            staff.Pass = txtPassword.Content;
            string checkUser = tkBLL.CheckLogin(user);
            //string checkStaff = tkBLL.CHeckLoginStaff(staff);
            // check các sự kiện đăng nhập lấy từ BLL-TaiKhoanBLL
            switch (checkUser)
            {
                case "sukien_taikhoan":
                    {
                        MessageBox.Show("Tài khoản không được để trống!");
                        return;
                    }
                case "sukien_matkhau":
                    {
                        MessageBox.Show("Mật khẩu không được để trống!");
                        return;
                    }
                case "taikhoan_fail":
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                        return;
                    }
            }
            //switch (checkStaff)
            //{
            //    case "taikhoan_fail":
            //        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            //        return;
            //    case "taikhoan_staff_null":
            //        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin tài khoản nhân viên!",
            //            "Thông báo",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Warning);
            //        return;
            //    case "login_true":
            //        MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công");
            //        return;
            //}
            MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công");

            this.Hide();
            int maQuyen = user.getMaQuyen();  // Lấy giá trị MaQuyen từ đối tượng user

            if (maQuyen == 0)
            {
                // Nếu MaQuyen = 0, người dùng sẽ vào Trang Chủ
                FrmNguoiDung();
            }
            else if (maQuyen == 1)
            {
                // Nếu MaQuyen = 1, người dùng sẽ vào trang Quản Trị
                FrmQuanTriVien();
            }
            else if(maQuyen == 2)
            {
                FrmQuanTriVien();
            }    
            else
            {
                // Kiểm tra với các mã quyền khác nếu có
                MessageBox.Show("Mã quyền không hợp lệ.");
            }
        }
        //lay thong tin nguoi dung
        private void FrmQuanTriVien()
        {
            string username = txtUsername.Content;
            Info_Account_MngBLL info = new Info_Account_MngBLL();
            NguoiDung user = info.Check_InFo_Account(username);
            if(user != null)
            {
                QuanTri quanTri = new QuanTri(user);
                quanTri.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng với username này.");
            }
        }
        // lay thong tin nguoi dung
        private void FrmNguoiDung()
        {
            string username = txtUsername.Content;
            Info_Account_MngBLL info = new Info_Account_MngBLL();
            NguoiDung user = info.Check_InFo_Account(username);
            if (user != null)
            {
                TrangChu trangChu = new TrangChu(user);
                trangChu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng với username này.");
            }
        }

        // Hiển thị password khi click vào sự kiện hiện mật khẩu
        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked) 
            {
                txtPassword.PasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = true;
            }
        }

        private void llblFogotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMK quenMK = new QuenMK();
            quenMK.Show();
        }

        // sự kiện nuts đâng ký
        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
            this.Show();
        }

        private void txtPassword_ContentChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = true;
        }
    }
}
