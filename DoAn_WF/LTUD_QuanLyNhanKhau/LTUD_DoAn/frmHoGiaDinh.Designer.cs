namespace LTUD_DoAn
{
    partial class frmHoGiaDinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmakhupho = new System.Windows.Forms.TextBox();
            this.txtmaho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.dgvHoGiaDinh = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbmakp = new System.Windows.Forms.RadioButton();
            this.rbmaho = new System.Windows.Forms.RadioButton();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoGiaDinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmakhupho);
            this.groupBox1.Controls.Add(this.txtmaho);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(211, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hộ gia đình";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtmakhupho
            // 
            this.txtmakhupho.Location = new System.Drawing.Point(141, 95);
            this.txtmakhupho.Name = "txtmakhupho";
            this.txtmakhupho.Size = new System.Drawing.Size(345, 22);
            this.txtmakhupho.TabIndex = 3;
            // 
            // txtmaho
            // 
            this.txtmaho.Location = new System.Drawing.Point(141, 39);
            this.txtmaho.Name = "txtmaho";
            this.txtmaho.Size = new System.Drawing.Size(345, 22);
            this.txtmaho.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khu phố";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hộ";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(251, 216);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(622, 216);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 23);
            this.btnlammoi.TabIndex = 4;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(378, 216);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(498, 216);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // dgvHoGiaDinh
            // 
            this.dgvHoGiaDinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoGiaDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoGiaDinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHoGiaDinh.Location = new System.Drawing.Point(0, 384);
            this.dgvHoGiaDinh.Name = "dgvHoGiaDinh";
            this.dgvHoGiaDinh.RowHeadersWidth = 51;
            this.dgvHoGiaDinh.RowTemplate.Height = 24;
            this.dgvHoGiaDinh.Size = new System.Drawing.Size(966, 216);
            this.dgvHoGiaDinh.TabIndex = 6;
            this.dgvHoGiaDinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoGiaDinh_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbmakp);
            this.groupBox2.Controls.Add(this.rbmaho);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Location = new System.Drawing.Point(211, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 109);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // rbmakp
            // 
            this.rbmakp.AutoSize = true;
            this.rbmakp.Location = new System.Drawing.Point(311, 69);
            this.rbmakp.Name = "rbmakp";
            this.rbmakp.Size = new System.Drawing.Size(132, 20);
            this.rbmakp.TabIndex = 2;
            this.rbmakp.TabStop = true;
            this.rbmakp.Text = "Theo mã khu phố";
            this.rbmakp.UseVisualStyleBackColor = true;
            this.rbmakp.CheckedChanged += new System.EventHandler(this.rbmakp_CheckedChanged);
            // 
            // rbmaho
            // 
            this.rbmaho.AutoSize = true;
            this.rbmaho.Location = new System.Drawing.Point(167, 69);
            this.rbmaho.Name = "rbmaho";
            this.rbmaho.Size = new System.Drawing.Size(100, 20);
            this.rbmaho.TabIndex = 1;
            this.rbmaho.TabStop = true;
            this.rbmaho.Text = "Theo mã hộ";
            this.rbmaho.UseVisualStyleBackColor = true;
            this.rbmaho.CheckedChanged += new System.EventHandler(this.rbmaho_CheckedChanged);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(91, 32);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(364, 22);
            this.txttimkiem.TabIndex = 0;
            this.txttimkiem.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // frmHoGiaDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(966, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvHoGiaDinh);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHoGiaDinh";
            this.Text = "frmHoGiaDinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoGiaDinh_FormClosing);
            this.Load += new System.EventHandler(this.frmHoGiaDinh_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHoGiaDinh_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoGiaDinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmakhupho;
        private System.Windows.Forms.TextBox txtmaho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridView dgvHoGiaDinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.RadioButton rbmakp;
        private System.Windows.Forms.RadioButton rbmaho;
    }
}