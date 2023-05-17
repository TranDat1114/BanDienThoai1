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
namespace _3PL.View
{
    public partial class FrmMain : Form
    {
        IChucVuService _chucVuService;
        INhanVienService _nhanVienService;
        public FrmMain(INhanVienService nhanVienService)
        {
            InitializeComponent();
            _chucVuService = new ChucVuService();
            _nhanVienService = nhanVienService;
            this.CenterToScreen();
            GoFullscreen(AutoSize);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var layEmail = Properties.Settings.Default.TKdaLogin;
            var nhanvien = _nhanVienService.GetAll().FirstOrDefault(p => p.SDT == layEmail);
            var nhanvien1 = _nhanVienService.GetAll().FirstOrDefault(p => p.SDT == Properties.Settings.Default.TKdaLogin);
            lb_maNV.Text = nhanvien.MaNV.ToString();
            labe_ten.Text = nhanvien.TenNV;
            label_sdt.Text = nhanvien.SDT;

            label_gioitinh.Text = nhanvien.GioiTinh == 0 ? "Nam" : "Nữ";
            string formattedDate = nhanvien.NgaySinh.ToString("dd-MM-yyyy");  //chuyển đổi sang dd/mm/yyyy 
            label_ngaysinh.Text = Convert.ToString(formattedDate);
            label_diachi.Text = nhanvien.DiaChi;

            panel_ttnv.Visible = true;

        }
        private Form activeForm;
        public void ChangeForm(Form form)
        {
            if (activeForm != null)
            {

                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            pn_main.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void btn_nv_Click(object sender, EventArgs e)
        {
            var idRole = _nhanVienService.GetAll().Where(p => p.SDT == Properties.Settings.Default.TKdaLogin).Select(p => p.MaCV).FirstOrDefault();
            if (idRole == 1)
            {
                FrmNhanVien frmNhanVien = new FrmNhanVien();
                ChangeForm(frmNhanVien);
                panel_ttnv.Visible = false;
            }
            else if (idRole != 1)
            {
                MessageBox.Show("Nhân viên không có quyền sử dụng chức năng này");
            }
           
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            FrmHoaDon frmBanHang = new FrmHoaDon();
            ChangeForm(frmBanHang);
            panel_ttnv.Visible = false;
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            FrmBanHang frmBanHang = new FrmBanHang();
            ChangeForm(frmBanHang);
            panel_ttnv.Visible = false;
        }

        private void btn_sp_Click(object sender, EventArgs e)
        {
            FrmQuanLySP frmQuanLySP = new FrmQuanLySP();
            ChangeForm(frmQuanLySP);
            panel_ttnv.Visible = false;
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang frmKhachHang = new FrmKhachHang();
            ChangeForm(frmKhachHang);
            panel_ttnv.Visible = false;
        }

        private void labelChaychu_Click(object sender, EventArgs e)
        {

        }
        int x = 260; int y = 20; int a = 1;
        private void timechaychu_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                labelChaychu.Location = new Point(x, y);
                if (x >= 700)
                {
                    a = -2;
                }
                if (x <= 300)
                {
                    a = 2;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_doimk_Click(object sender, EventArgs e)
        {
            var mk = _nhanVienService.GetAll().FirstOrDefault(p => p.matKhau == textBox_mkcu.Text);
            if (mk == null)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác");

            }
            else if (textBox_mkmoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự");

            }
            else if (textBox_nhaplaimk.Text != textBox_mkmoi.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác");
            }


            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi mật khẩu không ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var mkmoi = _nhanVienService.GetAll().FirstOrDefault();
                    mkmoi.matKhau = textBox_mkmoi.Text;
                    
                    _nhanVienService.Update(mkmoi);
                    MessageBox.Show("Đổi mật khẩu thành công");

                    this.Hide();
                    FrmDangNhap login = new FrmDangNhap();
                    login.ShowDialog();
                    this.Close();

                }

              
            }
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                FrmDangNhap frmLogin = new FrmDangNhap();
                frmLogin.ShowDialog();
                this.Close();
            }
        }

        private void pic_avtNV_Click(object sender, EventArgs e)
        {
            panel_ttnv.Visible = true;
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            FrmThongKe frmBanHang = new FrmThongKe();
            ChangeForm(frmBanHang);
            panel_ttnv.Visible = false;
        }
    }
}
