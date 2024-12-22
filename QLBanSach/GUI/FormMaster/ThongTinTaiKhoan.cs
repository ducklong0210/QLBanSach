using BLL;
using DTO;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Microsoft.SqlServer.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormMaster
{
    public partial class ThongTinTaiKhoan : Form
    {
        NguoiDung taiKhoan = new NguoiDung();
        Info_Account_MngBLL info_Account = new Info_Account_MngBLL();
        NhanVien Staff = new NhanVien();
        public ThongTinTaiKhoan(NguoiDung user)
        {
            InitializeComponent();
            this.taiKhoan = user;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có trở về trang quản trị không?",
                "Hộp thoại",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                Close();
                QuanTri quanTri = new QuanTri(this.taiKhoan);
                quanTri.Show();
            }
        }
        
        private void LoadThongTin()
        {
            if (taiKhoan != null)
            {
                txtMaND.Text = taiKhoan.MaND.ToString();
                txtUser.Text = taiKhoan.Username;
                txtPass.Text = taiKhoan.Pass;
                txtHoTen.Text = taiKhoan.HoVaTen;
                txtQuyenHan.Text = taiKhoan.MaQuyen.ToString();
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
        private void SuaThongTin()
        {
            Info_Account_MngBLL infoBLL = new Info_Account_MngBLL();
            NguoiDung user = new NguoiDung();

            user.MaND = int.Parse(txtMaND.Text);
            user.Username = txtUser.Text;
            user.Pass = txtPass.Text;
            user.HoVaTen = txtHoTen.Text;
            user.MaQuyen = int.Parse(txtQuyenHan.Text);
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

            string Edit_OK = infoBLL.SuaTTNguoiDung(user);
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
        private void btn_SuaTT_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn sửa thông tin tài khoản cá nhân không ?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                SuaThongTin();
            }
        }
        
        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            txtQuyenHan.Enabled = false;
        }

       

        private void txtQuyenHan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng không nên chỉnh sửa thông tin quyền hạn của mình!",
                "Cảnh báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
