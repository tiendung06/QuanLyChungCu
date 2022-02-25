using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.View
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label1.Left = (this.label1.Parent.Width - this.label1.Width) / 2;
            this.lbtGio.Text = datetime.ToString("HH:mm:ss");
            this.lbtGio.Left = (this.lbtGio.Parent.Width - this.lbtGio.Width) / 2;
            this.lbNgayThang.Text = datetime.ToString("ddd, dd/MM/yyyy");
            this.lbNgayThang.Left = (this.lbNgayThang.Parent.Width - this.lbNgayThang.Width) / 2;
        }
    }
}
