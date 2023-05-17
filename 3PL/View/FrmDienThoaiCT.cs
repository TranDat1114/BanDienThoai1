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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
namespace _3PL.View
{
    public partial class FrmDienThoaiCT : Form
    {
        string linkavata = "";
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        DienThoaiCT _DTCT = new DienThoaiCT();
        IDTCTService _DTCTService = new DTCTService();
        IDTService _DTService = new DTService();
        IMauSacService _MauSacService = new MauSacService();
        IImeiService _ImeiService = new IMeiService();
        IDungLuongService _DungLuongService = new DungLuongService();
        IHSXService _HSXService = new HSXService();
        public FrmDienThoaiCT()
        {
            InitializeComponent();
            var dt = _DTService.GetAll().Where(p => p.TrangThai ==1);
            var ms = _MauSacService.GetAll().Where(p => p.TrangThai == 1);
            var imei = _ImeiService.GetAll().Where(p => p.TrangThai == true);
            var dungluong = _DungLuongService.GetAll().Where(p => p.TrangThai == 1);
            var hsx = _HSXService.GetAll().Where(p => p.TrangThai == 1);
            foreach (var item in dt)
            {
                cbb_dienthoai.Items.Add(item.TenDT);
            }
            
            foreach (var item in ms)
            {
                
                cbb_mausac.Items.Add(item.TenMau);
            }
            foreach (var item in imei)
            {
                cbb_Imei.Items.Add(item.TenImei);
            }
            foreach (var item in dungluong)
            {
                cbb_dungluong.Items.Add(item.SoDungLuong);
            }
            foreach (var item in hsx)
            {
                cbb_hangSX.Items.Add(item.TenHang);
            }
            Loadtodata();
        }
        public void Loadtodata()
        {
            dtg_show.ColumnCount = 12;
            dtg_show.Columns[10].Name = "MaDTCT";
            dtg_show.Columns[10].Visible = false; ;
            dtg_show.Columns[0].Name = "Mã QR";
            dtg_show.Columns[1].Name = "Imei SP";
            dtg_show.Columns[2].Name = "Tên SP";
            dtg_show.Columns[3].Name = "Hãng SP";
            dtg_show.Columns[4].Name = "Màu Sắc SP";
            dtg_show.Columns[5].Name = "Dung Lượng SP";
            dtg_show.Columns[6].Name = "Số Lượng SP";
            dtg_show.Columns[7].Name = "Giá Nhập";
            dtg_show.Columns[8].Name = "Giá Bán";
            dtg_show.Columns[9].Name = "LinkAnh";
            dtg_show.Columns[9].Visible = false;
            dtg_show.Columns[11].Name = "Trạng Thái";
            dtg_show.Rows.Clear();


            var showall = _DTCTService.GetAllDTCT();
            if (tb_timkiem.Text != "")
            {
                showall = showall.Where(p => p.dienThoaiCT.MaQR.ToString().Contains(tb_timkiem.Text) || p.dienThoai.TenDT.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var item in showall)
            {
                dtg_show.Rows.Add(item.dienThoaiCT.MaQR, item.imei.TenImei, item.dienThoai.TenDT, item.hangSX.TenHang, item.mauSac.TenMau, item.dungLuong.SoDungLuong, item.dienThoaiCT.SoLuong, item.dienThoaiCT.GiaNhap, item.dienThoaiCT.GiaBan, item.dienThoaiCT.LinkAnh, item.dienThoaiCT.MaDTCT, item.dienThoaiCT.TrangThai == true?"Còn hàng" :"Hết hàng");
            }
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                _DTCT = _DTCTService.GetAll().FirstOrDefault(p => p.MaDTCT == Convert.ToInt32(r.Cells[10].Value.ToString()));
                tb_maQR.Text = r.Cells[0].Value.ToString();
                cbb_dienthoai.Text = r.Cells[2].Value.ToString();
                cbb_Imei.Text = r.Cells[1].Value.ToString();
                cbb_hangSX.Text = r.Cells[3].Value.ToString();
                cbb_mausac.Text = r.Cells[4].Value.ToString();
                cbb_dungluong.Text = r.Cells[5].Value.ToString();
                tb_soluong.Text = r.Cells[6].Value.ToString();
                tb_gianhap.Text = r.Cells[7].Value.ToString();
                tb_giaban.Text = r.Cells[8].Value.ToString();
                rb_conhang.Checked = r.Cells[11].Value.ToString() == "Còn hàng" ? true : false;
                rb_hethang.Checked = r.Cells[11].Value.ToString() == "Hết hàng" ? true : false;
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
        CancellationTokenSource cancellationToken;
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
                    tb_maQR.Text = result.ToString();
                    tb_timkiem.Text = result.ToString();
                }
            }
        }
        public bool Checkvalidate()
        {
            if (tb_soluong.Text == "" || tb_maQR.Text == "" || tb_gianhap.Text == "" || cbb_dienthoai.Text == "" || tb_giaban.Text == "" || cbb_dungluong.Text == "" || cbb_hangSX.Text == "" || cbb_Imei.Text == "" || cbb_mausac.Text == "") return false;
            return true;
        }
        public bool Checkdodaichu()
        {
            if (tb_maQR.TextLength > 50 || tb_soluong.TextLength >15 || tb_giaban.TextLength>20 || tb_gianhap.TextLength >20) return false;
            return true;
        }

