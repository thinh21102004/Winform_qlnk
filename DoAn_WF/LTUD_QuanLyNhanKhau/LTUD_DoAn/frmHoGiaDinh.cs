using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD_DoAn
{
    public partial class frmHoGiaDinh : Form
    {
        public frmHoGiaDinh()
        {
            InitializeComponent();
        }
        string timkiem = "";
        SqlConnection con = new SqlConnection(new Link()._Link);
        SqlCommand cmdKP;
        private void frmHoGiaDinh_Load(object sender, EventArgs e)
        {
            dgvHoGiaDinh.DataSource = LayDSKhuPho();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            this.KeyPreview = true;
            this.KeyDown += frmHoGiaDinh_KeyDown;
        }
        private DataTable LayDSKhuPho()
        {
            SqlDataAdapter daKP;
            DataTable dsKP = new DataTable();
            try
            {
                //Mở database
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_inhogiadinh";
                cmdKP.CommandType = CommandType.StoredProcedure;
                daKP = new SqlDataAdapter(cmdKP);
                daKP.Fill(dsKP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("In khong thanh cong" + ex);
            }
            finally
            {
                con.Close();
            }
            return dsKP;
        }
        private DataTable LayDSKhuPho(string maho)
        {
            SqlDataAdapter daKP;
            DataTable dsKP = new DataTable();
            try
            {
                //Mở database
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_timhgd_maho";
                cmdKP.CommandType = CommandType.StoredProcedure;
                cmdKP.Parameters.AddWithValue("@maho", maho);
                daKP = new SqlDataAdapter(cmdKP);
                daKP.Fill(dsKP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("In khong thanh cong" + ex);
            }
            finally
            {
                con.Close();
            }
            return dsKP;
        }
        private DataTable LayDSKhuPho_makp(string makp)
        {
            SqlDataAdapter daKP;
            DataTable dsKP = new DataTable();
            try
            {
                //Mở database
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_timhgd_makp";
                cmdKP.CommandType = CommandType.StoredProcedure;
                cmdKP.Parameters.AddWithValue("@makp", makp);
                daKP = new SqlDataAdapter(cmdKP);
                daKP.Fill(dsKP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("In khong thanh cong" + ex);
            }
            finally
            {
                con.Close();
            }
            return dsKP;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmaho.Text.Length == 0 || txtmakhupho.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                string maho = txtmaho.Text.Trim();
                string makhupho = txtmakhupho.Text.Trim();
                if (maho.Length == 0 || makhupho.Length == 0)
                {
                    MessageBox.Show("Không được để trống thông tin");
                }
                else
                {
                    if (maho.Length > 10 || Regex.IsMatch(maho, @"[^a-zA-Z0-9]"))
                    {
                        MessageBox.Show("Mã hộ không quá 10 kí tự và không có kí tự đặc biệt");
                    }
                    else
                    {
                        bool flag = true;
                        for (int i = 0; i <= dgvHoGiaDinh.Rows.Count - 2; i++)
                        {
                            if (maho == dgvHoGiaDinh.Rows[i].Cells[0].Value.ToString().Trim())
                            {
                                flag = false;
                            }
                        }
                        if (flag == false)
                        {
                            MessageBox.Show("Mã hộ đã tồn tại");
                        }
                        else
                        {
                            if (makhupho.Length > 10 || Regex.IsMatch(makhupho, @"[^a-zA-Z0-9]"))
                            {
                                MessageBox.Show("Mã khu phố không quá 10 kí tự và không có kí tự đặc biệt");
                            }
                            else
                            {
                                DialogResult dr = MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo);
                                if (dr == DialogResult.Yes)
                                {
                                    try
                                    {
                                        con.Open();
                                        cmdKP = new SqlCommand("exec so_themhgd '" + maho + "', '" + makhupho + "'", con);
                                        cmdKP.ExecuteNonQuery();
                                        MessageBox.Show("Thêm khu phố thành công");
                                        con.Close();
                                        txtmaho.Text = "";
                                        txtmaho.Focus();
                                        txtmakhupho.Text = "";
                                        if (txttimkiem.Text.Length == 0)
                                        {
                                            dgvHoGiaDinh.DataSource = LayDSKhuPho();
                                        }
                                        else
                                        {
                                            if (timkiem == "maho")
                                            {
                                                dgvHoGiaDinh.DataSource = LayDSKhuPho(txttimkiem.Text);
                                            }
                                            if (timkiem == "makhupho")
                                            {
                                                dgvHoGiaDinh.DataSource = LayDSKhuPho_makp(txttimkiem.Text);
                                            }
                                            if (timkiem == "")
                                            {
                                                dgvHoGiaDinh.DataSource = LayDSKhuPho();
                                            }
                                        }
                                    }
                                    catch
                                    {
                                        con.Close();
                                        MessageBox.Show("Thêm không thành công do khu phố chưa tồn tại");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Length == 0)
            {
                dgvHoGiaDinh.DataSource = LayDSKhuPho();
            }
            else
            {
                if (timkiem == "maho")
                {
                    dgvHoGiaDinh.DataSource = LayDSKhuPho(txttimkiem.Text);
                }
                if (timkiem == "makhupho")
                {
                    dgvHoGiaDinh.DataSource = LayDSKhuPho_makp(txttimkiem.Text);
                }
                if (timkiem == "")
                {
                    dgvHoGiaDinh.DataSource = LayDSKhuPho();
                }
            }
        }

        private void rbmaho_CheckedChanged(object sender, EventArgs e)
        {
            timkiem = "maho";
            if (txttimkiem.Text.Length == 0)
            {
                dgvHoGiaDinh.DataSource = LayDSKhuPho();
            }
            else
            {
                if (timkiem == "maho")
                {
                    dgvHoGiaDinh.DataSource = LayDSKhuPho(txttimkiem.Text);
                }
                if (timkiem == "makhupho")
                {
                    dgvHoGiaDinh.DataSource = LayDSKhuPho_makp(txttimkiem.Text);
                }
                if (timkiem == "")
                {
                    dgvHoGiaDinh.DataSource = LayDSKhuPho();
                }
            }
        }

        private void rbmakp_CheckedChanged(object sender, EventArgs e)
        {
            timkiem = "makhupho";
            if (txttimkiem.Text.Length == 0)
            {
                dgvHoGiaDinh.DataSource = LayDSKhuPho();
            }
            else
            {
                if (timkiem == "maho")
                {
                    dgvHoGiaDinh.DataSource = LayDSKhuPho(txttimkiem.Text);
                }
                if (timkiem == "makhupho")
                {
                    dgvHoGiaDinh.DataSource = LayDSKhuPho_makp(txttimkiem.Text);
                }
                if (timkiem == "")
                {
                    dgvHoGiaDinh.DataSource = LayDSKhuPho();
                }
            }
        }

        private void dgvHoGiaDinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chon;
            chon = dgvHoGiaDinh.CurrentRow.Index;
            txtmaho.Text = dgvHoGiaDinh.Rows[chon].Cells[0].Value.ToString().Trim();
            txtmakhupho.Text = dgvHoGiaDinh.Rows[chon].Cells[1].Value.ToString().Trim();
            btnthem.Enabled = false;
            txtmaho.ReadOnly = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmaho.Text = "";
            txtmakhupho.Text = "";
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            timkiem = "";
            txttimkiem.Text = "";
            rbmaho.Checked = false;
            rbmakp.Checked = false;
            txtmaho.ReadOnly = false;
            dgvHoGiaDinh.DataSource = LayDSKhuPho();
            txtmaho.Focus();
        }
        private void suaKP()
        {
            try
            {
                con.Open();

                cmdKP = new SqlCommand("exec sp_suahgd '" + txtmaho.Text + "','" + txtmakhupho.Text + "'", con);

                cmdKP.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                con.Close();
                txtmaho.Text = "";
                txtmakhupho.Text = "";
                btnthem.Enabled = true;
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                txtmaho.ReadOnly = false;
                txtmaho.Focus();
                if (txttimkiem.Text.Length == 0)
                {
                    dgvHoGiaDinh.DataSource = LayDSKhuPho();
                }
                else
                {
                    if (timkiem == "maho")
                    {
                        dgvHoGiaDinh.DataSource = LayDSKhuPho(txttimkiem.Text);
                    }
                    if (timkiem == "makhupho")
                    {
                        dgvHoGiaDinh.DataSource = LayDSKhuPho_makp(txttimkiem.Text);
                    }
                    if (timkiem == "")
                    {
                        dgvHoGiaDinh.DataSource = LayDSKhuPho();
                    }
                }
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Sửa không thành công do hộ không tồn tại");
            }
        }
        private void xoaHoGiaDinh()
        {
            try
            {
                con.Open();
                cmdKP.Connection = con;
                cmdKP = new SqlCommand("exec sp_xoahgd '" + txtmaho.Text + "'", con);
                cmdKP.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Xóa hộ thành công");
                txtmaho.Text = "";
                txtmakhupho.Text = "";
                btnthem.Enabled = true;
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                txtmaho.ReadOnly = false;
                txtmaho.Focus();
                if (txttimkiem.Text.Length == 0)
                {
                    dgvHoGiaDinh.DataSource = LayDSKhuPho();
                }
                else
                {
                    if (timkiem == "maho")
                    {
                        dgvHoGiaDinh.DataSource = LayDSKhuPho(txttimkiem.Text);
                    }
                    if (timkiem == "makhupho")
                    {
                        dgvHoGiaDinh.DataSource = LayDSKhuPho_makp(txttimkiem.Text);
                    }
                    if (timkiem == "")
                    {
                        dgvHoGiaDinh.DataSource = LayDSKhuPho();
                    }
                }
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Xóa không thành công do hộ có người sinh sống");
            }
            finally
            {
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                xoaHoGiaDinh();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                suaKP();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmHoGiaDinh_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmHoGiaDinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.T:
                        btnthem_Click(sender, e);
                        break;
                    case Keys.X:
                        btnxoa_Click(sender, e);
                        break;
                    case Keys.S:
                        btnsua_Click(sender, e);
                        break;
                    case Keys.L:
                        btnlammoi_Click(sender, e);
                        break;
                    case Keys.Q:
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
