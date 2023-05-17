using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class HoaDon
    {
        public int MaHD { get; set; }
        public int MaNV { get; set; }
        public int MaKH { get; set; }
        public DateTime NgayBan { get; set; }
        public string Ghichu { get; set; }
        public int TrangThai { get; set; }
        public string SDTKH { get; set; }
        public int Tong { get; set; }
        public virtual List<HoaDonChiTiet> HoaDonChiTietS { get; set; }
        public NhanVien NhanVienS { get; set; }
        public KhachHang KhachHangS { get; set; }
    }
}
