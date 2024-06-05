namespace LTUD_DoAn
{
    partial class frmPhuong
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbPhuong = new System.Windows.Forms.GroupBox();
            this.txtMaPhuongID = new System.Windows.Forms.TextBox();
            this.txtTenPhuong = new System.Windows.Forms.TextBox();
            this.txtMaQuanID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhuong = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnlammoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbten = new System.Windows.Forms.RadioButton();
            this.rbma = new System.Windows.Forms.RadioButton();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.gbPhuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(343, 234);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(157, 234);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 26);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbPhuong
            // 
            this.gbPhuong.Controls.Add(this.txtMaPhuongID);
            this.gbPhuong.Controls.Add(this.txtTenPhuong);
            this.gbPhuong.Controls.Add(this.txtMaQuanID);
            this.gbPhuong.Controls.Add(this.label6);
            this.gbPhuong.Controls.Add(this.label4);
            this.gbPhuong.Controls.Add(this.label1);
            this.gbPhuong.Location = new System.Drawing.Point(110, 24);
            this.gbPhuong.Name = "gbPhuong";
            this.gbPhuong.Size = new System.Drawing.Size(698, 194);
            this.gbPhuong.TabIndex = 0;
            this.gbPhuong.TabStop = false;
            this.gbPhuong.Text = "Phường";
            // 
            // txtMaPhuongID
            // 
            this.txtMaPhuongID.Location = new System.Drawing.Point(138, 57);
            this.txtMaPhuongID.Name = "txtMaPhuongID";
            this.txtMaPhuongID.Size = new System.Drawing.Size(193, 27);
            this.txtMaPhuongID.TabIndex = 1;
            this.txtMaPhuongID.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtTenPhuong
            // 
            this.txtTenPhuong.Location = new System.Drawing.Point(476, 57);
            this.txtTenPhuong.Name = "txtTenPhuong";
            this.txtTenPhuong.Size = new System.Drawing.Size(193, 27);
            this.txtTenPhuong.TabIndex = 3;
            this.txtTenPhuong.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtMaQuanID
            // 
            this.txtMaQuanID.Location = new System.Drawing.Point(138, 125);
            this.txtMaQuanID.Name = "txtMaQuanID";
            this.txtMaQuanID.Size = new System.Drawing.Size(193, 27);
            this.txtMaQuanID.TabIndex = 5;
            this.txtMaQuanID.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã phường";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên phường";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã quận";
            // 
            // dgvPhuong
            // 
            this.dgvPhuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhuong.Location = new System.Drawing.Point(0, 372);
            this.dgvPhuong.Name = "dgvPhuong";
            this.dgvPhuong.RowHeadersWidth = 51;
            this.dgvPhuong.RowTemplate.Height = 24;
            this.dgvPhuong.Size = new System.Drawing.Size(926, 183);
            this.dgvPhuong.TabIndex = 6;
            this.dgvPhuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuong_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(694, 234);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(85, 26);
            this.btnlammoi.TabIndex = 4;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbten);
            this.groupBox1.Controls.Add(this.rbma);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Location = new System.Drawing.Point(110, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rbten
            // 
            this.rbten.AutoSize = true;
            this.rbten.Location = new System.Drawing.Point(551, 37);
            this.rbten.Name = "rbten";
            this.rbten.Size = new System.Drawing.Size(89, 23);
            this.rbten.TabIndex = 2;
            this.rbten.TabStop = true;
            this.rbten.Text = "Theo tên";
            this.rbten.UseVisualStyleBackColor = true;
            this.rbten.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbma
            // 
            this.rbma.AutoSize = true;
            this.rbma.Location = new System.Drawing.Point(394, 37);
            this.rbma.Name = "rbma";
            this.rbma.Size = new System.Drawing.Size(88, 23);
            this.rbma.TabIndex = 1;
            this.rbma.TabStop = true;
            this.rbma.Text = "Theo mã";
            this.rbma.UseVisualStyleBackColor = true;
            this.rbma.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(30, 36);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(323, 27);
            this.txttimkiem.TabIndex = 0;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(515, 234);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmPhuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(926, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.dgvPhuong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbPhuong);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhuong";
            this.Text = "frmPhuong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhuong_FormClosing);
            this.Load += new System.EventHandler(this.frmPhuong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhuong_KeyDown);
            this.gbPhuong.ResumeLayout(false);
            this.gbPhuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbPhuong;
        private System.Windows.Forms.TextBox txtTenPhuong;
        private System.Windows.Forms.TextBox txtMaQuanID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhuongID;
        private System.Windows.Forms.DataGridView dgvPhuong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.RadioButton rbten;
        private System.Windows.Forms.RadioButton rbma;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}