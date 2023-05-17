using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1DAL.Models;
using _2BUS.IService;
using _2BUS.Service;
namespace _3PL.View
{
    public partial class FrmNhanVien : Form
    {
        IChucVuService _CVSV = new ChucVuService();
        INhanVienService _NVSV = new NhanVienService();
        NhanVien _Nv = new NhanVien();
        string laySDT = "";
        public FrmNhanVien()
        {
            InitializeComponent();
            foreach (var item in _CVSV.GetAll())
            {
                cbb_chucvu.Items.Add(item.TenCV);
            }
            
            dtp_ngaysinh.CustomFormat = "dd-MM-yyyy";
            loadNhanVien();
        }

        public void loadNhanVien()
        {
            
            dgv_nhanvien.Rows.Clear();
            var timkiem = _NVSV.GetAllView();
            if (textBox_timKiem.Text != "")
            {
                timkiem = timkiem.Where(p => p.nhanVien.TenNV.ToLower().Contains(textBox_timKiem.Text.ToLower()) || p.nhanVien.SDT.Contains(textBox_timKiem.Text) || p.nhanVien.TrangThai.ToString().ToLower().Contains(textBox_timKiem.Text)).ToList();
            }
            
            foreach (var item in timkiem)
            {
                string formattedDate = item.nhanVien.NgaySinh.ToString("dd-MM-yyyy");  //chuyển đổi sang dd/mm/yyyy 

                dgv_nhanvien.Rows.Add(item.nhanVien.MaNV, item.nhanVien.TenNV, item.nhanVien.SDT, item.nhanVien.DiaChi, item.nhanVien.GioiTinh == 0 ? "Nam" : "Nữ",
                    item.chucVu.TenCV,
                    item.nhanVien.TrangThai == 0 ? "Hoạt động" : "Không hoạt động",
                    item.nhanVien.NgaySinh.ToString("dd-MM-yyyy"));
            }
            cbb_chucvu.SelectedIndex = 1;
        }
        public bool Checkkytu()
        {
            if (tbt_tenNV.Text == "" || tbt_sdt.Text == "" || tbt_diachi.Text == "" || cbb_chucvu.Text == "" || rb_nam.Checked == false && rb_nu.Checked == false || rad_hd.Checked == false && rad_khd.Checked == false)return false;
            
            return true;
        }
        public bool checkdodai()
        {
            if (tbt_tenNV.TextLength >= 100 || tbt_diachi.TextLength >= 100 )
            
                return false;
            
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
            var checkSDT = _NVSV.GetAll().FirstOrDefault(p => p.SDT == tbt_sdt.Text);


            if (checkSDT != null)
            {
                MessageBox.Show("SDT đã tồn tại");
            }
            else if (CheckSo(tbt_sdt.Text) == false)
            {
                MessageBox.Show("SDT phải là số");
            }
            else if(tbt_sdt.TextLength<9 || tbt_sdt.TextLength > 10)
            {
                MessageBox.Show("SĐT phải là 9 hoặc 10 số");
            }
            else if (Checkkytu() == false)
            {
                MessageBox.Show("Không được để trống các thông tin");
            }
            else if(checkdodai() == false)
            {
                MessageBox.Show("Quá nhiều ký tự trong 1 thông tin");
            }
            else
            {
                int idss = _NVSV.GetAll().Count() + 1;

                // This will get the current PROJECT directory
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                NhanVien employeee = new NhanVien()
                {

                    matKhau = "123",
                    TenNV = tbt_tenNV.Text,
                    TrangThai = rad_hd.Checked ? 0 : 1,
                    GioiTinh = rb_nam.Checked ? 0 : 1,
                    NgaySinh = dtp_ngaysinh.Value,
                    DiaChi = tbt_diachi.Text,
                    SDT = tbt_sdt.Text,
                    MaCV = _CVSV.GetAll().FirstOrDefault(p => p.TenCV == cbb_chucvu.Text).MaCV

            };
                _NVSV.Add(employeee);
                MessageBox.Show("Thêm Nhân Viên thành công");
                loadNhanVien();
            }
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgv_nhanvien.Rows[e.RowIndex];
            _Nv = _NVSV.GetAll().FirstOrDefault(p => p.MaNV ==Convert.ToInt32(r.Cells[0].Value.ToString()));
            tbt_tenNV.Text = r.Cells[1].Value.ToString();
            tbt_sdt.Text = r.Cells[2].Value.ToString();
            rb_nam.Checked = r.Cells[4].Value.ToString() == "Nam" ? true : false;
            rb_nu.Checked = r.Cells[4].Value.ToString() == "Nữ" ? true : false;

            //dtp_ngaysinh.Value = Convert.ToDateTime(r.Cells[7].Value);
            dtp_ngaysinh.Value = _Nv.NgaySinh;
            cbb_chucvu.Text = r.Cells[5].Value.ToString();
            tbt_diachi.Text = r.Cells[3].Value.ToString();
            rad_hd.Checked = r.Cells[6].Value.ToString() == "Hoạt động" ? true : false;
            rad_khd.Checked = r.Cells[6].Value.ToString() == "Không hoạt động" ? true : false;

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var up = _NVSV.GetAll().FirstOrDefault(p => p.SDT == laySDT);
            if(_Nv == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
            else if (Checkkytu() == false)
            {
                MessageBox.Show("Bạn không được để trống thông tin");
            }
            else if (tbt_sdt.TextLength < 9 || tbt_sdt.TextLength > 10)
            {
                MessageBox.Show("SĐT phải là 9 hoặc 10 số");
            }
            else if (checkdodai() == false)
            {
                MessageBox.Show("Quá nhiều ký tự trong 1 thông tin");
            } 
            else if (CheckSo(tbt_sdt.Text) == false)
            {
                MessageBox.Show("Sđt phải là số");
            }
            else
            {
                if (_Nv.SDT == tbt_sdt.Text || (_Nv.SDT != tbt_sdt.Text && _NVSV.GetAll().FirstOrDefault(p => p.SDT == tbt_sdt.Text) == null))
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật thông tin không ?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _Nv.TenNV = tbt_tenNV.Text;
                        _Nv.GioiTinh = rb_nam.Checked ? 0 : 1;
                        _Nv.NgaySinh = dtp_ngaysinh.Value;
                        _Nv.MaCV = _CVSV.GetAll().FirstOrDefault(p => p.TenCV == cbb_chucvu.Text).MaCV;
                        _Nv.DiaChi = tbt_diachi.Text;
                        _Nv.SDT = tbt_sdt.Text;
                        _Nv.TrangThai = rad_hd.Checked ? 0 : 1;

                        _NVSV.Update(_Nv);
                        MessageBox.Show("Cập nhật thông tin thành công");
                        loadNhanVien();
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại đã tồn tại");
                }

            }
        }

        private void cbb_locChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_timKiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_timKiem_TextChanged_1(object sender, EventArgs e)
        {
            loadNhanVien();
        }

        private void button_rset_Click(object sender, EventArgs e)
        {
            _Nv = null;
            loadNhanVien();
            tbt_diachi.Text = "";
            tbt_sdt.Text = "";
            tbt_tenNV.Text = "";
            rad_hd.Checked = false;
            rad_khd.Checked = false;
            rb_nam.Checked = false;
            rb_nam.Checked = false;
            textBox_timKiem.Text = "";
        }
    }
    }

