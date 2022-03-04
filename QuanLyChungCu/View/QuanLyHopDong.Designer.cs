namespace QuanLyChungCu.View
{
    partial class QuanLyHopDong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            this.grp_TimKiem = new Guna.UI.WinForms.GunaGradient2Panel();
            this.optionCombobox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.grpThongTinTaiKhoan = new Guna.UI.WinForms.GunaGroupBox();
            this.mntDateEnd = new System.Windows.Forms.MonthCalendar();
            this.mntDateStart = new System.Windows.Forms.MonthCalendar();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDateEnd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDateStart = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnThemTK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnXoa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCapNhat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLamMoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtCustomerId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtRoomId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtContractId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDSChiTietHopDong = new System.Windows.Forms.DataGridView();
            this.errContractId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errRoomId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCustomerId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDateStart = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDateEnd = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContractId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grp_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionCombobox)).BeginInit();
            this.grpThongTinTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChiTietHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errContractId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRoomId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCustomerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDateStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDateEnd)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 27;
            // 
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(20, 13);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(179, 25);
            this.lbl_QLTaiKhoan.TabIndex = 3;
            this.lbl_QLTaiKhoan.Text = "Quản lý hợp đồng";
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
            // grpThongTinTaiKhoan
            // 
            this.grpThongTinTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTinTaiKhoan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.grpThongTinTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.grpThongTinTaiKhoan.Controls.Add(this.mntDateEnd);
            this.grpThongTinTaiKhoan.Controls.Add(this.mntDateStart);
            this.grpThongTinTaiKhoan.Controls.Add(this.button2);
            this.grpThongTinTaiKhoan.Controls.Add(this.button1);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtDateEnd);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtDateStart);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnThemTK);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnXoa);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnCapNhat);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnLamMoi);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtCustomerId);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtRoomId);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtContractId);
            this.grpThongTinTaiKhoan.Controls.Add(this.label2);
            this.grpThongTinTaiKhoan.Controls.Add(this.label1);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblUsername);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblMaTK);
            this.grpThongTinTaiKhoan.Controls.Add(this.label4);
            this.grpThongTinTaiKhoan.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinTaiKhoan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.grpThongTinTaiKhoan.Location = new System.Drawing.Point(27, 96);
            this.grpThongTinTaiKhoan.Name = "grpThongTinTaiKhoan";
            this.grpThongTinTaiKhoan.Radius = 6;
            this.grpThongTinTaiKhoan.Size = new System.Drawing.Size(1010, 202);
            this.grpThongTinTaiKhoan.TabIndex = 31;
            this.grpThongTinTaiKhoan.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // mntDateEnd
            // 
            this.mntDateEnd.Location = new System.Drawing.Point(310, 22);
            this.mntDateEnd.MaxSelectionCount = 1;
            this.mntDateEnd.Name = "mntDateEnd";
            this.mntDateEnd.TabIndex = 44;
            this.mntDateEnd.Visible = false;
            this.mntDateEnd.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mntNgayKetThuc_DateSelected);
            this.mntDateEnd.MouseLeave += new System.EventHandler(this.mntNgayKetThuc_MouseLeave);
            // 
            // mntDateStart
            // 
            this.mntDateStart.Location = new System.Drawing.Point(310, 22);
            this.mntDateStart.MaxSelectionCount = 1;
            this.mntDateStart.Name = "mntDateStart";
            this.mntDateStart.TabIndex = 44;
            this.mntDateStart.Visible = false;
            this.mntDateStart.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mntNgayBatDau_DateSelected);
            this.mntDateStart.MouseLeave += new System.EventHandler(this.mntNgayBatDau_MouseLeave);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(507, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.button2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.button2.OverrideDefault.Back.ColorAngle = 45F;
            this.button2.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.OverrideDefault.Border.ColorAngle = 45F;
            this.button2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2.OverrideDefault.Border.Rounding = 6;
            this.button2.OverrideDefault.Border.Width = 1;
            this.button2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button2.Size = new System.Drawing.Size(31, 31);
            this.button2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.button2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.button2.StateCommon.Back.ColorAngle = 45F;
            this.button2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.StateCommon.Border.ColorAngle = 45F;
            this.button2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2.StateCommon.Border.Rounding = 6;
            this.button2.StateCommon.Border.Width = 1;
            this.button2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.button2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.button2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.StatePressed.Back.Color1 = System.Drawing.SystemColors.Control;
            this.button2.StatePressed.Back.Color2 = System.Drawing.SystemColors.Control;
            this.button2.StatePressed.Back.ColorAngle = 135F;
            this.button2.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.StatePressed.Border.ColorAngle = 135F;
            this.button2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StatePressed.Border.Rounding = 6;
            this.button2.StatePressed.Border.Width = 1;
            this.button2.StateTracking.Back.Color1 = System.Drawing.SystemColors.Control;
            this.button2.StateTracking.Back.Color2 = System.Drawing.SystemColors.Control;
            this.button2.StateTracking.Back.ColorAngle = 45F;
            this.button2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.StateTracking.Border.ColorAngle = 45F;
            this.button2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2.StateTracking.Border.Width = 1;
            this.button2.TabIndex = 43;
            this.button2.Values.Text = "...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(507, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.button1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.button1.OverrideDefault.Back.ColorAngle = 45F;
            this.button1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.OverrideDefault.Border.ColorAngle = 45F;
            this.button1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button1.OverrideDefault.Border.Rounding = 6;
            this.button1.OverrideDefault.Border.Width = 1;
            this.button1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.button1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.button1.StateCommon.Back.ColorAngle = 45F;
            this.button1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.StateCommon.Border.ColorAngle = 45F;
            this.button1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button1.StateCommon.Border.Rounding = 6;
            this.button1.StateCommon.Border.Width = 1;
            this.button1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.button1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.button1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.StatePressed.Back.Color1 = System.Drawing.SystemColors.Control;
            this.button1.StatePressed.Back.Color2 = System.Drawing.SystemColors.Control;
            this.button1.StatePressed.Back.ColorAngle = 135F;
            this.button1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.StatePressed.Border.ColorAngle = 135F;
            this.button1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.StatePressed.Border.Rounding = 6;
            this.button1.StatePressed.Border.Width = 1;
            this.button1.StateTracking.Back.Color1 = System.Drawing.SystemColors.Control;
            this.button1.StateTracking.Back.Color2 = System.Drawing.SystemColors.Control;
            this.button1.StateTracking.Back.ColorAngle = 45F;
            this.button1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.StateTracking.Border.ColorAngle = 45F;
            this.button1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button1.StateTracking.Border.Width = 1;
            this.button1.TabIndex = 43;
            this.button1.Values.Text = "...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDateEnd.Location = new System.Drawing.Point(410, 62);
            this.txtDateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.Size = new System.Drawing.Size(93, 31);
            this.txtDateEnd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtDateEnd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDateEnd.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDateEnd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDateEnd.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDateEnd.StateCommon.Border.Rounding = 6;
            this.txtDateEnd.StateCommon.Border.Width = 1;
            this.txtDateEnd.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtDateEnd.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateEnd.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtDateEnd.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtDateEnd.TabIndex = 42;
            this.txtDateEnd.WordWrap = false;
            // 
            // txtDateStart
            // 
            this.txtDateStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDateStart.Location = new System.Drawing.Point(410, 22);
            this.txtDateStart.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.Size = new System.Drawing.Size(93, 31);
            this.txtDateStart.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtDateStart.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDateStart.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDateStart.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDateStart.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDateStart.StateCommon.Border.Rounding = 6;
            this.txtDateStart.StateCommon.Border.Width = 1;
            this.txtDateStart.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtDateStart.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateStart.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtDateStart.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtDateStart.TabIndex = 42;
            this.txtDateStart.WordWrap = false;
            // 
            // btnThemTK
            // 
            this.btnThemTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemTK.Location = new System.Drawing.Point(310, 146);
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
            this.btnThemTK.TabIndex = 41;
            this.btnThemTK.Values.Text = "Thêm";
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(455, 146);
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
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Values.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Location = new System.Drawing.Point(165, 146);
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
            this.btnCapNhat.TabIndex = 39;
            this.btnCapNhat.Values.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Location = new System.Drawing.Point(20, 146);
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
            this.btnLamMoi.TabIndex = 38;
            this.btnLamMoi.Values.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCustomerId.Location = new System.Drawing.Point(108, 102);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(166, 31);
            this.txtCustomerId.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtCustomerId.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustomerId.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustomerId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerId.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCustomerId.StateCommon.Border.Rounding = 6;
            this.txtCustomerId.StateCommon.Border.Width = 1;
            this.txtCustomerId.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtCustomerId.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtCustomerId.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtCustomerId.TabIndex = 5;
            this.txtCustomerId.WordWrap = false;
            // 
            // txtRoomId
            // 
            this.txtRoomId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRoomId.Location = new System.Drawing.Point(108, 62);
            this.txtRoomId.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(166, 31);
            this.txtRoomId.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtRoomId.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRoomId.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRoomId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRoomId.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtRoomId.StateCommon.Border.Rounding = 6;
            this.txtRoomId.StateCommon.Border.Width = 1;
            this.txtRoomId.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtRoomId.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomId.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtRoomId.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtRoomId.TabIndex = 5;
            this.txtRoomId.WordWrap = false;
            // 
            // txtContractId
            // 
            this.txtContractId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtContractId.Location = new System.Drawing.Point(108, 22);
            this.txtContractId.Margin = new System.Windows.Forms.Padding(2);
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.Size = new System.Drawing.Size(166, 31);
            this.txtContractId.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtContractId.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtContractId.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtContractId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtContractId.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtContractId.StateCommon.Border.Rounding = 6;
            this.txtContractId.StateCommon.Border.Width = 1;
            this.txtContractId.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtContractId.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractId.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtContractId.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtContractId.TabIndex = 4;
            this.txtContractId.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã người ở:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã hợp đồng:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lblUsername.Location = new System.Drawing.Point(20, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(66, 15);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Mã phòng:";
            // 
            // lblMaTK
            // 
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblMaTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lblMaTK.Location = new System.Drawing.Point(310, 30);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(85, 15);
            this.lblMaTK.TabIndex = 16;
            this.lblMaTK.Text = "Ngày bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(310, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ngày kết thúc";
            // 
            // dgvDSChiTietHopDong
            // 
            this.dgvDSChiTietHopDong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSChiTietHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSChiTietHopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSChiTietHopDong.ColumnHeadersHeight = 36;
            this.dgvDSChiTietHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractId,
            this.RoomId,
            this.CustomerId,
            this.DateStart,
            this.DateEnd});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSChiTietHopDong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSChiTietHopDong.Location = new System.Drawing.Point(27, 325);
            this.dgvDSChiTietHopDong.Name = "dgvDSChiTietHopDong";
            this.dgvDSChiTietHopDong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDSChiTietHopDong.RowHeadersWidth = 51;
            this.dgvDSChiTietHopDong.RowTemplate.Height = 36;
            this.dgvDSChiTietHopDong.Size = new System.Drawing.Size(1010, 378);
            this.dgvDSChiTietHopDong.TabIndex = 32;
            this.dgvDSChiTietHopDong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDSChiTietHopDong_MouseClick);
            // 
            // errContractId
            // 
            this.errContractId.ContainerControl = this;
            // 
            // errRoomId
            // 
            this.errRoomId.ContainerControl = this;
            // 
            // errCustomerId
            // 
            this.errCustomerId.ContainerControl = this;
            // 
            // errDateStart
            // 
            this.errDateStart.ContainerControl = this;
            // 
            // errDateEnd
            // 
            this.errDateEnd.ContainerControl = this;
            // 
            // ContractId
            // 
            this.ContractId.DataPropertyName = "ContractId";
            this.ContractId.HeaderText = "Mã hợp đồng";
            this.ContractId.MinimumWidth = 6;
            this.ContractId.Name = "ContractId";
            this.ContractId.Width = 130;
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "RoomId";
            this.RoomId.HeaderText = "Mã phòng";
            this.RoomId.MinimumWidth = 6;
            this.RoomId.Name = "RoomId";
            this.RoomId.Width = 120;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "Mã người ở";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Width = 130;
            // 
            // DateStart
            // 
            this.DateStart.DataPropertyName = "DateStart";
            this.DateStart.HeaderText = "Ngày bắt đầu";
            this.DateStart.MinimumWidth = 6;
            this.DateStart.Name = "DateStart";
            this.DateStart.ReadOnly = true;
            this.DateStart.Width = 140;
            // 
            // DateEnd
            // 
            this.DateEnd.DataPropertyName = "DateEnd";
            this.DateEnd.HeaderText = "Ngày kết thúc";
            this.DateEnd.MinimumWidth = 6;
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Width = 140;
            // 
            // QuanLyHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 729);
            this.Controls.Add(this.dgvDSChiTietHopDong);
            this.Controls.Add(this.grpThongTinTaiKhoan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyHopDong";
            this.Text = "QuanLyHopDong";
            this.Load += new System.EventHandler(this.QuanLyHopDong_Load);
            this.Shown += new System.EventHandler(this.QuanLyHopDong_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionCombobox)).EndInit();
            this.grpThongTinTaiKhoan.ResumeLayout(false);
            this.grpThongTinTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChiTietHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errContractId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRoomId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCustomerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDateStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDateEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private Guna.UI.WinForms.GunaGradient2Panel grp_TimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox optionCombobox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimKiem;
        private Guna.UI.WinForms.GunaGroupBox grpThongTinTaiKhoan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThemTK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXoa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCapNhat;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLamMoi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRoomId;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtContractId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblMaTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDSChiTietHopDong;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDateEnd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDateStart;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCustomerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mntDateStart;
        private System.Windows.Forms.MonthCalendar mntDateEnd;
        private System.Windows.Forms.ErrorProvider errContractId;
        private System.Windows.Forms.ErrorProvider errRoomId;
        private System.Windows.Forms.ErrorProvider errCustomerId;
        private System.Windows.Forms.ErrorProvider errDateStart;
        private System.Windows.Forms.ErrorProvider errDateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
    }
}