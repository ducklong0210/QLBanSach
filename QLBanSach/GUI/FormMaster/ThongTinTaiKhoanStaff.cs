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

namespace GUI.FormMaster
{
    public partial class ThongTinTaiKhoanStaff : Form
    {
        NhanVien Staff = new NhanVien();
        Info_Account_MngBLL info_Account = new Info_Account_MngBLL();

        public ThongTinTaiKhoanStaff(NhanVien staff)
        {
            this.Staff = staff;
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có trở về trang quản trị không?",
                "Hộp thoại",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Close();
                //QuanTri quanTri = new QuanTri(this.taiKhoan);
                //quanTri.Show();
            }
        }
        private void LoadThongTin()
        {
            if(Staff != null)
            {
                txtMaNV.Text = Staff.MaNV;
                txtPass.Text = Staff.Pass;
                txtTenNV.Text = Staff.TenNV;
                txtCCCD.Text = Staff.CCCD;
                txtQueQuan.Text = Staff.QueQuan;
                txtSoDienThoai.Text = Staff.SoDienThoai;
                if (Staff.TrangThai == "Hoạt Động")
                    cbTrangThai.SelectedIndex = 0;
                else if (Staff.TrangThai == "Tạm Ngưng")
                    cbTrangThai.SelectedIndex = 1;
                else if (Staff.TrangThai == "Đã Nghỉ")
                    cbTrangThai.SelectedIndex = 2;
                else
                    cbTrangThai.SelectedIndex = 3;
                string[] a = Staff.NamSinh.ToString().Trim().Split(' ');
                string[] ns = a[0].Split('/');
                dtpNamSinh.Value = new DateTime(int.Parse(ns[2]), int.Parse(ns[0]), int.Parse(ns[1]));
            }
            else
            {
                MessageBox.Show("Lỗi: Không thể hiển thị thông tin tài khoản nhân viên!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ThongTinTaiKhoanStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
