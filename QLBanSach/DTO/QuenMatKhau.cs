using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuenMatKhau
    {
        public int MaMK { get; set; }
        public string Username { get; set; }
        public DateTime NgayGui { get; set; }
        public string NoiDung { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }

        public QuenMatKhau() { }

        public QuenMatKhau(int maMK, string username, DateTime ngayGui, string noiDung, string email, string soDienThoai)
        {
            this.MaMK = maMK;
            this.Username = username;
            this.NgayGui = ngayGui;
            this.NoiDung = noiDung;
            this.Email = email;
            this.SoDienThoai = soDienThoai;
        }

        public int getMaMK() { return this.MaMK; }
        public string getUsername() { return this.Username; }
        public DateTime getNgayGui() { return this.NgayGui; }
        public string getNoiDung() { return this.NoiDung; }
        public string getEmail() { return this.Email; }
        public string getSoDienThoai() { return this.SoDienThoai; }

        public void setMaMK(int maMK) { this.MaMK = maMK; }
        public void setUsername(string username) { this.Username = username; }
        public void setNgayGui(DateTime ngayGui) { this.NgayGui = ngayGui; }
        public void setSoDienThoai(string soDienThoai) { this.SoDienThoai = soDienThoai; }
        public void setEmail(string email) { this.Email = email; }
        public void setNoiDung(string noiDung) { this.NoiDung = noiDung; }

    }
}
