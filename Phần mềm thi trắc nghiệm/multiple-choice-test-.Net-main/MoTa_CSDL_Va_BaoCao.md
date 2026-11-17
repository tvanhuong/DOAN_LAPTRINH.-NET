# BÁO CÁO ĐỒ ÁN MÔN HỌC: LẬP TRÌNH .NET (TIE501)
## ĐỀ TÀI: PHẦN MỀM THI TRẮC NGHIỆM TRỰC TUYẾN
**Lớp:** DH25PM  
**Giảng viên hướng dẫn:** Bộ môn Công nghệ phần mềm  

---

## 1. TỔNG QUAN HỆ THỐNG
Phần mềm thi trắc nghiệm được phát triển bằng ngôn ngữ C# trên nền tảng **.NET Framework 4.8** và giao diện **Windows Forms (WinForms)**. Ứng dụng tuân thủ nghiêm ngặt các quy định:
- Thiết kế theo chuẩn giao diện đa tài liệu **MDI (Multiple Document Interface)**.
- Xây dựng theo **mô hình 3 lớp (3-Tier Architecture)**: Giao diện (GUI), Xử lý nghiệp vụ (BLL), Truy xuất dữ liệu (DAL) và Đối tượng dữ liệu (DTO).
- Đạt tối thiểu **4 form nghiệp vụ chính** kèm các form hỗ trợ đăng nhập và đổi mật khẩu.
- Bố cục giao diện co giãn tự động không vỡ bố cục khi Maximize/Resize cửa sổ.
- Ràng buộc và thông báo lỗi dữ liệu bằng `ErrorProvider`.

---

## 2. MÔ TẢ CƠ SỞ DỮ LIỆU (CSDL)

### 2.1. Danh sách các bảng
Hệ thống sử dụng hệ quản trị CSDL **Microsoft SQL Server** với 4 bảng dữ liệu chính:

#### 1. Bảng `NguoiDung` (Lưu thông tin tài khoản đăng nhập và phân quyền)
| Tên cột | Kiểu dữ liệu | Khóa | Cho phép NULL | Mô tả |
| :--- | :--- | :---: | :---: | :--- |
| `MaND` | INT (Identity) | **PK** | Không | Mã định danh người dùng (tự tăng) |
| `TaiKhoan` | VARCHAR(50) | **Unique** | Không | Tên đăng nhập hệ thống |
| `MatKhau` | VARCHAR(100) | | Không | Mật khẩu tài khoản |
| `HoTen` | NVARCHAR(100) | | Không | Họ và tên đầy đủ của người dùng |
| `VaiTro` | NVARCHAR(20) | | Không | Phân quyền: `'Admin'` hoặc `'ThiSinh'` |

#### 2. Bảng `MonHoc` (Lưu danh mục môn thi / chủ đề trắc nghiệm)
| Tên cột | Kiểu dữ liệu | Khóa | Cho phép NULL | Mô tả |
| :--- | :--- | :---: | :---: | :--- |
| `MaMon` | VARCHAR(20) | **PK** | Không | Mã môn học (ví dụ: NET, A1, CSDL) |
| `TenMon` | NVARCHAR(100) | | Không | Tên hiển thị của môn học |
| `ThoiGianThi`| INT | | Không | Thời gian làm bài thi (tính theo phút) |
| `SoCauHoi` | INT | | Không | Số lượng câu hỏi cần lấy cho 1 đề thi |

#### 3. Bảng `CauHoi` (Ngân hàng câu hỏi trắc nghiệm theo từng môn)
| Tên cột | Kiểu dữ liệu | Khóa | Cho phép NULL | Mô tả |
| :--- | :--- | :---: | :---: | :--- |
| `MaCauHoi` | INT (Identity) | **PK** | Không | Mã câu hỏi (tự tăng) |
| `MaMon` | VARCHAR(20) | **FK** | Không | Thuộc môn học nào (Khóa ngoại trỏ đến `MonHoc(MaMon)`) |
| `NoiDung` | NVARCHAR(MAX) | | Không | Nội dung câu hỏi trắc nghiệm |
| `DapAnA` | NVARCHAR(500) | | Không | Lựa chọn A |
| `DapAnB` | NVARCHAR(500) | | Không | Lựa chọn B |
| `DapAnC` | NVARCHAR(500) | | Không | Lựa chọn C |
| `DapAnD` | NVARCHAR(500) | | Không | Lựa chọn D |
| `DapAnDung` | CHAR(1) | | Không | Đáp án đúng: `'A'`, `'B'`, `'C'`, hoặc `'D'` |

