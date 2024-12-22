using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class ForgotPassMng
    {
        List<QuenMatKhau> forgotPass = new List<QuenMatKhau>();
        private QuenMatKhau quenMatKhau;

        public string GuiThongTin(QuenMatKhau qmk)
        {
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_ForgotPassword";
            int kq = 0;
            try
            {
                cmd.Parameters.AddWithValue("@user", qmk.getUsername());
                cmd.Parameters.AddWithValue("@ngayGui", qmk.getNgayGui());
                cmd.Parameters.AddWithValue("@noiDung", qmk.getNoiDung());
                cmd.Parameters.AddWithValue("@email", qmk.getEmail());
                cmd.Parameters.AddWithValue("@soDienThoai", qmk.getSoDienThoai());
                kq = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi Sql: {ex.Message}");
            }
            finally
            {
                db.DongKetNoi();
            }
            if (kq > 0)
            {
                this.forgotPass.Add(qmk);
                return "forgotPass_Access";
            }
            return "forgotPass_Fail";
        }
        public string CheckUsername(string username)
        {
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select Count(*) from tbl_NguoiDung where Username = @user";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            int count = 0;
            try
            {
                cmd.Parameters.AddWithValue("@user", username);   
                count = (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL" + ex.Message);
            }
            finally
            {
                db.DongKetNoi();
            }
            if (count > 0)
            {
                return "check_Access";
            }
            return "error_Check";
        }
        public string GetPassword(string username)
        {
            SqlConnectDatabase db = new SqlConnectDatabase();
            db.MoKetNoi();
            SqlConnection sqlCon = db.sqlCon;
            string sql = "select Pass from tbl_NguoiDung where Username = @user";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            string password = null;
            try
            {
                cmd.Parameters.AddWithValue("@user", username);
                password = (string)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL" + ex.Message);
            }
            finally
            {
                db.DongKetNoi();
            }
            return password;
        }
    }
}
