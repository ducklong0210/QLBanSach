using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAL;
using System.Data;
namespace BLL
{
    public class StaffBLL
    {
        private StaffMng staffMngs;
        StaffMng staffMng = new StaffMng();
        public StaffBLL()
        {
            staffMngs = new StaffMng();
        }
        public DataTable HienThiThongTin()
        {
            try
            {
                return staffMng.HienThiThongTin();
            }
            catch(Exception ex)
            {
                return new DataTable();
            }
        }
        public DataTable TimKiemTenNV(string tenNV)
        {
            if(tenNV == null)
            {
                throw new Exception("Tên nhân viên lỗi null!");
            }
            return staffMng.TimKiemTenNV(tenNV);
        }
        public DataTable TimKiemTrangThai(string trangThai)
        {
            if (trangThai == null)
            {
                throw new Exception("Trạng thái nhân viên lỗi null!");
            }
            return staffMng.TimKiemTrangThai(trangThai);
        }
        
        public string ThemNhanVien(NhanVien addStaff)
        {
            if(addStaff == null)
            {
                return "addStaff_null_error";
            }
            if(addStaff.MaNV == ""|| 
               addStaff.TenNV == ""||
               addStaff.CCCD == ""||
               addStaff.TrangThai== ""||
               addStaff.QueQuan==""||
               addStaff.SoDienThoai=="")
            {
                return "error_Staff";
            }
            string Add_OK = staffMng.ThemNhanVien(addStaff);
            return Add_OK;
        }
        public string SuaNhanVien(NhanVien editStaff)
        {
            if (editStaff == null)
            {
                return "editStaff_null_error";
            }
            string Edit_OK = staffMng.SuaNhanVien(editStaff);
            return Edit_OK;
        }
        public string XoaNhanVien(NhanVien deleteStaff)
        {
            if (deleteStaff == null)
            {
                return "deleteStaff_null_error";
            }
            string Delete_OK = staffMng.XoaNhanVien(deleteStaff);
            return Delete_OK;
        }
        public string TamNgungNhanVien(NhanVien pauseStaff)
        {
            if (pauseStaff == null)
            {
                return "pauseStaff_null_error";
            }
            string Pause_OK = staffMng.TamNgungNhanVien(pauseStaff);
            return Pause_OK;
        }
    }
}
