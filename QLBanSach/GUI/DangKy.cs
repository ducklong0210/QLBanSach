using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            //làm mất backgroud của các lbl
            lblHeaderRegister.Parent = picBackRegister;
            lblHeaderRegister.BackColor = Color.Transparent;
            grbRegister.Parent = picBackRegister;
            grbRegister.BackColor = Color.Transparent;
       
        }
        
        
        // sự kiện đăng ký tài khoản
        private void btnRegister_Click(object sender, EventArgs e)
        {
            NguoiDung user = new NguoiDung();
            RegisterBLL DKBLL = new RegisterBLL();
            string tentk = txtUsername.Text;
            string pass = txtpassword.Text;
            user.Username = txtUsername.Text;
            user.Pass = txtpassword.Text;
            user.HoVaTen = txtFullname.Text;
            user.NamSinh = dtpNgaySinh.Value;

            if (cbGioiTinh.SelectedIndex == 0)
                user.GioiTinh = "Nam";
            else if (cbGioiTinh.SelectedIndex == 1)
                user.GioiTinh = "Nữ";
            else
                user.GioiTinh = "Không Xác Định";
            user.DiaChi = txtDiaChi.Text;
            user.SoDienThoai = txtSoDienThoai.Text;
            string CheckRegister = DKBLL.CheckRegister(user);

            // Sự kiện yêu cầu người dùng nhập đúng định dạng tài khoản và mật khẩu
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtFullname.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text) ||
                string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin!");

            }
            else if (!DKBLL.CheckAccount(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản có độ dài 6-24 ký tự, với các ký tự và chữ số,chữ hoa và chữ thường!");
            }
            else if (!DKBLL.CheckAccount(pass))
            {
                MessageBox.Show("Vui lòng mật khẩu có độ dài 6-24 ký tự, với các ký tự và chữ số,chữ hoa và chữ thường!");
            }
            else
            {
            switch (CheckRegister)
                {
                
                
                case "register_access":
                    {
                       XoaDuLieu();
                        MessageBox.Show("Đăng ký tài khoản thành công!");
                       DialogResult result = MessageBox.Show("Bạn có muốn trở lại trang đăng nhập không",
                            "Hỏi Thoát",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question);
                            if(result == DialogResult.Yes)
                            {
                                this.Close();
                            }
                        return;
                    }
                case "register_retail":
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!");
                        return;
                    }
                case "error":
                    {
                        MessageBox.Show("Đăng ký tài khoản không thành công ");
                        return;
                    }
                default:
                    {
                        MessageBox.Show("Lỗi không xác định" + CheckRegister);
                        return;
                    }
                }
            }
        }
        // sự kiện check xem tài khoản và mật khẩu nhập đúng định dạng chưa
        
       

        //Sự kiện xóa dữ liệu khi người dùng đăng ký tài khoản thành công
        private void XoaDuLieu()
        {
            txtUsername.Clear();
            txtpassword.Clear();
            txtFullname.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            cbGioiTinh.SelectedIndex = 2;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnBackLogin_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
