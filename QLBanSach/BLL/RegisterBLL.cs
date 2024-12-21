using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using DTO;
using DAL;
using System.Text.RegularExpressions;
namespace BLL
{
    public class RegisterBLL
    {
       
        UserRegister userRegister = new UserRegister();
        public string CheckRegister(NguoiDung taiKhoan)
        {
            
             string checkRegister = userRegister.CheckRegister(taiKhoan);
            return checkRegister;
        }
        public bool CheckAccount(string ac)
        {
            bool checkTKMK = Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
            return checkTKMK;
        }

    }
}
