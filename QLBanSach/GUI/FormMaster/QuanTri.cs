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
    public partial class QuanTri : Form
    {
        private NguoiDung taiKhoan;
        private NhanVien Staff;
        
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        
        public QuanTri(NguoiDung user)
        {
            InitializeComponent();
            taiKhoan = user;
            
        }
        
        private void btn_QLNguoiDung_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNguoiDung quanLyNguoiDung = new QuanLyNguoiDung(this.taiKhoan);
            quanLyNguoiDung.Show();
        }
        
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất tài khoản quản trị không?",
                "Hộp thoại",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Close();
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
            }
        }

        private void btn_QLSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySach quanLySach = new QuanLySach(this.taiKhoan);
            quanLySach.Show();
        }

        private void btn_ThongTinTK_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ThongTinTaiKhoan thongTinTaiKhoan = new ThongTinTaiKhoan(this.taiKhoan);
            thongTinTaiKhoan.Show();
        }

        private void btn_BaoCaoThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCaoThongKe baoCaoThongKe = new BaoCaoThongKe(this.taiKhoan);
            baoCaoThongKe.Show();
        }

        private void btn_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien(this.taiKhoan);
            quanLyNhanVien.Show();
        }
        
        
        private void KiemTraQuyenHan()
        {
            int maQuyen = taiKhoan.getMaQuyen();
            if (maQuyen == 1)
            {
                MessageBox.Show("Chào mừng Quản Trị Viên đến với trang quản trị!\n  Mời bạn sử dụng các chức năng",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                btn_QuanLyLoaiSach.Enabled = true;
                btn_BaoCaoThongKe.Enabled = true;
                btn_QLNguoiDung.Enabled = true;
                btn_QLSach.Enabled = true;
                btn_ThongTinTK.Enabled = true;
                btn_QuanLyNhanVien.Enabled = true;
            }
            else if (maQuyen == 2)
            {
                MessageBox.Show("Chào mừng Nhân Viên đến với trang quản trị!\n  Mời bạn sử dụng các chức năng",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                btn_QuanLyLoaiSach.Enabled = true;
                btn_BaoCaoThongKe.Enabled = true;
                btn_QLNguoiDung.Enabled = false;
                btn_QLSach.Enabled = true;
                btn_ThongTinTK.Enabled = true;
                btn_QuanLyNhanVien.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lỗi quyền khi hiển thị form quản trị!");
            }
        }
        private void QuanTri_Load(object sender, EventArgs e)
        {
            KiemTraQuyenHan();
            string user = taiKhoan.getHoVaTen();
            lblUser.Text = user;
        }

        private void btn_QuanLyLoaiSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLoaiSach quanLyLoaiSach = new QuanLyLoaiSach(this.taiKhoan);
            quanLyLoaiSach.Show();
        }

        private void btnThongTinTaiKhoanNV_Click(object sender, EventArgs e)
        {
            //ThongTinTaiKhoanStaff thongTinTaiKhoanStaff = new ThongTinTaiKhoanStaff();
            MessageBox.Show("Chức năng đang được phát triển!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
