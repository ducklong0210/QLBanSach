using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public int MaHD {  get; set; }
        public int MaND { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayLapHD { get; set; }
        public string SoDienThoai {  get; set; }
        public decimal TongTien {  get; set; }
        public HoaDon() { }
        public HoaDon(int maHD, int maND, string maNV, DateTime ngayLapHD, string soDienThoai, decimal tongTien)
        {
            this.MaHD = maHD;
            this.MaND = maND;
            this.MaNV = maNV;
            this.NgayLapHD = ngayLapHD;
            this.SoDienThoai = soDienThoai;
            this.TongTien = tongTien;
        }
        public int getMaHD() { return this.MaHD; }
        public int getMaND() {  return this.MaND; }
        public string getMaNV() { return this.MaNV; }
        public DateTime getNgayLapHD() { return this.NgayLapHD; }
        public string getSoDienThoai() {  return this.SoDienThoai;}
        public decimal getTongTien() { return this.TongTien; }

        public void setMaND(int MaND)
        {
            this.MaND = MaND;
        }
        public void setMaHD(int MaHD)
        {
            this.MaHD= MaHD;
        }
        public void setMaNV(string MaNV)
        {
            this.MaNV = MaNV;
        }
        public void setNgayLapHD(DateTime NgayLapHD)
        {
            this.NgayLapHD = NgayLapHD;
        }
        public void setSoDienThoai(string SoDienThoai)
        {
            this.SoDienThoai = SoDienThoai;
        }
        public void setTongTien(decimal TongTien)
        {
            this.TongTien = TongTien;
        }
    }
}
