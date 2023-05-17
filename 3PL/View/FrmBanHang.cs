using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2BUS.IService;
using _2BUS.Service;
using _1DAL.Models;
using _2BUS.ViewModel;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
namespace _3PL.View
{
    public partial class FrmBanHang : Form
    {
        IDTCTService _IDTCTService = new DTCTService();
        IDTService _IDTService = new DTService();
        IDungLuongService _IDLService = new DungLuongService();
        IHSXService _IHSXService = new HSXService();
        IImeiService _IImeiService = new IMeiService();
        IKhachHangService _IKHService = new KhachHangService();
        IMauSacService _IMSService = new MauSacService();
        IHoaDonService _IHoaDonService = new HoaDonService();
        INhanVienService _INVService = new NhanVienService();   
        IHoaDonCTService_ _IHDCTService = new HoaDonCTService();
        public List<HoaDonChiTietView> _lstHoaDon = new List<HoaDonChiTietView>();
        DienThoai _DT = new DienThoai();
        public int spID;
        public int IdHD = -1;
        KhachHang _KH = new KhachHang();
        HoaDon _HD;
        DienThoaiCT _DTCT = new DienThoaiCT();
        string linkavata = "";
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        public FrmBanHang()
        {
            InitializeComponent();
            LoadSP();
            LoadGioHang();
            LoadHoaDon();
            
        }
        public void LoadSP()
        {
           
            dtg_listsp.ColumnCount = 10;
            dtg_listsp.Columns[0].Name = "MaDTCT";
            dtg_listsp.Columns[0].Visible = false; 
            dtg_listsp.Columns[1].Name = "Imei SP";
            dtg_listsp.Columns[2].Name = "Tên SP";
            dtg_listsp.Columns[3].Name = "Hãng SP";
            dtg_listsp.Columns[4].Name = "Mau Sac SP";
            dtg_listsp.Columns[5].Name = "Dung Luong SP";
            dtg_listsp.Columns[6].Name = "Số Lượng SP";
            dtg_listsp.Columns[7].Name = "Giá Nhập";
            dtg_listsp.Columns[8].Name = "Giá Bán";
            dtg_listsp.Columns[9].Name = "LinkAnh";
            dtg_listsp.Columns[9].Visible = false;
            dtg_listsp.Rows.Clear();
            var showall = _IDTCTService.GetAllDTCT();
          

            if (tb_timkiem.Text != "")
            {
                showall = showall.Where(p => p.dienThoaiCT.MaQR.ToString().Contains(tb_timkiem.Text) || p.dienThoai.TenDT.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var item in showall)
            {
                dtg_listsp.Rows.Add(item.dienThoaiCT.MaDTCT, item.imei.TenImei, item.dienThoai.TenDT, item.hangSX.TenHang, item.mauSac.TenMau, item.dungLuong.SoDungLuong, item.dienThoaiCT.SoLuong, item.dienThoaiCT.GiaNhap, item.dienThoaiCT.GiaBan, item.dienThoaiCT.LinkAnh);
            }
        }
        public void LoadGioHang()
        {
            dtg_giohang.ColumnCount = 4;
            dtg_giohang.Columns[0].Name = "MaDTCT";  
            dtg_giohang.Columns[1].Name = "Tên SP";
            dtg_giohang.Columns[2].Name = "Số Lượng SP";
            dtg_giohang.Columns[3].Name = "Đơn Giá";
            dtg_giohang.Rows.Clear();
            foreach (var item in _lstHoaDon)
            {
                dtg_giohang.Rows.Add(item.Id, item.tendienthoai,item.Soluong, item.DonGia);
            }
            TONGTIEN();
        }
        public void TONGTIEN()
        {
            if (_lstHoaDon != null)
            {
                int Tien = 0;
                foreach (var item in _lstHoaDon)
                {
                    Tien += Convert.ToInt32(item.DonGia) * item.Soluong;
                }
                lb_tong.Text = Tien.ToString();
            }
            else
            {
                lb_tong.Text = "";
            }
        }
        public void LoadHoaDon()
        {
            dtg_hoadoncho.ColumnCount = 4;
            dtg_hoadoncho.Columns[0].Name = "Mã HĐ";
            dtg_hoadoncho.Columns[1].Name = "Tên KH";
            dtg_hoadoncho.Columns[2].Name = "Tình Trạng";
            dtg_hoadoncho.Columns[3].Name = "Tên SP";
            dtg_hoadoncho.Columns[3].Visible = false;
            dtg_hoadoncho.Rows.Clear();
            var hd = _IHoaDonService.GetAllView().Where(p => p.hoaDon.TrangThai == 0).ToList();
            foreach(var item in hd)
            {
                dtg_hoadoncho.Rows.Add(item.hoaDon.MaHD, item.khachHang.TenKH, item.hoaDon.TrangThai == 0 ? "Chưa thanh toán" : "Đã thanh toán");
            }
            
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadSP();
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            tb_timkiem.Text = "";
            LoadSP();
        }
        public void addGH(int id)
        {
            var sp = _IDTCTService.GetAllDTCT().FirstOrDefault(p => p.dienThoaiCT.MaDTCT == id);
            var data = _lstHoaDon.FirstOrDefault(p => p.Id == sp.dienThoaiCT.MaDTCT);
            if (sp.dienThoaiCT.SoLuong <= 0)
            {
                MessageBox.Show("Hết hàng");
            }
            else if (data == null)
            {
                HoaDonChiTietView hdct = new HoaDonChiTietView()
                {
                    Id = sp.dienThoaiCT.MaDTCT,
                    tendienthoai = sp.dienThoai.TenDT,
                    DonGia = sp.dienThoaiCT.GiaBan,
                    Soluong = 1,
                };
                _lstHoaDon.Add(hdct);
            }
            else
            {
                if(data.Soluong == sp.dienThoaiCT.SoLuong)
                {
                    MessageBox.Show("Sản phẩm trong giỏ đã vượt quá số lượng tồn");
                }
                else
                {
                    data.Soluong++;
                }
            }
            LoadGioHang();
           
        }

        private void dtg_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_giohang.Rows[e.RowIndex];
                spID = Convert.ToInt32(r.Cells[0].Value.ToString());
            }
        }

