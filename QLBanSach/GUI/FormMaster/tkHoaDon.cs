using BLL;
using DTO;
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
    public partial class tkHoaDon : Form
    {
        private BillBLL billBLL = new BillBLL();
        public tkHoaDon()
        {
            InitializeComponent();
        }

        private void tkHoaDon_Load(object sender, EventArgs e)
        {

            DataTable dt = billBLL.HoaDon();
            // Kiểm tra dữ liệu của bảng
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!");
                return;
            }
            this.rpvHoaDon.LocalReport.DataSources.Clear();
            this.rpvHoaDon.LocalReport.ReportEmbeddedResource = "GUI.FormMaster.ReportHoaDon.rdlc";

            ReportDataSource rds = new ReportDataSource("DSHoaDon", dt);
            this.rpvHoaDon.LocalReport.DataSources.Add(rds);

            this.rpvHoaDon.RefreshReport();
        }
    }
}
