namespace TinhTong
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_so2 = new System.Windows.Forms.TextBox();
            this.txt_so1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_TinhTong = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phép cộng hai số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số thứ hai";
            // 
            // txt_so2
            // 
            this.txt_so2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_so2.Location = new System.Drawing.Point(289, 216);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(210, 40);
            this.txt_so2.TabIndex = 4;
            // 
            // txt_so1
            // 
            this.txt_so1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_so1.Location = new System.Drawing.Point(289, 146);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(210, 40);
            this.txt_so1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả";
            // 
            // txt_kq
            // 
            this.txt_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kq.Location = new System.Drawing.Point(289, 289);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(210, 40);
            this.txt_kq.TabIndex = 7;
            // 
            // btn_TinhTong
            // 
            this.btn_TinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TinhTong.Location = new System.Drawing.Point(121, 373);
            this.btn_TinhTong.Name = "btn_TinhTong";
            this.btn_TinhTong.Size = new System.Drawing.Size(172, 46);
            this.btn_TinhTong.TabIndex = 8;
            this.btn_TinhTong.Text = "Tính tổng";
            this.btn_TinhTong.UseVisualStyleBackColor = true;
            this.btn_TinhTong.Click += new System.EventHandler(this.btn_TinhTong_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(613, 373);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(118, 46);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TinhTong);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_so1);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Phép cộng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_so2;
        private System.Windows.Forms.TextBox txt_so1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_TinhTong;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

