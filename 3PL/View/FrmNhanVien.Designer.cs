namespace _3PL.View
{
    partial class FrmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_timKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.rad_khd = new System.Windows.Forms.RadioButton();
            this.rad_hd = new System.Windows.Forms.RadioButton();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.tbt_sdt = new System.Windows.Forms.TextBox();
            this.tbt_diachi = new System.Windows.Forms.TextBox();
            this.tbt_tenNV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_rset = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(-7, -8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 829);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(509, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_timKiem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgv_nhanvien);
            this.groupBox2.Location = new System.Drawing.Point(19, 419);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1187, 386);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // textBox_timKiem
            // 
            this.textBox_timKiem.Location = new System.Drawing.Point(168, 38);
            this.textBox_timKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_timKiem.Name = "textBox_timKiem";
            this.textBox_timKiem.Size = new System.Drawing.Size(198, 26);
            this.textBox_timKiem.TabIndex = 2;
            this.textBox_timKiem.TextChanged += new System.EventHandler(this.textBox_timKiem_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm nhân viên";
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhanvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_nhanvien.Location = new System.Drawing.Point(14, 96);
            this.dgv_nhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.RowHeadersWidth = 51;
            this.dgv_nhanvien.RowTemplate.Height = 25;
            this.dgv_nhanvien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_nhanvien.Size = new System.Drawing.Size(1167, 286);
            this.dgv_nhanvien.TabIndex = 0;
            this.dgv_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giới tính";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Chức vụ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Trạng thái";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ngày sinh";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtp_ngaysinh);
            this.groupBox1.Controls.Add(this.rad_khd);
            this.groupBox1.Controls.Add(this.rad_hd);
            this.groupBox1.Controls.Add(this.cbb_chucvu);
            this.groupBox1.Controls.Add(this.tbt_sdt);
            this.groupBox1.Controls.Add(this.tbt_diachi);
            this.groupBox1.Controls.Add(this.tbt_tenNV);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(17, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(950, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_nu);
            this.panel2.Controls.Add(this.rb_nam);
            this.panel2.Location = new System.Drawing.Point(653, 203);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 50);
            this.panel2.TabIndex = 24;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(99, 14);
            this.rb_nu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(45, 23);
            this.rb_nu.TabIndex = 19;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(3, 14);
            this.rb_nam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(56, 23);
            this.rb_nam.TabIndex = 18;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ngày sinh:";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(149, 212);
            this.dtp_ngaysinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(251, 26);
            this.dtp_ngaysinh.TabIndex = 20;
            // 
            // rad_khd
            // 
            this.rad_khd.AutoSize = true;
            this.rad_khd.Location = new System.Drawing.Point(492, 288);
            this.rad_khd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rad_khd.Name = "rad_khd";
            this.rad_khd.Size = new System.Drawing.Size(135, 23);
            this.rad_khd.TabIndex = 23;
            this.rad_khd.TabStop = true;
            this.rad_khd.Text = "Không hoạt động";
            this.rad_khd.UseVisualStyleBackColor = true;
            // 
            // rad_hd
            // 
            this.rad_hd.AutoSize = true;
            this.rad_hd.Location = new System.Drawing.Point(392, 288);
            this.rad_hd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rad_hd.Name = "rad_hd";
            this.rad_hd.Size = new System.Drawing.Size(93, 23);
            this.rad_hd.TabIndex = 22;
            this.rad_hd.TabStop = true;
            this.rad_hd.Text = "Hoạt động";
            this.rad_hd.UseVisualStyleBackColor = true;
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(653, 34);
            this.cbb_chucvu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(234, 27);
            this.cbb_chucvu.TabIndex = 17;
            // 
            // tbt_sdt
            // 
            this.tbt_sdt.Location = new System.Drawing.Point(149, 117);
            this.tbt_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_sdt.Name = "tbt_sdt";
            this.tbt_sdt.Size = new System.Drawing.Size(251, 26);
            this.tbt_sdt.TabIndex = 15;
            // 
            // tbt_diachi
            // 
            this.tbt_diachi.Location = new System.Drawing.Point(653, 116);
            this.tbt_diachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_diachi.Name = "tbt_diachi";
            this.tbt_diachi.Size = new System.Drawing.Size(234, 26);
            this.tbt_diachi.TabIndex = 14;
            // 
            // tbt_tenNV
            // 
            this.tbt_tenNV.Location = new System.Drawing.Point(149, 39);
            this.tbt_tenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_tenNV.Name = "tbt_tenNV";
            this.tbt_tenNV.Size = new System.Drawing.Size(251, 26);
            this.tbt_tenNV.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(541, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "Chức vụ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Trạng thái:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Số điện thoại:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(541, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Địa chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên nhân viên:\r\n";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_rset);
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(973, 81);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(233, 330);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // button_rset
            // 
            this.button_rset.BackColor = System.Drawing.Color.Cyan;
            this.button_rset.Image = ((System.Drawing.Image)(resources.GetObject("button_rset.Image")));
            this.button_rset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_rset.Location = new System.Drawing.Point(22, 244);
            this.button_rset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_rset.Name = "button_rset";
            this.button_rset.Size = new System.Drawing.Size(205, 65);
            this.button_rset.TabIndex = 2;
            this.button_rset.Text = "Reset";
            this.button_rset.UseVisualStyleBackColor = false;
            this.button_rset.Click += new System.EventHandler(this.button_rset_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(22, 135);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(205, 65);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Cập nhật";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(22, 33);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(205, 64);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm nhân viên";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1216, 812);
            this.Controls.Add(this.panel1);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private Button button_rset;
        private TextBox textBox_timKiem;
        private Label label1;
        private DataGridView dgv_nhanvien;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private GroupBox groupBox1;
        private Panel panel2;
        private RadioButton rb_nu;
        private RadioButton rb_nam;
        private Label label8;
        private DateTimePicker dtp_ngaysinh;
        private RadioButton rad_khd;
        private RadioButton rad_hd;
        private ComboBox cbb_chucvu;
        private TextBox tbt_sdt;
        private TextBox tbt_diachi;
        private TextBox tbt_tenNV;
        private Label label12;
        private Label label13;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label6;
        private GroupBox groupBox3;
        private Button btn_sua;
        private Button btn_them;
        private Label label2;
    }
}