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
    public partial class ThongTinTaiKhoan : Form
    {
        NguoiDung taiKhoan = new NguoiDung();
        Info_Account_MngBLL info_Account = new Info_Account_MngBLL();
        
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
                if (cbGioiTinh.Text == "Nam")
                {
                    cbGioiTinh.SelectedIndex = 0;
                }
                else if (cbGioiTinh.Text == "Nữ")
                {
                    cbGioiTinh.SelectedIndex = 1;
                }
                else
                {     
                    cbGioiTinh.SelectedIndex = 2;
                }
                // Gán ngày sinh vào DateTimePicker
                //string[] a = dtpNamSinh.ToString().Trim().Split(' ');
                //string[] ns = a[0].Split('/');
                //dtpNamSinh.Value = new DateTime(int.Parse(ns[2]), int.Parse(ns[0]), int.Parse(ns[1]));
                // Kiểm tra trước khi thao tác
                if (DateTime.TryParse(dtpNamSinh.Text, out DateTime dateValue))
                {
                    // Lấy ngày, tháng, năm từ DateTime
                    int year = dateValue.Year;
                    int month = dateValue.Month;
                    int day = dateValue.Day;

                    // Cập nhật lại giá trị của dtpNamSinh
                    dtpNamSinh.Value = new DateTime(year, month, day);
                }
                else
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.");
                }


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
        private void btn_SuaTT_Click(object sender, EventArgs e)
        {

        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
    }
}
