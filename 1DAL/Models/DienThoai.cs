using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class DienThoai
    {
        public int MaDT { get; set; }
        public string TenDT { get; set; }
        public int TrangThai { get; set; }
        public virtual List<DienThoaiCT> DienThoaiCTS { get; set; }
    }
}
