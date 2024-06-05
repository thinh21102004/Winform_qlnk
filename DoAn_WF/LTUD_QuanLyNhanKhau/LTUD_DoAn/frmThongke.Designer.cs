namespace LTUD_DoAn
{
    partial class frmThongke
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnThongKeTP = new System.Windows.Forms.Button();
            this.btnThongKeTuoi = new System.Windows.Forms.Button();
            this.btnThongKeGT = new System.Windows.Forms.Button();
            this.rpvThongKe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnNhapNgu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(561, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "Thống Kê";
            // 
            // btnThongKeTP
            // 
            this.btnThongKeTP.Location = new System.Drawing.Point(151, 42);
            this.btnThongKeTP.Name = "btnThongKeTP";
            this.btnThongKeTP.Size = new System.Drawing.Size(120, 55);
            this.btnThongKeTP.TabIndex = 22;
            this.btnThongKeTP.Text = "Thông Kê Thành Phố";
            this.btnThongKeTP.UseVisualStyleBackColor = true;
            this.btnThongKeTP.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThongKeTuoi
            // 
            this.btnThongKeTuoi.Location = new System.Drawing.Point(416, 42);
            this.btnThongKeTuoi.Name = "btnThongKeTuoi";
            this.btnThongKeTuoi.Size = new System.Drawing.Size(127, 55);
            this.btnThongKeTuoi.TabIndex = 23;
            this.btnThongKeTuoi.Text = "Thông Kê Tuổi";
            this.btnThongKeTuoi.UseVisualStyleBackColor = true;
            this.btnThongKeTuoi.Click += new System.EventHandler(this.btnThongKeTuoi_Click);
            // 
            // btnThongKeGT
            // 
            this.btnThongKeGT.Location = new System.Drawing.Point(735, 42);
            this.btnThongKeGT.Name = "btnThongKeGT";
            this.btnThongKeGT.Size = new System.Drawing.Size(127, 55);
            this.btnThongKeGT.TabIndex = 24;
            this.btnThongKeGT.Text = "Thông Kê Giới Tính";
            this.btnThongKeGT.UseVisualStyleBackColor = true;
            this.btnThongKeGT.Click += new System.EventHandler(this.btnThongKeGT_Click);
            // 
            // rpvThongKe
            // 
            this.rpvThongKe.ActiveViewIndex = -1;
            this.rpvThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvThongKe.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvThongKe.Location = new System.Drawing.Point(1, 103);
            this.rpvThongKe.Name = "rpvThongKe";
            this.rpvThongKe.Size = new System.Drawing.Size(1292, 656);
            this.rpvThongKe.TabIndex = 25;
            // 
            // btnNhapNgu
            // 
            this.btnNhapNgu.Location = new System.Drawing.Point(1026, 42);
            this.btnNhapNgu.Name = "btnNhapNgu";
            this.btnNhapNgu.Size = new System.Drawing.Size(127, 55);
            this.btnNhapNgu.TabIndex = 26;
            this.btnNhapNgu.Text = "Thông Kê Nhập Ngũ";
            this.btnNhapNgu.UseVisualStyleBackColor = true;
            this.btnNhapNgu.Click += new System.EventHandler(this.btnNhapNgu_Click);
            // 
            // frmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1293, 760);
            this.Controls.Add(this.btnNhapNgu);
            this.Controls.Add(this.rpvThongKe);
            this.Controls.Add(this.btnThongKeGT);
            this.Controls.Add(this.btnThongKeTuoi);
            this.Controls.Add(this.btnThongKeTP);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongke";
            this.Text = "frmThongke";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongke_FormClosing);
            this.Load += new System.EventHandler(this.frmThongke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThongKeTP;
        private System.Windows.Forms.Button btnThongKeTuoi;
        private System.Windows.Forms.Button btnThongKeGT;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpvThongKe;
        private System.Windows.Forms.Button btnNhapNgu;
    }
}