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
    public partial class FrmINNhanKhau : Form
    {
        public FrmINNhanKhau()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            if(txtCCCDID.Text.Trim().Length==0){
                MessageBox.Show("Bạn Chưa Nhập cccd");
            }
            CrystalReportNK rpt = new CrystalReportNK();
            rpt.SetParameterValue("@cccd", txtCCCDID.Text.Trim());
            crystalReportViewer1.ReportSource = rpt;
            MessageBox.Show("Nếu chưa hiện ra thông tin thì có thể cccd không tồn tại");
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FrmINNhanKhau_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu Ý CCCDID Chứa 12 kí tự là số\n VD:100000000001");
        }

        private void FrmINNhanKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
