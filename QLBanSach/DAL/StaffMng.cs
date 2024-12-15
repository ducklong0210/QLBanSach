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
    public class StaffMng
    {
        private List<NhanVien> nhanViens = new List<NhanVien>();
        public NhanVien staff;
        
        public DataTable HienThiThongTin()
        {
            DataTable dt = new DataTable();
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select * from tbl_NhanVien";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable TimKiemTenNV(string tenNV)
        {
            DataTable dt = new DataTable();
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select * from tbl_NhanVien where TenNV LIKE @tenNV";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            try {
                cmd.Parameters.AddWithValue("@tenNV", "%" + tenNV + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }
            return dt;
        }
        public DataTable TimKiemTrangThai(string trangThai)
        {
            DataTable dt = new DataTable();
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select * from tbl_NhanVien where TrangThai = @trangThai";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            try
            {
                cmd.Parameters.AddWithValue("@trangThai","N"+trangThai);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }
            return dt;
        }
    }
}
