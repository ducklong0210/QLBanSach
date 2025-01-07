using BLL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.FormMaster
{
    public partial class QuanLyLoaiSach : Form
    {
        private NguoiDung taiKhoan;
        private DataTable dtLoaiSach;
        private BookBLL bookBLLs = new BookBLL();
        public QuanLyLoaiSach(NguoiDung user)
        {
            taiKhoan = user;
            InitializeComponent();
        }
        int chucNang = 0;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chucNang == 1)
            {
                ThemLoaiSach();
            }
            if (chucNang == 2)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn sửa thông tin loại sách không ?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    SuaTTLoaiSach();
                }
            }
        }
        private void ThemLoaiSach()
        {
            BookBLL bookBLL = new BookBLL();
            LoaiSach loaiSach = new LoaiSach();
            loaiSach.MaLoaiSach = txtMaLoaiSach.Text;
            loaiSach.TenLoaiSach = txtTenLoaiSach.Text;
            loaiSach.NgayThem = dtpNgayThem.Value;
            string Add_OK = bookBLL.ThemLoaiSach(loaiSach);
            switch (Add_OK)
            {
                case "error_LoaiSach":
                    {
                        MessageBox.Show("Bạn chưa điền đầy đủ thông tin.Mời bạn kiểm tra lại thông tin!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                case "error_null_LoaiSach":
                    {
                        MessageBox.Show("Lỗi null loại sách!");
                        return;
                    }
                case "add_Success":
                    {
                        MessageBox.Show(" Chúc mừng bạn thêm loại sách thành công!");
                        HienThiLoaiSach();
                        XoaThongTin();
                        grbThongTinChiTiet.Enabled = false;
                        return;
                    }
                case "error_Add_Success":
                    {
                        MessageBox.Show("Lỗi không thêm được loại sách!");
                        return;
                    }
                default:
                    MessageBox.Show("Lỗi không xác định được" + Add_OK);
                    return;
            }
        }
        private void SuaTTLoaiSach()
        {
            BookBLL bookBLL = new BookBLL();
            LoaiSach loaiSach = new LoaiSach();
            loaiSach.MaLoaiSach = txtMaLoaiSach.Text;
            loaiSach.TenLoaiSach = txtTenLoaiSach.Text;
            loaiSach.NgayThem = dtpNgayThem.Value;
            string Edit_OK = bookBLL.SuaLoaiSach(loaiSach);
            switch (Edit_OK)
            {

                case "error_null_LoaiSach":
                    {
                        MessageBox.Show("Lỗi null loại sách!");
                        return;
                    }
                case "edit_Success":
                    {
                        MessageBox.Show(" Chúc mừng bạn sửa loại sách thành công!");
                        HienThiLoaiSach();
                        XoaThongTin();
                        grbThongTinChiTiet.Enabled = false;
                        return;
                    }
                case "error_Edit_Success":
                    {
                        MessageBox.Show("Lỗi không sửa được loại sách!");
                        return;
                    }
                default:
                    MessageBox.Show("Lỗi không xác định được" + Edit_OK);
                    return;
            }
        }
        // Xoa loại sách
        private void XoaLoaiSach()
        {
            BookBLL bookBLL = new BookBLL();
            LoaiSach loaiSach = new LoaiSach();
            loaiSach.MaLoaiSach = txtMaLoaiSach.Text;

            string Delete_OK = bookBLL.XoaLoaiSach(loaiSach);
            switch (Delete_OK)
            {
                case "error_null_LoaiSach":
                    {
                        MessageBox.Show("Lỗi null loại sách!");
                        return;
                    }
                case "delete_Success":
                    {
                        MessageBox.Show(" Chúc mừng bạn xóa loại sách thành công!");
                        HienThiLoaiSach();
                        XoaThongTin();
                        grbThongTinChiTiet.Enabled = false;
                        return;
                    }
                case "error_Delete_Success":
                    {
                        MessageBox.Show("Lỗi không xóa được loại sách!");
                        return;
                    }
                default:
                    MessageBox.Show("Lỗi không xác định được" + Delete_OK);
                    return;
            }
        }
        private void XoaThongTin()
        {
            txtMaLoaiSach.Clear();
            txtTenLoaiSach.Clear();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn hủy bỏ thay đổi này không",
                "Hộp thoại",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                XoaThongTin();
                grbThongTinChiTiet.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        private void HienThiLoaiSach()
        {
            dtLoaiSach = bookBLLs.HienThiLoaiSach();
            dgvThongTinLoaiSach.DataSource = dtLoaiSach;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaLoaiSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucNang = 2;
            txtMaLoaiSach.Enabled = false;
            grbThongTinChiTiet.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            chucNang = 1;
            txtMaLoaiSach.Enabled = true;
            grbThongTinChiTiet.Enabled = true;
            XoaThongTin();
        }

        private void btnThoat_Click(object sender, EventArgs e)
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
        int vt = -1;
        private void dgvThongTinLoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            // select ca hang
            dgvThongTinLoaiSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataRow dtRow = dtLoaiSach.Rows[vt];
            txtMaLoaiSach.Text = dtRow["MaLoaiSach"].ToString().Trim();
            txtTenLoaiSach.Text = dtRow["TenLoaiSach"].ToString().Trim();
            string[] a = dtRow["NgayThem"].ToString().Trim().Split(' ');
            string[] ns = a[0].Split('/');
            dtpNgayThem.Value = new DateTime(int.Parse(ns[2]), int.Parse(ns[0]), int.Parse(ns[1]));

            grbThongTinChiTiet.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void QuanLyLoaiSach_Load(object sender, EventArgs e)
        {
            HienThiLoaiSach();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            grbThongTinChiTiet.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maLoaiSach = txtTKMaLoaiSach.Text.Trim();
            string tenLoaiSach = txtTKTenLoaiSach.Text.Trim();
            DataTable dtMaLoaiSach = bookBLLs.TimKiemMaLoaiSach(maLoaiSach);
            DataTable dtTenLoaiSach = bookBLLs.TimKiemTenLoaiSach(tenLoaiSach);
            if (dtMaLoaiSach.Rows.Count > 0)
            {
                dgvThongTinLoaiSach.DataSource = dtMaLoaiSach;
            }
            else if (dtTenLoaiSach.Rows.Count > 0)
            {
                dgvThongTinLoaiSach.DataSource = dtTenLoaiSach;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin loại sách!");
                dgvThongTinLoaiSach.DataSource = dtLoaiSach;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HienThiLoaiSach();
        }
    }
}
