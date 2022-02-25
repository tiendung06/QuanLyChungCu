namespace QuanLyChungCu.View
{
    partial class QuanLyTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDSTaiKhoans = new System.Windows.Forms.DataGridView();
            this.Id_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            this.errId_Customer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errUser_Name = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPass_Word = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpThongTinTaiKhoan = new Guna.UI.WinForms.GunaGroupBox();
            this.txtMaTK = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtId_Customer = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnThemTK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnXoa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCapNhat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLamMoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.grp_TimKiem = new Guna.UI.WinForms.GunaGradient2Panel();
            this.optionCombobox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUser_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPass_Word)).BeginInit();
            this.grpThongTinTaiKhoan.SuspendLayout();
            this.grp_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionCombobox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSTaiKhoans
            // 
            this.dgvDSTaiKhoans.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSTaiKhoans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSTaiKhoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSTaiKhoans.ColumnHeadersHeight = 36;
            this.dgvDSTaiKhoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Customer,
            this.User_Name_Customer,
            this.PassWord_Customer});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSTaiKhoans.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSTaiKhoans.Location = new System.Drawing.Point(27, 325);
            this.dgvDSTaiKhoans.Name = "dgvDSTaiKhoans";
            this.dgvDSTaiKhoans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDSTaiKhoans.RowHeadersWidth = 51;
            this.dgvDSTaiKhoans.RowTemplate.Height = 36;
            this.dgvDSTaiKhoans.Size = new System.Drawing.Size(1010, 378);
            this.dgvDSTaiKhoans.TabIndex = 11;
            this.dgvDSTaiKhoans.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDSTaiKhoan_MouseClick);
            // 
            // Id_Customer
            // 
            this.Id_Customer.DataPropertyName = "Id_Customer";
            this.Id_Customer.HeaderText = "Mã Người Dùng";
            this.Id_Customer.MinimumWidth = 6;
            this.Id_Customer.Name = "Id_Customer";
            this.Id_Customer.Width = 140;
            // 
            // User_Name_Customer
            // 
            this.User_Name_Customer.DataPropertyName = "User_Name_Customer";
            this.User_Name_Customer.HeaderText = "Tên Đăng Nhập";
            this.User_Name_Customer.MinimumWidth = 6;
            this.User_Name_Customer.Name = "User_Name_Customer";
            this.User_Name_Customer.ReadOnly = true;
            this.User_Name_Customer.Width = 240;
            // 
            // PassWord_Customer
            // 
            this.PassWord_Customer.DataPropertyName = "PassWord_Customer";
            this.PassWord_Customer.HeaderText = "Mật Khẩu";
            this.PassWord_Customer.MinimumWidth = 6;
            this.PassWord_Customer.Name = "PassWord_Customer";
            this.PassWord_Customer.ReadOnly = true;
            this.PassWord_Customer.Width = 250;
            // 
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(20, 13);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(176, 25);
            this.lbl_QLTaiKhoan.TabIndex = 3;
            this.lbl_QLTaiKhoan.Text = "Quản lý tài khoản";
            // 
            // errId_Customer
            // 
            this.errId_Customer.ContainerControl = this;
            // 
            // errUser_Name
            // 
            this.errUser_Name.ContainerControl = this;
            // 
            // errPass_Word
            // 
            this.errPass_Word.ContainerControl = this;
            // 
            // grpThongTinTaiKhoan
            // 
            this.grpThongTinTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTinTaiKhoan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.grpThongTinTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.grpThongTinTaiKhoan.Controls.Add(this.txtMaTK);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtUsername);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Customer);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnThemTK);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnXoa);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnCapNhat);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnLamMoi);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblUsername);
            this.grpThongTinTaiKhoan.Controls.Add(this.label1);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblMaTK);
            this.grpThongTinTaiKhoan.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinTaiKhoan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.grpThongTinTaiKhoan.Location = new System.Drawing.Point(27, 96);
            this.grpThongTinTaiKhoan.Name = "grpThongTinTaiKhoan";
            this.grpThongTinTaiKhoan.Radius = 6;
            this.grpThongTinTaiKhoan.Size = new System.Drawing.Size(682, 202);
            this.grpThongTinTaiKhoan.TabIndex = 19;
            this.grpThongTinTaiKhoan.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtMaTK
            // 
            this.txtMaTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMaTK.Location = new System.Drawing.Point(145, 132);
            this.txtMaTK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(166, 31);
            this.txtMaTK.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtMaTK.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaTK.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaTK.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaTK.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtMaTK.StateCommon.Border.Rounding = 6;
            this.txtMaTK.StateCommon.Border.Width = 1;
            this.txtMaTK.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtMaTK.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTK.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtMaTK.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtMaTK.TabIndex = 6;
            this.txtMaTK.WordWrap = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUsername.Location = new System.Drawing.Point(145, 87);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(166, 31);
            this.txtUsername.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtUsername.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsername.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsername.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUsername.StateCommon.Border.Rounding = 6;
            this.txtUsername.StateCommon.Border.Width = 1;
            this.txtUsername.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtUsername.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.TabIndex = 5;
            this.txtUsername.WordWrap = false;
            // 
            // txtId_Customer
            // 
            this.txtId_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtId_Customer.Location = new System.Drawing.Point(145, 42);
            this.txtId_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.txtId_Customer.Name = "txtId_Customer";
            this.txtId_Customer.Size = new System.Drawing.Size(166, 31);
            this.txtId_Customer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtId_Customer.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtId_Customer.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtId_Customer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtId_Customer.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtId_Customer.StateCommon.Border.Rounding = 6;
            this.txtId_Customer.StateCommon.Border.Width = 1;
            this.txtId_Customer.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtId_Customer.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Customer.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtId_Customer.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtId_Customer.TabIndex = 4;
            this.txtId_Customer.WordWrap = false;
            // 
            // btnThemTK
            // 
            this.btnThemTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemTK.Location = new System.Drawing.Point(514, 87);
            this.btnThemTK.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThemTK.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThemTK.OverrideDefault.Back.ColorAngle = 45F;
            this.btnThemTK.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThemTK.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThemTK.OverrideDefault.Border.ColorAngle = 45F;
            this.btnThemTK.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThemTK.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThemTK.OverrideDefault.Border.Rounding = 6;
            this.btnThemTK.OverrideDefault.Border.Width = 1;
            this.btnThemTK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnThemTK.Size = new System.Drawing.Size(125, 36);
            this.btnThemTK.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThemTK.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThemTK.StateCommon.Back.ColorAngle = 45F;
            this.btnThemTK.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThemTK.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThemTK.StateCommon.Border.ColorAngle = 45F;
            this.btnThemTK.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThemTK.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThemTK.StateCommon.Border.Rounding = 6;
            this.btnThemTK.StateCommon.Border.Width = 1;
            this.btnThemTK.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnThemTK.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnThemTK.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnThemTK.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnThemTK.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnThemTK.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnThemTK.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThemTK.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnThemTK.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnThemTK.StatePressed.Back.ColorAngle = 135F;
            this.btnThemTK.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThemTK.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThemTK.StatePressed.Border.ColorAngle = 135F;
            this.btnThemTK.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThemTK.StatePressed.Border.Rounding = 6;
            this.btnThemTK.StatePressed.Border.Width = 1;
            this.btnThemTK.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnThemTK.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnThemTK.StateTracking.Back.ColorAngle = 45F;
            this.btnThemTK.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThemTK.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThemTK.StateTracking.Border.ColorAngle = 45F;
            this.btnThemTK.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThemTK.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThemTK.StateTracking.Border.Width = 1;
            this.btnThemTK.TabIndex = 10;
            this.btnThemTK.Values.Text = "Thêm tài khoản";
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(369, 87);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXoa.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXoa.OverrideDefault.Back.ColorAngle = 45F;
            this.btnXoa.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXoa.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXoa.OverrideDefault.Border.ColorAngle = 45F;
            this.btnXoa.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXoa.OverrideDefault.Border.Rounding = 6;
            this.btnXoa.OverrideDefault.Border.Width = 1;
            this.btnXoa.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnXoa.Size = new System.Drawing.Size(125, 36);
            this.btnXoa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXoa.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXoa.StateCommon.Back.ColorAngle = 45F;
            this.btnXoa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXoa.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXoa.StateCommon.Border.ColorAngle = 45F;
            this.btnXoa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXoa.StateCommon.Border.Rounding = 6;
            this.btnXoa.StateCommon.Border.Width = 1;
            this.btnXoa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXoa.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnXoa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnXoa.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnXoa.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnXoa.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnXoa.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnXoa.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnXoa.StatePressed.Back.ColorAngle = 135F;
            this.btnXoa.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXoa.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXoa.StatePressed.Border.ColorAngle = 135F;
            this.btnXoa.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StatePressed.Border.Rounding = 6;
            this.btnXoa.StatePressed.Border.Width = 1;
            this.btnXoa.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnXoa.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnXoa.StateTracking.Back.ColorAngle = 45F;
            this.btnXoa.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXoa.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXoa.StateTracking.Border.ColorAngle = 45F;
            this.btnXoa.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXoa.StateTracking.Border.Width = 1;
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Values.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Location = new System.Drawing.Point(514, 42);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCapNhat.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCapNhat.OverrideDefault.Back.ColorAngle = 45F;
            this.btnCapNhat.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCapNhat.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCapNhat.OverrideDefault.Border.ColorAngle = 45F;
            this.btnCapNhat.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCapNhat.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCapNhat.OverrideDefault.Border.Rounding = 6;
            this.btnCapNhat.OverrideDefault.Border.Width = 1;
            this.btnCapNhat.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCapNhat.Size = new System.Drawing.Size(125, 36);
            this.btnCapNhat.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCapNhat.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCapNhat.StateCommon.Back.ColorAngle = 45F;
            this.btnCapNhat.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCapNhat.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCapNhat.StateCommon.Border.ColorAngle = 45F;
            this.btnCapNhat.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCapNhat.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCapNhat.StateCommon.Border.Rounding = 6;
            this.btnCapNhat.StateCommon.Border.Width = 1;
            this.btnCapNhat.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCapNhat.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCapNhat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnCapNhat.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnCapNhat.StatePressed.Back.ColorAngle = 135F;
            this.btnCapNhat.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCapNhat.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCapNhat.StatePressed.Border.ColorAngle = 135F;
            this.btnCapNhat.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCapNhat.StatePressed.Border.Rounding = 6;
            this.btnCapNhat.StatePressed.Border.Width = 1;
            this.btnCapNhat.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnCapNhat.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnCapNhat.StateTracking.Back.ColorAngle = 45F;
            this.btnCapNhat.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCapNhat.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCapNhat.StateTracking.Border.ColorAngle = 45F;
            this.btnCapNhat.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCapNhat.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCapNhat.StateTracking.Border.Width = 1;
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Values.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Location = new System.Drawing.Point(369, 42);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLamMoi.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLamMoi.OverrideDefault.Back.ColorAngle = 45F;
            this.btnLamMoi.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLamMoi.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLamMoi.OverrideDefault.Border.ColorAngle = 45F;
            this.btnLamMoi.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLamMoi.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLamMoi.OverrideDefault.Border.Rounding = 6;
            this.btnLamMoi.OverrideDefault.Border.Width = 1;
            this.btnLamMoi.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnLamMoi.Size = new System.Drawing.Size(125, 36);
            this.btnLamMoi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLamMoi.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLamMoi.StateCommon.Back.ColorAngle = 45F;
            this.btnLamMoi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLamMoi.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLamMoi.StateCommon.Border.ColorAngle = 45F;
            this.btnLamMoi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLamMoi.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLamMoi.StateCommon.Border.Rounding = 6;
            this.btnLamMoi.StateCommon.Border.Width = 1;
            this.btnLamMoi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLamMoi.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLamMoi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnLamMoi.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnLamMoi.StatePressed.Back.ColorAngle = 135F;
            this.btnLamMoi.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLamMoi.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLamMoi.StatePressed.Border.ColorAngle = 135F;
            this.btnLamMoi.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLamMoi.StatePressed.Border.Rounding = 6;
            this.btnLamMoi.StatePressed.Border.Width = 1;
            this.btnLamMoi.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnLamMoi.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnLamMoi.StateTracking.Back.ColorAngle = 45F;
            this.btnLamMoi.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLamMoi.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLamMoi.StateTracking.Border.ColorAngle = 45F;
            this.btnLamMoi.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLamMoi.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLamMoi.StateTracking.Border.Width = 1;
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Values.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lblUsername.Location = new System.Drawing.Point(30, 95);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(94, 15);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã người dùng:";
            // 
            // lblMaTK
            // 
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lblMaTK.Location = new System.Drawing.Point(30, 140);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(63, 15);
            this.lblMaTK.TabIndex = 16;
            this.lblMaTK.Text = "Mật khẩu:";
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.BackColor = System.Drawing.Color.Transparent;
            this.grp_TimKiem.Controls.Add(this.optionCombobox);
            this.grp_TimKiem.Controls.Add(this.btnTimKiem);
            this.grp_TimKiem.Controls.Add(this.txtTimKiem);
            this.grp_TimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_TimKiem.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.grp_TimKiem.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.grp_TimKiem.Location = new System.Drawing.Point(414, 0);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Radius = 5;
            this.grp_TimKiem.Size = new System.Drawing.Size(650, 70);
            this.grp_TimKiem.TabIndex = 23;
            // 
            // optionCombobox
            // 
            this.optionCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optionCombobox.DropDownWidth = 143;
            this.optionCombobox.Items.AddRange(new object[] {
            "Mã người dùng",
            "Tên người dùng"});
            this.optionCombobox.Location = new System.Drawing.Point(95, 23);
            this.optionCombobox.Name = "optionCombobox";
            this.optionCombobox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.optionCombobox.Size = new System.Drawing.Size(147, 25);
            this.optionCombobox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.optionCombobox.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.optionCombobox.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.optionCombobox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.optionCombobox.StateCommon.ComboBox.Border.Rounding = 6;
            this.optionCombobox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.optionCombobox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionCombobox.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.optionCombobox.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Location = new System.Drawing.Point(511, 17);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTimKiem.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTimKiem.OverrideDefault.Back.ColorAngle = 45F;
            this.btnTimKiem.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTimKiem.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTimKiem.OverrideDefault.Border.ColorAngle = 45F;
            this.btnTimKiem.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimKiem.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnTimKiem.OverrideDefault.Border.Rounding = 6;
            this.btnTimKiem.OverrideDefault.Border.Width = 1;
            this.btnTimKiem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnTimKiem.Size = new System.Drawing.Size(112, 36);
            this.btnTimKiem.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTimKiem.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTimKiem.StateCommon.Back.ColorAngle = 45F;
            this.btnTimKiem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTimKiem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTimKiem.StateCommon.Border.ColorAngle = 45F;
            this.btnTimKiem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimKiem.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnTimKiem.StateCommon.Border.Rounding = 6;
            this.btnTimKiem.StateCommon.Border.Width = 1;
            this.btnTimKiem.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTimKiem.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTimKiem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnTimKiem.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnTimKiem.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnTimKiem.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnTimKiem.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimKiem.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnTimKiem.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnTimKiem.StatePressed.Back.ColorAngle = 135F;
            this.btnTimKiem.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTimKiem.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTimKiem.StatePressed.Border.ColorAngle = 135F;
            this.btnTimKiem.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimKiem.StatePressed.Border.Rounding = 6;
            this.btnTimKiem.StatePressed.Border.Width = 1;
            this.btnTimKiem.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnTimKiem.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnTimKiem.StateTracking.Back.ColorAngle = 45F;
            this.btnTimKiem.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTimKiem.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnTimKiem.StateTracking.Border.ColorAngle = 45F;
            this.btnTimKiem.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimKiem.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnTimKiem.StateTracking.Border.Width = 1;
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Values.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTimKiem.Location = new System.Drawing.Point(247, 17);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 36);
            this.txtTimKiem.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtTimKiem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTimKiem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTimKiem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTimKiem.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTimKiem.StateCommon.Border.Rounding = 6;
            this.txtTimKiem.StateCommon.Border.Width = 1;
            this.txtTimKiem.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtTimKiem.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.lbl_QLTaiKhoan);
            this.panel1.Controls.Add(this.grp_TimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 70);
            this.panel1.TabIndex = 24;
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpThongTinTaiKhoan);
            this.Controls.Add(this.dgvDSTaiKhoans);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyTaiKhoan";
            this.Text = "QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUser_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPass_Word)).EndInit();
            this.grpThongTinTaiKhoan.ResumeLayout(false);
            this.grpThongTinTaiKhoan.PerformLayout();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionCombobox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSTaiKhoans;
        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private System.Windows.Forms.ErrorProvider errId_Customer;
        private System.Windows.Forms.ErrorProvider errUser_Name;
        private System.Windows.Forms.ErrorProvider errPass_Word;
        private Guna.UI.WinForms.GunaGroupBox grpThongTinTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaTK;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI.WinForms.GunaGradient2Panel grp_TimKiem;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox optionCombobox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThemTK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXoa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCapNhat;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLamMoi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMaTK;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtId_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord_Customer;
    }
}