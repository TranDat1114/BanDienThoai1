using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class DungLuong
    {
        public int MaDungLuong { get; set; }
        public string SoDungLuong { get; set; }
        public int TrangThai { get; set; }
        public virtual List<DienThoaiCT> DienThoaiCTS { get; set; }
    }
}
