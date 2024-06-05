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
using static System.Windows.Forms.LinkLabel;

namespace LTUD_DoAn
{
    public partial class frmKhuPho : Form
    {
        public frmKhuPho()
        {
            InitializeComponent();
        }
        string timkiem = "";
        SqlConnection con = new SqlConnection(new Link()._Link);
        SqlCommand cmdKP;
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
                cmdKP.CommandText = "sp_LayDSKhuPho";
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
        private void dgvKhuPho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKhuPho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chon;
            chon = dgvKhuPho.CurrentRow.Index;
            txtMaKhuPhoID.Text = dgvKhuPho.Rows[chon].Cells[0].Value.ToString().Trim();
            txtTenKP.Text = dgvKhuPho.Rows[chon].Cells[1].Value.ToString().Trim();
            txtMaPhuongID.Text = dgvKhuPho.Rows[chon].Cells[2].Value.ToString().Trim();
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaKhuPhoID.ReadOnly = true;
        }

        private void frmKhuPho_Load_1(object sender, EventArgs e)
        {
            dgvKhuPho.DataSource = LayDSKhuPho();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMaKhuPhoID.Focus();
            this.KeyPreview = true;
            this.KeyDown += frmKhuPho_KeyDown;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (txtMaKhuPhoID.Text.Length == 0 || txtMaPhuongID.Text.Length == 0 || txtTenKP.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                string makp = txtMaKhuPhoID.Text.Trim();
                string tenkp = txtTenKP.Text.Trim();
                string maphuong = txtMaPhuongID.Text.Trim();
                if (makp.Length == 0 || tenkp.Length == 0 || maphuong.Length == 0)
                {
                    MessageBox.Show("Không được để trống thông tin");
                }
                else
                {
                    if (tenkp.Length > 20 || Regex.IsMatch(tenkp, @"[^a-zA-Z0-9\s]"))
                    {
                        MessageBox.Show("Tên khu phố không được lớn hơn 20 kí tự và không có kí tự đặc biệt ngoại trừ khoảng trắng");
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            try
                            {
                                con.Open();
                                cmdKP = new SqlCommand("exec sp_SuaKhuPho '" + makp + "','" + tenkp + "','" + maphuong + "'", con);
                                cmdKP.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Cập nhật thành công");
                                txtMaKhuPhoID.ReadOnly = false;
                                txtMaKhuPhoID.Text = "";
                                txtMaKhuPhoID.Focus();
                                txtMaPhuongID.Text = "";
                                txtTenKP.Text = "";
                                btnThem.Enabled = true;
                                btnXoa.Enabled = false;
                                btnSua.Enabled = false;
                                if (txtTimkiem.Text.Length > 0)
                                {
                                    if (timkiem == "theoma")
                                    {
                                        dgvKhuPho.DataSource = LayDSKhuPho(txtTimkiem.Text);
                                    }
                                    if (timkiem == "theoten")
                                    {
                                        dgvKhuPho.DataSource = LayDSKhuPho_ten(txtTimkiem.Text);
                                    }
                                    if (timkiem == "")
                                    {
                                        dgvKhuPho.DataSource = LayDSKhuPho();
                                    }
                                }
                                else
                                {
                                    dgvKhuPho.DataSource = LayDSKhuPho();
                                }
                            }
                            catch (Exception)
                            {
                                con.Close();
                                MessageBox.Show("Cập nhật không thành công do phường không tồn tại");
                            }
                        }
                        else
                        {

                        }
                    }
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            txtMaKhuPhoID.Text = "";
            txtMaPhuongID.Text = "";
            txtTenKP.Text = "";
            txtMaKhuPhoID.Focus();
            txtTimkiem.Text = "";
            txtMaKhuPhoID.ReadOnly = false;
            rbmakp.Checked = false;
            rbtenkp.Checked = false;
            timkiem = "";
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int chon;
                chon = dgvKhuPho.CurrentRow.Index;
                string makp = dgvKhuPho.Rows[chon].Cells[0].Value.ToString().Trim();
                try
                {
                    con.Open();
                    cmdKP = new SqlCommand("exec sp_XoaKhuPho '" + dgvKhuPho.Rows[dgvKhuPho.CurrentRow.Index].Cells[0].Value.ToString().Trim() + "'", con);
                    cmdKP.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Xóa khu phố thành công");

                    txtMaKhuPhoID.Text = "";
                    txtMaPhuongID.Text = "";
                    txtTenKP.Text = "";
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    txtMaKhuPhoID.ReadOnly = false;
                    txtMaKhuPhoID.Focus();
                    if (txtTimkiem.Text.Length > 0)
                    {
                        if (timkiem == "theoma")
                        {
                            dgvKhuPho.DataSource = LayDSKhuPho(txtTimkiem.Text);
                        }
                        if (timkiem == "theoten")
                        {
                            dgvKhuPho.DataSource = LayDSKhuPho_ten(txtTimkiem.Text);
                        }
                        if (timkiem == "")
                        {
                            dgvKhuPho.DataSource = LayDSKhuPho();
                        }
                    }
                    else
                    {
                        dgvKhuPho.DataSource = LayDSKhuPho();
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa khu phố không thành công do có hộ dân sinh sống");
                }
                finally
                {
                }
            }
            else
            {

            }
        }

        private void gBKhuPho_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhuPhoID.Text.Length == 0 || txtMaPhuongID.Text.Length == 0 || txtTenKP.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                string makp = txtMaKhuPhoID.Text.Trim();
                string tenkp = txtTenKP.Text.Trim();
                string maphuong = txtMaPhuongID.Text.Trim();
                if (makp.Length == 0 || tenkp.Length == 0 || maphuong.Length == 0)
                {
                    MessageBox.Show("Không được để trống thông tin");
                }
                else
                {
                    bool flag1 = false;
                    for (int i = 0; i < dgvKhuPho.Rows.Count - 1; i++)
                    {
                        if (makp == dgvKhuPho.Rows[i].Cells[0].Value.ToString().Trim())
                        {
                            flag1 = true;
                        }
                    }
                    if (flag1 == true)
                    {
                        MessageBox.Show("Mã khu phố đã tồn tại");
                    }
                    else
                    {
                        if (makp.Length > 10 || Regex.IsMatch(makp, @"[^a-zA-Z0-9]"))
                        {
                            MessageBox.Show("Mã khu phố không được lớn hơn 10 kí tự và không có kí tự đặc biệt");
                        }
                        else
                        {
                            if (tenkp.Length > 20 || Regex.IsMatch(tenkp, @"[^a-zA-Z0-9\s]"))
                            {
                                MessageBox.Show("Tên khu phố không được lớn hơn 20 kí tự và không có kí tự đặc biệt ngoại trừ khoảng trắng");
                            }
                            else
                            {
                                DialogResult dr = MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo);
                                if (dr == DialogResult.Yes)
                                {
                                    try
                                    {
                                        con.Open();
                                        cmdKP = new SqlCommand("Exec  sp_ThemKhuPho '" + txtMaKhuPhoID.Text + "', '" + txtTenKP.Text + "', '" + txtMaPhuongID.Text + "'", con);
                                        cmdKP.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Thêm khu phố thành công");
                                        txtMaKhuPhoID.Text = "";
                                        txtMaPhuongID.Text = "";
                                        txtTenKP.Text = "";
                                        txtMaKhuPhoID.Focus();
                                        if (txtTimkiem.Text.Length > 0)
                                        {
                                            if (timkiem == "theoma")
                                            {
                                                dgvKhuPho.DataSource = LayDSKhuPho(txtTimkiem.Text);
                                            }
                                            if (timkiem == "theoten")
                                            {
                                                dgvKhuPho.DataSource = LayDSKhuPho_ten(txtTimkiem.Text);
                                            }
                                            if (timkiem == "")
                                            {
                                                dgvKhuPho.DataSource = LayDSKhuPho();
                                            }
                                        }
                                        else
                                        {
                                            con.Close();
                                            dgvKhuPho.DataSource = LayDSKhuPho();
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Thêm không thành công do phường chưa tồn tại");
                                    }
                                }
                                else
                                {

                                }
                            }
                        }
                    }
                }
            }

        }
        private DataTable LayDSKhuPho(string makp)
        {
            SqlDataAdapter daNK;
            DataTable dsNK = new DataTable();
            try
            {
                //Mở database
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_timkhupho_theoma";
                cmdKP.CommandType = CommandType.StoredProcedure;
                cmdKP.Parameters.AddWithValue("@makp", makp);
                daNK = new SqlDataAdapter(cmdKP);
                daNK.Fill(dsNK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("In khong thanh cong" + ex);
            }
            finally
            {
                con.Close();
            }
            return dsNK;
        }
        private DataTable LayDSKhuPho_ten(string ten)
        {
            SqlDataAdapter daNK;
            DataTable dsNK = new DataTable();
            try
            {
                //Mở database
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_timkhupho_theoten";
                cmdKP.CommandType = CommandType.StoredProcedure;
                cmdKP.Parameters.AddWithValue("@tenkp", ten);
                daNK = new SqlDataAdapter(cmdKP);
                daNK.Fill(dsNK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("In khong thanh cong" + ex);
            }
            finally
            {
                con.Close();
            }
            return dsNK;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text.Length > 0)
            {
                if (timkiem == "theoma")
                {
                    dgvKhuPho.DataSource = LayDSKhuPho(txtTimkiem.Text);
                }
                if (timkiem == "theoten")
                {
                    dgvKhuPho.DataSource = LayDSKhuPho_ten(txtTimkiem.Text);
                }
                if (timkiem == "")
                {
                    dgvKhuPho.DataSource = LayDSKhuPho();
                }
            }
            else
            {
                dgvKhuPho.DataSource = LayDSKhuPho();
            }
        }

        private void rbmakp_CheckedChanged(object sender, EventArgs e)
        {
            timkiem = "theoma";
            if (txtTimkiem.Text.Length > 0)
            {
                if (timkiem == "theoma")
                {
                    dgvKhuPho.DataSource = LayDSKhuPho(txtTimkiem.Text);
                }
                if (timkiem == "theoten")
                {
                    dgvKhuPho.DataSource = LayDSKhuPho_ten(txtTimkiem.Text);
                }
                if (timkiem == "")
                {
                    dgvKhuPho.DataSource = LayDSKhuPho();
                }
            }
            else
            {
                dgvKhuPho.DataSource = LayDSKhuPho();
            }
        }

        private void rbtenkp_CheckedChanged(object sender, EventArgs e)
        {
            timkiem = "theoten";
            if (txtTimkiem.Text.Length > 0)
            {
                if (timkiem == "theoma")
                {
                    dgvKhuPho.DataSource = LayDSKhuPho(txtTimkiem.Text);
                }
                if (timkiem == "theoten")
                {
                    dgvKhuPho.DataSource = LayDSKhuPho_ten(txtTimkiem.Text);
                }
                if (timkiem == "")
                {
                    dgvKhuPho.DataSource = LayDSKhuPho();
                }
            }
            else
            {
                dgvKhuPho.DataSource = LayDSKhuPho();
            }
        }

        private void frmKhuPho_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmKhuPho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.T:
                        btnThem_Click(sender, e);
                        break;
                    case Keys.X:
                        btnXoa_Click(sender, e);
                        break;
                    case Keys.S:
                        btnSua_Click_1(sender, e);
                        break;
                    case Keys.L:
                        btnThoat_Click(sender, e);
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

