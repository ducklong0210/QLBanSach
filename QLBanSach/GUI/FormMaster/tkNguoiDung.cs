using BLL;
using Microsoft.Reporting.WinForms;
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
    public partial class tkNguoiDung : Form
    {
        private NguoiDungBLL userBLL = new NguoiDungBLL();
        public tkNguoiDung()
        {
            InitializeComponent();
        }

        private void tkNguoiDung_Load(object sender, EventArgs e)
        {
            DataTable dt = userBLL.HienThiDuLieuUser();
            // Kiểm tra dữ liệu của bảng
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!");
                return;
            }
            this.rpvNguoiDung.LocalReport.DataSources.Clear();
            this.rpvNguoiDung.LocalReport.ReportEmbeddedResource = "GUI.FormMaster.ReportNguoiDung.rdlc";

            ReportDataSource rds = new ReportDataSource("DSNguoiDung", dt);
            this.rpvNguoiDung.LocalReport.DataSources.Add(rds);

            this.rpvNguoiDung.RefreshReport();
        }
    }
}
