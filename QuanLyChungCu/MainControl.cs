using QuanLyChungCu.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyChungCu
{
    public partial class MainControl : KryptonForm
    {
        public MainControl()
        {
            InitializeComponent();
            lblNameUser.Text = Login.nameLogin;
            this.lblNameUser.Left = (this.lblNameUser.Parent.Width - this.lblNameUser.Width) / 2;
            home();
            if (Login.resultLogin != 1)
            {
                btnBaoCaoThongKe.Visible = false;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đăng xuất?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //set form
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }

        public void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["QuanLyPhong"] == null)
                btnQLPhong.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyKhachO"] == null)
                btnQLKhachO.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyHopDong"] == null)
                btnQLHopDong.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyThuTien"] == null)
                btnQLThuTien.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["BaoCaoThongKe"] == null)
                btnBaoCaoThongKe.BackColor = Color.FromArgb(250, 255, 252);
        }

        //reset color for button
        public void resetColorForButton()
        {
            btnHome.BackColor = Color.FromArgb(250, 255, 252);
            btnHome.ForeColor = Color.FromArgb(103, 102, 105);
            btnHome.IconColor = Color.FromArgb(103, 102, 105);

            btnQLPhong.BackColor = Color.FromArgb(250, 255, 252);
            btnQLPhong.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLPhong.IconColor = Color.FromArgb(103, 102, 105);

            btnQLKhachO.BackColor = Color.FromArgb(250, 255, 252);
            btnQLKhachO.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLKhachO.IconColor = Color.FromArgb(103, 102, 105);

            btnQLHopDong.BackColor = Color.FromArgb(250, 255, 252);
            btnQLHopDong.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLHopDong.IconColor = Color.FromArgb(103, 102, 105);

            btnQLThuTien.BackColor = Color.FromArgb(250, 255, 252);
            btnQLThuTien.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLThuTien.IconColor = Color.FromArgb(103, 102, 105);

            btnBaoCaoThongKe.BackColor = Color.FromArgb(250, 255, 252);
            btnBaoCaoThongKe.ForeColor = Color.FromArgb(103, 102, 105);
            btnBaoCaoThongKe.IconColor = Color.FromArgb(103, 102, 105);
        }

        private void home()
        {
            resetColorForButton();
            AbrirFormulario<Default>();
            btnHome.BackColor = Color.FromArgb(8, 142, 254);
            btnHome.ForeColor = Color.FromArgb(250, 255, 252);
            btnHome.IconColor = Color.FromArgb(250, 255, 252);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            home();
        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            resetColorForButton();
            AbrirFormulario<QuanLyPhong>();
            btnQLPhong.BackColor = Color.FromArgb(8, 142, 254);
            btnQLPhong.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLPhong.IconColor = Color.FromArgb(250, 255, 252);
        }

        private void btnQLKhachO_Click(object sender, EventArgs e)
        {
            resetColorForButton();
            AbrirFormulario<QuanLyNguoiThue>();
            btnQLKhachO.BackColor = Color.FromArgb(8, 142, 254);
            btnQLKhachO.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLKhachO.IconColor = Color.FromArgb(250, 255, 252);
        }

        public static string checkInjectionSQL(string value)
        {
            return value.Replace("\'", "NULL").Replace("=", "NULL");
        }

        private void btnQLHopDong_Click(object sender, EventArgs e)
        {
            //form hop dong
            resetColorForButton();
            AbrirFormulario<QuanLyHopDong>();
            btnQLHopDong.BackColor = Color.FromArgb(8, 142, 254);
            btnQLHopDong.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLHopDong.IconColor = Color.FromArgb(250, 255, 252);
        }

        private void btnQuanLyThuTien_Click(object sender, EventArgs e)
        {
            resetColorForButton();
            AbrirFormulario<QuanLyThuTien>();
            btnQLThuTien.BackColor = Color.FromArgb(8, 142, 254);
            btnQLThuTien.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLThuTien.IconColor = Color.FromArgb(250, 255, 252);
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            resetColorForButton();
            AbrirFormulario<BaoCaoThongKe>();
            btnBaoCaoThongKe.BackColor = Color.FromArgb(8, 142, 254);
            btnBaoCaoThongKe.ForeColor = Color.FromArgb(250, 255, 252);
            btnBaoCaoThongKe.IconColor = Color.FromArgb(250, 255, 252);
        }
    }
}
