namespace _3PL.View
{
    partial class FrmDienThoaiCT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDienThoaiCT));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btb_CapNhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rb_hethang = new System.Windows.Forms.RadioButton();
            this.rb_conhang = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pcb_anhSP = new System.Windows.Forms.PictureBox();
            this.ptb_quetma = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_maQR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_giaban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_gianhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_dienthoai = new System.Windows.Forms.ComboBox();
            this.cbb_mausac = new System.Windows.Forms.ComboBox();
            this.cbb_hangSX = new System.Windows.Forms.ComboBox();
            this.cbb_Imei = new System.Windows.Forms.ComboBox();
            this.cbb_dungluong = new System.Windows.Forms.ComboBox();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.So = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_anhSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quetma)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtg_show);
            this.groupBox3.Location = new System.Drawing.Point(44, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1182, 248);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách diện thoại";
            // 
            // dtg_show
            // 
            this.dtg_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(6, 23);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowTemplate.Height = 28;
            this.dtg_show.Size = new System.Drawing.Size(1170, 248);
            this.dtg_show.StandardTab = true;
            this.dtg_show.TabIndex = 0;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tìm kiếm mã QR:";
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(337, 106);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(211, 27);
            this.cboDevice.TabIndex = 26;
            this.cboDevice.Visible = false;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(337, 57);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(211, 26);
            this.tb_timkiem.TabIndex = 26;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_lamMoi);
            this.groupBox2.Controls.Add(this.btb_CapNhat);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(891, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 494);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(66, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Quét mã";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_lamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_lamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoi.Image")));
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(66, 307);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(202, 58);
            this.btn_lamMoi.TabIndex = 2;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = false;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btb_CapNhat
            // 
            this.btb_CapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btb_CapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btb_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btb_CapNhat.Image")));
            this.btb_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btb_CapNhat.Location = new System.Drawing.Point(66, 212);
            this.btb_CapNhat.Name = "btb_CapNhat";
            this.btb_CapNhat.Size = new System.Drawing.Size(202, 58);
            this.btb_CapNhat.TabIndex = 1;
            this.btb_CapNhat.Text = "Cập nhật";
            this.btb_CapNhat.UseVisualStyleBackColor = false;
            this.btb_CapNhat.Click += new System.EventHandler(this.btb_CapNhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(66, 115);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(202, 58);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rb_hethang);
            this.groupBox1.Controls.Add(this.rb_conhang);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.ptb_quetma);
            this.groupBox1.Controls.Add(this.cboDevice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_timkiem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_maQR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_giaban);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_gianhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbb_dienthoai);
            this.groupBox1.Controls.Add(this.cbb_mausac);
            this.groupBox1.Controls.Add(this.cbb_hangSX);
            this.groupBox1.Controls.Add(this.cbb_Imei);
            this.groupBox1.Controls.Add(this.cbb_dungluong);
            this.groupBox1.Controls.Add(this.tb_soluong);
            this.groupBox1.Controls.Add(this.So);
            this.groupBox1.Location = new System.Drawing.Point(50, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 494);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điện thoại";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(475, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "Trạng thái:";
            // 
            // rb_hethang
            // 
            this.rb_hethang.AutoSize = true;
            this.rb_hethang.Location = new System.Drawing.Point(685, 411);
            this.rb_hethang.Name = "rb_hethang";
            this.rb_hethang.Size = new System.Drawing.Size(84, 23);
            this.rb_hethang.TabIndex = 29;
            this.rb_hethang.TabStop = true;
            this.rb_hethang.Text = "Hết hàng";
            this.rb_hethang.UseVisualStyleBackColor = true;
            // 
            // rb_conhang
            // 
            this.rb_conhang.AutoSize = true;
            this.rb_conhang.Location = new System.Drawing.Point(572, 410);
            this.rb_conhang.Name = "rb_conhang";
            this.rb_conhang.Size = new System.Drawing.Size(87, 23);
            this.rb_conhang.TabIndex = 28;
            this.rb_conhang.TabStop = true;
            this.rb_conhang.Text = "Còn hàng";
            this.rb_conhang.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pcb_anhSP);
            this.groupBox4.Location = new System.Drawing.Point(557, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 184);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chọn ảnh";
            // 
            // pcb_anhSP
            // 
            this.pcb_anhSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_anhSP.Image = ((System.Drawing.Image)(resources.GetObject("pcb_anhSP.Image")));
            this.pcb_anhSP.Location = new System.Drawing.Point(6, 18);
            this.pcb_anhSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_anhSP.Name = "pcb_anhSP";
            this.pcb_anhSP.Size = new System.Drawing.Size(200, 159);
            this.pcb_anhSP.TabIndex = 28;
            this.pcb_anhSP.TabStop = false;
            this.pcb_anhSP.Click += new System.EventHandler(this.pcb_anhSP_Click);
            // 
            // ptb_quetma
            // 
            this.ptb_quetma.BackColor = System.Drawing.SystemColors.Control;
            this.ptb_quetma.Location = new System.Drawing.Point(6, 16);
            this.ptb_quetma.Name = "ptb_quetma";
            this.ptb_quetma.Size = new System.Drawing.Size(308, 184);
            this.ptb_quetma.TabIndex = 25;
            this.ptb_quetma.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Imei:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hãng SX:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Màu sắc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dung lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Điện thoại:";
            // 
            // tb_maQR
            // 
            this.tb_maQR.Location = new System.Drawing.Point(557, 217);
            this.tb_maQR.Name = "tb_maQR";
            this.tb_maQR.Size = new System.Drawing.Size(211, 26);
            this.tb_maQR.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã QR:";
            // 
            // tb_giaban
            // 
            this.tb_giaban.Location = new System.Drawing.Point(557, 357);
            this.tb_giaban.Name = "tb_giaban";
            this.tb_giaban.Size = new System.Drawing.Size(211, 26);
            this.tb_giaban.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Giá nhập:";
            // 
            // tb_gianhap
            // 
            this.tb_gianhap.Location = new System.Drawing.Point(557, 307);
            this.tb_gianhap.Name = "tb_gianhap";
            this.tb_gianhap.Size = new System.Drawing.Size(211, 26);
            this.tb_gianhap.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giá bán:";
            // 
            // cbb_dienthoai
            // 
            this.cbb_dienthoai.FormattingEnabled = true;
            this.cbb_dienthoai.Location = new System.Drawing.Point(103, 407);
            this.cbb_dienthoai.Name = "cbb_dienthoai";
            this.cbb_dienthoai.Size = new System.Drawing.Size(211, 27);
            this.cbb_dienthoai.TabIndex = 8;
            // 
            // cbb_mausac
            // 
            this.cbb_mausac.FormattingEnabled = true;
            this.cbb_mausac.Location = new System.Drawing.Point(103, 361);
            this.cbb_mausac.Name = "cbb_mausac";
            this.cbb_mausac.Size = new System.Drawing.Size(211, 27);
            this.cbb_mausac.TabIndex = 7;
            // 
            // cbb_hangSX
            // 
            this.cbb_hangSX.FormattingEnabled = true;
            this.cbb_hangSX.Location = new System.Drawing.Point(103, 310);
            this.cbb_hangSX.Name = "cbb_hangSX";
            this.cbb_hangSX.Size = new System.Drawing.Size(211, 27);
            this.cbb_hangSX.TabIndex = 6;
            // 
            // cbb_Imei
            // 
            this.cbb_Imei.FormattingEnabled = true;
            this.cbb_Imei.Location = new System.Drawing.Point(103, 261);
            this.cbb_Imei.Name = "cbb_Imei";
            this.cbb_Imei.Size = new System.Drawing.Size(211, 27);
            this.cbb_Imei.TabIndex = 5;
            // 
            // cbb_dungluong
            // 
            this.cbb_dungluong.FormattingEnabled = true;
            this.cbb_dungluong.Location = new System.Drawing.Point(103, 212);
            this.cbb_dungluong.Name = "cbb_dungluong";
            this.cbb_dungluong.Size = new System.Drawing.Size(211, 27);
            this.cbb_dungluong.TabIndex = 4;
            // 
            // tb_soluong
            // 
            this.tb_soluong.Location = new System.Drawing.Point(558, 261);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(211, 26);
            this.tb_soluong.TabIndex = 3;
            // 
            // So
            // 
            this.So.AutoSize = true;
            this.So.Location = new System.Drawing.Point(483, 264);
            this.So.Name = "So";
            this.So.Size = new System.Drawing.Size(66, 19);
            this.So.TabIndex = 1;
            this.So.Text = "Số lượng:";
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(531, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 37);
            this.label10.TabIndex = 15;
            this.label10.Text = "Sản Phẩm Chi Tiết";
            // 
            // FrmDienThoaiCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1377, 884);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDienThoaiCT";
            this.Text = "FrmDienThoaiCT";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_anhSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_quetma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dtg_show;
        private GroupBox groupBox2;
        private Button btn_lamMoi;
        private Button btb_CapNhat;
        private Button btn_them;
        private GroupBox groupBox1;
        private TextBox tb_soluong;
        private Label So;
        private ComboBox cbb_dienthoai;
        private ComboBox cbb_mausac;
        private ComboBox cbb_hangSX;
        private ComboBox cbb_Imei;
        private ComboBox cbb_dungluong;
        private TextBox tb_maQR;
        private Label label3;
        private TextBox tb_giaban;
        private Label label2;
        private TextBox tb_gianhap;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox ptb_quetma;
        private Button button1;
        private TextBox tb_timkiem;
        private ComboBox cboDevice;
        private System.Windows.Forms.Timer timer1;
        private Label label9;
        private GroupBox groupBox4;
        private PictureBox pcb_anhSP;
        private Label label10;
        private Label label11;
        private RadioButton rb_hethang;
        private RadioButton rb_conhang;
    }
}