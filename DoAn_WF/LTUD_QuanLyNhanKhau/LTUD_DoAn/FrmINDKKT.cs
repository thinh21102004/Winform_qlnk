using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;

namespace LTUD_DoAn
{
    public partial class FrmINDKKT : Form
    {
        public FrmINDKKT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtCCCDNam.Text.Trim().Length == 0&& txtCCCDNu.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn Chưa Nhập cccd nam hoặc nữ");
            }
            RPDangKyKetHon rpt = new RPDangKyKetHon();
            
            rpt.SetParameterValue("@cccdnam", txtCCCDNam.Text.Trim());
            rpt.SetParameterValue("@cccdnu", txtCCCDNu.Text.Trim());
            crystalReportViewer1.ReportSource = rpt;
            MessageBox.Show("Nếu chưa hiện ra thông tin thì có thể cccd không tồn tại hoặc cccd của người nam hoặc nữ không đúng với giới tính và độ tuổi cho phép kết hôn");

        }

        private void btnXacNhan1_Click(object sender, EventArgs e)
        {

        }

        private void FrmINDKKT_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu Ý CCCDID Chứa 12 kí tự là số\n VD:100000000001");
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FrmINDKKT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
