using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class MauSac
    {
        public int MaMau { get; set; }
        public string TenMau { get; set; }
        public int TrangThai { get; set; }
        public virtual List<DienThoaiCT> DienThoaiCTS { get; set; }
    }
}
