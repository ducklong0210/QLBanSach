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
using Microsoft.Reporting.WinForms;
namespace GUI.FormMaster
{
    public partial class BaoCaoThongKe : Form
    {
        private NguoiDung taiKhoan;
        private BillBLL billBLL = new BillBLL();
        public BaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btn_tkHoaDon_Click(object sender, EventArgs e)
        {
            tkHoaDon tkHoaDon = new tkHoaDon();
            tkHoaDon.Show();
        }

        private void btn_tkSach_Click(object sender, EventArgs e)
        {
            tkSach tkSach = new tkSach();
            tkSach.Show();
        }

        private void btn_tkNhapHang_Click(object sender, EventArgs e)
        {
            tkNhapHang tkNhap = new tkNhapHang();
            tkNhap.Show();
        }

        private void btn_tkNhanVien_Click(object sender, EventArgs e)
        {
            tkNhanVien tkNhanVien = new tkNhanVien();
            tkNhanVien.Show();
        }

        private void btn_tkNguoiDung_Click(object sender, EventArgs e)
        {
            tkNguoiDung tkNguoiDung = new tkNguoiDung();
            tkNguoiDung.Show();
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
    }
}
