using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap
    {
        public int MaPN {  get; set; }
        public DateTime NgayLapPN { get; set; }
        public string NhaCC {  get; set; }
        public decimal TongTien {  get; set; }

        public PhieuNhap() { }
        public PhieuNhap(int maPN, DateTime ngayLapPN, string nhaCC, decimal tongTien)
        {
            this.MaPN = maPN;
            this.NgayLapPN = ngayLapPN;
            this.NhaCC = nhaCC;
            this.TongTien = tongTien;
        }
        public int getMaPN() { return this.MaPN; }
        public DateTime getNgayLapPN() { return this.NgayLapPN; }
        public string getNhaCC() { return this.NhaCC; }
        public decimal getTongTien() { return this.TongTien; }

        public void setMaPN(int MaPN)
        {
            this.MaPN = MaPN;
        }
        public void setNgayLapPN(DateTime NgayLapPN)
        {
            this.NgayLapPN= NgayLapPN;
        }
        public void setNhaNCC(string NhaCC)
        {
            this.NhaCC= NhaCC;
        }
        public void setTongTien(decimal TongTien)
        {
            this.TongTien= TongTien;
        }
    }
}
