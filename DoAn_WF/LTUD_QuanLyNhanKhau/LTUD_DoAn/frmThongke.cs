using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD_DoAn
{
    public partial class frmThongke : Form
    {
        public frmThongke()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RPThongTinTP rpt = new RPThongTinTP();
            rpvThongKe.ReportSource = rpt;
        }

        private void btnThongKeTuoi_Click(object sender, EventArgs e)
        {
            RPThongKeTuoi rpt = new RPThongKeTuoi();
            rpvThongKe.ReportSource = rpt;
        }

        private void btnThongKeGT_Click(object sender, EventArgs e)
        {
            RPThongKeGT rpt = new RPThongKeGT();
            rpvThongKe.ReportSource = rpt;
        }

        private void btnNhapNgu_Click(object sender, EventArgs e)
        {
            RPNhapNgu rpt = new RPNhapNgu();
            rpvThongKe.ReportSource = rpt;
        }

        private void frmThongke_Load(object sender, EventArgs e)
        {

        }

        private void frmThongke_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