#### 4. Bảng `BaiThi` (Lưu kết quả và lịch sử thi của thí sinh)
| Tên cột | Kiểu dữ liệu | Khóa | Cho phép NULL | Mô tả |
| :--- | :--- | :---: | :---: | :--- |
| `MaBaiThi` | INT (Identity) | **PK** | Không | Mã bài thi đã nộp (tự tăng) |
| `MaND` | INT | **FK** | Không | Thí sinh nào thi (Khóa ngoại trỏ đến `NguoiDung(MaND)`) |
| `MaMon` | VARCHAR(20) | **FK** | Không | Môn thi (Khóa ngoại trỏ đến `MonHoc(MaMon)`) |
| `NgayThi` | DATETIME | | Không | Thời điểm nộp bài thi (mặc định: `GETDATE()`) |
| `SoCauDung` | INT | | Không | Số câu trả lời đúng |
| `TongSoCau` | INT | | Không | Tổng số câu hỏi của đề thi |
| `DiemSo` | FLOAT | | Không | Điểm số tính theo thang điểm 10 |

---

### 2.2. Sơ đồ quan hệ giữa các bảng (Entity Relationship Diagram - ERD)

```text
  [NguoiDung] (1) <---------------- (N) [BaiThi]
     (MaND)                               (MaND)
                                            |
                                            | (N)
                                            v
  [CauHoi] (N) -------------------> (1) [MonHoc]
    (MaMon)                               (MaMon)
```

- **Mối quan hệ 1 - N giữa `MonHoc` và `CauHoi`:** Một môn học có thể có nhiều câu hỏi trắc nghiệm trong ngân hàng đề. Khi xóa một môn học, toàn bộ câu hỏi liên quan sẽ tự động xóa theo (`ON DELETE CASCADE`).
- **Mối quan hệ 1 - N giữa `MonHoc` và `BaiThi`:** Một môn học có thể có nhiều lượt bài thi của các thí sinh.
- **Mối quan hệ 1 - N giữa `NguoiDung` và `BaiThi`:** Một người dùng (thí sinh) có thể thực hiện nhiều bài thi khác nhau qua các lần làm bài.

---

## 3. MÔ TẢ CHI TIẾT CÁC FORM CHỨC NĂNG

### 3.1. Form cha MDI (`frmMain`)
- Đặt `IsMdiContainer = true`.
- Quản lý thanh thực đơn `MenuStrip`: Hệ thống, Quản lý, Thi trắc nghiệm, Báo cáo kết quả, Cửa sổ, Trợ giúp.
- Phân quyền động: Khi thí sinh đăng nhập, tự động ẩn thanh menu quản lý câu hỏi và môn học, chỉ cho phép thi và xem điểm.

### 3.2. Form 1: Quản lý Môn học (`frmQuanLyMonHoc`)
- Chức năng: Thêm mới, cập nhật, xóa, làm mới thông tin môn học.
- Ràng buộc (Validation): Bắt lỗi để trống mã môn, tên môn; kiểm tra trùng mã môn học; thời gian thi và số câu hỏi phải > 0.
- Bố cục responsive qua `SplitContainer`, `GroupBox`, `DataGridView`.

### 3.3. Form 2: Quản lý Ngân hàng câu hỏi (`frmQuanLyCauHoi`)
- Chức năng: Lọc câu hỏi theo môn học, nhập nội dung, 4 đáp án A-B-C-D, chọn đáp án đúng.
- Hỗ trợ thêm, sửa, xóa, hiển thị danh sách trên `DataGridView`.

### 3.4. Form 3: Làm bài thi trắc nghiệm (`frmThiTracNghiem`)
- Nạp ngẫu nhiên số lượng câu hỏi từ CSDL (`ORDER BY NEWID()`).
- Đồng hồ đếm ngược `Timer` hiển thị `mm:ss` nổi bật. Tự động đổi màu cảnh báo khi còn dưới 1 phút.
- Danh sách nút số câu hỏi (1..N): Tự động đổi màu xanh lá khi thí sinh đã chọn đáp án câu đó.
- Nộp bài tự động khi hết giờ hoặc nộp bài thủ công có hộp thoại xác nhận số câu chưa làm.
- Tính điểm chuẩn thang 10, lưu vào CSDL, hiển thị xếp loại và hiển thị lại đáp án đúng sau khi nộp để đối chiếu.

### 3.5. Form 4: Lịch sử & Báo cáo kết quả thi (`frmLichSuKetQua`)
- Hiển thị danh sách lịch sử thi có sắp xếp theo thời gian mới nhất.
- Hỗ trợ lọc theo môn học. Phân quyền hiển thị theo người dùng.
- Thống kê tóm tắt: Tổng số lượt thi, Điểm cao nhất, Điểm trung bình.
