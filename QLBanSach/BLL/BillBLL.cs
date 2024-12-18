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
    public class BillBLL
    {
        private BillMng billMng;
        public BillBLL()
        {
            billMng = new BillMng();
        }
        public DataTable HoaDon()
        {
            return billMng.HoaDon();
        }
        public DataTable NhapHang()
        {
            return billMng.NhapHang();
        }
    }
}
