using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSach
    {
        public string MaLoaiSach { get; set; }
        public string TenLoaiSach { get; set; }
        public DateTime NgayThem { get; set; }  
        public LoaiSach() { }

        public LoaiSach(string maLoaiSach, string tenLoaiSach, DateTime ngayThem)
        {
            this.MaLoaiSach = maLoaiSach;
            this.TenLoaiSach = tenLoaiSach;
            this.NgayThem = ngayThem;
        }
        public string getMaLoaiSach()  { return this.MaLoaiSach; }
        public string getTenLoaiSach() { return this.TenLoaiSach; }
        public DateTime getNgayThem() { return this.NgayThem; }
        public void setMaLoaiSach(string MaLoaiSach)
        {
            this.MaLoaiSach = MaLoaiSach;
        }
        public void setTenLoaiSach(string TenLoaiSach)
        {
            this.TenLoaiSach= TenLoaiSach;
        }
        public void setNgayThem(DateTime NgayThem)
        {
            this.NgayThem= NgayThem;
        }
    }
}
