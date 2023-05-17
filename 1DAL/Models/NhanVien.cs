using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public int MaCV { get; set; }
        public string TenNV { get; set; }
        public int GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public int TrangThai { get; set; }
        public string matKhau { get; set; }
        public ChucVu ChucVuS { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
    }
}
