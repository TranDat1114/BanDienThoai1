namespace _3PL.View
{
    partial class FrmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtg_hoadonchitiet = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_XoaHD = new System.Windows.Forms.Button();
            this.btn_timk = new System.Windows.Forms.Button();
            this.dtg_hoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbt_timk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadonchitiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_hoadonchitiet);
            this.groupBox2.Location = new System.Drawing.Point(41, 445);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1193, 343);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn chi tiết";
            // 
            // dtg_hoadonchitiet
            // 
            this.dtg_hoadonchitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_hoadonchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hoadonchitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dtg_hoadonchitiet.Location = new System.Drawing.Point(15, 42);
            this.dtg_hoadonchitiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_hoadonchitiet.Name = "dtg_hoadonchitiet";
            this.dtg_hoadonchitiet.RowHeadersWidth = 51;
            this.dtg_hoadonchitiet.RowTemplate.Height = 25;
            this.dtg_hoadonchitiet.Size = new System.Drawing.Size(613, 294);
            this.dtg_hoadonchitiet.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_XoaHD);
            this.groupBox1.Controls.Add(this.btn_timk);
            this.groupBox1.Controls.Add(this.dtg_hoadon);
            this.groupBox1.Controls.Add(this.tbt_timk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1193, 430);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // btn_XoaHD
            // 
            this.btn_XoaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_XoaHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaHD.Image")));
            this.btn_XoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaHD.Location = new System.Drawing.Point(1017, 33);
            this.btn_XoaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XoaHD.Name = "btn_XoaHD";
            this.btn_XoaHD.Size = new System.Drawing.Size(170, 54);
            this.btn_XoaHD.TabIndex = 15;
            this.btn_XoaHD.Text = "Xóa hoá đơn";
            this.btn_XoaHD.UseVisualStyleBackColor = false;
            this.btn_XoaHD.Click += new System.EventHandler(this.btn_XoaHD_Click);
            // 
            // btn_timk
            // 
            this.btn_timk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_timk.Image = ((System.Drawing.Image)(resources.GetObject("btn_timk.Image")));
            this.btn_timk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timk.Location = new System.Drawing.Point(387, 33);
            this.btn_timk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_timk.Name = "btn_timk";
            this.btn_timk.Size = new System.Drawing.Size(97, 29);
            this.btn_timk.TabIndex = 3;
            this.btn_timk.Text = "Tìm kiếm";
            this.btn_timk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timk.UseVisualStyleBackColor = false;
            this.btn_timk.Click += new System.EventHandler(this.btn_timk_Click);
            // 
            // dtg_hoadon
            // 
            this.dtg_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtg_hoadon.Location = new System.Drawing.Point(8, 108);
            this.dtg_hoadon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_hoadon.Name = "dtg_hoadon";
            this.dtg_hoadon.RowHeadersWidth = 51;
            this.dtg_hoadon.RowTemplate.Height = 25;
            this.dtg_hoadon.Size = new System.Drawing.Size(1179, 314);
            this.dtg_hoadon.TabIndex = 2;
            this.dtg_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_hoadon_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày Tạo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Nhân Viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Điện Thoại Khách Hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tổng Giá";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Trạng Thái";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ghi Chú";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // tbt_timk
            // 
            this.tbt_timk.Location = new System.Drawing.Point(154, 33);
            this.tbt_timk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_timk.Name = "tbt_timk";
            this.tbt_timk.Size = new System.Drawing.Size(217, 26);
            this.tbt_timk.TabIndex = 1;
            this.tbt_timk.TextChanged += new System.EventHandler(this.tbt_timk_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm hóa đơn";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã Sản Phẩm";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Mã QR Sản Phẩm";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Số Lượng";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Đơn Giá";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1275, 794);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadonchitiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dtg_hoadonchitiet;
        private GroupBox groupBox1;
        private Button btn_XoaHD;
        private Button btn_timk;
        private DataGridView dtg_hoadon;
        private TextBox tbt_timk;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
    }
}