        public bool CheckSo(string value)
        {
            foreach (Char c in value)
            {
                if (!Char.IsDigit(c)) return false;
            }
            return true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            var dt = _DTService.GetAll().FirstOrDefault(p => p.TenDT == cbb_dienthoai.Text);
            var dtct = _DTCTService.GetAll().FirstOrDefault(p => p.MaQR == tb_maQR.Text);
            var hangsx = _HSXService.GetAll().FirstOrDefault(p => p.TenHang == cbb_hangSX.Text);
            var mausac = _MauSacService.GetAll().FirstOrDefault(p => p.TenMau == cbb_mausac.Text);
            var dungluong = _DungLuongService.GetAll().FirstOrDefault(p => p.SoDungLuong == cbb_dungluong.Text);
            var imei = _ImeiService.GetAll().FirstOrDefault(p => p.TenImei == cbb_Imei.Text);
            if (Checkvalidate() == false)
            {
                MessageBox.Show("Khong duoc de trong cac thong tin", "Chu y");
            }
            else if (Checkdodaichu() == false)
            {
                MessageBox.Show("Qua nhieu ky tu trong 1 thong tin", "Chu y");
            }
            else if (dtct != null)
            {
                MessageBox.Show("Ma QR nay da ton tai", "Chu y");
            }
            else if (CheckSo(tb_giaban.Text) == false || CheckSo(tb_gianhap.Text) == false || CheckSo(tb_soluong.Text) == false)
            {
                MessageBox.Show("Gia va So luong phai la so", "Chu y");
            }
            else if (Convert.ToInt32(tb_giaban.Text) < Convert.ToInt32(tb_gianhap.Text))
            {
                MessageBox.Show("Gia ban phai cao hon gia nhap");
            }
            else if (linkavata == "")
            {
                MessageBox.Show("ban chua them anh cho san pham");
            }
            else if (dungluong == null)
            {
                MessageBox.Show("Dung luong dien thoai khong ton tai");
            }
            else if (hangsx == null)
            {
                MessageBox.Show("Hang SP khong ton tai");
            }
            else if (mausac == null)
            {
                MessageBox.Show("Mau Sac dien thoai khong ton tai");
            }
            else if (dt == null)
            {
                MessageBox.Show("Dien thoai khong ton tai");
            }
            else if (rb_conhang.Checked == false && rb_hethang.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
           
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm sản phẩm không", "Chú ý", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    var add = new DienThoaiCT()
                    {
                        MaQR = tb_maQR.Text,
                        MaDT = _DTService.GetAll().FirstOrDefault(p => p.TenDT == cbb_dienthoai.Text).MaDT,
                        MaMau = _MauSacService.GetAll().FirstOrDefault(p => p.TenMau == cbb_mausac.Text).MaMau,
                        MaDungLuong = _DungLuongService.GetAll().FirstOrDefault(p => p.SoDungLuong == cbb_dungluong.Text).MaDungLuong,
                        MaHang = _HSXService.GetAll().FirstOrDefault(p => p.TenHang == cbb_hangSX.Text).MaHang,
                        MaImei = _ImeiService.GetAll().FirstOrDefault(p => p.TenImei == cbb_Imei.Text).MaImei,
                        SoLuong = Convert.ToInt32(tb_soluong.Text),
                        GiaBan = Convert.ToInt32(tb_giaban.Text),
                        GiaNhap = Convert.ToInt32(tb_gianhap.Text),
                        LinkAnh = linkavata,
                        TrangThai = rb_conhang.Checked ? true : false,
                    };
                   if(rb_hethang.Checked == true)
                    {
                        add.SoLuong = 0;
                        _DTCTService.Add(add);
                        MessageBox.Show("Them san pham thanh cong");
                        Loadtodata();
                    }
                    else
                    {
                        _DTCTService.Add(add);
                        MessageBox.Show("Them san pham thanh cong");
                        Loadtodata();
                    }
                    
                }
            }
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Quét mã")
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
                if(dl == DialogResult.Yes)
                {
                    videoCaptureDevice.Stop();
                    button1.Text = "Quét mã";
                }
                
            }
            
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            Loadtodata();
            _DTCT = null;
            tb_giaban.Text = "";
            tb_gianhap.Text = "";
            tb_maQR.Text = "";
            tb_soluong.Text = "";
            tb_timkiem.Text = "";
            cbb_dienthoai.Text = "";
            cbb_dungluong.Text = "";
            cbb_hangSX.Text = "";
            cbb_Imei.Text = "";
            cbb_mausac.Text = "";
            linkavata = "";
            pcb_anhSP.Image = null;
        }

        private void pcb_anhSP_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (pcb_anhSP.Image != null)
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn đổi ảnh không", "Some tite", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (op.ShowDialog() == DialogResult.OK)
                    {
                        pcb_anhSP.Image = Image.FromFile(op.FileName);
                        pcb_anhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                        linkavata = op.FileName;
                    }
                }
            }
            else
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    pcb_anhSP.Image = Image.FromFile(op.FileName);
                    pcb_anhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                    linkavata = op.FileName;
                }
            }
        }

        private void btb_CapNhat_Click(object sender, EventArgs e)
        {
            var dt = _DTService.GetAll().FirstOrDefault(p => p.TenDT == cbb_dienthoai.Text);
            var dtct = _DTCTService.GetAll().FirstOrDefault(p => p.MaQR == tb_maQR.Text);
            var hangsx = _HSXService.GetAll().FirstOrDefault(p => p.TenHang == cbb_hangSX.Text);
            var mausac = _MauSacService.GetAll().FirstOrDefault(p => p.TenMau == cbb_mausac.Text);
            var dungluong = _DungLuongService.GetAll().FirstOrDefault(p => p.SoDungLuong == cbb_dungluong.Text);
            var imei = _ImeiService.GetAll().FirstOrDefault(p => p.TenImei == cbb_Imei.Text);
            if(_DTCT == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
            else
            {
                var sp = _DTCTService.GetAll().FirstOrDefault(p => p.MaQR == tb_maQR.Text);
                if(Checkvalidate() == false)
                {
                    MessageBox.Show("Không được để trống các thông tin");
                }else if(Checkdodaichu() == false)
                {
                    MessageBox.Show("Quá nhiều ký tự trong 1 thông tin");
                }else if(CheckSo(tb_gianhap.Text)==false || CheckSo(tb_giaban.Text) == false || CheckSo(tb_soluong.Text) == false)
                {
                    MessageBox.Show("Giá và số lượng phải là số");
                }else if (Convert.ToInt32(tb_gianhap.Text) > Convert.ToInt32(tb_giaban.Text))
                {
                    MessageBox.Show("Giá bán phải cao hơn giá nhập");
                }else if(pcb_anhSP.Image == null)
                {
                    MessageBox.Show("Bạn chưa thêm ảnh cho sản phẩm");
                }
                else if (dungluong == null)
                {
                    MessageBox.Show("Dung luong dien thoai khong ton tai");
                }
                else if (hangsx == null)
                {
                    MessageBox.Show("Hang SP khong ton tai");
                }
                else if (mausac == null)
                {
                    MessageBox.Show("Mau Sac dien thoai khong ton tai");
                }
                else if (dt == null)
                {
                    MessageBox.Show("Điện thoại khong ton tai");
                }
                else if( rb_conhang.Checked == false && rb_hethang.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái");
                }
                else
                {
                    if(_DTCT.MaQR == tb_maQR.Text||(_DTCT.MaQR!=tb_maQR.Text && _DTCTService.GetAll().FirstOrDefault(x=>x.MaQR == tb_maQR.Text) == null))
                    {
                        DialogResult dl = MessageBox.Show("Bạn muốn cập nhập sản phẩm không?", "Chú ý", MessageBoxButtons.YesNo);
                        if(dl == DialogResult.Yes)
                        {
                            _DTCT.MaQR = tb_maQR.Text;
                            _DTCT.MaDT = _DTService.GetAll().FirstOrDefault(p => p.TenDT == cbb_dienthoai.Text).MaDT;
                            _DTCT.MaMau = _MauSacService.GetAll().FirstOrDefault(p => p.TenMau == cbb_mausac.Text).MaMau;
                            _DTCT.MaDungLuong = _DungLuongService.GetAll().FirstOrDefault(p => p.SoDungLuong == cbb_dungluong.Text).MaDungLuong;
                            _DTCT.MaHang = _HSXService.GetAll().FirstOrDefault(p => p.TenHang == cbb_hangSX.Text).MaHang;
                            _DTCT.MaImei = _ImeiService.GetAll().FirstOrDefault(p => p.TenImei == cbb_Imei.Text).MaImei;
                            _DTCT.SoLuong = Convert.ToInt32(tb_soluong.Text);
                            _DTCT.GiaBan = Convert.ToInt32(tb_giaban.Text);
                            _DTCT.GiaNhap = Convert.ToInt32(tb_gianhap.Text);
                            _DTCT.LinkAnh = linkavata;
                            _DTCT.TrangThai = rb_conhang.Checked ? true : false;
                            if(rb_hethang.Checked == true)
                            {
                                _DTCT.SoLuong = 0;
                                _DTCTService.Update(_DTCT);
                                MessageBox.Show("Cập nhập san pham thanh cong");
                                Loadtodata();
                            }
                            else
                            {
                                _DTCTService.Update(_DTCT);
                                MessageBox.Show("Cập nhập san pham thanh cong");
                                Loadtodata();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã QR này đã tồn tại");
                    }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_DTCT == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
            else
            {
                _DTCTService.Delete(_DTCT);
                MessageBox.Show("Xóa sản phẩm thành công");
                Loadtodata();
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            Loadtodata();
        }
    }
}
