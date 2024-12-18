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
    public partial class tkNhapHang : Form
    {
        private BillBLL billBLL = new BillBLL();
        public tkNhapHang()
        {
            InitializeComponent();
        }

        private void tkNhapHang_Load(object sender, EventArgs e)
        {

            DataTable dt = billBLL.NhapHang();
            // Kiểm tra dữ liệu của bảng
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!");
                return;
            }
            this.rpvNhapHang.LocalReport.DataSources.Clear();
            this.rpvNhapHang.LocalReport.ReportEmbeddedResource = "GUI.FormMaster.ReportNhapHang.rdlc";

            ReportDataSource rds = new ReportDataSource("DSNhapHang", dt);
            this.rpvNhapHang.LocalReport.DataSources.Add(rds);

            this.rpvNhapHang.RefreshReport();
        }
    }
}
