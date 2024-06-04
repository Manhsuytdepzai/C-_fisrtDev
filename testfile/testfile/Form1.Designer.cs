namespace testfile
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("trinhmanh", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("manhtrinh", System.Windows.Forms.HorizontalAlignment.Left);
            this.button1 = new System.Windows.Forms.Button();
            this.testtable = new System.Windows.Forms.ListView();
            this.trinhmanh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manhtrinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testtable
            // 
            this.testtable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trinhmanh,
            this.manhtrinh});
            listViewGroup1.Header = "trinhmanh";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "manhtrinh";
            listViewGroup2.Name = "listViewGroup2";
            this.testtable.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.testtable.HideSelection = false;
            this.testtable.Location = new System.Drawing.Point(46, 186);
            this.testtable.Name = "testtable";
            this.testtable.Size = new System.Drawing.Size(655, 163);
            this.testtable.TabIndex = 2;
            this.testtable.UseCompatibleStateImageBehavior = false;
            this.testtable.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // trinhmanh
            // 
            this.trinhmanh.Text = "manhtrinh";
            this.trinhmanh.Width = 500;
            // 
            // manhtrinh
            // 
            this.manhtrinh.Text = "Trinhmanh";
            this.manhtrinh.Width = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testtable);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView testtable;
        private System.Windows.Forms.ColumnHeader trinhmanh;
        private System.Windows.Forms.ColumnHeader manhtrinh;
    }
}

