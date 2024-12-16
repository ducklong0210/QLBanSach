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
using BLL;
namespace GUI.FormMaster
{
    public partial class tkSach : Form
    {
        private BookBLL bookBLL= new BookBLL();
        public tkSach()
        {
            InitializeComponent();
        }

        private void tkSach_Load(object sender, EventArgs e)
        {
            DataTable dt = bookBLL.HienThiDuLieuBook();
            // Kiểm tra dữ liệu của bảng
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!");
                return;
            }
            this.rpvSach.LocalReport.DataSources.Clear();
            this.rpvSach.LocalReport.ReportEmbeddedResource = "GUI.FormMaster.ReportSach.rdlc";

            ReportDataSource rds = new ReportDataSource("DSSach", dt);
            this.rpvSach.LocalReport.DataSources.Add(rds);

            this.rpvSach.RefreshReport();
        }
    }
}
