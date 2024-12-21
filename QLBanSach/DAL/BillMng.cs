using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
namespace DAL
{
    public class BillMng
    {
        public BillMng() { }
        
        public DataTable HoaDon()
        {
            DataTable dt = new DataTable();
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            string sql = "select *from tbl_HoaDon";
            SqlConnection sqlCon = db.sqlCon;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable NhapHang()
        {
            DataTable dt = new DataTable();
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            string sql = "select * from tbl_PhieuNhap";
            SqlConnection sqlCon = db.sqlCon;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
            adapter.Fill(dt);
            return dt;
        }
        

    }
}
