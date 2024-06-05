namespace LTUD_DoAn
{
    partial class frmQuan
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbQuan = new System.Windows.Forms.GroupBox();
            this.txtTenQuan = new System.Windows.Forms.TextBox();
            this.txtMaQuanID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbten = new System.Windows.Forms.RadioButton();
            this.rbma = new System.Windows.Forms.RadioButton();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.gbQuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(689, 169);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 26);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(522, 169);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(351, 169);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(159, 169);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 26);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbQuan
            // 
            this.gbQuan.Controls.Add(this.txtTenQuan);
            this.gbQuan.Controls.Add(this.txtMaQuanID);
            this.gbQuan.Controls.Add(this.label4);
            this.gbQuan.Controls.Add(this.label1);
            this.gbQuan.Location = new System.Drawing.Point(121, 21);
            this.gbQuan.Name = "gbQuan";
            this.gbQuan.Size = new System.Drawing.Size(698, 123);
            this.gbQuan.TabIndex = 0;
            this.gbQuan.TabStop = false;
            this.gbQuan.Text = "Quận";
            // 
            // txtTenQuan
            // 
            this.txtTenQuan.Location = new System.Drawing.Point(471, 57);
            this.txtTenQuan.Name = "txtTenQuan";
            this.txtTenQuan.Size = new System.Drawing.Size(193, 27);
            this.txtTenQuan.TabIndex = 3;
            // 
            // txtMaQuanID
            // 
            this.txtMaQuanID.Location = new System.Drawing.Point(136, 57);
            this.txtMaQuanID.Name = "txtMaQuanID";
            this.txtMaQuanID.Size = new System.Drawing.Size(193, 27);
            this.txtMaQuanID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Quận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã quận ID";
            // 
            // dgvQuan
            // 
            this.dgvQuan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQuan.Location = new System.Drawing.Point(0, 299);
            this.dgvQuan.Name = "dgvQuan";
            this.dgvQuan.RowHeadersWidth = 51;
            this.dgvQuan.RowTemplate.Height = 24;
            this.dgvQuan.Size = new System.Drawing.Size(948, 268);
            this.dgvQuan.TabIndex = 6;
            this.dgvQuan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuan_CellClick);
            this.dgvQuan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuan_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbten);
            this.groupBox1.Controls.Add(this.rbma);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Location = new System.Drawing.Point(121, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rbten
            // 
            this.rbten.AutoSize = true;
            this.rbten.Location = new System.Drawing.Point(543, 39);
            this.rbten.Name = "rbten";
            this.rbten.Size = new System.Drawing.Size(89, 23);
            this.rbten.TabIndex = 2;
            this.rbten.TabStop = true;
            this.rbten.Text = "Theo tên";
            this.rbten.UseVisualStyleBackColor = true;
            this.rbten.CheckedChanged += new System.EventHandler(this.rbten_CheckedChanged);
            // 
            // rbma
            // 
            this.rbma.AutoSize = true;
            this.rbma.Location = new System.Drawing.Point(401, 39);
            this.rbma.Name = "rbma";
            this.rbma.Size = new System.Drawing.Size(88, 23);
            this.rbma.TabIndex = 1;
            this.rbma.TabStop = true;
            this.rbma.Text = "Theo mã";
            this.rbma.UseVisualStyleBackColor = true;
            this.rbma.CheckedChanged += new System.EventHandler(this.rbma_CheckedChanged);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(28, 36);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(341, 27);
            this.txttimkiem.TabIndex = 0;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // frmQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(948, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbQuan);
            this.Controls.Add(this.dgvQuan);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuan";
            this.Text = "frmQuan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuan_FormClosing);
            this.Load += new System.EventHandler(this.frmQuan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmQuan_KeyDown);
            this.gbQuan.ResumeLayout(false);
            this.gbQuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbQuan;
        private System.Windows.Forms.TextBox txtTenQuan;
        private System.Windows.Forms.TextBox txtMaQuanID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbten;
        private System.Windows.Forms.RadioButton rbma;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}