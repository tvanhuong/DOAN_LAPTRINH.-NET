-- =====================================================================
-- ĐỒ ÁN MÔN HỌC: LẬP TRÌNH .NET (TIE501)
-- ĐỀ TÀI: PHẦN MỀM THI TRẮC NGHIỆM
-- LỚP: DH25PM
-- =====================================================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'QL_ThiTracNghiem')
BEGIN
    ALTER DATABASE QL_ThiTracNghiem SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QL_ThiTracNghiem;
END
GO

CREATE DATABASE QL_ThiTracNghiem;
GO

USE QL_ThiTracNghiem;
GO

-- 1. BẢNG NGƯỜI DÙNG (Admin & Thí sinh)
CREATE TABLE NguoiDung (
    MaND INT IDENTITY(1,1) PRIMARY KEY,
    TaiKhoan VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(100) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    VaiTro NVARCHAR(20) NOT NULL DEFAULT N'ThiSinh' -- 'Admin' hoặc 'ThiSinh'
);
GO

-- 2. BẢNG MÔN THI
CREATE TABLE MonHoc (
    MaMon VARCHAR(20) PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL,
    ThoiGianThi INT NOT NULL DEFAULT 15, -- Thời gian thi tính theo phút
    SoCauHoi INT NOT NULL DEFAULT 10     -- Số câu hỏi mỗi đề thi
);
GO

-- 3. BẢNG CÂU HỎI TRẮC NGHIỆM
CREATE TABLE CauHoi (
    MaCauHoi INT IDENTITY(1,1) PRIMARY KEY,
    MaMon VARCHAR(20) NOT NULL,
    NoiDung NVARCHAR(MAX) NOT NULL,
    DapAnA NVARCHAR(500) NOT NULL,
    DapAnB NVARCHAR(500) NOT NULL,
    DapAnC NVARCHAR(500) NOT NULL,
    DapAnD NVARCHAR(500) NOT NULL,
    DapAnDung CHAR(1) NOT NULL, -- 'A', 'B', 'C', hoặc 'D'
    CONSTRAINT FK_CauHoi_MonHoc FOREIGN KEY (MaMon) REFERENCES MonHoc(MaMon) ON DELETE CASCADE
);
GO

-- 4. BẢNG KẾT QUẢ BÀI THI
CREATE TABLE BaiThi (
    MaBaiThi INT IDENTITY(1,1) PRIMARY KEY,
    MaND INT NOT NULL,
    MaMon VARCHAR(20) NOT NULL,
    NgayThi DATETIME DEFAULT GETDATE(),
    SoCauDung INT NOT NULL DEFAULT 0,
    TongSoCau INT NOT NULL DEFAULT 0,
    DiemSo FLOAT NOT NULL DEFAULT 0,
    CONSTRAINT FK_BaiThi_NguoiDung FOREIGN KEY (MaND) REFERENCES NguoiDung(MaND),
    CONSTRAINT FK_BaiThi_MonHoc FOREIGN KEY (MaMon) REFERENCES MonHoc(MaMon)
);
GO

-- =====================================================================
-- DỮ LIỆU MẪU ĐỂ THỬ NGHIỆM VÀ CHẤM ĐIỂM
-- =====================================================================

-- 1. Nạp người dùng mẫu
INSERT INTO NguoiDung (TaiKhoan, MatKhau, HoTen, VaiTro) VALUES 
('admin', 'admin123', N'Quản Trị Viên Hệ Thống', N'Admin'),
('sinhvien1', '123456', N'Nguyễn Văn An', N'ThiSinh'),
('sinhvien2', '123456', N'Trần Thị Bình', N'ThiSinh'),
('sinhvien3', '123456', N'Lê Hoàng Cường', N'ThiSinh');
GO

-- 2. Nạp môn học mẫu
INSERT INTO MonHoc (MaMon, TenMon, ThoiGianThi, SoCauHoi) VALUES 
('NET', N'Lập trình .NET & C# WinForms', 15, 6),
('A1', N'Lý thuyết lái xe mô tô A1', 19, 5),
('CSDL', N'Cơ sở dữ liệu & SQL Server', 10, 4);
GO

