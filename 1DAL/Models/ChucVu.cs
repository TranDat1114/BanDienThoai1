
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class ChucVu
    {
        public int MaCV { get; set; }
        public string TenCV { get; set; }
        public virtual List<NhanVien> NhanVienS { get; set; }
    }
}
