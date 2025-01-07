namespace GUI.FormMaster
{
    partial class QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhanVien));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.dtpNamSinh = new System.Windows.Forms.DateTimePicker();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl = new System.Windows.Forms.Panel();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btn_TamNgung = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grbThongTinNguoiDung = new System.Windows.Forms.GroupBox();
            this.dgvThongTinNguoiDung = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.cbTKTrangThai = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.lblTKTrangThai = new System.Windows.Forms.Label();
            this.txtTKTenNV = new System.Windows.Forms.TextBox();
            this.lblTKTenNV = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbThongTinChiTiet.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grbThongTinNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNguoiDung)).BeginInit();
            this.panel4.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 58);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(296, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grbThongTinChiTiet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(777, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 528);
            this.panel2.TabIndex = 3;
            // 
            // grbThongTinChiTiet
            // 
            this.grbThongTinChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbThongTinChiTiet.Controls.Add(this.txtPass);
            this.grbThongTinChiTiet.Controls.Add(this.lblPass);
            this.grbThongTinChiTiet.Controls.Add(this.btn_Huy);
            this.grbThongTinChiTiet.Controls.Add(this.btn_Luu);
            this.grbThongTinChiTiet.Controls.Add(this.cbTrangThai);
            this.grbThongTinChiTiet.Controls.Add(this.dtpNamSinh);
            this.grbThongTinChiTiet.Controls.Add(this.lblNamSinh);
            this.grbThongTinChiTiet.Controls.Add(this.txtQueQuan);
            this.grbThongTinChiTiet.Controls.Add(this.lblQueQuan);
            this.grbThongTinChiTiet.Controls.Add(this.lblTrangThai);
            this.grbThongTinChiTiet.Controls.Add(this.txtCCCD);
            this.grbThongTinChiTiet.Controls.Add(this.lblCCCD);
            this.grbThongTinChiTiet.Controls.Add(this.txtSoDienThoai);
            this.grbThongTinChiTiet.Controls.Add(this.lblSoDienThoai);
            this.grbThongTinChiTiet.Controls.Add(this.txtTenNV);
            this.grbThongTinChiTiet.Controls.Add(this.lblTenNV);
            this.grbThongTinChiTiet.Controls.Add(this.txtMaNV);
            this.grbThongTinChiTiet.Controls.Add(this.lblMaNV);
            this.grbThongTinChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTinChiTiet.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinChiTiet.Name = "grbThongTinChiTiet";
            this.grbThongTinChiTiet.Size = new System.Drawing.Size(288, 528);
            this.grbThongTinChiTiet.TabIndex = 0;
            this.grbThongTinChiTiet.TabStop = false;
            this.grbThongTinChiTiet.Text = "Thông Tin Chi Tiết";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(152, 95);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(124, 23);
            this.txtPass.TabIndex = 1;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(15, 97);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(47, 17);
            this.lblPass.TabIndex = 19;
            this.lblPass.Text = "Pass :";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huy.Image = global::GUI.Properties.Resources.multiply__1_;
            this.btn_Huy.Location = new System.Drawing.Point(176, 440);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(84, 51);
            this.btn_Huy.TabIndex = 9;
            this.btn_Huy.Text = "&Hủy";
            this.btn_Huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Luu.Image = global::GUI.Properties.Resources.diskette;
            this.btn_Luu.Location = new System.Drawing.Point(43, 440);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(82, 51);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "&Lưu";
            this.btn_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Hoạt Động",
            "Tạm Ngưng",
            "Đã Nghỉ",
            "Không Xác Định"});
            this.cbTrangThai.Location = new System.Drawing.Point(152, 371);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(124, 24);
            this.cbTrangThai.TabIndex = 7;
            // 
            // dtpNamSinh
            // 
            this.dtpNamSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNamSinh.Location = new System.Drawing.Point(152, 238);
            this.dtpNamSinh.Name = "dtpNamSinh";
            this.dtpNamSinh.Size = new System.Drawing.Size(124, 23);
            this.dtpNamSinh.TabIndex = 4;
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(15, 241);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(81, 17);
            this.lblNamSinh.TabIndex = 14;
            this.lblNamSinh.Text = "Năm Sinh : ";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(152, 329);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(124, 23);
            this.txtQueQuan.TabIndex = 6;
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(15, 332);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(86, 17);
            this.lblQueQuan.TabIndex = 10;
            this.lblQueQuan.Text = "Quê Quán : ";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(15, 373);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(86, 17);
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Trạng Thái :";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(152, 188);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(124, 23);
            this.txtCCCD.TabIndex = 3;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(3, 191);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(148, 17);
            this.lblCCCD.TabIndex = 6;
            this.lblCCCD.Text = "Căn Cước Công Dân : ";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(152, 289);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(124, 23);
            this.txtSoDienThoai.TabIndex = 5;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(6, 290);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(110, 17);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số Điện Thoại : ";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(152, 139);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(124, 23);
            this.txtTenNV.TabIndex = 2;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(15, 141);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(109, 17);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Tên Nhân viên :";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(152, 47);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(124, 23);
            this.txtMaNV.TabIndex = 0;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(15, 47);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(109, 17);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã Nhân Viên : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 528);
            this.panel1.TabIndex = 2;
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnl.Controls.Add(this.grbChucNang);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 439);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(777, 89);
            this.pnl.TabIndex = 3;
            // 
            // grbChucNang
            // 
            this.grbChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbChucNang.Controls.Add(this.btn_TamNgung);
            this.grbChucNang.Controls.Add(this.btn_Thoat);
            this.grbChucNang.Controls.Add(this.btn_Xoa);
            this.grbChucNang.Controls.Add(this.btn_Sua);
            this.grbChucNang.Controls.Add(this.btn_Them);
            this.grbChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChucNang.Location = new System.Drawing.Point(0, 0);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(777, 89);
            this.grbChucNang.TabIndex = 0;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng";
            // 
            // btn_TamNgung
            // 
            this.btn_TamNgung.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_TamNgung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TamNgung.Image = global::GUI.Properties.Resources.delete;
            this.btn_TamNgung.Location = new System.Drawing.Point(480, 24);
            this.btn_TamNgung.Name = "btn_TamNgung";
            this.btn_TamNgung.Size = new System.Drawing.Size(103, 52);
            this.btn_TamNgung.TabIndex = 3;
            this.btn_TamNgung.Text = "Tạm &Ngưng";
            this.btn_TamNgung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TamNgung.UseVisualStyleBackColor = false;
            this.btn_TamNgung.Click += new System.EventHandler(this.btn_TamNgung_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Image = global::GUI.Properties.Resources.log_out;
            this.btn_Thoat.Location = new System.Drawing.Point(647, 24);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(86, 52);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "&Exit";
            this.btn_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Image = global::GUI.Properties.Resources.delete;
            this.btn_Xoa.Location = new System.Drawing.Point(343, 24);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 52);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Image = global::GUI.Properties.Resources.edit;
            this.btn_Sua.Location = new System.Drawing.Point(196, 24);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(91, 52);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "&Sửa";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.Image = global::GUI.Properties.Resources.user;
            this.btn_Them.Location = new System.Drawing.Point(44, 24);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 52);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "&Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grbThongTinNguoiDung);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(777, 330);
            this.panel5.TabIndex = 2;
            // 
            // grbThongTinNguoiDung
            // 
            this.grbThongTinNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbThongTinNguoiDung.Controls.Add(this.dgvThongTinNguoiDung);
            this.grbThongTinNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTinNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinNguoiDung.Name = "grbThongTinNguoiDung";
            this.grbThongTinNguoiDung.Size = new System.Drawing.Size(777, 330);
            this.grbThongTinNguoiDung.TabIndex = 0;
            this.grbThongTinNguoiDung.TabStop = false;
            this.grbThongTinNguoiDung.Text = "Thông Tin Người Dùng";
            // 
            // dgvThongTinNguoiDung
            // 
            this.dgvThongTinNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Pass,
            this.TenNV,
            this.NamSinh,
            this.CCCD,
            this.SoDienThoai,
            this.QueQuan,
            this.TrangThai});
            this.dgvThongTinNguoiDung.Cursor = System.Windows.Forms.Cursors.No;
            this.dgvThongTinNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTinNguoiDung.Location = new System.Drawing.Point(3, 19);
            this.dgvThongTinNguoiDung.Name = "dgvThongTinNguoiDung";
            this.dgvThongTinNguoiDung.ReadOnly = true;
            this.dgvThongTinNguoiDung.Size = new System.Drawing.Size(771, 308);
            this.dgvThongTinNguoiDung.TabIndex = 0;
            this.dgvThongTinNguoiDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinNguoiDung_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // Pass
            // 
            this.Pass.DataPropertyName = "Pass";
            this.Pass.HeaderText = "Pass";
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm Sinh";
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "Căn Cước Công Dân";
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.grbTimKiem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(777, 51);
            this.panel4.TabIndex = 1;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbTimKiem.Controls.Add(this.cbTKTrangThai);
            this.grbTimKiem.Controls.Add(this.btnReset);
            this.grbTimKiem.Controls.Add(this.btn_TimKiem);
            this.grbTimKiem.Controls.Add(this.lblTKTrangThai);
            this.grbTimKiem.Controls.Add(this.txtTKTenNV);
            this.grbTimKiem.Controls.Add(this.lblTKTenNV);
            this.grbTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTimKiem.Location = new System.Drawing.Point(0, 0);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(777, 51);
            this.grbTimKiem.TabIndex = 0;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm Kiếm";
            // 
            // cbTKTrangThai
            // 
            this.cbTKTrangThai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTKTrangThai.FormattingEnabled = true;
            this.cbTKTrangThai.Items.AddRange(new object[] {
            "Hoạt Động",
            "Tạm Ngưng",
            "Đã Nghỉ",
            "Không Xác Định"});
            this.cbTKTrangThai.Location = new System.Drawing.Point(410, 19);
            this.cbTKTrangThai.Name = "cbTKTrangThai";
            this.cbTKTrangThai.Size = new System.Drawing.Size(128, 24);
            this.cbTKTrangThai.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Image = global::GUI.Properties.Resources.reset;
            this.btnReset.Location = new System.Drawing.Point(701, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(47, 37);
            this.btnReset.TabIndex = 3;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.search;
            this.btn_TimKiem.Location = new System.Drawing.Point(580, 9);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(52, 42);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // lblTKTrangThai
            // 
            this.lblTKTrangThai.AutoSize = true;
            this.lblTKTrangThai.Location = new System.Drawing.Point(315, 22);
            this.lblTKTrangThai.Name = "lblTKTrangThai";
            this.lblTKTrangThai.Size = new System.Drawing.Size(86, 17);
            this.lblTKTrangThai.TabIndex = 8;
            this.lblTKTrangThai.Text = "Trạng Thái :";
            // 
            // txtTKTenNV
            // 
            this.txtTKTenNV.Location = new System.Drawing.Point(147, 19);
            this.txtTKTenNV.Name = "txtTKTenNV";
            this.txtTKTenNV.Size = new System.Drawing.Size(133, 23);
            this.txtTKTenNV.TabIndex = 0;
            // 
            // lblTKTenNV
            // 
            this.lblTKTenNV.AutoSize = true;
            this.lblTKTenNV.Location = new System.Drawing.Point(29, 20);
            this.lblTKTenNV.Name = "lblTKTenNV";
            this.lblTKTenNV.Size = new System.Drawing.Size(111, 17);
            this.lblTKTenNV.TabIndex = 6;
            this.lblTKTenNV.Text = "Tên Nhân Viên :";
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1065, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1081, 567);
            this.Name = "QuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.grbThongTinChiTiet.ResumeLayout(false);
            this.grbThongTinChiTiet.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.grbThongTinNguoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNguoiDung)).EndInit();
            this.panel4.ResumeLayout(false);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbThongTinChiTiet;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNamSinh;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox grbThongTinNguoiDung;
        private System.Windows.Forms.DataGridView dgvThongTinNguoiDung;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btn_TamNgung;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label lblTKTrangThai;
        private System.Windows.Forms.TextBox txtTKTenNV;
        private System.Windows.Forms.Label lblTKTenNV;
        private System.Windows.Forms.ComboBox cbTKTrangThai;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}