-- 3. Nạp ngân hàng câu hỏi môn .NET
INSERT INTO CauHoi (MaMon, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung) VALUES 
('NET', N'Trong WinForms, thuộc tính nào biến một Form thành Form cha MDI?', N'IsMdiContainer', N'MdiParent', N'IsContainer', N'MdiChild', 'A'),
('NET', N'Từ khóa nào trong C# dùng để khai báo một hằng số không thể thay đổi giá trị?', N'var', N'const', N'readonly', N'static', 'B'),
('NET', N'Control nào trong WinForms dùng để hiển thị biểu tượng thông báo lỗi trực quan cạnh ô nhập liệu?', N'MessageBox', N'ToolTip', N'ErrorProvider', N'Label', 'C'),
('NET', N'Để thực hiện đếm ngược thời gian trong WinForms ta sử dụng component nào?', N'BackgroundWorker', N'Timer', N'ProgressBar', N'Stopwatch', 'B'),
('NET', N'Lớp nào trong ADO.NET dùng để mở kết nối đến CSDL SQL Server?', N'MySqlConnection', N'OleDbConnection', N'SqlConnection', N'DbConnection', 'C'),
('NET', N'Mô hình 3 lớp (3-Tier Architecture) trong ứng dụng thông thường gồm những tầng nào?', N'Model - View - Controller', N'GUI - BLL - DAL', N'Client - Server - Database', N'UI - Service - Repository', 'B');

-- 4. Nạp ngân hàng câu hỏi môn Bằng lái A1
INSERT INTO CauHoi (MaMon, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung) VALUES 
('A1', N'Người đủ bao nhiêu tuổi trở lên thì được điều khiển xe mô tô hai bánh từ 50 cm3 trở lên?', N'16 tuổi', N'18 tuổi', N'20 tuổi', N'21 tuổi', 'B'),
('A1', N'Khi gặp biển báo "Cấm đi ngược chiều", người tham gia giao thông có được phép đi vào không?', N'Được phép nếu đường vắng', N'Không được phép', N'Được đi vào ban đêm', N'Được đi nếu đi xe máy', 'B'),
('A1', N'Người lái xe không được lùi xe ở những khu vực nào dưới đây?', N'Khu vực cho phép đỗ xe', N'Nơi đường bộ giao nhau cùng mức với đường sắt', N'Đoạn đường thẳng có tầm nhìn tốt', N'Khu vực bãi đỗ xe công cộng', 'B'),
('A1', N'Tại nơi đường giao nhau không có báo hiệu đi theo vòng xuyến, người điều khiển phương tiện phải nhường đường như thế nào?', N'Nhường đường cho xe đi đến từ bên trái', N'Nhường đường cho xe đi đến từ bên phải', N'Xe nào tốc độ nhanh hơn được đi trước', N'Xe có phân khối lớn hơn được đi trước', 'B'),
('A1', N'Hành vi nào dưới đây bị nghiêm cấm khi tham gia giao thông đường bộ?', N'Đội mũ bảo hiểm cài quai đúng quy cách', N'Điều khiển xe cơ giới chạy quá tốc độ quy định, giành đường, vượt ẩu', N'Bật đèn chiếu gần trong đô thị vào ban đêm', N'Đi đúng phần đường quy định', 'B');

-- 5. Nạp ngân hàng câu hỏi môn CSDL
INSERT INTO CauHoi (MaMon, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung) VALUES 
('CSDL', N'Khóa chính (Primary Key) trong một bảng cơ sở dữ liệu quan hệ có đặc điểm gì?', N'Chấp nhận giá trị NULL', N'Duy nhất và không được NULL', N'Có thể trùng lặp giá trị', N'Chỉ chứa kiểu số nguyên', 'B'),
('CSDL', N'Lệnh nào trong SQL dùng để xóa toàn bộ dữ liệu trong bảng một cách nhanh chóng mà không ghi log từng dòng?', N'DELETE', N'DROP', N'TRUNCATE', N'REMOVE', 'C'),
('CSDL', N'Mệnh đề nào trong câu lệnh SELECT dùng để lọc kết quả sau khi đã GROUP BY?', N'WHERE', N'HAVING', N'ORDER BY', N'FILTER', 'B'),
('CSDL', N'Ràng buộc nào đảm bảo tính toàn vẹn tham chiếu giữa 2 bảng?', N'PRIMARY KEY', N'UNIQUE', N'CHECK', N'FOREIGN KEY', 'D');

-- 6. Nạp một vài lịch sử bài thi mẫu
INSERT INTO BaiThi (MaND, MaMon, NgayThi, SoCauDung, TongSoCau, DiemSo) VALUES 
(2, 'NET', DATEADD(DAY, -2, GETDATE()), 5, 6, 8.33),
(3, 'A1', DATEADD(DAY, -1, GETDATE()), 5, 5, 10.0),
(2, 'CSDL', GETDATE(), 3, 4, 7.5);
GO
