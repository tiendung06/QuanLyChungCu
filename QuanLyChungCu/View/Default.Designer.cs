namespace QuanLyChungCu.View
{
    partial class Default
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
            this.lbNgayThang = new System.Windows.Forms.Label();
            this.lbtGio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbNgayThang
            // 
            this.lbNgayThang.AutoSize = true;
            this.lbNgayThang.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.lbNgayThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(181)))), ((int)(((byte)(191)))));
            this.lbNgayThang.Location = new System.Drawing.Point(450, 342);
            this.lbNgayThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgayThang.Name = "lbNgayThang";
            this.lbNgayThang.Size = new System.Drawing.Size(165, 25);
            this.lbNgayThang.TabIndex = 21;
            this.lbNgayThang.Text = "Sat, 01/01/2022";
            this.lbNgayThang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtGio
            // 
            this.lbtGio.AutoSize = true;
            this.lbtGio.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtGio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lbtGio.Location = new System.Drawing.Point(387, 252);
            this.lbtGio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtGio.Name = "lbtGio";
            this.lbtGio.Size = new System.Drawing.Size(291, 77);
            this.lbtGio.TabIndex = 20;
            this.lbtGio.Text = "00:00:00";
            this.lbtGio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(260, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "Phần mềm quản lý chung cư mini";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1064, 729);
            this.Controls.Add(this.lbNgayThang);
            this.Controls.Add(this.lbtGio);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Default";
            this.Text = "Default";
            this.Load += new System.EventHandler(this.Default_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNgayThang;
        private System.Windows.Forms.Label lbtGio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}