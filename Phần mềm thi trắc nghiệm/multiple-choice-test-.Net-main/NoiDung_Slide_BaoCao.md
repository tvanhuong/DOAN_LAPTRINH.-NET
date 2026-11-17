# KỊCH BẢN & NỘI DUNG SLIDE BÁO CÁO ĐỒ ÁN .NET
## ĐỀ TÀI: PHẦN MỀM THI TRẮC NGHIỆM TRỰC TUYẾN (WINFORMS C#)

---

### SLIDE 1: TRANG BÌA
- **Tiêu đề:** ĐỒ ÁN HỌC PHẦN: LẬP TRÌNH .NET
- **Đề tài:** XÂY DỰNG PHẦN MỀM THI TRẮC NGHIỆM TRỰC TUYẾN
- **Lớp:** DH25PM
- **Công nghệ áp dụng:** C# WinForms (.NET Framework 4.8), Chuẩn MDI, Kiến trúc 3-Tier, Microsoft SQL Server.

---

### SLIDE 2: MỤC TIÊU VÀ YÊU CẦU ĐỒ ÁN
- Xây dựng phần mềm thi trắc nghiệm thực tế phục vụ ôn luyện và kiểm tra kiến thức (ví dụ: Tin học, Bằng lái xe A1, CSDL...).
- Đáp ứng đầy đủ quy định của giảng viên:
  + Giao diện chuẩn MDI đa cửa sổ.
  + Tối thiểu 4 Form nghiệp vụ chính.
  + Kiểm tra ràng buộc và thông báo lỗi dữ liệu (Validation với ErrorProvider).
  + Bố cục giao diện co giãn linh hoạt, không vỡ layout khi phóng to/thu nhỏ cửa sổ.

---

### SLIDE 3: KIẾN TRÚC HỆ THỐNG (MÔ HÌNH 3 LỚP)
- **GUI (Presentation Layer):**
  + Form cha `frmMain` (IsMdiContainer = true).
  + 4 Form chính: `frmQuanLyMonHoc`, `frmQuanLyCauHoi`, `frmThiTracNghiem`, `frmLichSuKetQua`.
  + Form phụ: `frmDangNhap`, `frmDoiMatKhau`.
- **BLL (Business Logic Layer):**
  + Xử lý kiểm tra tính hợp lệ dữ liệu, đếm giờ thi, thuật toán tính điểm và xếp loại.
- **DAL (Data Access Layer):**
  + Lớp dùng chung `DatabaseHelper` kết nối SQL Server qua ADO.NET.
- **DTO (Data Transfer Object):**
  + Các đối tượng truyền dữ liệu giữa các tầng: `NguoiDungDTO`, `MonHocDTO`, `CauHoiDTO`, `BaiThiDTO`.

---

### SLIDE 4: THIẾT KẾ CƠ SỞ DỮ LIỆU
- **4 Bảng dữ liệu quan hệ chặt chẽ:**
  1. `NguoiDung`: Quản lý tài khoản, mật khẩu và phân quyền (Admin / Thí sinh).
  2. `MonHoc`: Quản lý môn thi, thời gian thi (phút) và số câu hỏi đề thi.
  3. `CauHoi`: Ngân hàng câu hỏi trắc nghiệm, 4 phương án A-B-C-D, đáp án đúng.
  4. `BaiThi`: Lưu lịch sử ngày giờ nộp bài, số câu đúng, tổng số câu, điểm số thang 10.
- **Ràng buộc:** Khóa ngoại `ON DELETE CASCADE` đảm bảo toàn vẹn dữ liệu.

---

### SLIDE 5: CHỨC NĂNG QUẢN LÝ (DÀNH CHO ADMIN)
- **Form 1 - Quản lý Môn học:**
  + Thêm, sửa, xóa, làm mới thông tin môn học.
  + Bắt lỗi rỗng mã/tên môn, kiểm tra trùng mã môn, thời gian thi và số câu hỏi phải > 0.
- **Form 2 - Quản lý Ngân hàng Câu hỏi:**
  + Lọc câu hỏi theo từng môn học.
  + Nhập nội dung câu hỏi, 4 đáp án A, B, C, D, chọn đáp án đúng.
  + Hiển thị trực quan trên DataGridView.

---

### SLIDE 6: CHỨC NĂNG LÀM BÀI THI TRẮC NGHIỆM (CORE FEATURE)
- Chọn môn thi -> Bắt đầu làm bài.
- Nạp ngẫu nhiên số lượng câu hỏi từ CSDL (`ORDER BY NEWID()`).
- Đồng hồ đếm ngược `Timer` (hiển thị `mm:ss`), tự động cảnh báo đổi màu đỏ khi < 1 phút.
- Tự động nộp bài khi hết giờ hoặc nộp bài thủ công (có cảnh báo số câu chưa làm).
- Đổi màu trạng thái trên nút số câu hỏi (Xanh lá: đã làm; Xám: chưa làm).
- Tính điểm tự động thang 10, hiển thị xếp loại và lưu vào CSDL.
- Sau khi nộp bài: Cho phép xem lại từng câu hỏi kèm đáp án đúng để đối chiếu.

---

### SLIDE 7: CHỨC NĂNG BÁO CÁO & LỊCH SỬ KẾT QUẢ
- **Form 4 - Lịch sử kết quả thi:**
  + Hiển thị toàn bộ lịch sử thi sắp xếp theo thời gian mới nhất.
  + Phân quyền: Thí sinh chỉ xem kết quả của bản thân; Admin xem được toàn bộ.
  + Hỗ trợ lọc theo từng môn thi.
  + Thống kê tóm tắt: Tổng số lượt thi, Điểm cao nhất, Điểm trung bình.

---

### SLIDE 8: ĐIỂM NỔI BẬT & KỸ THUẬT ÁP DỤNG
- **Giao diện Responsive:** Sử dụng kết hợp `Anchor`, `Dock`, `SplitContainer`, `TableLayoutPanel` giúp ứng dụng co giãn mượt mà trên mọi độ phân giải màn hình.
- **Validation trực quan:** Sử dụng `ErrorProvider` chỉ đích danh ô nhập liệu bị lỗi.
- **Trải nghiệm người dùng:** Thông báo xác nhận rõ ràng, phím tắt tiện lợi (`AcceptButton`, `CancelButton`), phân quyền chặt chẽ.

---

### SLIDE 9: KẾT LUẬN & HƯỚNG PHÁT TRIỂN
- **Kết quả đạt được:** Hoàn thành 100% các yêu cầu quy định trong đề cương đồ án.
- **Hướng phát triển:** Xuất file kết quả ra PDF/Excel, thêm câu hỏi có hình ảnh minh họa, xáo trộn thứ tự các đáp án A-B-C-D.
- Cảm ơn Thầy/Cô và các bạn đã chú ý lắng nghe!
