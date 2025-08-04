# QLBanSach

## Giới thiệu

QLBanSach là ứng dụng quản lý bán sách được phát triển bằng .NET WinForms. Ứng dụng hỗ trợ các chức năng như quản lý sách, khách hàng, đơn hàng, thống kê doanh thu,...

## Yêu cầu hệ thống

- Windows 10 trở lên
- .NET Framework (phiên bản phù hợp với dự án, ví dụ: .NET Framework 4.7.2)
- SQL Server (nếu sử dụng cơ sở dữ liệu SQL Server)

## Hướng dẫn cài đặt và sử dụng

### 1. Tải mã nguồn

Clone hoặc tải mã nguồn dự án về máy:
```bash
git clone https://github.com/<tên-tài-khoản>/<tên-repo>.git
```

### 2. Mở dự án

- Mở Visual Studio.
- Chọn **File > Open > Project/Solution** và chọn file `.sln` của dự án.

### 3. Cấu hình cơ sở dữ liệu

- Mở file cấu hình (ví dụ: `App.config`).
- Cập nhật chuỗi kết nối (`connectionString`) cho phù hợp với SQL Server trên máy bạn.

### 4. Khởi tạo cơ sở dữ liệu

- Mở SQL Server Management Studio.
- Tạo database mới (nếu chưa có).
- Chạy các script tạo bảng và dữ liệu mẫu (nếu có file script đi kèm dự án).

### 5. Chạy ứng dụng

- Nhấn **F5** hoặc chọn **Start** trong Visual Studio để chạy ứng dụng.

### 6. Sử dụng

- Đăng nhập bằng tài khoản mặc định (nếu có).
- Sử dụng các chức năng quản lý sách, khách hàng, đơn hàng, thống kê,...
- Đăng xuất khi hoàn thành.

## Đóng góp

- Nếu bạn muốn đóng góp, hãy tạo Pull Request hoặc gửi Issue trên GitHub.

## Liên hệ

- Email: [your-email@example.com]