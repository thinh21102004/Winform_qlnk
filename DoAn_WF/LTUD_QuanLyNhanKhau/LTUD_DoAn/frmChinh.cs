using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace LTUD_DoAn
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            this.Hide();
            frmDangNhap.ShowDialog();
            this.Show();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void quậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuan fq = new frmQuan();
            fq.ShowDialog();
            this.Show();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            đăngXuấtToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;

            thoátToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;

            quậnToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;

            phườngToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;

            khuPhốToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.K;

            nhânKhẩuToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;

            hộGiaĐìnhToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;

            inNhânKhẩuToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;

            inĐăngKýKếtHônToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;

            thốngKêToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
        }

        private void phườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPhuong fp = new frmPhuong();
            fp.ShowDialog();
            this.Show();
        }

        private void khuPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhuPho fkp = new frmKhuPho();
            fkp.ShowDialog();
            this.Show();
        }

        private void nhânKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanKhau fnk = new frmNhanKhau();
            fnk.ShowDialog();
            this.Show();
        }

        

        private void hộGiaĐìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoGiaDinh fh = new frmHoGiaDinh();
            fh.ShowDialog();
            this.Show();
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lỗi này thì Dev chịu chứ không hỗ trợ được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        //Chức năng của Phong
        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void inNhânKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmINNhanKhau fq = new FrmINNhanKhau();
            fq.ShowDialog();
            this.Show();
        }

        private void inĐăngKýKếtHônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmINDKKT fq = new FrmINDKKT();
            fq.ShowDialog();
            this.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongke fq = new frmThongke();
            fq.ShowDialog();
            this.Show();
        }
    }
}
