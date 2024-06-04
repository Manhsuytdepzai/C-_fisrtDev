namespace Form_KhachHang
{
    partial class frm_DanhSachKhachHang
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
            this.lbl_ttkh = new System.Windows.Forms.Label();
            this.lbl_ttChiTietKhachHang = new System.Windows.Forms.Label();
            this.lbl_maKhachHang = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_DienThoai = new System.Windows.Forms.Label();
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.cbo_GioiTinh = new System.Windows.Forms.ComboBox();
            this.grb_KhachHang = new System.Windows.Forms.GroupBox();
            this.gridDSKhachHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grb_KhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ttkh
            // 
            this.lbl_ttkh.AutoSize = true;
            this.lbl_ttkh.BackColor = System.Drawing.Color.Silver;
            this.lbl_ttkh.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttkh.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ttkh.Location = new System.Drawing.Point(168, 9);
            this.lbl_ttkh.Name = "lbl_ttkh";
            this.lbl_ttkh.Size = new System.Drawing.Size(428, 36);
            this.lbl_ttkh.TabIndex = 0;
            this.lbl_ttkh.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // lbl_ttChiTietKhachHang
            // 
            this.lbl_ttChiTietKhachHang.AutoSize = true;
            this.lbl_ttChiTietKhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttChiTietKhachHang.Location = new System.Drawing.Point(27, 52);
            this.lbl_ttChiTietKhachHang.Name = "lbl_ttChiTietKhachHang";
            this.lbl_ttChiTietKhachHang.Size = new System.Drawing.Size(249, 22);
            this.lbl_ttChiTietKhachHang.TabIndex = 1;
            this.lbl_ttChiTietKhachHang.Text = "Thông tin chi tiết khách hàng";
            // 
            // lbl_maKhachHang
            // 
            this.lbl_maKhachHang.AutoSize = true;
            this.lbl_maKhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maKhachHang.Location = new System.Drawing.Point(52, 91);
            this.lbl_maKhachHang.Name = "lbl_maKhachHang";
            this.lbl_maKhachHang.Size = new System.Drawing.Size(123, 21);
            this.lbl_maKhachHang.TabIndex = 2;
            this.lbl_maKhachHang.Text = "Mã khách hàng";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(52, 128);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(60, 21);
            this.lbl_HoTen.TabIndex = 3;
            this.lbl_HoTen.Text = "Họ tên";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.Location = new System.Drawing.Point(52, 165);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(76, 21);
            this.lbl_GioiTinh.TabIndex = 4;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(439, 91);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(65, 21);
            this.lbl_DiaChi.TabIndex = 5;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_DienThoai
            // 
            this.lbl_DienThoai.AutoSize = true;
            this.lbl_DienThoai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DienThoai.Location = new System.Drawing.Point(439, 128);
            this.lbl_DienThoai.Name = "lbl_DienThoai";
            this.lbl_DienThoai.Size = new System.Drawing.Size(86, 21);
            this.lbl_DienThoai.TabIndex = 6;
            this.lbl_DienThoai.Text = "Điện thoại";
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKhachHang.Location = new System.Drawing.Point(181, 84);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Size = new System.Drawing.Size(148, 29);
            this.txt_MaKhachHang.TabIndex = 7;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(181, 125);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(232, 29);
            this.txt_HoTen.TabIndex = 8;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(535, 83);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(241, 29);
            this.txt_DiaChi.TabIndex = 9;
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DienThoai.Location = new System.Drawing.Point(535, 125);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(159, 29);
            this.txt_DienThoai.TabIndex = 10;
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_GioiTinh.FormattingEnabled = true;
            this.cbo_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_GioiTinh.Location = new System.Drawing.Point(182, 165);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Size = new System.Drawing.Size(101, 29);
            this.cbo_GioiTinh.TabIndex = 11;
            // 
            // grb_KhachHang
            // 
            this.grb_KhachHang.Controls.Add(this.gridDSKhachHang);
            this.grb_KhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grb_KhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_KhachHang.Location = new System.Drawing.Point(0, 244);
            this.grb_KhachHang.Name = "grb_KhachHang";
            this.grb_KhachHang.Size = new System.Drawing.Size(800, 206);
            this.grb_KhachHang.TabIndex = 12;
            this.grb_KhachHang.TabStop = false;
            this.grb_KhachHang.Text = "Danh sách khách hàng";
            // 
            // gridDSKhachHang
            // 
            this.gridDSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gridDSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSKhachHang.Location = new System.Drawing.Point(3, 25);
            this.gridDSKhachHang.Name = "gridDSKhachHang";
            this.gridDSKhachHang.Size = new System.Drawing.Size(794, 178);
            this.gridDSKhachHang.TabIndex = 0;
            this.gridDSKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDSKhachHang_CellClick);
            this.gridDSKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDSKhachHang_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.Name = "Column1";
            this.Column1.Width = 135;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            this.Column3.Width = 67;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "DiaChi";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 61;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "DienThoai";
            this.Column5.HeaderText = "Điện thoại";
            this.Column5.Name = "Column5";
            this.Column5.Width = 102;
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.BackColor = System.Drawing.Color.Aqua;
            this.btn_HienThi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThi.ForeColor = System.Drawing.Color.Red;
            this.btn_HienThi.Location = new System.Drawing.Point(31, 207);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(116, 31);
            this.btn_HienThi.TabIndex = 13;
            this.btn_HienThi.Text = "Hiển thị";
            this.btn_HienThi.UseVisualStyleBackColor = false;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Aqua;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(238, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 31);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Aqua;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Location = new System.Drawing.Point(388, 207);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 31);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Aqua;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(525, 207);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 31);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frm_DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.grb_KhachHang);
            this.Controls.Add(this.cbo_GioiTinh);
            this.Controls.Add(this.txt_DienThoai);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_MaKhachHang);
            this.Controls.Add(this.lbl_DienThoai);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.lbl_maKhachHang);
            this.Controls.Add(this.lbl_ttChiTietKhachHang);
            this.Controls.Add(this.lbl_ttkh);
            this.Name = "frm_DanhSachKhachHang";
            this.Text = "DANH SÁCH KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frm_DanhSachKhachHang_Load);
            this.grb_KhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ttkh;
        private System.Windows.Forms.Label lbl_ttChiTietKhachHang;
        private System.Windows.Forms.Label lbl_maKhachHang;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_DienThoai;
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.ComboBox cbo_GioiTinh;
        private System.Windows.Forms.GroupBox grb_KhachHang;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.DataGridView gridDSKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}

