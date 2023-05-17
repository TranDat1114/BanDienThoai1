using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1DAL.ConText;
using _1DAL.Models;
using _2BUS.IService;
using _2BUS.Service;
namespace _3PL.View
{
    public partial class FrmKhachHang : Form
    {
        IKhachHangService _KHSV = new   KhachHangService();
        KhachHang _KH = new KhachHang();
        public FrmKhachHang()
        {
            InitializeComponent();
            Loadtodata();
        }
         
        public void Loadtodata()
        {
            int stt = 1;
            dtg_show.ColumnCount = 7;
            dtg_show.Columns[0].Name = "MaKH";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Tên Khách Hàng";
            dtg_show.Columns[3].Name = "Địa Chỉ";
            dtg_show.Columns[4].Name = "Số Điện Thoại";
            dtg_show.Columns[5].Name = "Giới Tính";
            dtg_show.Columns[6].Name = "Điểm";
            dtg_show.Rows.Clear();
            foreach (var x in _KHSV.GetAll())
            {
                dtg_show.Rows.Add(x.MaKH, stt++, x.TenKH, x.DiaChi, x.SDT, x.GioiTinh== true?"Nam":"Nữ", x.Diem);
            }
        }
      
        public bool CheckSo(string value)
        {
            foreach (Char c in value)
            {
                if (!Char.IsDigit(c)) return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_tenkh.Text == "" || tb_diachi.Text == "" || tb_sdt.Text == "" || rb_nam.Checked == false && rb_nu.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (CheckSo(tb_sdt.Text) == false)
            {
                MessageBox.Show("Số điện thoại không được nhập chữ");
            }
            else if(tb_tenkh.TextLength > 100 || tb_diachi.TextLength > 100 )
            {
                MessageBox.Show("Quá nhiều kí tự trong 1 thông tin","Chú ý");
            }
            else if(tb_sdt.TextLength < 10 || tb_sdt.TextLength > 10)
            {
                MessageBox.Show("SDT phải là 10 số");
            }
            else
            {
                if (_KHSV.GetAll().Any(x => x.SDT == tb_sdt.Text))
                {
                    MessageBox.Show("SDT đã tồn tại");
                }
                else
                {
                    var p = new KhachHang()
                    {
                        //MaKH = Convert.ToInt32
                        TenKH = tb_tenkh.Text,
                        DiaChi = tb_diachi.Text,
                        SDT = tb_sdt.Text,
                        GioiTinh = rb_nam.Checked ? true : false,
                        Diem = 50000
                    };
                    _KHSV.Add(p);
                    MessageBox.Show("Thêm thành công");
                    Loadtodata();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_KH == null)
            {
                MessageBox.Show("Vui lòng chọn Khách Hàng");
            }
            else if (tb_tenkh.Text == "" || tb_diachi.Text == "" || tb_sdt.Text == "" || rb_nam.Checked == false && rb_nu.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (CheckSo(tb_sdt.Text) == false)
            {
                MessageBox.Show("Số điện thoại không được nhập chữ");
            }
            else if (tb_tenkh.TextLength > 100 || tb_diachi.TextLength > 100 )
            {
                MessageBox.Show("Quá nhiều kí tự trong 1 thông tin", "Chú ý");
            }
            else if (tb_sdt.TextLength > 10 || tb_sdt.TextLength < 10)
            {
                MessageBox.Show("SĐT phải là 10 số", "Chú ý");
            }
            else
            {
                if (_KH.TenKH == tb_tenkh.Text || (_KH.TenKH != tb_tenkh.Text && _KHSV.GetAll().FirstOrDefault(x => x.TenKH == tb_tenkh.Text) == null))
                {
                    if(_KH.SDT == tb_sdt.Text || (_KH.SDT != tb_sdt.Text && _KHSV.GetAll().FirstOrDefault(p => p.SDT == tb_sdt.Text) == null))
                    {
                        _KH.TenKH = tb_tenkh.Text;
                        _KH.DiaChi = tb_diachi.Text;
                        _KH.SDT = tb_sdt.Text;
                        _KH.GioiTinh = rb_nam.Checked == true ? true : false;
                        _KHSV.Update(_KH);
                        MessageBox.Show("Sửa Khách hàng thành công");
                        Loadtodata();
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại khách hàng đã tồn tại");
                    }
                }
                else
                {
                    MessageBox.Show("Mã Khách hàng đã tồn tại");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _KH = null;
            tb_diachi.Text = "";
            tb_tenkh.Text = "";
            tb_sdt.Text = "";
            rb_nam.Checked = false;
            rb_nu.Checked = false;  
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                _KH = _KHSV.GetAll().FirstOrDefault(p => p.MaKH == Convert.ToInt32(r.Cells[0].Value.ToString()));
                tb_tenkh.Text = r.Cells[2].Value.ToString();
                tb_diachi.Text = r.Cells[3].Value.ToString();
                tb_sdt.Text = r.Cells[4].Value.ToString();
                rb_nam.Checked = r.Cells[5].Value.ToString() == "Nam" ? true : false;
                rb_nu.Checked = r.Cells[5].Value.ToString() == "Nữ" ? true : false;

            }
        }
    }
}
