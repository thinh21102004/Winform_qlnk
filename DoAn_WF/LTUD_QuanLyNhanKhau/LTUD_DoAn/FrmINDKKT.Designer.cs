namespace LTUD_DoAn
{
    partial class FrmINDKKT
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
            this.txtCCCDNam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCCCDNu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // txtCCCDNam
            // 
            this.txtCCCDNam.Location = new System.Drawing.Point(307, 48);
            this.txtCCCDNam.Name = "txtCCCDNam";
            this.txtCCCDNam.Size = new System.Drawing.Size(147, 22);
            this.txtCCCDNam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập CCCDID Người Nam Và Người Nữ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCCCDNu
            // 
            this.txtCCCDNu.Location = new System.Drawing.Point(670, 48);
            this.txtCCCDNu.Name = "txtCCCDNu";
            this.txtCCCDNu.Size = new System.Drawing.Size(147, 22);
            this.txtCCCDNu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CCCD Người Nam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CCCD Người Nữ";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(875, 41);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(91, 36);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 76);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1293, 707);
            this.crystalReportViewer1.TabIndex = 6;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // FrmINDKKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1293, 795);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCCCDNu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCCCDNam);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmINDKKT";
            this.Text = "FrmINDKKT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmINDKKT_FormClosing);
            this.Load += new System.EventHandler(this.FrmINDKKT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCCCDNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCCCDNu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXacNhan;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}