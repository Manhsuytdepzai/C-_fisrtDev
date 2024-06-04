namespace Quanlygai
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chọnCâuHỏiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.câu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.câu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnCâuHỏiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chọnCâuHỏiToolStripMenuItem
            // 
            this.chọnCâuHỏiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.câu2ToolStripMenuItem,
            this.câu3ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.chọnCâuHỏiToolStripMenuItem.Name = "chọnCâuHỏiToolStripMenuItem";
            this.chọnCâuHỏiToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.chọnCâuHỏiToolStripMenuItem.Text = "Chọn câu hỏi";
            // 
            // câu2ToolStripMenuItem
            // 
            this.câu2ToolStripMenuItem.Name = "câu2ToolStripMenuItem";
            this.câu2ToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.câu2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.câu2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.câu2ToolStripMenuItem.Text = "Câu 2";
            this.câu2ToolStripMenuItem.Click += new System.EventHandler(this.câu2ToolStripMenuItem_Click);
            // 
            // câu3ToolStripMenuItem
            // 
            this.câu3ToolStripMenuItem.Name = "câu3ToolStripMenuItem";
            this.câu3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.câu3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.câu3ToolStripMenuItem.Text = "Câu 3";
            this.câu3ToolStripMenuItem.Click += new System.EventHandler(this.câu3ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chọnCâuHỏiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem câu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem câu3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

