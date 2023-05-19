using _1DAL.Models;

using _2BUS.IService;
using _2BUS.Service;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace _3PL.View
{
    public partial class FrmThongKe : Form
    {
        private IDTService _dt;
        private IDTCTService _dtct;
        private IDungLuongService _dungLuong;
        private IHoaDonService _hd;
        private IHoaDonCTService_ _hdct;
        private IKhachHangService _kh;
        public List<HoaDon> _lstHoaDon;
        public List<HoaDonChiTiet> _lstHDCT;
        public List<KhachHang> _lstKhachHang;
        public List<DienThoaiCT> _lstDTCT;
        public INhanVienService _nv;
        public List<NhanVien> _lstnv;
        public FrmThongKe(IDTService dTService, IDTCTService dTCTService, IDungLuongService dungLuongService, IHoaDonService hoaDonService, IHoaDonCTService_ hoaDonCTService_, IKhachHangService khachHangService, INhanVienService nhanVienService)
        {
            InitializeComponent();
            _dt = dTService;
            _dtct = dTCTService;
            _dungLuong = dungLuongService;
            _hd = hoaDonService;
            _hdct = hoaDonCTService_;
            _kh = khachHangService;
            _nv = nhanVienService;
            _lstnv = new List<NhanVien>();

            _lstKhachHang = new List<KhachHang>();
            _lstHDCT = new List<HoaDonChiTiet>();
            _lstHoaDon = _hd.GetAll();
            _lstDTCT = new List<DienThoaiCT>();
            LoadDate();
            loadData();

        }

        public void LoadDate()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbb_thang.Items.Add(i);

            }
            //var x = Convert.ToInt32(_lstHoaDon.FirstOrDefault().NgayBan.ToString("yyyy"));
            //var y = Convert.ToInt32(_lstHoaDon.LastOrDefault().NgayBan.ToString("yyyy"));
            //for (int i = x; i <= y; i++)
            //{
            //    cbb_nam.Items.Add(i);
            //}

        }
        public void loadData()
        {
            dtgv_show.Rows.Clear();

            var data = (from a in _lstHoaDon
                        join b in _kh.GetAll()
                        on a.MaKH equals b.MaKH
                        join c in _nv.GetAll() on a.MaNV equals c.MaNV
                        select new { a, b, c }
                        );


            foreach (var item in data)
            {
                dtgv_show.Rows.Add(item.a.MaHD, item.c.TenNV, item.a.Tong, item.a.NgayBan, item.b.SDT, item.a.TrangThai == 1 ? "Đã thanh toán" : "Chưa thanh toán");
            }

            lb_doanhthu.Text = data.Select(x => x.a).Distinct().Sum(x => x.Tong).ToString();
            lb_tonghd.Text = data.GroupBy(x => x.a).Count().ToString();
            lb_chuathanhtoan.Text = data.Select(x => x.a).Distinct().Where(x => x.TrangThai == 0).Count().ToString();
            lb_khachhang.Text = data.GroupBy(x => x.b).Count().ToString();

        }

        //private void dtp_ngay_ValueChanged(object sender, EventArgs e)
        //{
        //    _lstHoaDon = _hd.GetAll().Where(x => x.NgayBan.ToString("dd-MM-yyyy") == dtp_ngay.Value.ToString("dd-MM-yyyy")).ToList();
        //    loadData();
        //}

        private void dtp_ngay_ValueChanged_1(object sender, EventArgs e)
        {
            var a = dtp_ngay.Value.ToString("dd-MM-yyyy");
            _lstHoaDon = _hd.GetAll().Where(x => x.NgayBan.ToString("dd-MM-yyyy") == a).ToList();
            loadData();
        }


        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
            if (tb_sdt.Text != "")
            {
                _lstHoaDon = _hd.GetAll().Where(x => x.SDTKH.ToString().Contains(tb_sdt.Text)).ToList();
                loadData();
            }

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            cbb_thang.SelectedIndex = 0;
            cbb_nam.SelectedIndex = 0;
            dtp_ngay.Text = DateTime.Now.ToString();
            loadData();
        }

        private void cbb_thang_TextChanged(object sender, EventArgs e)
        {
            if (cbb_nam.Text != "")
            {
                _lstHoaDon = _hd.GetAll().Where(x => (x.NgayBan.Year.ToString() == cbb_nam.Text && x.NgayBan.Month.ToString() == cbb_thang.Text)).ToList();
                loadData();
            }
        }

        private void cbb_nam_TextChanged(object sender, EventArgs e)
        {
            _lstHoaDon = _hd.GetAll().Where(x => x.NgayBan.Year.ToString() == cbb_nam.Text).ToList();
            loadData();
        }
    }
}
