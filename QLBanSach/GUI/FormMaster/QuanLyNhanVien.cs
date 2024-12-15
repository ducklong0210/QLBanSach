using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI.FormMaster
{
    public partial class QuanLyNhanVien : Form
    {
        private NguoiDung taiKhoan;
        private DataTable dtNhanVien;
        NhanVien staff = new NhanVien();
        private StaffBLL staffBLL;
        private StaffBLL nhanVienBLL = new StaffBLL();

        public QuanLyNhanVien()
        {
            staffBLL = new StaffBLL();
            InitializeComponent();
        }
        private void HienThiThongTin()
        {
            dtNhanVien = nhanVienBLL.HienThiThongTin();
            dgvThongTinNguoiDung.DataSource = dtNhanVien;
        }
        private void XoaThongTin()
        {

        }
        private void ThemNhanVien()
        {

        }
        private void SuaNhanVien()
        {

        }
        private void XoaNhanVien()
        {

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            chucNang = 1;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            chucNang = 2;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            XoaNhanVien();
        }

        private void btn_TamNgung_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tenNV = txtTKTenNV.Text;
            string trangThai = cbTKTrangThai.Text.Trim();
            if (cbTKTrangThai.SelectedIndex == 0)
            {
                trangThai = "Hoạt Động";
            }
            else if(cbTKTrangThai.SelectedIndex == 1)
            {
                trangThai = "Tạm Ngưng";
            }    
            else if(cbTKTrangThai.SelectedIndex == 2)
                    {
                trangThai = "Đã Nghỉ";
            }
            else
            {
                trangThai = "Không Xác Định";
            }
            DataTable dtTenNV = nhanVienBLL.TimKiemTenNV(tenNV);
            DataTable dtTrangThai = nhanVienBLL.TimKiemTrangThai(trangThai);
            if(dtTenNV.Rows.Count > 0)
            {
                dgvThongTinNguoiDung.DataSource = dtTenNV;
            }
            else if (dtTrangThai.Rows.Count > 0)
            {
                dgvThongTinNguoiDung.DataSource= dtTrangThai;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên");
                dgvThongTinNguoiDung.DataSource = dtNhanVien;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        int chucNang = 0;
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(chucNang == 1)
            {
                ThemNhanVien();
            }
            if(chucNang == 2)
            {
                SuaNhanVien();
            }    
        }
        
        private void btn_Huy_Click(object sender, EventArgs e)
        {

        }

        private void dgvThongTinNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
        }
        
    }
}
