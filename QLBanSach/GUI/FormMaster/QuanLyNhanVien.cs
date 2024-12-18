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
        private StaffBLL staffBLLs;
        private StaffBLL nhanVienBLL = new StaffBLL();

        public QuanLyNhanVien(NguoiDung user)
        {
            taiKhoan = user;
            staffBLLs = new StaffBLL();
            InitializeComponent();
        }
        private void HienThiThongTin()
        {
            dtNhanVien = nhanVienBLL.HienThiThongTin();
            dgvThongTinNguoiDung.DataSource = dtNhanVien;
        }
        private void XoaThongTin()
        {
            txtMaNV.Clear();
            txtPass.Clear();
            txtTenNV.Clear();
            txtQueQuan.Clear();
            txtCCCD.Clear();
            txtSoDienThoai.Clear();
            cbTrangThai.SelectedIndex = 0;
            dtpNamSinh.Value = DateTime.Now;
        }
        private void ThemNhanVien()
        {
            // khởi tạo đối tượng Nhân Viên BLL
            StaffBLL staffBLL = new StaffBLL();
            // khởi tạo đối tượng nhan viên
            NhanVien nhanVien = new NhanVien();
            nhanVien.Pass = txtPass.Text.Trim();
            nhanVien.MaNV = txtMaNV.Text.Trim();
            nhanVien.TenNV = txtTenNV.Text.Trim();
            nhanVien.NamSinh = dtpNamSinh.Value;
            nhanVien.SoDienThoai = txtSoDienThoai.Text.Trim();
            nhanVien.QueQuan = txtQueQuan.Text.Trim();
            nhanVien.CCCD = txtCCCD.Text.Trim();
            // sự kiện kiểm tra giới tính
            if (cbTrangThai.SelectedIndex == 0)
                nhanVien.TrangThai = "Hoạt Động";
            else if (cbTrangThai.SelectedIndex == 1)
                nhanVien.TrangThai = "Tạm Ngưng";
            else if (cbTrangThai.SelectedIndex == 2)
                nhanVien.TrangThai = "Đã Nghỉ";
            else
                nhanVien.TrangThai = "Không Xác Định";
            
            // sự kiện gán thêm nhân viên vào
            string add_OK = staffBLL.ThemNhanVien(nhanVien);
            // sự kiện giá trị của bll null thì trả về KXD
            if (add_OK == null)
            {
                MessageBox.Show("Lỗi không xác định");
                return;
            }
            //Xử lý kết quả
            switch (add_OK)
            {
                case "addStaff_null_error":
                    MessageBox.Show("Tài khoản nhân viên lỗi null!");
                    return;
                case "error_Staff":
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin nhân viên.Mời bạn kiểm tra lại thông tin!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                case "staff_Add_Retail":
                    MessageBox.Show("Tài khoản nhân viên đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                case "add_Success":
                    MessageBox.Show("Chúc mừng bạn thêm thành công tài khoản nhân viên!");
                    HienThiThongTin();
                    XoaThongTin();
                    grbThongTinChiTiet.Enabled = false;
                    return;
                case "error_Add_Success":
                    MessageBox.Show("Lỗi khi thêm nhân viên!");
                    return;
                default:
                    MessageBox.Show("Kết quả không xác định: " + add_OK);
                    return;
            }
        }
        private void SuaNhanVien()
        {
            // khởi tạo đối tượng Nhân Viên BLL
            StaffBLL staffBLL = new StaffBLL();
            // khởi tạo đối tượng nhan viên
            NhanVien nhanVien = new NhanVien();
            nhanVien.Pass = txtPass.Text.Trim();
            nhanVien.MaNV = txtMaNV.Text.Trim();
            nhanVien.TenNV = txtTenNV.Text.Trim();
            nhanVien.NamSinh = dtpNamSinh.Value;
            nhanVien.SoDienThoai = txtSoDienThoai.Text.Trim();
            nhanVien.QueQuan = txtQueQuan.Text.Trim();
            nhanVien.CCCD = txtCCCD.Text.Trim();
            // sự kiện kiểm tra giới tính
            if (cbTrangThai.SelectedIndex == 0)
                nhanVien.TrangThai = "Hoạt Động";
            else if (cbTrangThai.SelectedIndex == 1)
                nhanVien.TrangThai = "Tạm Ngưng";
            else if (cbTrangThai.SelectedIndex == 2)
                nhanVien.TrangThai = "Đã Nghỉ";
            else
                nhanVien.TrangThai = "Không Xác Định";
            // sự kiện gán thêm nhân viên vào
            string edit_OK = staffBLL.SuaNhanVien(nhanVien);
            // sự kiện giá trị của bll null thì trả về KXD
            if (edit_OK == null)
            {
                MessageBox.Show("Lỗi không xác định");
                return;
            }
            //Xử lý kết quả
            switch(edit_OK)
            {
                case "edit_Success":
                    MessageBox.Show("Chỉnh sửa thông tin nhân viên thành công!");
                    XoaThongTin();
                    HienThiThongTin();

                    grbThongTinChiTiet.Enabled = false;
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                    return;
                case "error_Edit_Success":
                    MessageBox.Show("Lỗi khi chỉnh sửa nhân viên!");
                    return;
                case "editStaff_null_error":
                    MessageBox.Show("Tài khoản nhân viên lỗi null!");
                    return;
                default:
                    MessageBox.Show("Lỗi không xác định được: " + edit_OK);
                    return;
            }
        }
        private void XoaNhanVien()
        {
           // khởi tạo đối tượng Nhân Viên BLL
            StaffBLL staffBLL = new StaffBLL();
            // khởi tạo đối tượng nhan viên
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNV = txtMaNV.Text.Trim();
            string delete_OK = staffBLL.XoaNhanVien(nhanVien);
            // xử lý kết quả
            switch (delete_OK)
            {
                case "delete_Success":
                    MessageBox.Show("Xóa nhân viên thành công!");
                    HienThiThongTin();  // Cập nhật lại DataGridView
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                    return;
                case "error_Delete_Success":
                    MessageBox.Show("Lỗi khi xóa nhân viên.");
                    return;
                default:
                    MessageBox.Show("Có lỗi xảy ra khi xóa nhân viên.");
                    return;
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            chucNang = 1;
            XoaThongTin();
            grbThongTinChiTiet.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_TamNgung.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            chucNang = 2;
            grbThongTinChiTiet.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            XoaNhanVien();
        }

        private void btn_TamNgung_Click(object sender, EventArgs e)
        {
            TamNgungNhanVien();
        }
        private void TamNgungNhanVien()
        {
            // khởi tạo đối tượng Nhân Viên BLL
            StaffBLL staffBLL = new StaffBLL();
            // khởi tạo đối tượng nhan viên
            NhanVien nhanVien = new NhanVien();
            nhanVien.Pass = txtPass.Text.Trim();
            nhanVien.MaNV = txtMaNV.Text.Trim();
            nhanVien.TenNV = txtTenNV.Text.Trim();
            nhanVien.NamSinh = dtpNamSinh.Value;
            nhanVien.SoDienThoai = txtSoDienThoai.Text.Trim();
            nhanVien.QueQuan = txtQueQuan.Text.Trim();
            nhanVien.CCCD = txtCCCD.Text.Trim();
            // sự kiện kiểm tra giới tính
            if (cbTKTrangThai.SelectedIndex == 0)
            {
                nhanVien.TrangThai = "Hoạt Động";

            }
            else if (cbTKTrangThai.SelectedIndex == 1)
            {
                nhanVien.TrangThai = "Tạm Ngưng";
            }
            else if (cbTKTrangThai.SelectedIndex == 2)
            {
                nhanVien.TrangThai = "Đã Nghỉ";
            }
            else
            {
                nhanVien.TrangThai = "Không Xác Định";
            }
            // sự kiện gán thêm nhân viên vào
            string pause_OK = staffBLL.TamNgungNhanVien(nhanVien);
            // sự kiện giá trị của bll null thì trả về KXD
            if (pause_OK == null)
            {
                MessageBox.Show("Lỗi không xác định");
                return;
            }
            //Xử lý kết quả
            switch (pause_OK)
            {
                case "pause_Success":
                    MessageBox.Show("Tạm ngưng nhân viên thành công!");
                    XoaThongTin();
                    HienThiThongTin();

                    grbThongTinChiTiet.Enabled = false;
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                    return;
                case "error_Pause_Success":
                    MessageBox.Show("Lỗi khi tạm ngưng nhân viên!");
                    return;
                case "pauseStaff_null_error":
                    MessageBox.Show("Tài khoản nhân viên lỗi null!");
                    return;
                default:
                    MessageBox.Show("Lỗi không xác định được: " + pause_OK);
                    return;
            }
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
                QuanTri quanTri = new QuanTri(this.taiKhoan);
                quanTri.Show();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tenNV = txtTKTenNV.Text.Trim();
            string trangThai = cbTKTrangThai.Text.Trim();
            // Kiểm tra giá trị ComboBox
            //if (cbTKTrangThai.SelectedIndex == 0)
            //    trangThai = "Hoạt Động";
            //else if (cbTKTrangThai.SelectedIndex == 1)
            //    trangThai = "Tạm Ngưng";
            //else if (cbTKTrangThai.SelectedIndex == 2)
            //    trangThai = "Đã Nghỉ";
            //else
            //    trangThai = "Không Xác Định";
            
            DataTable dtTenNV = nhanVienBLL.TimKiemTenNV(tenNV);
            DataTable dtTrangThai = nhanVienBLL.TimKiemTrangThai(trangThai);
            if (dtTenNV.Rows.Count > 0)
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
            HienThiThongTin();
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
            DialogResult rs = MessageBox.Show("Bạn có muốn hủy bỏ thay đổi này không",
                "Hộp thoại",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                XoaThongTin();
                grbThongTinChiTiet.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }
        int vt = -1;
        private void dgvThongTinNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            dgvThongTinNguoiDung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataRow dtRow = dtNhanVien.Rows[vt];
            txtPass.Text = dtRow["Pass"].ToString().Trim();
            txtMaNV.Text = dtRow["MaNV"].ToString().Trim();
            txtTenNV.Text = dtRow["TenNV"].ToString().Trim();
            txtCCCD.Text = dtRow["CCCD"].ToString().Trim();
            txtSoDienThoai.Text = dtRow["SoDienThoai"].ToString().Trim();
            txtQueQuan.Text = dtRow["QueQuan"].ToString().Trim();
            if (dtRow["TrangThai"].ToString().Trim() == "Hoạt Động")
            {
                cbTrangThai.SelectedIndex = 0;
            }
            else if (dtRow["TrangThai"].ToString().Trim() == "Tạm Ngưng")
            {
                cbTrangThai.SelectedIndex = 1;
            }
            else if (dtRow["TrangThai"].ToString().Trim() == "Đã Nghỉ")
            {
                cbTrangThai.SelectedIndex = 2;
            }
            else
                cbTrangThai.SelectedIndex = 3;
            string[] a = dtRow["NamSinh"].ToString().Split(' ');
            string[] ns = a[0].Split('/');
            dtpNamSinh.Value = new DateTime(int.Parse(ns[2]), int.Parse(ns[0]), int.Parse(ns[1]));
            
            // hiển thị các btn khi click vào dgv
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_TamNgung.Enabled = true;
            grbThongTinChiTiet.Enabled = false;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            grbThongTinChiTiet.Enabled = false;
           
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_TamNgung.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
