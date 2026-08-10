# Library
Các bước triển khai hệ thống quản lý thư viện được thực hiện như sau:
Bước 1: Cài đặt Microsoft Visual Studio
Cài đặt Microsoft Visual Studio 2019 hoặc Visual Studio 2022 trên máy tính. Trong quá
trình cài đặt cần lựa chọn gói .NET Desktop Development để hỗ trợ phát triển và chạy ứng
dụng Windows Forms.
Bước 2: Cài đặt .NET Framework 4.7.2
Cài đặt .NET Framework 4.7.2 cho máy tính sử dụng. Đây là môi trường thực thi cần thiết
để chương trình có thể hoạt động. Nếu máy tính đã cài đặt phiên bản tương thích thì có thể bỏ
qua bước này.
Bước 3: Tạo thư mục chứa dự án
Tạo một thư mục mới trên máy tính để lưu trữ mã nguồn của hệ thống quản lý thư viện. Sau
đó giải nén toàn bộ mã nguồn dự án vào thư mục vừa tạo.
Bước 4: Mở dự án bằng Visual Studio
Khởi động Visual Studio và mở file Solution (.sln) của dự án.
File → Open → Project/Solution
Sau đó chọn file:
QLTV.sln
(hoặc tên file Solution tương ứng của dự án).
Bước 5: Cài đặt các thư viện phụ thuộc
Mở NuGet Package Manager và thực hiện Restore Packages.
Tools → NuGet Package Manager → Manage NuGet Packages for Solution
Hoặc sử dụng Package Manager Console:
Update-Package -Reinstall
Hệ thống sẽ tự động tải các thư viện cần thiết như:
• Entity Framework 6
• DevExpress
• Crystal Reports Runtime
• Các thư viện hỗ trợ khác
Bước 6: Cài đặt Microsoft SQL Server
Tiến hành cài đặt Microsoft SQL Server trên máy tính.
Khuyến nghị sử dụng:
Microsoft SQL Server 2019
hoặc
Microsoft SQL Server 2022
Sau khi cài đặt hoàn tất cần ghi nhớ:
• Server Name
• Username
63
• Password
để phục vụ cho việc cấu hình kết nối cơ sở dữ liệu.
Bước 7: Khôi phục cơ sở dữ liệu
Mở SQL Server Management Studio (SSMS).
Nếu dự án cung cấp file Backup (.bak):
Databases
↓
Restore Database
Chọn file cơ sở dữ liệu được đính kèm cùng mã nguồn.
Nếu dự án cung cấp file SQL:
File → Open → SQL Script
Sau đó thực hiện:
Execute
để tạo cơ sở dữ liệu.
Bước 8: Cấu hình kết nối cơ sở dữ liệu
Mở file:
App.config
hoặc
Model1.edmx
và chỉnh sửa Connection String phù hợp với SQL Server đã cài đặt.
Ví dụ:
Data Source=DESKTOP-PC;
Initial Catalog=QLThuVien;
Integrated Security=True
hoặc
Data Source=DESKTOP-PC;
Initial Catalog=QLThuVien;
User ID=sa;
Password=123456
Bước 9: Thiết lập Startup Project
Trong cửa sổ Solution Explorer:
Chuột phải Project chính
↓
Set as Startup Project
Đảm bảo hệ thống chạy đúng Form khởi động.
Bước 10: Build dự án
64
Thực hiện biên dịch toàn bộ chương trình:
Build → Build Solution
hoặc nhấn:
Ctrl + Shift + B
Kiểm tra và xử lý các lỗi phát sinh (nếu có).
Bước 11: Chạy thử hệ thống
Sau khi Build thành công, tiến hành chạy chương trình:
Debug → Start Debugging
hoặc nhấn:
F5
Màn hình đăng nhập của hệ thống sẽ xuất hiện.
Bước 12: Kiểm tra cơ sở dữ liệu và chức năng hệ thống
Tiến hành đăng nhập và kiểm tra các chức năng:
• Quản lý sách.
• Quản lý độc giả.
• Quản lý nhân viên.
• Quản lý mượn sách.
• Quản lý trả sách.
• Quản lý phiếu phạt.
• Thống kê báo cáo.
Đồng thời kiểm tra việc lưu trữ dữ liệu trên SQL Server để đảm bảo hệ thống hoạt động
chính xác.
Bước 13: Hoàn tất triển khai
Sau khi các chức năng hoạt động ổn định, hệ thống có thể được triển khai chính thức tại thư
viện. Người dùng chỉ cần khởi động chương trình và đăng nhập bằng tài khoản được cấp để sử
dụng toàn bộ các chức năng của phần mềm.
