using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAL;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
namespace BLL
{
    public class BookBLL
    {
        private BookMng bookMng;

        public BookBLL()
        {
            bookMng = new BookMng();
        }

        //Hien thi thong tin sach
        public DataTable HienThiDuLieuBook()
        {
            try
            {
                return bookMng.DocDuLieuBook();
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }
        //tim kiem
        public DataTable TimKiemTenSach(string tenSach)
        {
            if (string.IsNullOrEmpty(tenSach))
            {
                return new DataTable();
            }
            return bookMng.TimKiemTenSach(tenSach);
        }
        public DataTable TimKiemLoaiSach(string maLoaiSach)
        {
            if(string.IsNullOrEmpty(maLoaiSach))
            {
                return new DataTable();
            }
            return bookMng.TimKiemLoaiSach(maLoaiSach);
        }
        public DataTable TimKiemGia(decimal giaSach)
        {
            if (giaSach == null)
            {
                return new DataTable();
            }    
            return bookMng.TimKiemGiaSach(giaSach);
        }
        //them sach
        public string ThemSach(Sach addBook)
        {
            // kiểm tra thông tin đã được nhập đầy đủ vào chưa
            if (addBook.TenSach == "" || 
                addBook.MaLoaiSach != addBook.MaLoaiSach ||
                addBook.Gia == 0 || 
                addBook.SoLuong == 0  ||
                addBook.Poster == "")
            {
                return "error_null_book";
            }
            //Kiểm tra null của sách
            if (addBook == null)
            {
                return "error_book";
            }    
            BookMng bookMng = new BookMng();
            string Add_OK = bookMng.ThemSach(addBook);
            return Add_OK;
        }
        
        // sua sach
        public string SuaTTSach(Sach editBook)
        {
            // kiểm tra thông tin đã được nhập đầy đủ vào chưa
            if (editBook.TenSach == "" || 
                editBook.MaLoaiSach == "" ||
                editBook.Gia == 0 || 
                editBook.SoLuong == 0 || 
                editBook.Poster == "")
            {
                return "error_null_book";
            }
            //Kiểm tra null của sách
            if (editBook == null)
            {
                return "error_book";
            }
            BookMng bookMng = new BookMng();
            string Edit_OK = bookMng.SuaTTSach(editBook);
            return Edit_OK;
        }
        public string XoaSach(string deleteBook)
        {
            //Kiểm tra null của sách
            if (deleteBook == null)
            {
                return "error_book";
            }
            try
            {
                return bookMng.XoaSach(deleteBook);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình xóa sách: " + ex.Message);
            }
        }
        // ========================== Xử lý thông tin loại sách ====================================

        public DataTable HienThiLoaiSach()
        {
            try
            {
                return bookMng.HienThiDuLieuLoaiSach();
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }
        public DataTable TimKiemMaLoaiSach(string maLoaiSach)
        {
            if(maLoaiSach == null)
            {
                throw new Exception("Mã Loại Sách Null!");
            }
            return bookMng.TimKiemMaLoaiSach(maLoaiSach);
        }
        public DataTable TimKiemTenLoaiSach(string tenLoaiSach)
        {
            if (tenLoaiSach == null)
            {
                throw new Exception("Tên Loại Sách Null!");
            }
            return bookMng.TimKiemTenLoaiSach(tenLoaiSach);
        }
        public string ThemLoaiSach(LoaiSach addLoaiSach)
        {
            if(addLoaiSach == null)
            {
                return "error_null_LoaiSach";
            }
            if(addLoaiSach.MaLoaiSach == "" ||
                addLoaiSach.TenLoaiSach == "")
            {
                return "error_LoaiSach";
            }
            BookMng bookMng = new BookMng();
            string Add_OK = bookMng.ThemLoaiSach(addLoaiSach);
            return Add_OK;
        }
        public string SuaLoaiSach(LoaiSach editLoaiSach)
        {
            if (editLoaiSach == null)
            {
                return "error_null_LoaiSach";
            }
            if (editLoaiSach.MaLoaiSach == "" ||
                editLoaiSach.TenLoaiSach == "")
            {
                return "error_LoaiSach";
            }
            BookMng bookMng = new BookMng();
            string Edit_OK = bookMng.SuaLoaiSach(editLoaiSach);
            return Edit_OK;
        }
        public string XoaLoaiSach(LoaiSach deleteLoaiSach)
        {
            if (deleteLoaiSach == null)
            {
                return "error_null_LoaiSach";
            }
            try 
            {
                string Delete_OK = bookMng.XoaLoaiSach(deleteLoaiSach);
                return Delete_OK;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình xóa loại sách");
            }
        }

    }
}
