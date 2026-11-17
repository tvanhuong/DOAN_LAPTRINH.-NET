# Đồ Án Lập Trình .NET: Phần Mềm Thi Trắc Nghiệm Trực Tuyến

- **Môn học:** Lập trình .NET (Mã HP: TIE501)
- **Lớp:** DH25PM
- **Kiến trúc:** Chuẩn MDI, Mô hình 3 lớp (3-Tier: GUI - BLL - DAL - DTO)
- **Công nghệ:** C# Windows Forms (.NET Framework 4.8), Microsoft SQL Server

---

## Cấu Trúc Thư Mục

```text
ThiTracNghiem_DotNet/
├── ThiTracNghiem.sln             # File Solution mở bằng Visual Studio
├── CSDL_ThiTracNghiem.sql        # Script tạo CSDL và dữ liệu mẫu nộp cho GV
├── HuongDanSuDung.txt            # Hướng dẫn chạy & tài khoản test nộp cho GV
├── MoTa_CSDL_Va_BaoCao.md        # Nội dung nộp file Word (mô tả bảng, quan hệ, form)
├── NoiDung_Slide_BaoCao.md       # Nội dung nộp file PowerPoint thuyết trình
├── .gitignore                    # Bỏ qua bin, obj, packages khi push git
└── ThiTracNghiem/
    ├── ThiTracNghiem.csproj      # Project file Visual Studio
    ├── App.config                # Cấu hình chuỗi kết nối SQL Server (Data Source=.)
    ├── Program.cs                # Điểm khởi chạy ứng dụng (Mở frmDangNhap)
    ├── DTO/                      # Tầng đối tượng truyền dữ liệu
    ├── DAL/                      # Tầng truy xuất CSDL (ADO.NET)
    ├── BLL/                      # Tầng xử lý nghiệp vụ & validation
    ├── GUI/                      # Tầng giao diện người dùng WinForms
    └── Properties/               # Cấu hình AssemblyInfo
```

---

## Hướng Dẫn Sử Dụng Nhanh

1. Mở SQL Server Management Studio (SSMS) trên máy trường, mở file `CSDL_ThiTracNghiem.sql` và bấm **F5** để khởi tạo Database.
2. Mở file `ThiTracNghiem.sln` bằng Visual Studio 2019/2022.
3. Bấm **F5** để chạy!
   - Tài khoản Admin: `admin` / `admin123`
   - Tài khoản Thí sinh: `sinhvien1` / `123456`
