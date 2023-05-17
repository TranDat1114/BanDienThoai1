using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1DAL.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaCV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCV = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.MaCV);
                });

            migrationBuilder.CreateTable(
                name: "DienThoai",
                columns: table => new
                {
                    MaDT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDT = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DienThoai", x => x.MaDT);
                });

            migrationBuilder.CreateTable(
                name: "DungLuong",
                columns: table => new
                {
                    MaDungLuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoDungLuong = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DungLuong", x => x.MaDungLuong);
                });

            migrationBuilder.CreateTable(
                name: "HangSX",
                columns: table => new
                {
                    MaHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHang = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangSX", x => x.MaHang);
                });

            migrationBuilder.CreateTable(
                name: "Imei",
                columns: table => new
                {
                    MaImei = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenImei = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imei", x => x.MaImei);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKH = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Diem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    MaMau = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMau = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.MaMau);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCV = table.Column<int>(type: "int", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    matKhau = table.Column<string>(type: "nvarchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_MaCV",
                        column: x => x.MaCV,
                        principalTable: "ChucVu",
                        principalColumn: "MaCV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DienThoaiCT",
                columns: table => new
                {
                    MaDTCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHang = table.Column<int>(type: "int", nullable: false),
                    MaImei = table.Column<int>(type: "int", nullable: false),
                    MaMau = table.Column<int>(type: "int", nullable: false),
                    MaDT = table.Column<int>(type: "int", nullable: false),
                    MaDungLuong = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaNhap = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    MaQR = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LinkAnh = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DienThoaiCT", x => x.MaDTCT);
                    table.ForeignKey(
                        name: "FK_DienThoaiCT_DienThoai_MaDT",
                        column: x => x.MaDT,
                        principalTable: "DienThoai",
                        principalColumn: "MaDT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DienThoaiCT_DungLuong_MaDungLuong",
                        column: x => x.MaDungLuong,
                        principalTable: "DungLuong",
                        principalColumn: "MaDungLuong",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DienThoaiCT_HangSX_MaHang",
                        column: x => x.MaHang,
                        principalTable: "HangSX",
                        principalColumn: "MaHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DienThoaiCT_Imei_MaImei",
                        column: x => x.MaImei,
                        principalTable: "Imei",
                        principalColumn: "MaImei",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DienThoaiCT_MauSac_MaMau",
                        column: x => x.MaMau,
                        principalTable: "MauSac",
                        principalColumn: "MaMau",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<int>(type: "int", nullable: false),
                    MaKH = table.Column<int>(type: "int", nullable: false),
                    NgayBan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    SDTKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonCT",
                columns: table => new
                {
                    MaDTCT = table.Column<int>(type: "int", nullable: false),
                    MaHD = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCT", x => new { x.MaDTCT, x.MaHD });
                    table.ForeignKey(
                        name: "FK_HoaDonCT_DienThoaiCT_MaDTCT",
                        column: x => x.MaDTCT,
                        principalTable: "DienThoaiCT",
                        principalColumn: "MaDTCT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonCT_HoaDon_MaHD",
                        column: x => x.MaHD,
                        principalTable: "HoaDon",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "MaCV", "TenCV" },
                values: new object[,]
                {
                    { 1, "Quản lý" },
                    { 2, "Nhân viên" }
                });

            migrationBuilder.InsertData(
                table: "DienThoai",
                columns: new[] { "MaDT", "TenDT", "TrangThai" },
                values: new object[,]
                {
                    { 1, "Iphone 14 Pro Max", 1 },
                    { 2, "Realme note 9 pro", 1 }
                });

            migrationBuilder.InsertData(
                table: "DungLuong",
                columns: new[] { "MaDungLuong", "SoDungLuong", "TrangThai" },
                values: new object[,]
                {
                    { 1, "8gb Ram/ 124gb bo nho", 1 },
                    { 2, "6gb Ram/ 64gb bo nho", 1 }
                });

            migrationBuilder.InsertData(
                table: "HangSX",
                columns: new[] { "MaHang", "TenHang", "TrangThai" },
                values: new object[,]
                {
                    { 1, "Apple", 1 },
                    { 2, "Realme", 1 }
                });

            migrationBuilder.InsertData(
                table: "Imei",
                columns: new[] { "MaImei", "TenImei", "TrangThai" },
                values: new object[,]
                {
                    { 1, "0123456789", true },
                    { 2, "0123456788", true }
                });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "MaKH", "DiaChi", "Diem", "GioiTinh", "SDT", "TenKH" },
                values: new object[,]
                {
                    { 1, "Hà Nam", 50000, true, "0336253482", "Ngô Quốc Mạnh" },
                    { 2, "Hà Nội", 50000, true, "0123456789", "Chuyên Xem Chùa" },
                    { 3, "không rõ", 0, true, "0", "Khách Vãng Lai" }
                });

            migrationBuilder.InsertData(
                table: "MauSac",
                columns: new[] { "MaMau", "TenMau", "TrangThai" },
                values: new object[,]
                {
                    { 1, "Xanh", 1 },
                    { 2, "Tim", 1 }
                });

            migrationBuilder.InsertData(
                table: "DienThoaiCT",
                columns: new[] { "MaDTCT", "GiaBan", "GiaNhap", "LinkAnh", "MaDT", "MaDungLuong", "MaHang", "MaImei", "MaMau", "MaQR", "SoLuong", "TrangThai" },
                values: new object[] { 1, 110000, 100000, "", 1, 1, 1, 1, 1, "12345", 50, true });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "MaNV", "DiaChi", "GioiTinh", "MaCV", "NgaySinh", "SDT", "TenNV", "TrangThai", "matKhau" },
                values: new object[] { 1, "Hà Nam", 1, 1, new DateTime(2023, 5, 15, 13, 30, 43, 484, DateTimeKind.Local).AddTicks(5560), "0336253482", "Ngô Quốc Mạnh", 0, "123" });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "MaNV", "DiaChi", "GioiTinh", "MaCV", "NgaySinh", "SDT", "TenNV", "TrangThai", "matKhau" },
                values: new object[] { 2, "Tuyên Quang", 1, 2, new DateTime(2023, 5, 15, 13, 30, 43, 484, DateTimeKind.Local).AddTicks(5551), "0379702133", "Nguyễn Văn Đạo", 0, "123" });

            migrationBuilder.CreateIndex(
                name: "IX_DienThoaiCT_MaDT",
                table: "DienThoaiCT",
                column: "MaDT");

            migrationBuilder.CreateIndex(
                name: "IX_DienThoaiCT_MaDungLuong",
                table: "DienThoaiCT",
                column: "MaDungLuong");

            migrationBuilder.CreateIndex(
                name: "IX_DienThoaiCT_MaHang",
                table: "DienThoaiCT",
                column: "MaHang");

            migrationBuilder.CreateIndex(
                name: "IX_DienThoaiCT_MaImei",
                table: "DienThoaiCT",
                column: "MaImei");

            migrationBuilder.CreateIndex(
                name: "IX_DienThoaiCT_MaMau",
                table: "DienThoaiCT",
                column: "MaMau");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKH",
                table: "HoaDon",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNV",
                table: "HoaDon",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_MaHD",
                table: "HoaDonCT",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaCV",
                table: "NhanVien",
                column: "MaCV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonCT");

            migrationBuilder.DropTable(
                name: "DienThoaiCT");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "DienThoai");

            migrationBuilder.DropTable(
                name: "DungLuong");

            migrationBuilder.DropTable(
                name: "HangSX");

            migrationBuilder.DropTable(
                name: "Imei");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
