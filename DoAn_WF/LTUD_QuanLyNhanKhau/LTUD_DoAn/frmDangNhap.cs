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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            // Set to no text.
            txtMK.Text = "";
            // The password character is an asterisk.
            txtMK.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtMK.MaxLength = 14;
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "admin" && txtMK.Text == "password")
            {
                this.Hide();
                frmChinh fc = new frmChinh();
                fc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += frmDangNhap_KeyDown;
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Home:
                        btnDangNhap_Click(sender, e);
                        break;
                    case Keys.End:
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
