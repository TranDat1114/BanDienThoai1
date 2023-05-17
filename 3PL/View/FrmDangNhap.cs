﻿using _2BUS.IService;
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

namespace _3PL.View
{
    public partial class FrmDangNhap : Form
    {
        IKhachHangService _khachhang;
        INhanVienService _nhanvien ;
        INhanVienService inhanvienservice;
        public FrmDangNhap(IKhachHangService khachHangService, INhanVienService nhanVienService)
        {
            _khachhang = khachHangService;
            _nhanvien = nhanVienService;
        }
        public FrmDangNhap()
        {
            InitializeComponent();
            //inhanvienservice = new NhanVienService();
            txtTK.Text = Properties.Settings.Default.tk;
            txtMK.Text = Properties.Settings.Default.mk;
            if (Properties.Settings.Default.tk != "")
            {
                cbNhoMK.Checked = true;
            }
           
        }
        public void saveInfor()
        {
            if (cbNhoMK.Checked == true)
            {
                Properties.Settings.Default.tk = txtTK.Text;
                Properties.Settings.Default.mk = txtMK.Text;
                Properties.Settings.Default.TKdaLogin = txtTK.Text;
                Properties.Settings.Default.MKdaLogin = txtMK.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.tk = "";
                Properties.Settings.Default.mk = "";
                Properties.Settings.Default.TKdaLogin = txtTK.Text;
                Properties.Settings.Default.MKdaLogin = txtMK.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "" || txtMK.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập và mật khẩu");
            }
            else
            {
                var login = _nhanvien.GetAll().FirstOrDefault(p => p.SDT == txtTK.Text && p.matKhau == txtMK.Text);

                if (login != null)
                {
                    if (login.TrangThai == 1)
                    {
                        MessageBox.Show("Nhân viên đã nghỉ việc không thể đăng nhập bằng tài khoản này","Chú ý");
                    }
                    else
                    {
                        saveInfor();
                        this.Hide();
                        FrmMain frmMain = new FrmMain();
                        frmMain.ShowDialog();
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai");
                }
            }
        }

        private void cbNhoMK_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmQuenMK quenMK = new FrmQuenMK();
            quenMK.ShowDialog();
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
           
          
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
