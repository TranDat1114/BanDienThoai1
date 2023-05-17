using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _2BUS.ViewModel
{
    public class ChiTietSPView
    {
        public DienThoaiCT dienThoaiCT { get; set; }
        public MauSac mauSac { get; set; }
        public HangSX hangSX { get; set; }
        public DungLuong dungLuong { get; set; }
        public DienThoai dienThoai { get; set; }
        public Imei imei { get; set; }
        public HoaDon hoaDon { get; set; }
        public KhachHang khachHang { get; set; }


    }
}
