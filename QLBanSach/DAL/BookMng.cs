using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using DTO;
namespace DAL
{
    public class BookMng
    {
        public List<Sach> Book = new List<Sach>();
        public List<LoaiSach> loaiSach = new List<LoaiSach>();
        public Sach sach;
        public LoaiSach loaiSachs;
        public DataTable DocDuLieuBook()
        {
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select * from tbl_Sach";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // sự kiện tìm kiếm

        public DataTable TimKiemTenSach(string tenSach)
        {
            DataTable dt = new DataTable();
            
                SqlConnectDatabase db = new SqlConnectDatabase();
                db.MoKetNoi();
                SqlConnection sqlCon = db.sqlCon;
                string sql = "select * from tbl_Sach where TenSach LIKE @tenSach";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
            try
            {
                cmd.Parameters.AddWithValue("@tenSach", "%" + tenSach + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }
            finally
            {
                db.DongKetNoi();
            }
            
            return dt;
        }
        public DataTable TimKiemLoaiSach(string maLoaiSach)
        {
            DataTable dt = new DataTable();
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select * from tbl_Sach where MaLoaiSach = @maLoaiSach";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            try
            {
                cmd.Parameters.AddWithValue("@maLoaiSach", maLoaiSach);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }

            return dt; 
        }
        public DataTable TimKiemGiaSach(decimal gia)
        {
            DataTable dt = new DataTable();
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;

            string sql = "select * from tbl_Sach where Gia < @gia";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            try
            {
                cmd.Parameters.AddWithValue("@gia",gia);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }
            finally
            {
                db.DongKetNoi();
            }

            return dt;
        }

        

        //sự kiện thêm sách
        public string ThemSach(Sach addSach)
        {
            //Ket noi csdl
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_InsertBook";
            int kq = 0;
            //Truyền tham số vào thủ tục thêm sách
            try
            {
                cmd.Parameters.AddWithValue("@tenSach",addSach.getTenSach());
                cmd.Parameters.AddWithValue("@namSanXuat",addSach.getNamSanXuat());
                cmd.Parameters.AddWithValue("@maLoaiSach",addSach.getMaLoaiSach());
                cmd.Parameters.AddWithValue("@gia",addSach.getGia());
                cmd.Parameters.AddWithValue("@poster",addSach.getPoster());
                cmd.Parameters.AddWithValue("@soLuong",addSach.getSoLuong());
                // thực thi
                kq = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000) // Bắt lỗi throw 50000 trong csdl
                {
                    return "book_Add_Retail";
                }
                Console.WriteLine($" Lỗi : {ex.Message} ");
            }
            finally
            {
                // đóng kết nối
                db.DongKetNoi();
            }
            if (kq > 0)
            {
                this.Book.Add(addSach);
                return "add_Success";
            }
            return "error_Add_Success";
        }
        //sự kiện sửa sách
        public string SuaTTSach(Sach editSach)
        {
            //Ket noi csdl
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_EditBook";
            int kq = 0;
            // Truyền tham số vào thủ tục sửa sách
            try
            {
                cmd.Parameters.AddWithValue("@maSach", editSach.getMaSach());
                cmd.Parameters.AddWithValue("@tenSach", editSach.getTenSach());
                cmd.Parameters.AddWithValue("@namSanXuat", editSach.getNamSanXuat());
                cmd.Parameters.AddWithValue("@maLoaiSach", editSach.getMaLoaiSach());
                cmd.Parameters.AddWithValue("@gia", editSach.getGia());
                cmd.Parameters.AddWithValue("@poster", editSach.getPoster());
                cmd.Parameters.AddWithValue("@soLuong", editSach.getSoLuong());
                //Thực thi
                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Lỗi : {ex.Message} ");
            }
            finally
            {
                // đóng kết nối
                db.DongKetNoi();
            }
            if (kq > 0)
            {
                this.Book.Add(editSach);
                return "edit_Success";
            }    
            return "error_Edit_Success";
        }
        public string XoaSach(string deleteSach)
        {
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_DeleteBook";
            int kq = 0;
            try
            {
                //Truyền tham số vào
                cmd.Parameters.AddWithValue("@maSach", deleteSach);
                //Thực thi thủ tục
                kq = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Loi SQL : ${ex.Message}");
            }
            finally
            {
                // đóng kết nối
                db.DongKetNoi();
            }
            if (kq > 0)
            {
                return "delete_Success";
            }


            return "error_Delete_Success";
        }
 //============================= Xử lý phân loại sách ===============================
        public DataTable HienThiDuLieuLoaiSach()
        {
            DataTable dt = new DataTable();
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select * from tbl_LoaiSach";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlCon);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable TimKiemMaLoaiSach(string maLoaiSach)
        {
            DataTable dt = new DataTable();
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select * from tbl_LoaiSach where MaLoaiSach = @maLoaiSach";
            SqlCommand cmd = new SqlCommand(sql,sqlCon);
            try
            {
                cmd.Parameters.AddWithValue("@maLoaiSach", maLoaiSach);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }
            return dt;
        }
        public DataTable TimKiemTenLoaiSach(string tenLoaiSach)
        {
            DataTable dt = new DataTable();
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select * from tbl_LoaiSach where TenLoaiSach LIKE @tenLoaiSach";
            SqlCommand cmd = new SqlCommand(sql,sqlCon);
            try
            {
                cmd.Parameters.AddWithValue("@tenLoaiSach", "%" + tenLoaiSach + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }

            return dt;
        }
        public string ThemLoaiSach(LoaiSach addLoaiSach)
        {
            //Ket noi csdl
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_InsertLoaiSach";
            int kq = 0;
            try
            {
                cmd.Parameters.AddWithValue("@maLoaiSach",addLoaiSach.getMaLoaiSach());
                cmd.Parameters.AddWithValue("@tenLoaiSach", addLoaiSach.getTenLoaiSach());
                cmd.Parameters.AddWithValue("@ngayThem", addLoaiSach.getNgayThem());
                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi SQL : ${ex.Message}");
            }
            finally
            {
                db.DongKetNoi();
            }
            if(kq > 0)
            {
                this.loaiSach.Add(addLoaiSach);
                return "add_Success";
            }

            return "error_Add_Success";
        }
        public string SuaLoaiSach(LoaiSach editLoaiSach)
        {
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_EditLoaiSach";
            int kq = 0;
            try
            {
                cmd.Parameters.AddWithValue("@maLoaiSach", editLoaiSach.getMaLoaiSach());
                cmd.Parameters.AddWithValue("@tenLoaiSach", editLoaiSach.getTenLoaiSach());
                cmd.Parameters.AddWithValue("@ngayThem", editLoaiSach.getNgayThem());
                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi SQL : ${ex.Message}");
            }
            finally
            {
                db.DongKetNoi();
            }
            if (kq > 0)
            {
               
                return "edit_Success";
            }

            return "error_Edit_Success";
        }

        public string XoaLoaiSach(LoaiSach deleteLoaiSach)
        {
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_DeleteLoaiSach";
            int kq = 0;
            try
            {
                cmd.Parameters.AddWithValue("@maLoaiSach", deleteLoaiSach.getMaLoaiSach());
                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
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
        
    }
}
