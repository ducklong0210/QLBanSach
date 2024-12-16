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
using BLL;
namespace GUI.FormMaster
{
    public partial class tkNhanVien : Form
    {
        private StaffBLL staffBLL = new StaffBLL();
        public tkNhanVien()
        {
            InitializeComponent();
        }

        private void tkNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = staffBLL.HienThiThongTin();
            // Kiểm tra dữ liệu của bảng
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!");
                return;
            }
            this.rpvNhanVien.LocalReport.DataSources.Clear();
            this.rpvNhanVien.LocalReport.ReportEmbeddedResource = "GUI.FormMaster.ReportNhanVien.rdlc";

            ReportDataSource rds = new ReportDataSource("DSNhanVien", dt);
            this.rpvNhanVien.LocalReport.DataSources.Add(rds);

            this.rpvNhanVien.RefreshReport();
        }
    }
}
