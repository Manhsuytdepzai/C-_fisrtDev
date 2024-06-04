namespace DanhSachKhachHang_1_Form
{
    partial class frm_KhachHang
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
            this.lbl_KhachHang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.cbo_GioiTinh = new System.Windows.Forms.ComboBox();
            this.grb_KhachHang = new System.Windows.Forms.GroupBox();
            this.lv_DSKhachHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_GoiDuLieu = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_XoaAll = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.grb_KhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_KhachHang
            // 
            this.lbl_KhachHang.AutoSize = true;
            this.lbl_KhachHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KhachHang.Location = new System.Drawing.Point(320, 11);
            this.lbl_KhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KhachHang.Name = "lbl_KhachHang";
            this.lbl_KhachHang.Size = new System.Drawing.Size(407, 35);
            this.lbl_KhachHang.TabIndex = 0;
            this.lbl_KhachHang.Text = "THÔNG TIN KHÁCH HÀNG";
            this.lbl_KhachHang.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin chi tiết về khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(603, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(603, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số điện thoại";
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKhachHang.Location = new System.Drawing.Point(253, 110);
            this.txt_MaKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Size = new System.Drawing.Size(175, 35);
            this.txt_MaKhachHang.TabIndex = 4;
            this.txt_MaKhachHang.TextChanged += new System.EventHandler(this.txt_MaKhachHang_TextChanged);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(253, 158);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(321, 35);
            this.txt_HoTen.TabIndex = 4;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(751, 110);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(328, 35);
            this.txt_DiaChi.TabIndex = 4;
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DienThoai.Location = new System.Drawing.Point(751, 164);
            this.txt_DienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(189, 35);
            this.txt_DienThoai.TabIndex = 4;
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_GioiTinh.FormattingEnabled = true;
            this.cbo_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_GioiTinh.Location = new System.Drawing.Point(253, 206);
            this.cbo_GioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Size = new System.Drawing.Size(160, 35);
            this.cbo_GioiTinh.TabIndex = 5;
            this.cbo_GioiTinh.SelectedIndexChanged += new System.EventHandler(this.cbo_GioiTinh_SelectedIndexChanged);
            // 
            // grb_KhachHang
            // 
            this.grb_KhachHang.Controls.Add(this.lv_DSKhachHang);
            this.grb_KhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grb_KhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_KhachHang.Location = new System.Drawing.Point(0, 336);
            this.grb_KhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.grb_KhachHang.Name = "grb_KhachHang";
            this.grb_KhachHang.Padding = new System.Windows.Forms.Padding(4);
            this.grb_KhachHang.Size = new System.Drawing.Size(1105, 271);
            this.grb_KhachHang.TabIndex = 6;
            this.grb_KhachHang.TabStop = false;
            this.grb_KhachHang.Text = "Thông tin khách hàng";
            // 
            // lv_DSKhachHang
            // 
            this.lv_DSKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_DSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_DSKhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_DSKhachHang.FullRowSelect = true;
            this.lv_DSKhachHang.GridLines = true;
            this.lv_DSKhachHang.HideSelection = false;
            this.lv_DSKhachHang.Location = new System.Drawing.Point(4, 32);
            this.lv_DSKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.lv_DSKhachHang.Name = "lv_DSKhachHang";
            this.lv_DSKhachHang.Size = new System.Drawing.Size(1097, 235);
            this.lv_DSKhachHang.TabIndex = 0;
            this.lv_DSKhachHang.UseCompatibleStateImageBehavior = false;
            this.lv_DSKhachHang.View = System.Windows.Forms.View.Details;
            this.lv_DSKhachHang.SelectedIndexChanged += new System.EventHandler(this.lv_DSKhachHang_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã khách hàng";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điện thoại";
            this.columnHeader5.Width = 150;
            // 
            // btn_GoiDuLieu
            // 
            this.btn_GoiDuLieu.BackColor = System.Drawing.Color.Aqua;
            this.btn_GoiDuLieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoiDuLieu.ForeColor = System.Drawing.Color.Red;
            this.btn_GoiDuLieu.Location = new System.Drawing.Point(39, 268);
            this.btn_GoiDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GoiDuLieu.Name = "btn_GoiDuLieu";
            this.btn_GoiDuLieu.Size = new System.Drawing.Size(155, 46);
            this.btn_GoiDuLieu.TabIndex = 7;
            this.btn_GoiDuLieu.Text = "Gọi dữ liệu";
            this.btn_GoiDuLieu.UseVisualStyleBackColor = false;
            this.btn_GoiDuLieu.Click += new System.EventHandler(this.btn_GoiDuLieu_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Aqua;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Red;
            this.btn_Them.Location = new System.Drawing.Point(245, 268);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(92, 46);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_XoaAll
            // 
            this.btn_XoaAll.BackColor = System.Drawing.Color.Aqua;
            this.btn_XoaAll.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaAll.ForeColor = System.Drawing.Color.Red;
            this.btn_XoaAll.Location = new System.Drawing.Point(382, 268);
            this.btn_XoaAll.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaAll.Name = "btn_XoaAll";
            this.btn_XoaAll.Size = new System.Drawing.Size(173, 46);
            this.btn_XoaAll.TabIndex = 9;
            this.btn_XoaAll.Text = "Xóa toàn bộ";
            this.btn_XoaAll.UseVisualStyleBackColor = false;
            this.btn_XoaAll.Click += new System.EventHandler(this.btn_XoaAll_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Aqua;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Location = new System.Drawing.Point(608, 268);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(81, 46);
            this.btn_Xoa.TabIndex = 10;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Aqua;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Red;
            this.btn_Thoat.Location = new System.Drawing.Point(751, 268);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(121, 46);
            this.btn_Thoat.TabIndex = 11;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.Aqua;
            this.sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.ForeColor = System.Drawing.Color.Red;
            this.sua.Location = new System.Drawing.Point(935, 268);
            this.sua.Margin = new System.Windows.Forms.Padding(4);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(121, 46);
            this.sua.TabIndex = 12;
            this.sua.Text = "sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 607);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_XoaAll);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_GoiDuLieu);
            this.Controls.Add(this.grb_KhachHang);
            this.Controls.Add(this.cbo_GioiTinh);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_DienThoai);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_MaKhachHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_KhachHang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_KhachHang";
            this.Text = "FORM THÔNG TIN VỀ KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frm_KhachHang_Load);
            this.grb_KhachHang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.ComboBox cbo_GioiTinh;
        private System.Windows.Forms.GroupBox grb_KhachHang;
        private System.Windows.Forms.ListView lv_DSKhachHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_GoiDuLieu;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_XoaAll;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button sua;
    }
}

