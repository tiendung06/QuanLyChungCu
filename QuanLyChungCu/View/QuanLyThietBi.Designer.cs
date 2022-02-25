namespace QuanLyChungCu.View
{
    partial class QuanLyThietBi
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.errRoom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errId_Type = new System.Windows.Forms.ErrorProvider(this.components);
            this.errId_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errName_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errQty_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            this.errPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errFunction_Group = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvDSThietBi = new System.Windows.Forms.DataGridView();
            this.Id_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Function_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errStatus_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.cbbLoaiTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtName_Device = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtStatus = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtId_Type = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtRoom = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtFunction_Device = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtId_Device = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnThemTK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnXoa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCapNhat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLamMoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.errRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQty_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFunction_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errStatus_Device)).BeginInit();
            this.panel1.SuspendLayout();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiTimKiem)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(343, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Trạng Thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(343, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Mã Loại TB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(343, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Thuộc Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(343, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Chức Năng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Đơn Gía";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã Thiết Bị";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lblUsername.Location = new System.Drawing.Point(30, 95);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 15);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Tên Thiết Bị";
            // 
            // errRoom
            // 
            this.errRoom.ContainerControl = this;
            // 
            // errId_Type
            // 
            this.errId_Type.ContainerControl = this;
            // 
            // errId_Device
            // 
            this.errId_Device.ContainerControl = this;
            // 
            // errName_Device
            // 
            this.errName_Device.ContainerControl = this;
            // 
            // errQty_Device
            // 
            this.errQty_Device.ContainerControl = this;
            // 
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_QLTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(20, 13);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(155, 25);
            this.lbl_QLTaiKhoan.TabIndex = 23;
            this.lbl_QLTaiKhoan.Text = "Quản lý thiết bị";
            // 
            // errPrice
            // 
            this.errPrice.ContainerControl = this;
            // 
            // errFunction_Group
            // 
            this.errFunction_Group.ContainerControl = this;
            // 
            // dgvDSThietBi
            // 
            this.dgvDSThietBi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSThietBi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSThietBi.ColumnHeadersHeight = 36;
            this.dgvDSThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Device,
            this.Name_Device,
            this.Price,
            this.Function_Device,
            this.Room,
            this.Id_Type,
            this.Status_Device});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSThietBi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSThietBi.Location = new System.Drawing.Point(27, 325);
            this.dgvDSThietBi.Name = "dgvDSThietBi";
            this.dgvDSThietBi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDSThietBi.RowHeadersWidth = 51;
            this.dgvDSThietBi.RowTemplate.Height = 36;
            this.dgvDSThietBi.Size = new System.Drawing.Size(1010, 378);
            this.dgvDSThietBi.TabIndex = 27;
            this.dgvDSThietBi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDSThietBi_MouseClick);
            // 
            // Id_Device
            // 
            this.Id_Device.DataPropertyName = "Id_Device";
            this.Id_Device.HeaderText = "Mã thiết bị";
            this.Id_Device.MinimumWidth = 6;
            this.Id_Device.Name = "Id_Device";
            this.Id_Device.Width = 140;
            // 
            // Name_Device
            // 
            this.Name_Device.DataPropertyName = "Name_Device";
            this.Name_Device.HeaderText = "Tên thiết bị";
            this.Name_Device.MinimumWidth = 6;
            this.Name_Device.Name = "Name_Device";
            this.Name_Device.ReadOnly = true;
            this.Name_Device.Width = 140;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Đơn giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 110;
            // 
            // Function_Device
            // 
            this.Function_Device.DataPropertyName = "Function_Device";
            this.Function_Device.HeaderText = "Chức năng";
            this.Function_Device.MinimumWidth = 6;
            this.Function_Device.Name = "Function_Device";
            this.Function_Device.Width = 120;
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Thuộc phòng";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.Width = 135;
            // 
            // Id_Type
            // 
            this.Id_Type.DataPropertyName = "Id_Type";
            this.Id_Type.HeaderText = "Mã loại thiết bị";
            this.Id_Type.MinimumWidth = 6;
            this.Id_Type.Name = "Id_Type";
            this.Id_Type.Width = 135;
            // 
            // Status_Device
            // 
            this.Status_Device.DataPropertyName = "Status_Device";
            this.Status_Device.HeaderText = "Trạng thái";
            this.Status_Device.MinimumWidth = 6;
            this.Status_Device.Name = "Status_Device";
            this.Status_Device.Width = 120;
            // 
            // errStatus_Device
            // 
            this.errStatus_Device.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.gunaGradient2Panel1);
            this.panel1.Controls.Add(this.lbl_QLTaiKhoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 70);
            this.panel1.TabIndex = 28;
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.cbbLoaiTimKiem);
            this.gunaGradient2Panel1.Controls.Add(this.btnTimKiem);
            this.gunaGradient2Panel1.Controls.Add(this.txtTimKiem);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(414, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 5;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(650, 70);
            this.gunaGradient2Panel1.TabIndex = 24;
            // 
            // cbbLoaiTimKiem
            // 
            this.cbbLoaiTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbLoaiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiTimKiem.DropDownWidth = 143;
            this.cbbLoaiTimKiem.Items.AddRange(new object[] {
            "Mã người dùng",
            "Tên người dùng"});
            this.cbbLoaiTimKiem.Location = new System.Drawing.Point(95, 23);
            this.cbbLoaiTimKiem.Name = "cbbLoaiTimKiem";
            this.cbbLoaiTimKiem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbbLoaiTimKiem.Size = new System.Drawing.Size(147, 25);
            this.cbbLoaiTimKiem.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.cbbLoaiTimKiem.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbbLoaiTimKiem.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbbLoaiTimKiem.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbbLoaiTimKiem.StateCommon.ComboBox.Border.Rounding = 6;
            this.cbbLoaiTimKiem.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.cbbLoaiTimKiem.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiTimKiem.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.cbbLoaiTimKiem.TabIndex = 1;
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
            this.txtTimKiem.Size = new System.Drawing.Size(260, 32);
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
            this.txtTimKiem.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.WordWrap = false;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.gunaGroupBox1.Controls.Add(this.txtPrice);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.txtName_Device);
            this.gunaGroupBox1.Controls.Add(this.txtStatus);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.txtId_Type);
            this.gunaGroupBox1.Controls.Add(this.txtRoom);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.txtFunction_Device);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.txtId_Device);
            this.gunaGroupBox1.Controls.Add(this.btnThemTK);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.lblUsername);
            this.gunaGroupBox1.Controls.Add(this.btnXoa);
            this.gunaGroupBox1.Controls.Add(this.btnCapNhat);
            this.gunaGroupBox1.Controls.Add(this.btnLamMoi);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(27, 96);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 6;
            this.gunaGroupBox1.Size = new System.Drawing.Size(957, 202);
            this.gunaGroupBox1.TabIndex = 29;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPrice.Location = new System.Drawing.Point(123, 132);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(166, 31);
            this.txtPrice.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtPrice.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrice.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrice.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtPrice.StateCommon.Border.Rounding = 6;
            this.txtPrice.StateCommon.Border.Width = 1;
            this.txtPrice.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtPrice.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtPrice.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtPrice.TabIndex = 6;
            this.txtPrice.WordWrap = false;
            // 
            // txtName_Device
            // 
            this.txtName_Device.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtName_Device.Location = new System.Drawing.Point(123, 87);
            this.txtName_Device.Margin = new System.Windows.Forms.Padding(2);
            this.txtName_Device.Name = "txtName_Device";
            this.txtName_Device.Size = new System.Drawing.Size(166, 31);
            this.txtName_Device.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtName_Device.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName_Device.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName_Device.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName_Device.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtName_Device.StateCommon.Border.Rounding = 6;
            this.txtName_Device.StateCommon.Border.Width = 1;
            this.txtName_Device.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtName_Device.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Device.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtName_Device.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtName_Device.TabIndex = 5;
            this.txtName_Device.WordWrap = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtStatus.Location = new System.Drawing.Point(456, 149);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(166, 31);
            this.txtStatus.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtStatus.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStatus.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStatus.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtStatus.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtStatus.StateCommon.Border.Rounding = 6;
            this.txtStatus.StateCommon.Border.Width = 1;
            this.txtStatus.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtStatus.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtStatus.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtStatus.TabIndex = 4;
            this.txtStatus.WordWrap = false;
            // 
            // txtId_Type
            // 
            this.txtId_Type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtId_Type.Location = new System.Drawing.Point(456, 107);
            this.txtId_Type.Margin = new System.Windows.Forms.Padding(2);
            this.txtId_Type.Name = "txtId_Type";
            this.txtId_Type.Size = new System.Drawing.Size(166, 31);
            this.txtId_Type.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtId_Type.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtId_Type.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtId_Type.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtId_Type.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtId_Type.StateCommon.Border.Rounding = 6;
            this.txtId_Type.StateCommon.Border.Width = 1;
            this.txtId_Type.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtId_Type.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Type.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtId_Type.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtId_Type.TabIndex = 4;
            this.txtId_Type.WordWrap = false;
            // 
            // txtRoom
            // 
            this.txtRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRoom.Location = new System.Drawing.Point(456, 64);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(166, 31);
            this.txtRoom.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtRoom.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRoom.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRoom.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRoom.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtRoom.StateCommon.Border.Rounding = 6;
            this.txtRoom.StateCommon.Border.Width = 1;
            this.txtRoom.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtRoom.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtRoom.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtRoom.TabIndex = 4;
            this.txtRoom.WordWrap = false;
            // 
            // txtFunction_Device
            // 
            this.txtFunction_Device.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFunction_Device.Location = new System.Drawing.Point(456, 23);
            this.txtFunction_Device.Margin = new System.Windows.Forms.Padding(2);
            this.txtFunction_Device.Name = "txtFunction_Device";
            this.txtFunction_Device.Size = new System.Drawing.Size(166, 31);
            this.txtFunction_Device.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtFunction_Device.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFunction_Device.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFunction_Device.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFunction_Device.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtFunction_Device.StateCommon.Border.Rounding = 6;
            this.txtFunction_Device.StateCommon.Border.Width = 1;
            this.txtFunction_Device.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtFunction_Device.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFunction_Device.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtFunction_Device.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtFunction_Device.TabIndex = 4;
            this.txtFunction_Device.WordWrap = false;
            // 
            // txtId_Device
            // 
            this.txtId_Device.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtId_Device.Location = new System.Drawing.Point(123, 42);
            this.txtId_Device.Margin = new System.Windows.Forms.Padding(2);
            this.txtId_Device.Name = "txtId_Device";
            this.txtId_Device.Size = new System.Drawing.Size(166, 31);
            this.txtId_Device.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.txtId_Device.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtId_Device.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtId_Device.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtId_Device.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtId_Device.StateCommon.Border.Rounding = 6;
            this.txtId_Device.StateCommon.Border.Width = 1;
            this.txtId_Device.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.txtId_Device.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Device.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtId_Device.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtId_Device.TabIndex = 4;
            this.txtId_Device.WordWrap = false;
            // 
            // btnThemTK
            // 
            this.btnThemTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemTK.Location = new System.Drawing.Point(799, 68);
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
            this.btnThemTK.Values.Text = "Thêm thiết bị";
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(654, 68);
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
            this.btnCapNhat.Location = new System.Drawing.Point(799, 23);
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
            this.btnCapNhat.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnCapNhat.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnCapNhat.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnCapNhat.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btnCapNhat.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
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
            this.btnLamMoi.Location = new System.Drawing.Point(654, 23);
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
            // QuanLyThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 729);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDSThietBi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyThietBi";
            this.Text = "QuanLyThietBi";
            this.Load += new System.EventHandler(this.QuanLyThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQty_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFunction_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errStatus_Device)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiTimKiem)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ErrorProvider errRoom;
        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private System.Windows.Forms.ErrorProvider errId_Type;
        private System.Windows.Forms.ErrorProvider errId_Device;
        private System.Windows.Forms.ErrorProvider errName_Device;
        private System.Windows.Forms.ErrorProvider errQty_Device;
        private System.Windows.Forms.ErrorProvider errPrice;
        private System.Windows.Forms.ErrorProvider errFunction_Group;
        private System.Windows.Forms.DataGridView dgvDSThietBi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errStatus_Device;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbLoaiTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimKiem;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtName_Device;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtId_Device;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThemTK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXoa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCapNhat;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLamMoi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtId_Type;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRoom;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFunction_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Function_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Device;
    }
}