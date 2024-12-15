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
        private StaffMng staffMng;
        public StaffBLL()
        {
            staffMng = new StaffMng();
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
                throw new Exception("Tên nhân viên lỗi null!");
            }
            return staffMng.TimKiemTenNV(trangThai);
        }
    }
}
