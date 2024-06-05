namespace LTUD_DoAn
{
    partial class frmNhanKhau
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
            this.gbNhanKhau = new System.Windows.Forms.GroupBox();
            this.tbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCCCDID = new System.Windows.Forms.TextBox();
            this.txtMaHoID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNhanKhau = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdCCCD = new System.Windows.Forms.RadioButton();
            this.gbNhanKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNhanKhau
            // 
            this.gbNhanKhau.Controls.Add(this.tbNu);
            this.gbNhanKhau.Controls.Add(this.rbNam);
            this.gbNhanKhau.Controls.Add(this.dtpNgaySinh);
            this.gbNhanKhau.Controls.Add(this.txtHoTen);
            this.gbNhanKhau.Controls.Add(this.txtCCCDID);
            this.gbNhanKhau.Controls.Add(this.txtMaHoID);
            this.gbNhanKhau.Controls.Add(this.label6);
            this.gbNhanKhau.Controls.Add(this.label4);
            this.gbNhanKhau.Controls.Add(this.label3);
            this.gbNhanKhau.Controls.Add(this.label2);
            this.gbNhanKhau.Controls.Add(this.label1);
            this.gbNhanKhau.Location = new System.Drawing.Point(147, 12);
            this.gbNhanKhau.Name = "gbNhanKhau";
            this.gbNhanKhau.Size = new System.Drawing.Size(698, 222);
            this.gbNhanKhau.TabIndex = 0;
            this.gbNhanKhau.TabStop = false;
            this.gbNhanKhau.Text = "Nhân khẩu";
            // 
            // tbNu
            // 
            this.tbNu.AutoSize = true;
            this.tbNu.Location = new System.Drawing.Point(253, 167);
            this.tbNu.Name = "tbNu";
            this.tbNu.Size = new System.Drawing.Size(51, 23);
            this.tbNu.TabIndex = 10;
            this.tbNu.TabStop = true;
            this.tbNu.Text = "Nữ";
            this.tbNu.UseVisualStyleBackColor = true;
            this.tbNu.CheckedChanged += new System.EventHandler(this.tbNu_CheckedChanged);
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(169, 167);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(62, 23);
            this.rbNam.TabIndex = 9;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(476, 105);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(188, 27);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(471, 45);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(193, 27);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtCCCDID
            // 
            this.txtCCCDID.Location = new System.Drawing.Point(137, 45);
            this.txtCCCDID.Name = "txtCCCDID";
            this.txtCCCDID.Size = new System.Drawing.Size(193, 27);
            this.txtCCCDID.TabIndex = 1;
            // 
            // txtMaHoID
            // 
            this.txtMaHoID.Location = new System.Drawing.Point(137, 106);
            this.txtMaHoID.Name = "txtMaHoID";
            this.txtMaHoID.Size = new System.Drawing.Size(193, 27);
            this.txtMaHoID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "CCCD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã hộ ID";
            // 
            // dgvNhanKhau
            // 
            this.dgvNhanKhau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanKhau.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhanKhau.Location = new System.Drawing.Point(0, 399);
            this.dgvNhanKhau.Name = "dgvNhanKhau";
            this.dgvNhanKhau.ReadOnly = true;
            this.dgvNhanKhau.RowHeadersWidth = 51;
            this.dgvNhanKhau.RowTemplate.Height = 24;
            this.dgvNhanKhau.Size = new System.Drawing.Size(993, 173);
            this.dgvNhanKhau.TabIndex = 6;
            this.dgvNhanKhau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanKhau_CellClick);
            this.dgvNhanKhau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanKhau_CellContentClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(556, 256);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(360, 256);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(169, 256);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 26);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(22, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(374, 27);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTen);
            this.groupBox1.Controls.Add(this.rdCCCD);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(147, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Location = new System.Drawing.Point(588, 27);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(89, 23);
            this.rdTen.TabIndex = 2;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Theo tên";
            this.rdTen.UseVisualStyleBackColor = true;
            this.rdTen.CheckedChanged += new System.EventHandler(this.rdTen_CheckedChanged);
            // 
            // rdCCCD
            // 
            this.rdCCCD.AutoSize = true;
            this.rdCCCD.Location = new System.Drawing.Point(449, 27);
            this.rdCCCD.Name = "rdCCCD";
            this.rdCCCD.Size = new System.Drawing.Size(113, 23);
            this.rdCCCD.TabIndex = 1;
            this.rdCCCD.TabStop = true;
            this.rdCCCD.Text = "Theo CCCD";
            this.rdCCCD.UseVisualStyleBackColor = true;
            this.rdCCCD.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // frmNhanKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(993, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNhanKhau);
            this.Controls.Add(this.gbNhanKhau);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhanKhau";
            this.Text = "frmNhanKhau";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanKhau_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanKhau_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNhanKhau_KeyDown);
            this.gbNhanKhau.ResumeLayout(false);
            this.gbNhanKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNhanKhau;
        private System.Windows.Forms.DataGridView dgvNhanKhau;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCDID;
        private System.Windows.Forms.TextBox txtMaHoID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton tbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.RadioButton rdCCCD;
    }
}