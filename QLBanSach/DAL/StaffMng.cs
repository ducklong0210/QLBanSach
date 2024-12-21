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
            string sql = "select * from tbl_NhanVien where TrangThai LIKE @trangThai";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            try
            {
                cmd.Parameters.AddWithValue("@trangThai","%" + trangThai + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }
            return dt;
        }
        
            public string ThemNhanVien(NhanVien addStaff)
            {
            //Ket noi csdl
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_InsertStaff";
            int kq = 0;
            try
            {
                cmd.Parameters.AddWithValue("@pass", addStaff.getPass());
                cmd.Parameters.AddWithValue("@maNV", addStaff.getMaNV());
                cmd.Parameters.AddWithValue("@tenNV", addStaff.getTenNV());
                cmd.Parameters.AddWithValue("@namSinh", addStaff.getNamSinh());
                cmd.Parameters.AddWithValue("@CCCD", addStaff.getCCCD());
                cmd.Parameters.AddWithValue("@soDienThoai", addStaff.getSoDienThoai());
                cmd.Parameters.AddWithValue("@queQuan", addStaff.getQueQuan());
                cmd.Parameters.AddWithValue("@trangThai", addStaff.getTrangThai());
                kq = cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                if (ex.Number == 50000) // Bắt lỗi throw 50000 trong csdl
                {
                    return "staff_Add_Retail";
                }
                Console.WriteLine($"Loi SQL : ${ex.Message}");
            }
            finally
            {
                db.DongKetNoi();
            }
            if(kq >  0)
            {
                this.nhanViens.Add(addStaff);
                return "add_Success";
            }
            return "error_Add_Success";
        }
        public string SuaNhanVien(NhanVien editStaff)
        {
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_EditStaff";
            int kq = 0;
            try
            {
                cmd.Parameters.AddWithValue("@pass", editStaff.getPass());
                cmd.Parameters.AddWithValue("@maNV", editStaff.getMaNV());
                cmd.Parameters.AddWithValue("@tenNV", editStaff.getTenNV());
                cmd.Parameters.AddWithValue("@namSinh", editStaff.getNamSinh());
                cmd.Parameters.AddWithValue("@CCCD", editStaff.getCCCD());
                cmd.Parameters.AddWithValue("@soDienThoai", editStaff.getSoDienThoai());
                cmd.Parameters.AddWithValue("@queQuan", editStaff.getQueQuan());
                cmd.Parameters.AddWithValue("@trangThai", editStaff.getTrangThai());
                kq = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Loi SQL : ${ex.Message}");
            }
            finally
            {
                db.DongKetNoi();
            }
            if (kq > 0)
            {
                this.nhanViens.Add(editStaff);
                return "edit_Success";
            }
            return "error_Edit_Success";
        }
        public string XoaNhanVien(NhanVien deleteStaff)
        {
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_DeleteStaff";
            int kq = 0;
            try
            {
                cmd.Parameters.AddWithValue("@maNV", deleteStaff.getMaNV());
                kq = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Loi SQL : ${ex.Message}");
            }
            finally
            {
                db.DongKetNoi();
            }
            if (kq > 0)
            {
                return "delete_Success";
            }
            return "error_Delete_Success";
        }
        public string TamNgungNhanVien(NhanVien pauseStaff)
        {
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_TamNgungNhanVien";
            int kq = 0;
            try
            {
                cmd.Parameters.AddWithValue("@maNV", pauseStaff.getMaNV());
                cmd.Parameters.AddWithValue("@pass", pauseStaff.getPass());
                cmd.Parameters.AddWithValue("@tenNV", pauseStaff.getTenNV());
                cmd.Parameters.AddWithValue("@namSinh", pauseStaff.getNamSinh());
                cmd.Parameters.AddWithValue("@CCCD", pauseStaff.getCCCD());
                cmd.Parameters.AddWithValue("@soDienThoai", pauseStaff.getSoDienThoai());
                cmd.Parameters.AddWithValue("@queQuan", pauseStaff.getQueQuan());
                kq = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Loi SQL : ${ex.Message}");
            }
            finally
            {
                db.DongKetNoi();
            }
            if (kq > 0)
            {
                this.nhanViens.Add(pauseStaff);
                return "pause_Success";
            }
            return "error_Pause_Success";
        }
    }
}
