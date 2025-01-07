using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ForgotPassBLL
    {
        List<NguoiDung> users = new List<NguoiDung>();
        NguoiDung user = new NguoiDung();
        ForgotPassMng forgotPassMng = new ForgotPassMng();
        UserMng userMng = new UserMng();


        public string GuiThongTin(QuenMatKhau qmk)
        {
            
            //if (qmk.Username != user.Username)
            //{
            //    return "error_forgotPass";
            //}    
            if(string.IsNullOrEmpty(qmk.Username) ||
               string.IsNullOrEmpty(qmk.Email) ||
               string.IsNullOrEmpty(qmk.SoDienThoai) ||
               string.IsNullOrEmpty(qmk.NoiDung))
            {
                return "forgotPass_null";
            }

            string guiThanhCong = forgotPassMng.GuiThongTin(qmk);
            return guiThanhCong;
        }
        public string CheckUsername(string username) 
        {

            if (string.IsNullOrEmpty(username)) 
            {
                return "null_Username";
            }
            string check_OK = forgotPassMng.CheckUsername(username);
            return check_OK;
        }
        public string CheckSdt(string username)
        {

            if (string.IsNullOrEmpty(username))
            {
                return "null_Username";
            }
            string check_OK = forgotPassMng.CheckSdt(username);
            return check_OK;
        }
        public string GetPassword(string username)
        {

            if (string.IsNullOrEmpty(username))
            {
                return "null_Username";
            }
            string check_OK = forgotPassMng.GetPassword(username);
            return check_OK;
        }
    }
}
