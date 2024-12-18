using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using DTO;
using DAL;
namespace BLL
{
    public class TaiKhoanBLL
    {
        UserAccess taiKhoanAccess = new UserAccess();
        public string CheckLogin(NguoiDung taiKhoan)
        {
            //Kiểm tra tài khoản mật khẩu người dùng nhập vào hay chưa
            if (taiKhoan.Username == "")
            {
                return "sukien_taikhoan";
            }
            if(taiKhoan.Pass == "")
            {
                return "sukien_matkhau";
            }
            string infoUserBLL = taiKhoanAccess.CheckLogin(taiKhoan);
            return infoUserBLL;
        }
        //public string CHeckLoginStaff(NhanVien staff)
        //{
        //    if (staff.MaNV == "" || staff.Pass == "")
        //        return "taikhoan_staff_null";
        //    string infoStaffBLL = taiKhoanAccess.CheckLoginStaff(staff);
        //    return infoStaffBLL;
        //}

    }
}
