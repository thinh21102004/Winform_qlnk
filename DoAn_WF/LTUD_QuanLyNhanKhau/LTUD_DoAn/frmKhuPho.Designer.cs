namespace LTUD_DoAn
{
    partial class frmKhuPho
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
            this.gBKhuPho = new System.Windows.Forms.GroupBox();
            this.txtMaPhuongID = new System.Windows.Forms.TextBox();
            this.txtTenKP = new System.Windows.Forms.TextBox();
            this.txtMaKhuPhoID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvKhuPho = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtenkp = new System.Windows.Forms.RadioButton();
            this.rbmakp = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.gBKhuPho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuPho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBKhuPho
            // 
            this.gBKhuPho.Controls.Add(this.txtMaPhuongID);
            this.gBKhuPho.Controls.Add(this.txtTenKP);
            this.gBKhuPho.Controls.Add(this.txtMaKhuPhoID);
            this.gBKhuPho.Controls.Add(this.label4);
            this.gBKhuPho.Controls.Add(this.label3);
            this.gBKhuPho.Controls.Add(this.label2);
            this.gBKhuPho.Location = new System.Drawing.Point(136, 13);
            this.gBKhuPho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gBKhuPho.Name = "gBKhuPho";
            this.gBKhuPho.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gBKhuPho.Size = new System.Drawing.Size(760, 169);
            this.gBKhuPho.TabIndex = 0;
            this.gBKhuPho.TabStop = false;
            this.gBKhuPho.Text = "Khu phố";
            this.gBKhuPho.Enter += new System.EventHandler(this.gBKhuPho_Enter);
            // 
            // txtMaPhuongID
            // 
            this.txtMaPhuongID.Location = new System.Drawing.Point(535, 41);
            this.txtMaPhuongID.Name = "txtMaPhuongID";
            this.txtMaPhuongID.Size = new System.Drawing.Size(169, 27);
            this.txtMaPhuongID.TabIndex = 3;
            // 
            // txtTenKP
            // 
            this.txtTenKP.Location = new System.Drawing.Point(188, 109);
            this.txtTenKP.Name = "txtTenKP";
            this.txtTenKP.Size = new System.Drawing.Size(169, 27);
            this.txtTenKP.TabIndex = 5;
            // 
            // txtMaKhuPhoID
            // 
            this.txtMaKhuPhoID.Location = new System.Drawing.Point(188, 41);
            this.txtMaKhuPhoID.Name = "txtMaKhuPhoID";
            this.txtMaKhuPhoID.Size = new System.Drawing.Size(169, 27);
            this.txtMaKhuPhoID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã phường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khu phố";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khu phố";
            // 
            // dgvKhuPho
            // 
            this.dgvKhuPho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhuPho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuPho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhuPho.Location = new System.Drawing.Point(0, 370);
            this.dgvKhuPho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKhuPho.Name = "dgvKhuPho";
            this.dgvKhuPho.ReadOnly = true;
            this.dgvKhuPho.RowHeadersWidth = 51;
            this.dgvKhuPho.RowTemplate.Height = 24;
            this.dgvKhuPho.Size = new System.Drawing.Size(1028, 215);
            this.dgvKhuPho.TabIndex = 6;
            this.dgvKhuPho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhuPho_CellClick);
            this.dgvKhuPho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhuPho_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(214, 217);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 26);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(384, 217);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(556, 217);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(710, 217);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(96, 26);
            this.btnLammoi.TabIndex = 4;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtenkp);
            this.groupBox1.Controls.Add(this.rbmakp);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Location = new System.Drawing.Point(136, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rbtenkp
            // 
            this.rbtenkp.AutoSize = true;
            this.rbtenkp.Location = new System.Drawing.Point(608, 40);
            this.rbtenkp.Name = "rbtenkp";
            this.rbtenkp.Size = new System.Drawing.Size(146, 23);
            this.rbtenkp.TabIndex = 2;
            this.rbtenkp.TabStop = true;
            this.rbtenkp.Text = "theo Tên khu phố";
            this.rbtenkp.UseVisualStyleBackColor = true;
            this.rbtenkp.CheckedChanged += new System.EventHandler(this.rbtenkp_CheckedChanged);
            // 
            // rbmakp
            // 
            this.rbmakp.AutoSize = true;
            this.rbmakp.Location = new System.Drawing.Point(433, 40);
            this.rbmakp.Name = "rbmakp";
            this.rbmakp.Size = new System.Drawing.Size(143, 23);
            this.rbmakp.TabIndex = 1;
            this.rbmakp.TabStop = true;
            this.rbmakp.Text = "theo Mã khu phố";
            this.rbmakp.UseVisualStyleBackColor = true;
            this.rbmakp.CheckedChanged += new System.EventHandler(this.rbmakp_CheckedChanged);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(31, 39);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(372, 27);
            this.txtTimkiem.TabIndex = 0;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmKhuPho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1028, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvKhuPho);
            this.Controls.Add(this.gBKhuPho);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKhuPho";
            this.Text = "frmKhuPho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhuPho_FormClosing);
            this.Load += new System.EventHandler(this.frmKhuPho_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKhuPho_KeyDown);
            this.gBKhuPho.ResumeLayout(false);
            this.gBKhuPho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuPho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBKhuPho;
        private System.Windows.Forms.DataGridView dgvKhuPho;
        private System.Windows.Forms.TextBox txtMaPhuongID;
        private System.Windows.Forms.TextBox txtTenKP;
        private System.Windows.Forms.TextBox txtMaKhuPhoID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.RadioButton rbtenkp;
        private System.Windows.Forms.RadioButton rbmakp;
    }
}