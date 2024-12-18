using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormCustomer
{
    public partial class ThongTinCaNhan : Form
    {
        NguoiDung taiKhoan = new NguoiDung();
        Info_Account_MngBLL info_Account = new Info_Account_MngBLL();

        public ThongTinCaNhan(NguoiDung user)
        {
            taiKhoan = user;
            InitializeComponent();
        }

        private void LoadThongTin()
        {
            if (taiKhoan != null)
            {
                txtUser.Text = taiKhoan.Username;
                txtPass.Text = taiKhoan.Pass;
                txtHoTen.Text = taiKhoan.HoVaTen;
                // Gán giá trị cho ComboBox Giới Tính
                if (taiKhoan.GioiTinh == "Nam")
                {
                    cbGioiTinh.SelectedIndex = 0;
                }
                else if (taiKhoan.GioiTinh == "Nữ")
                {
                    cbGioiTinh.SelectedIndex = 1;
                }
                else
                {
                    cbGioiTinh.SelectedIndex = 2;
                }
                // Gán ngày sinh vào DateTimePicker
                string[] a = taiKhoan.NamSinh.ToString().Trim().Split(' ');
                string[] ns = a[0].Split('/');
                dtpNamSinh.Value = new DateTime(int.Parse(ns[2]), int.Parse(ns[0]), int.Parse(ns[1]));
                // Kiểm tra trước khi thao tác
                txtDiaChi.Text = taiKhoan.DiaChi;
                txtSoDienThoai.Text = taiKhoan.SoDienThoai;
            }
            else
            {
                MessageBox.Show("Lỗi: Không thể hiển thị thông tin tài khoản!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void btn_SuaTT_Click(object sender, EventArgs e)
        {
            Info_Account_MngBLL infoBLL = new Info_Account_MngBLL();
            NguoiDung user = new NguoiDung();

            user.Username = txtUser.Text;
            user.Pass = txtPass.Text;
            user.HoVaTen = txtHoTen.Text;
            user.SoDienThoai = txtSoDienThoai.Text;
            user.DiaChi = txtDiaChi.Text;
            // Kiểm tra giới tính
            if (cbGioiTinh.SelectedIndex == 0)
                user.GioiTinh = "Nam";
            else if (cbGioiTinh.SelectedIndex == 1)
                user.GioiTinh = "Nữ";
            else
                user.GioiTinh = "Không Xác Định";
            user.NamSinh = dtpNamSinh.Value;
            // sự kiện chỉnh sửa thông tin người dùng
            string Edit_OK = infoBLL.SuaTTTaiKhoanUser(user);
            if (Edit_OK == null)
            {
                MessageBox.Show("Lỗi không xác định");
            }
            switch (Edit_OK)
            {
                case "edit_Success":
                    {
                        MessageBox.Show("Chỉnh sửa thông tin người dùng thành công!\n Vui lòng thoát ra vào lại để cập nhật lại tài khoản sau khi chỉnh sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                        LoadThongTin();
                        return;
                    }
                case "error_Edit_Success":
                    {
                        MessageBox.Show("Lỗi khi chỉnh sửa người dùng!");
                        return;
                    }
                case "editUser_error_null":
                    {
                        MessageBox.Show("user null");
                        return;
                    }
                default:
                    MessageBox.Show("Lỗi không xác định được: " + Edit_OK);
                    return;
            }
        }
    }
}
