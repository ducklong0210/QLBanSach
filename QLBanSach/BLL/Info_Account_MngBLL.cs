using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Info_Account_MngBLL
    {
        private Info_Account_Mng info_account;
        public Info_Account_MngBLL() 
        {
            info_account = new Info_Account_Mng();
        }
        public NguoiDung Check_InFo_Account(string username)
        {
            
            NguoiDung user = info_account.Info_Account(username);
            return user;
        }
        public NhanVien Check_Info_Account_Staff(string maND)
        {
            NhanVien staff = info_account.Info_Account_Staff(maND);
            return staff;
        }
        public string SuaTTNguoiDung(NguoiDung editUser)
        {
            if (editUser == null)
            {
                return "editUser_error_null";
            }
            Info_Account_Mng infoMng = new Info_Account_Mng();

            string Edit_OK = infoMng.SuaTTTaiKhoan(editUser);
            return Edit_OK;
        }
        public string SuaTTTaiKhoanUser(NguoiDung editUser)
        {
            if (editUser == null)
            {
                return "editUser_error_null";
            }
            Info_Account_Mng infoMng = new Info_Account_Mng();

            string Edit_OK = infoMng.SuaTTTaiKhoanUser(editUser);
            return Edit_OK;
        }
        public string SuaTTTaiKhoanNhanVien(NhanVien editStaff)
        {
            if (editStaff == null)
            {
                return "editStaff_null_error";
            }
            string Edit_OK = info_account.SuaTTTaiKhoanNV(editStaff);
            return Edit_OK;
        }
    }
}
