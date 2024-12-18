using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string MaNV {  get; set; }
        
        public string Pass {  get; set; }
        public string TenNV { get; set; }
        public  DateTime NamSinh { get; set; }
        public string CCCD {  get; set; }
        public string SoDienThoai {  get; set; }
        public string QueQuan {  get; set; }
        public string TrangThai {  get; set; }
        public NhanVien() { }
        public NhanVien(string maNV, string tenNV, DateTime namSinh, string cCCD, string soDienThoai, string queQuan, string trangThai, string pass)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.NamSinh = namSinh;
            this.CCCD = cCCD;
            this.SoDienThoai = soDienThoai;
            this.QueQuan = queQuan;
            this.TrangThai = trangThai;
            this.Pass = pass;
        }

        public string getMaNV() { return this.MaNV; }
        public string getPass() {  return this.Pass; }
        public string getTenNV() { return this.TenNV; }
        public DateTime getNamSinh() { return this.NamSinh; }
        public string getQueQuan() { return this.QueQuan; }
        public string getTrangThai() { return this.TrangThai; }
        public string getCCCD() {  return this.CCCD; }
        public string getSoDienThoai() { return this.SoDienThoai; }

        public void setMaNV(string MaNV)
        {
            this.MaNV = MaNV;   
        }
        public void setPass(string Pass) 
        {
            this.Pass = Pass; 
        }
        public void setTenNV(string TenNV)
        {
            this.TenNV = TenNV;
        }
        public void setNamSinh(DateTime NamSinh)
        {
            this.NamSinh = NamSinh;
        }
        public void setCCCD(string CCCD)
        {
            this.CCCD = CCCD;
        }
        public void setSoDienThoai(string SoDienThoai)
        {
            this.SoDienThoai = SoDienThoai;
        }
        public void setQueQuan(string QueQuan)
        {
            this.QueQuan = QueQuan;
        }
        public void setTrangThai(string TrangThai)
        {
            this.TrangThai = TrangThai;
        }

    }
}
