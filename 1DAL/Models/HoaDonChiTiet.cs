using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class HoaDonChiTiet
    {
        public int MaDTCT { get; set; }
        public int MaHD { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public DienThoaiCT DienThoaiCTS { get; set; }
        public HoaDon HoaDonS { get; set; }
    
    }
}
