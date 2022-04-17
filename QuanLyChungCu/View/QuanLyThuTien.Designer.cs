namespace QuanLyChungCu.View
{
    partial class QuanLyThuTien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            this.grp_TimKiem = new Guna.UI.WinForms.GunaGradient2Panel();
            this.optionCombobox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.grpThongTinThuTien = new Guna.UI.WinForms.GunaGroupBox();
            this.txtCost = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMonth = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSettlementDay = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPayday = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnHuyThanhToan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnXuatHoaDon = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnThanhToan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLamMoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtRentStatus = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtContractId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtRentId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDSChiTietThuTien = new System.Windows.Forms.DataGridView();
            this.RentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettlementDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentStatusTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grp_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionCombobox)).BeginInit();
            this.grpThongTinThuTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChiTietThuTien)).BeginInit();
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
            this.panel1.TabIndex = 34;
            // 
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(20, 13);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(161, 25);
            this.lbl_QLTaiKhoan.TabIndex = 3;
            this.lbl_QLTaiKhoan.Text = "Quản lý thu tiền";
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
            this.optionCombobox.TabIndex = 12;
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
            this.btnTimKiem.TabIndex = 14;
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
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.WordWrap = false;
            // 
            // grpThongTinThuTien
            // 
            this.grpThongTinThuTien.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTinThuTien.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.grpThongTinThuTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.grpThongTinThuTien.Controls.Add(this.txtCost);
            this.grpThongTinThuTien.Controls.Add(this.txtMonth);
            this.grpThongTinThuTien.Controls.Add(this.txtSettlementDay);
            this.grpThongTinThuTien.Controls.Add(this.txtPayday);
            this.grpThongTinThuTien.Controls.Add(this.btnHuyThanhToan);
            this.grpThongTinThuTien.Controls.Add(this.btnXuatHoaDon);
            this.grpThongTinThuTien.Controls.Add(this.btnThanhToan);
            this.grpThongTinThuTien.Controls.Add(this.btnLamMoi);
            this.grpThongTinThuTien.Controls.Add(this.txtRentStatus);
            this.grpThongTinThuTien.Controls.Add(this.txtContractId);
            this.grpThongTinThuTien.Controls.Add(this.txtRentId);
            this.grpThongTinThuTien.Controls.Add(this.label2);
            this.grpThongTinThuTien.Controls.Add(this.label1);
            this.grpThongTinThuTien.Controls.Add(this.label5);
            this.grpThongTinThuTien.Controls.Add(this.lblUsername);
            this.grpThongTinThuTien.Controls.Add(this.label3);
            this.grpThongTinThuTien.Controls.Add(this.lblMaTK);
            this.grpThongTinThuTien.Controls.Add(this.label4);
            this.grpThongTinThuTien.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinThuTien.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.grpThongTinThuTien.Location = new System.Drawing.Point(27, 96);
            this.grpThongTinThuTien.Name = "grpThongTinThuTien";
            this.grpThongTinThuTien.Radius = 6;
            this.grpThongTinThuTien.Size = new System.Drawing.Size(1010, 202);
            this.grpThongTinThuTien.TabIndex = 35;
            this.grpThongTinThuTien.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtCost
            // 
            this.txtCost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCost.Location = new System.Drawing.Point(776, 22);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(166, 31);
            this.txtCost.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtCost.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCost.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCost.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCost.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCost.StateCommon.Border.Rounding = 6;
            this.txtCost.StateCommon.Border.Width = 1;
            this.txtCost.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtCost.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtCost.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtCost.TabIndex = 42;
            this.txtCost.WordWrap = false;
            // 
            // txtMonth
            // 
            this.txtMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMonth.Location = new System.Drawing.Point(497, 102);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(166, 31);
            this.txtMonth.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtMonth.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMonth.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMonth.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMonth.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtMonth.StateCommon.Border.Rounding = 6;
            this.txtMonth.StateCommon.Border.Width = 1;
            this.txtMonth.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtMonth.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtMonth.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtMonth.TabIndex = 42;
            this.txtMonth.WordWrap = false;
            // 
            // txtSettlementDay
            // 
            this.txtSettlementDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSettlementDay.Location = new System.Drawing.Point(497, 62);
            this.txtSettlementDay.Margin = new System.Windows.Forms.Padding(2);
            this.txtSettlementDay.Name = "txtSettlementDay";
            this.txtSettlementDay.Size = new System.Drawing.Size(93, 31);
            this.txtSettlementDay.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtSettlementDay.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSettlementDay.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSettlementDay.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSettlementDay.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSettlementDay.StateCommon.Border.Rounding = 6;
            this.txtSettlementDay.StateCommon.Border.Width = 1;
            this.txtSettlementDay.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtSettlementDay.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSettlementDay.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtSettlementDay.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtSettlementDay.TabIndex = 42;
            this.txtSettlementDay.WordWrap = false;
            // 
            // txtPayday
            // 
            this.txtPayday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPayday.Location = new System.Drawing.Point(497, 22);
            this.txtPayday.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayday.Name = "txtPayday";
            this.txtPayday.Size = new System.Drawing.Size(93, 31);
            this.txtPayday.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtPayday.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPayday.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPayday.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPayday.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtPayday.StateCommon.Border.Rounding = 6;
            this.txtPayday.StateCommon.Border.Width = 1;
            this.txtPayday.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtPayday.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayday.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtPayday.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtPayday.TabIndex = 42;
            this.txtPayday.WordWrap = false;
            // 
            // btnHuyThanhToan
            // 
            this.btnHuyThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyThanhToan.Location = new System.Drawing.Point(318, 146);
            this.btnHuyThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyThanhToan.Name = "btnHuyThanhToan";
            this.btnHuyThanhToan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnHuyThanhToan.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnHuyThanhToan.OverrideDefault.Back.ColorAngle = 45F;
            this.btnHuyThanhToan.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnHuyThanhToan.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnHuyThanhToan.OverrideDefault.Border.ColorAngle = 45F;
            this.btnHuyThanhToan.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHuyThanhToan.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnHuyThanhToan.OverrideDefault.Border.Rounding = 6;
            this.btnHuyThanhToan.OverrideDefault.Border.Width = 1;
            this.btnHuyThanhToan.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnHuyThanhToan.Size = new System.Drawing.Size(125, 36);
            this.btnHuyThanhToan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnHuyThanhToan.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnHuyThanhToan.StateCommon.Back.ColorAngle = 45F;
            this.btnHuyThanhToan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnHuyThanhToan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnHuyThanhToan.StateCommon.Border.ColorAngle = 45F;
            this.btnHuyThanhToan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHuyThanhToan.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnHuyThanhToan.StateCommon.Border.Rounding = 6;
            this.btnHuyThanhToan.StateCommon.Border.Width = 1;
            this.btnHuyThanhToan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHuyThanhToan.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHuyThanhToan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThanhToan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnHuyThanhToan.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnHuyThanhToan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnHuyThanhToan.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnHuyThanhToan.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHuyThanhToan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnHuyThanhToan.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnHuyThanhToan.StatePressed.Back.ColorAngle = 135F;
            this.btnHuyThanhToan.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnHuyThanhToan.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnHuyThanhToan.StatePressed.Border.ColorAngle = 135F;
            this.btnHuyThanhToan.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHuyThanhToan.StatePressed.Border.Rounding = 6;
            this.btnHuyThanhToan.StatePressed.Border.Width = 1;
            this.btnHuyThanhToan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnHuyThanhToan.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnHuyThanhToan.StateTracking.Back.ColorAngle = 45F;
            this.btnHuyThanhToan.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnHuyThanhToan.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnHuyThanhToan.StateTracking.Border.ColorAngle = 45F;
            this.btnHuyThanhToan.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHuyThanhToan.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnHuyThanhToan.StateTracking.Border.Width = 1;
            this.btnHuyThanhToan.TabIndex = 9;
            this.btnHuyThanhToan.Values.Text = "Hủy thanh toán";
            this.btnHuyThanhToan.Click += new System.EventHandler(this.btnHuyThanhToan_Click);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(469, 146);
            this.btnXuatHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXuatHoaDon.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXuatHoaDon.OverrideDefault.Back.ColorAngle = 45F;
            this.btnXuatHoaDon.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXuatHoaDon.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXuatHoaDon.OverrideDefault.Border.ColorAngle = 45F;
            this.btnXuatHoaDon.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatHoaDon.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXuatHoaDon.OverrideDefault.Border.Rounding = 6;
            this.btnXuatHoaDon.OverrideDefault.Border.Width = 1;
            this.btnXuatHoaDon.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnXuatHoaDon.Size = new System.Drawing.Size(125, 36);
            this.btnXuatHoaDon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXuatHoaDon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXuatHoaDon.StateCommon.Back.ColorAngle = 45F;
            this.btnXuatHoaDon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXuatHoaDon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXuatHoaDon.StateCommon.Border.ColorAngle = 45F;
            this.btnXuatHoaDon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatHoaDon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXuatHoaDon.StateCommon.Border.Rounding = 6;
            this.btnXuatHoaDon.StateCommon.Border.Width = 1;
            this.btnXuatHoaDon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXuatHoaDon.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnXuatHoaDon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHoaDon.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnXuatHoaDon.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnXuatHoaDon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnXuatHoaDon.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnXuatHoaDon.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatHoaDon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnXuatHoaDon.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnXuatHoaDon.StatePressed.Back.ColorAngle = 135F;
            this.btnXuatHoaDon.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXuatHoaDon.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXuatHoaDon.StatePressed.Border.ColorAngle = 135F;
            this.btnXuatHoaDon.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatHoaDon.StatePressed.Border.Rounding = 6;
            this.btnXuatHoaDon.StatePressed.Border.Width = 1;
            this.btnXuatHoaDon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnXuatHoaDon.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnXuatHoaDon.StateTracking.Back.ColorAngle = 45F;
            this.btnXuatHoaDon.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXuatHoaDon.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnXuatHoaDon.StateTracking.Border.ColorAngle = 45F;
            this.btnXuatHoaDon.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatHoaDon.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXuatHoaDon.StateTracking.Border.Width = 1;
            this.btnXuatHoaDon.TabIndex = 10;
            this.btnXuatHoaDon.Values.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Location = new System.Drawing.Point(169, 146);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThanhToan.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThanhToan.OverrideDefault.Back.ColorAngle = 45F;
            this.btnThanhToan.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThanhToan.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThanhToan.OverrideDefault.Border.ColorAngle = 45F;
            this.btnThanhToan.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThanhToan.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThanhToan.OverrideDefault.Border.Rounding = 6;
            this.btnThanhToan.OverrideDefault.Border.Width = 1;
            this.btnThanhToan.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnThanhToan.Size = new System.Drawing.Size(125, 36);
            this.btnThanhToan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThanhToan.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThanhToan.StateCommon.Back.ColorAngle = 45F;
            this.btnThanhToan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThanhToan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThanhToan.StateCommon.Border.ColorAngle = 45F;
            this.btnThanhToan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThanhToan.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThanhToan.StateCommon.Border.Rounding = 6;
            this.btnThanhToan.StateCommon.Border.Width = 1;
            this.btnThanhToan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnThanhToan.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnThanhToan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnThanhToan.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnThanhToan.StatePressed.Back.ColorAngle = 135F;
            this.btnThanhToan.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThanhToan.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThanhToan.StatePressed.Border.ColorAngle = 135F;
            this.btnThanhToan.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThanhToan.StatePressed.Border.Rounding = 6;
            this.btnThanhToan.StatePressed.Border.Width = 1;
            this.btnThanhToan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnThanhToan.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnThanhToan.StateTracking.Back.ColorAngle = 45F;
            this.btnThanhToan.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThanhToan.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnThanhToan.StateTracking.Border.ColorAngle = 45F;
            this.btnThanhToan.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThanhToan.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThanhToan.StateTracking.Border.Width = 1;
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Values.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
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
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Values.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtRentStatus
            // 
            this.txtRentStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRentStatus.Location = new System.Drawing.Point(141, 102);
            this.txtRentStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtRentStatus.Name = "txtRentStatus";
            this.txtRentStatus.Size = new System.Drawing.Size(166, 31);
            this.txtRentStatus.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtRentStatus.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRentStatus.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRentStatus.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRentStatus.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtRentStatus.StateCommon.Border.Rounding = 6;
            this.txtRentStatus.StateCommon.Border.Width = 1;
            this.txtRentStatus.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtRentStatus.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentStatus.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtRentStatus.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtRentStatus.TabIndex = 3;
            this.txtRentStatus.WordWrap = false;
            // 
            // txtContractId
            // 
            this.txtContractId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtContractId.Location = new System.Drawing.Point(141, 62);
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
            this.txtContractId.TabIndex = 2;
            this.txtContractId.WordWrap = false;
            // 
            // txtRentId
            // 
            this.txtRentId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRentId.Location = new System.Drawing.Point(141, 22);
            this.txtRentId.Margin = new System.Windows.Forms.Padding(2);
            this.txtRentId.Name = "txtRentId";
            this.txtRentId.Size = new System.Drawing.Size(166, 31);
            this.txtRentId.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtRentId.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRentId.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRentId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRentId.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtRentId.StateCommon.Border.Rounding = 6;
            this.txtRentId.StateCommon.Border.Width = 1;
            this.txtRentId.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtRentId.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentId.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtRentId.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtRentId.TabIndex = 1;
            this.txtRentId.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Trạng thái hóa đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(718, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Giá tiền:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lblUsername.Location = new System.Drawing.Point(20, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 15);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Mã hợp đồng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(362, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tháng:";
            // 
            // lblMaTK
            // 
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblMaTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lblMaTK.Location = new System.Drawing.Point(362, 30);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(130, 15);
            this.lblMaTK.TabIndex = 16;
            this.lblMaTK.Text = "Ngày bắt đầu thu tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(362, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ngày thanh toán:";
            // 
            // dgvDSChiTietThuTien
            // 
            this.dgvDSChiTietThuTien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSChiTietThuTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSChiTietThuTien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSChiTietThuTien.ColumnHeadersHeight = 36;
            this.dgvDSChiTietThuTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentId,
            this.ContractId,
            this.Cost,
            this.Month,
            this.Payday,
            this.SettlementDay,
            this.RentStatusTitle});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSChiTietThuTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSChiTietThuTien.Location = new System.Drawing.Point(27, 325);
            this.dgvDSChiTietThuTien.Name = "dgvDSChiTietThuTien";
            this.dgvDSChiTietThuTien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDSChiTietThuTien.RowHeadersWidth = 51;
            this.dgvDSChiTietThuTien.RowTemplate.Height = 36;
            this.dgvDSChiTietThuTien.Size = new System.Drawing.Size(1010, 378);
            this.dgvDSChiTietThuTien.TabIndex = 36;
            this.dgvDSChiTietThuTien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDSChiTietThuTien_MouseClick);
            // 
            // RentId
            // 
            this.RentId.DataPropertyName = "RentId";
            this.RentId.HeaderText = "Mã hóa đơn";
            this.RentId.MinimumWidth = 6;
            this.RentId.Name = "RentId";
            this.RentId.ReadOnly = true;
            this.RentId.Width = 120;
            // 
            // ContractId
            // 
            this.ContractId.DataPropertyName = "ContractId";
            this.ContractId.HeaderText = "Mã hợp đồng";
            this.ContractId.MinimumWidth = 6;
            this.ContractId.Name = "ContractId";
            this.ContractId.ReadOnly = true;
            this.ContractId.Width = 130;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Giá tiền (VND)";
            this.Cost.Name = "Cost";
            this.Cost.Width = 140;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Tháng";
            this.Month.Name = "Month";
            this.Month.Width = 80;
            // 
            // Payday
            // 
            this.Payday.DataPropertyName = "Payday";
            this.Payday.HeaderText = "Ngày bắt đầu thu tiền";
            this.Payday.MinimumWidth = 6;
            this.Payday.Name = "Payday";
            this.Payday.ReadOnly = true;
            this.Payday.Width = 170;
            // 
            // SettlementDay
            // 
            this.SettlementDay.DataPropertyName = "SettlementDay";
            this.SettlementDay.HeaderText = "Ngày thanh toán";
            this.SettlementDay.MinimumWidth = 6;
            this.SettlementDay.Name = "SettlementDay";
            this.SettlementDay.ReadOnly = true;
            this.SettlementDay.Width = 150;
            // 
            // RentStatusTitle
            // 
            this.RentStatusTitle.DataPropertyName = "RentStatusTitle";
            this.RentStatusTitle.HeaderText = "Trạng thái hóa đơn";
            this.RentStatusTitle.Name = "RentStatusTitle";
            this.RentStatusTitle.ReadOnly = true;
            this.RentStatusTitle.Width = 160;
            // 
            // QuanLyThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 729);
            this.Controls.Add(this.dgvDSChiTietThuTien);
            this.Controls.Add(this.grpThongTinThuTien);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyThuTien";
            this.Text = "QuanLyThuTien";
            this.Load += new System.EventHandler(this.QuanLyThuTien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionCombobox)).EndInit();
            this.grpThongTinThuTien.ResumeLayout(false);
            this.grpThongTinThuTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChiTietThuTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private Guna.UI.WinForms.GunaGradient2Panel grp_TimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox optionCombobox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimKiem;
        private Guna.UI.WinForms.GunaGroupBox grpThongTinThuTien;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSettlementDay;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPayday;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHuyThanhToan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXuatHoaDon;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThanhToan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLamMoi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRentStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtContractId;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblMaTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDSChiTietThuTien;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCost;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payday;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettlementDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentStatusTitle;
    }
}