        private void dtg_listsp_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_listsp.Rows[e.RowIndex];
                _DTCT = _IDTCTService.GetAll().FirstOrDefault(p => p.MaDTCT == Convert.ToInt32(r.Cells[0].Value.ToString()));
                spID = Convert.ToInt32(r.Cells[0].Value.ToString());
                addGH(spID);
                if (_DTCT.LinkAnh != null && File.Exists(_DTCT.LinkAnh))
                {
                    pcb_anhSP.Image = Image.FromFile(_DTCT.LinkAnh);
                    pcb_anhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                    linkavata = _DTCT.LinkAnh;
                }
                else
                {
                    pcb_anhSP.Image = null;
                }
            }
        }

        private void dtg_giohang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_giohang.Rows[e.RowIndex];
                if (int.TryParse(dtg_giohang.Rows[r.Index].Cells[2].Value.ToString(), out int x))
                {
                    if (dtg_giohang.Rows[r.Index].Cells[2].Value != _lstHoaDon[r.Index].Soluong.ToString())
                    {
                        if (Convert.ToInt32(dtg_giohang.Rows[r.Index].Cells[2].Value) <= 0)
                        {
                            MessageBox.Show("Nhập sai số lượng");
                            dtg_giohang.Rows[r.Index].Cells[2].Value = _lstHoaDon[r.Index].Soluong;
                        }
                        else
                        {
                            var p = _IDTCTService.GetAll().FirstOrDefault(x => x.MaDTCT == _lstHoaDon[r.Index].Id);
                            if (p.SoLuong < Convert.ToInt32(dtg_giohang.Rows[r.Index].Cells[2].Value))
                            {
                                MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                                dtg_giohang.Rows[r.Index].Cells[2].Value = _lstHoaDon[r.Index].Soluong;
                            }
                            else
                            {
                                _lstHoaDon[r.Index].Soluong = Convert.ToInt32(dtg_giohang.Rows[r.Index].Cells[2].Value);
                                TONGTIEN();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai số lượng");
                    dtg_giohang.Rows[r.Index].Cells[3].Value = _lstHoaDon[r.Index].Soluong;
                }
            }
        }

        private void tb_mahd_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_mahd.Text, out int m))
            {
                HoaDon o = _IHoaDonService.GetAll().FirstOrDefault(x => x.MaHD == Convert.ToInt32(tb_mahd.Text) && x.TrangThai ==0);
                
                if (o != null)
                {

                    var a = _IHDCTService.GetAll().FirstOrDefault(p=>p.MaHD==spID);
                    lb_tongtien.Text = Convert.ToString(a.SoLuong * a.DonGia);
                    tb_tienkhachdua.Text = "";
                    var khach = _IKHService.GetAll().FirstOrDefault(x => x.SDT == o.SDTKH);
                    lb_giamgia.Text = $"{khach.Diem}";
                    tbt_giamGia.Text = "0";
                }
                else
                {
                    lb_tongtien.Text = "";
                    lb_tong.Text = "";
                    tbt_giamGia.Text = "";
                   
                    tb_tienkhachdua.Text = "";
                }

            }
        }

        private void btn_xoagiohang_Click(object sender, EventArgs e)
        {
            if (_lstHoaDon.Any())
            {
                _lstHoaDon = null;
                _lstHoaDon = new List<HoaDonChiTietView>();
                LoadGioHang();
                tb_sdtkh.Text = "";
                tb_mahd.Text = "";

            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void btn_xoasp_Click(object sender, EventArgs e)
        {
            if (_lstHoaDon.Any())
            {
                var item = _lstHoaDon.FirstOrDefault(x => x.Id == spID);
                _lstHoaDon.Remove(item);
                LoadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            
                if (_lstHoaDon.Any())
                {
                    int Tong = 0;
                    foreach (var item in _lstHoaDon)
                    {
                        Tong += item.DonGia * item.Soluong;
                    }
                    _KH = _IKHService.GetAll().FirstOrDefault(x => x.SDT == tb_sdtkh.Text);
                 
                    var KHH = _IKHService.GetAll().FirstOrDefault(x => x.SDT == "0");
                int IDNV = _INVService.GetAllView().FirstOrDefault(x => x.nhanVien.SDT == Properties.Settings.Default.tk).nhanVien.MaNV;
                if (_KH != null)
                    {
                    HoaDon HD = new HoaDon()
                    {
                        MaNV = IDNV,
                        MaKH = _KH.MaKH,
                        SDTKH = _KH.SDT,
                        TrangThai = 0,
                        Tong = Tong,
                        NgayBan = DateTime.Now,
                        Ghichu = tbt_ghiChu.Text,
                    };
                        _IHoaDonService.Add(HD);
                        foreach (var item in _lstHoaDon)
                        {
                            HoaDonChiTiet od = new HoaDonChiTiet()
                            {
                                MaHD = HD.MaHD,
                                MaDTCT = item.Id,
                                DonGia = item.DonGia,
                                SoLuong = item.Soluong

                            };
                            _IHDCTService.Add(od);
                            var p = _IDTCTService.GetAll().FirstOrDefault(x => x.MaDTCT == item.Id);

                            p.SoLuong -= item.Soluong;
                            _IDTCTService.Update(p);

                        }
                        MessageBox.Show($"Tạo hóa đơn thành công. ID: {HD.MaHD}");
                        LoadHoaDon();
                        _lstHoaDon = new List<HoaDonChiTietView>();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập khách hàng");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
                }
        }

        private void tb_sdtkh_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_sdtkh.Text, out int x))
            {
                _KH = _IKHService.GetAll().FirstOrDefault(x => x.SDT == tb_sdtkh.Text);
                var KHH = _IKHService.GetAll().FirstOrDefault(x => x.SDT == "0");
                if (_KH != null)
                {
                    lb_tenkh.Text = _KH.TenKH;
                    tb_diemtichluy.Text = _KH.Diem.ToString();
                }
                else if (KHH != null)
                {
                    lb_tenkh.Text = KHH.TenKH;
                    tb_diemtichluy.Text = KHH.Diem.ToString();
                }
                else
                {
                    lb_tenkh.Text = "";
                    tb_diemtichluy.Text = "";
                }
            }
            else
            {
                lb_tenkh.Text = "";
                tb_diemtichluy.Text = "";
            }
        }

        private void btn_capNhapHĐ_Click(object sender, EventArgs e)
        {
            if (spID != -1)
            {
                if (_lstHoaDon.Any())
                {
                    int Tien = 0;
                    _KH = _IKHService.GetAll().FirstOrDefault(x => x.SDT == tb_sdtkh.Text);
                    if (_KH != null)
                    {
                        var HD = _IHoaDonService.GetAll().FirstOrDefault(x => x.MaHD == spID);
                        var HDCT = _IHDCTService.GetAll().Where(x => x.MaHD == spID);
                        foreach (var item in HDCT)
                        {
                            _IHDCTService.Delete(item);
                        }

                        
                        foreach (var item in _lstHoaDon)
                        {
                            HoaDonChiTiet hoadonct = new HoaDonChiTiet()
                            {
                                MaHD = spID,
                                MaDTCT = item.Id,
                                DonGia = item.DonGia,
                                SoLuong = item.Soluong
                            };
                            Tien += Convert.ToInt32(item.DonGia * item.Soluong);
                            _IHDCTService.Add(hoadonct);
                            var SP = _IDTCTService.GetAll().FirstOrDefault(x => x.MaDTCT == item.Id);
                            SP.SoLuong -= item.Soluong;
                            _IDTCTService.Update(SP);
                        }
                        
                        HD.NgayBan = DateTime.Now;
                        HD.SDTKH = _KH.SDT;
                        HD.MaKH = _KH.MaKH;
                        HD.Tong = Tien;
                        _IHoaDonService.Update(HD);

                        tb_mahd.Text = spID.ToString();
                        lb_tongtien.Text = Tien.ToString();
                        tb_sdtkh.Text = "";
                        lb_tong.Text = "";
                        tbt_giamGia.Text = "";
                        tb_mahd.Text = "";
                        MessageBox.Show($"Cập nhật hóa đơn thành công. ID: {spID}");
                        spID = -1;
                        LoadHoaDon();
                        dtg_giohang.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập khách hàng");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn chưa thanh toán");
            }
        }

        private void tb_tienkhachdua_TextChanged(object sender, EventArgs e)
        {
            LoadTienThua();
            
        }

        private void dtg_hoadoncho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_hoadoncho.Rows[e.RowIndex];
                spID = Convert.ToInt32(r.Cells[0].Value.ToString());
                tb_mahd.Text = spID.ToString();

                var HDCT = _IHDCTService.GetAll().Where(x => x.MaHD == spID);
                var HD = _IHoaDonService.GetAll().FirstOrDefault(x => x.MaHD == spID).SDTKH;
                var KH = _IKHService.GetAll().FirstOrDefault(x => x.SDT == HD);

                tb_sdtkh.Text = KH.SDT;
                _lstHoaDon = new List<HoaDonChiTietView>();
                foreach (var item in HDCT)
                {
                    var SP = _IDTCTService.GetAllDTCT().FirstOrDefault(x => x.dienThoaiCT.MaDTCT == item.MaDTCT);
                
                    HoaDonChiTietView ViewHDCT = new HoaDonChiTietView()
                    {
                        Id = SP.dienThoaiCT.MaDTCT,
                        tendienthoai = SP.dienThoai.TenDT,
                        DonGia = SP.dienThoaiCT.GiaBan,
                        Soluong = HDCT.FirstOrDefault(x => x.MaDTCT == SP.dienThoaiCT.MaDTCT).SoLuong
                    };
                    _lstHoaDon.Add(ViewHDCT);

                    LoadGioHang();
                }
            }
        }
        public void LoadTienThua()
        {
            if (!(tb_tienkhachdua.Text == "" && tbt_giamGia.Text == ""))
            {
                if (tbt_giamGia.Text == "")
                {
                    if (float.TryParse(tb_tienkhachdua.Text, out float x))
                    {
                        lb_tientralai.Text = (float.Parse(tb_tienkhachdua.Text) - float.Parse(lb_tongtien.Text)).ToString();
                    }
                }
                else
                {
                    if (float.TryParse(tb_tienkhachdua.Text, out float x) && float.TryParse(tbt_giamGia.Text, out float y))
                    {
                        lb_tientralai.Text = (float.Parse(tb_tienkhachdua.Text) - float.Parse(lb_tongtien.Text) + float.Parse(tbt_giamGia.Text)).ToString();
                    }
                }
            }
        }

        public void giamgia()
        {
            lb_giamgia.Text = tb_diemtichluy.Text;
        }
        private void tbt_giamGia_TextChanged(object sender, EventArgs e)
        {
            LoadTienThua();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            HoaDon HD = _IHoaDonService.GetAll().FirstOrDefault(p => Convert.ToString(p.MaHD) == tb_mahd.Text && p.TrangThai == 0);
            if (HD == null)
            {
                MessageBox.Show("Đơn hàng không tồn tại hoặc đã thanh toán");
                lb_tong.Text = "0";
            }
            else if (tb_mahd.Text == "")
            {
                MessageBox.Show("Đơn hàng không tồn tại");
            }
            else
            {
                var KhachH = _IKHService.GetAll().FirstOrDefault(x => x.SDT == HD.SDTKH);
                int x;
                if (tbt_giamGia.Text == "" || float.Parse(tbt_giamGia.Text) < 0 || float.Parse(lb_tientralai.Text) < 0 || tb_tienkhachdua.Text == "" || (!float.TryParse(tbt_giamGia.Text, out float z) && tbt_giamGia.Text != "") || !float.TryParse(tb_tienkhachdua.Text, out float y) || float.Parse(tbt_giamGia.Text) > float.Parse(lb_tong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng số tiền");
                }
                else if (Convert.ToInt32(tb_diemtichluy.Text) < Convert.ToInt32(tbt_giamGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng số tiền");
                }
               
                else if (tb_sdtkh.Text == "0")
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thanh toán", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        HD.TrangThai = 1;
                        HD.Ghichu = tbt_ghiChu.Text;
                        _IHoaDonService.Update(HD);
                        if (tb_tienkhachdua.Text == "0" && float.Parse(tbt_giamGia.Text) > HD.Tong)
                        {
                            lb_tientralai.Text = "0";
                            KhachH.Diem -= Convert.ToInt32(HD.Tong);
                        }
                        MessageBox.Show("Thanh toán thành công");
                        tb_mahd.Text = "";
                        tb_sdtkh.Text = "";
                        tbt_giamGia.Text = "";
                        lb_giamgia.Text = "";
                        tb_tienkhachdua.Text = "";
                        lb_tongtien.Text = "";
                        lb_tong.Text = "";
                        lb_tientralai.Text = "0";
                        tbt_ghiChu.Text = "";
                        _lstHoaDon = new List<HoaDonChiTietView>();
                        LoadGioHang();
                        LoadHoaDon();
                        LoadSP();
                        
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thanh toán", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        HD.TrangThai = 1;
                        HD.Ghichu = tbt_ghiChu.Text;
                        _IHoaDonService.Update(HD);
                        if (tb_tienkhachdua.Text == "0" && float.Parse(tbt_giamGia.Text) > HD.Tong)
                        {
                            lb_tientralai.Text = "0";
                            KhachH.Diem -= Convert.ToInt32(HD.Tong);
                        }
                        else
                        {
                            if (tbt_giamGia.Text != "")
                            {
                                KhachH.Diem = KhachH.Diem + Convert.ToInt32((HD.Tong * 10) / 100) - Convert.ToInt32(tbt_giamGia.Text);
                            }
                            else
                            {
                                KhachH.Diem += Convert.ToInt32((HD.Tong * 10) / 100);
                            }
                        }
                        _IKHService.Update(KhachH);
                        MessageBox.Show("Thanh toán thành công");
                        tb_mahd.Text = "";
                        tb_sdtkh.Text = "";
                        tbt_giamGia.Text = "";
                        lb_giamgia.Text = "";
                        tb_tienkhachdua.Text = "";
                        lb_tongtien.Text = "";
                        lb_tong.Text = "";
                        lb_tientralai.Text = "0";
                        tbt_ghiChu.Text = "";
                        _lstHoaDon = new List<HoaDonChiTietView>();
                        LoadGioHang();
                        LoadHoaDon();
                        LoadSP();
                       
                    }
                }
            }
        }

        private void lb_giamgia_Click(object sender, EventArgs e)
        {
            giamgia();
        }

        private void pcb_anhSP_Click(object sender, EventArgs e)
        {

        }
        private void CaptureDecvice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ptb_quetma.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ptb_quetma.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)ptb_quetma.Image);
                if (result != null)
                {
                   
                    tb_timkiem.Text = result.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Quét mã")
            {
                cboDevice.Visible = false;
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                {
                    cboDevice.Items.Add(filterInfo.Name);
                }
                cboDevice.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += new NewFrameEventHandler(CaptureDecvice_NewFrame);
                videoCaptureDevice.Start();
                timer1.Start();
                button1.Text = "Dừng Quét";
            }
            else
            {
                DialogResult dl = MessageBox.Show("Ban co muon dung quet khong", "Chu y", MessageBoxButtons.YesNo);
                if (dl == DialogResult.Yes)
                {
                    videoCaptureDevice.Stop();
                    button1.Text = "Quét mã";
                }

            }
        }

        private void cboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
