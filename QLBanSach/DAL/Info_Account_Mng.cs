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
    public class Info_Account_Mng
    {
        public List<NhanVien> Staff = new List<NhanVien>();
        private List<NguoiDung> Users = new List<NguoiDung>();
        public NguoiDung Info_Account(string username) {
            NguoiDung user = null;
            // Kết nối CSDL
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select * from tbl_NguoiDung where Username = @username";
            SqlCommand cmd = new SqlCommand(sql,sqlCon);
            try
            {
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = cmd.ExecuteReader();
               
                    if (reader.Read())
                    {
                        user = new NguoiDung
                        {
                            MaND = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Pass = reader.GetString(2),
                            MaQuyen = reader.GetInt32(3),
                            HoVaTen = reader.GetString(4),
                            NamSinh = reader.GetDateTime(5),
                            GioiTinh = reader.GetString(6),
                            DiaChi = reader.GetString(7),
                            SoDienThoai = reader.GetString(8)
                        };
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }
            finally
            {
                db.DongKetNoi();
            }
            return user;
        }
        public string SuaTTTaiKhoan(NguoiDung editUser)
        {
            //Ket noi csdl
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_EditTaiKhoan";
            int kq = 0;
            // Truyền tham số vào
            try
            {
                cmd.Parameters.AddWithValue("@maND", editUser.getMaND());
                cmd.Parameters.AddWithValue("@user", editUser.getUsername());
                cmd.Parameters.AddWithValue("@pass", editUser.getPass());
                cmd.Parameters.AddWithValue("@hoTen", editUser.getHoVaTen());
                cmd.Parameters.AddWithValue("@maQuyen", editUser.getMaQuyen());
                cmd.Parameters.AddWithValue("@gioiTinh", editUser.getGioiTinh());
                cmd.Parameters.AddWithValue("@namSinh", editUser.getNamSinh());
                cmd.Parameters.AddWithValue("@diaChi", editUser.getDiaChi());
                cmd.Parameters.AddWithValue("@soDienThoai", editUser.getSoDienThoai());
                // thực thi
                kq = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
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
                this.Users.Add(editUser);
                return "edit_Success";
            }
            return "error_Edit_Success";
        }
        public string SuaTTTaiKhoanUser(NguoiDung editUser)
        {
            //Ket noi csdl
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_EditTaiKhoanUser";
            int kq = 0;
            // Truyền tham số vào
            try
            {
                cmd.Parameters.AddWithValue("@user", editUser.getUsername());
                cmd.Parameters.AddWithValue("@pass", editUser.getPass());
                cmd.Parameters.AddWithValue("@hoTen", editUser.getHoVaTen());
                cmd.Parameters.AddWithValue("@gioiTinh", editUser.getGioiTinh());
                cmd.Parameters.AddWithValue("@namSinh", editUser.getNamSinh());
                cmd.Parameters.AddWithValue("@diaChi", editUser.getDiaChi());
                cmd.Parameters.AddWithValue("@soDienThoai", editUser.getSoDienThoai());
                // thực thi
                kq = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
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
                this.Users.Add(editUser);
                return "edit_Success";
            }
            return "error_Edit_Success";
        }
     
        public NhanVien Info_Account_Staff(string maND)
        {
            NhanVien staff=null;
            // Kết nối CSDL
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select * from tbl_NhanVien where MaNV = @maNV";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            try
            {
                cmd.Parameters.AddWithValue("@maNV", maND);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    staff = new NhanVien
                    {
                        MaNV = reader.GetString(0),
                        TenNV = reader.GetString(1),
                        NamSinh = reader.GetDateTime(2),
                        CCCD = reader.GetString(3),
                        SoDienThoai = reader.GetString(4),
                        QueQuan = reader.GetString(5),
                        TrangThai = reader.GetString(6),
                        Pass = reader.GetString(7),
                        
                    };
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi :" + ex.Message);
            }
            finally
            {
                db.DongKetNoi();
            }
            return staff;
        }
        public string SuaTTTaiKhoanNV(NhanVien editStaff)
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
                this.Staff.Add(editStaff);
                return "edit_Success";
            }
            return "error_Edit_Success";
        }
    }
}
