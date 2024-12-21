
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using DTO;
namespace DAL
{

    public class RegisterAccess
    {
        private List<NguoiDung> Users = new List<NguoiDung>();
        public NguoiDung taiKhoan;
        // Chuỗi xử lý tài khoản đăng ký
        public string Register(NguoiDung taikhoan)
        {
            //Ket noi csdl
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_Register";
            int kq = 0;
            try
            {
                cmd.Parameters.AddWithValue("@user", taikhoan.getUsername());
                cmd.Parameters.AddWithValue("@pass", taikhoan.getPass());
                cmd.Parameters.AddWithValue("@hoTen", taikhoan.getHoVaTen());
                cmd.Parameters.AddWithValue("@namSinh", taikhoan.getNamSinh());
                cmd.Parameters.AddWithValue("@gioiTinh", taikhoan.getGioiTinh());
                cmd.Parameters.AddWithValue("@diaChi", taikhoan.getDiaChi());
                cmd.Parameters.AddWithValue("@soDienThoai", taikhoan.getSoDienThoai());
                kq = cmd.ExecuteNonQuery();
                   
            }
            catch (SqlException ex)
            {
                // Kiểm tra mã lỗi trong csdl
                if (ex.Number == 50000) // Bắt lỗi throw 50000 trong csdl
                {
                    return "register_retail";
                }
                Console.WriteLine($"Loi SQL: {ex.Message}");
            }
            finally
            {
               db.DongKetNoi();
            }
            if (kq > 0)
            {
                this.Users.Add(taikhoan);
                return "register_access";
            }
            Console.WriteLine($"Username: {taikhoan.getGioiTinh()}");
            return "error";
        }
    }
}
