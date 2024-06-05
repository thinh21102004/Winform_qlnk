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
    public partial class frmQuan : Form
    {
        public frmQuan()
        {
            InitializeComponent();
        }
        string timkiem = "";
        SqlConnection con = new SqlConnection(new Link()._Link);
        SqlCommand cmdKP;
        private void dgvQuan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataTable LayDSQuan()
        {
            DataTable dsp = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter();
            try
            {
                //mo db
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_LayDSQuan";
                cmdKP.CommandType = CommandType.StoredProcedure;
                dap = new SqlDataAdapter(cmdKP);
                dap.Fill(dsp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dsp;
        }
        public DataTable LayDSQuan(string ten)
        {
            DataTable dsp = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter();
            try
            {
                //mo db
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_timquan_ten";
                cmdKP.CommandType = CommandType.StoredProcedure;
                cmdKP.Parameters.AddWithValue("@ten", ten);
                dap = new SqlDataAdapter(cmdKP);
                dap.Fill(dsp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dsp;
        }
        public DataTable LayDSQuan_ma(string ma)
        {
            DataTable dsp = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter();
            try
            {
                //mo db
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_timquan_ma";
                cmdKP.CommandType = CommandType.StoredProcedure;
                cmdKP.Parameters.AddWithValue("@ma", ma);
                dap = new SqlDataAdapter(cmdKP);
                dap.Fill(dsp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dsp;
        }
        private void frmQuan_Load(object sender, EventArgs e)
        {
            dgvQuan.DataSource = LayDSQuan();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            this.KeyPreview = true;
            this.KeyDown += frmQuan_KeyDown;
        }

        private void dgvQuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chon;
            chon = dgvQuan.CurrentRow.Index;
            txtMaQuanID.Text = dgvQuan.Rows[chon].Cells[0].Value.ToString().Trim();
            txtTenQuan.Text = dgvQuan.Rows[chon].Cells[1].Value.ToString().Trim();
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMaQuanID.ReadOnly = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaQuanID.ReadOnly = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaQuanID.Text = "";
            txtTenQuan.Text = "";
            txttimkiem.Text = "";
            txtMaQuanID.Focus();
            timkiem = "";
            rbma.Checked = false;
            rbten.Checked = false;
            dgvQuan.DataSource = LayDSQuan();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Length > 0)
            {
                if (timkiem == "ten")
                {
                    dgvQuan.DataSource = LayDSQuan(txttimkiem.Text);
                }
                if (timkiem == "ma")
                {
                    dgvQuan.DataSource = LayDSQuan_ma(txttimkiem.Text);
                }
                if (timkiem == "")
                {
                    dgvQuan.DataSource = LayDSQuan();
                }
            }
            else
            {
                dgvQuan.DataSource = LayDSQuan();
            }
        }

        private void rbma_CheckedChanged(object sender, EventArgs e)
        {
            timkiem = "ma";
            if (txttimkiem.Text.Length > 0)
            {
                if (timkiem == "ten")
                {
                    dgvQuan.DataSource = LayDSQuan(txttimkiem.Text);
                }
                if (timkiem == "ma")
                {
                    dgvQuan.DataSource = LayDSQuan_ma(txttimkiem.Text);
                }
                if (timkiem == "")
                {
                    dgvQuan.DataSource = LayDSQuan();
                }
            }
            else
            {
                dgvQuan.DataSource = LayDSQuan();
            }
        }

        private void rbten_CheckedChanged(object sender, EventArgs e)
        {
            timkiem = "ten";
            if (txttimkiem.Text.Length > 0)
            {
                if (timkiem == "ten")
                {
                    dgvQuan.DataSource = LayDSQuan(txttimkiem.Text);
                }
                if (timkiem == "ma")
                {
                    dgvQuan.DataSource = LayDSQuan_ma(txttimkiem.Text);
                }
                if (timkiem == "")
                {
                    dgvQuan.DataSource = LayDSQuan();
                }
            }
            else
            {
                dgvQuan.DataSource = LayDSQuan();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenQuan.Text.Length == 0 || txtMaQuanID.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                string tenquan = txtTenQuan.Text.Trim();
                string maquan = txtMaQuanID.Text.Trim();
                if (tenquan.Length == 0 || maquan.Length == 0)
                {
                    MessageBox.Show("Không được để trống thông tin");
                }
                else
                {
                    if (maquan.Length > 5 || Regex.IsMatch(maquan, @"[^a-zA-Z0-9]"))
                    {
                        MessageBox.Show("Mã Phường không được lớn hơn 5 kí tự và không có kí tự đặc biệt");
                    }
                    else
                    {
                        if (tenquan.Length > 20 || Regex.IsMatch(tenquan, @"[^a-zA-Z0-9\s]"))
                        {
                            MessageBox.Show("Tên không được lớn hơn 20 kí tự và không có kí tự đặc biệt ngoại trừ khoảng trắng");
                        }
                        else
                        {
                            DialogResult dr = MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                try
                                {
                                    //Mở db
                                    con.Open();

                                    // Khởi tạo và cấu hình SqlCommand
                                    SqlCommand cmdKhuPho = new SqlCommand();
                                    cmdKhuPho.Connection = con;
                                    cmdKhuPho.CommandText = "sp_ThemQuan";
                                    cmdKhuPho.CommandType = CommandType.StoredProcedure;

                                    // Thêm các tham số vào SqlCommand
                                    cmdKhuPho.Parameters.AddWithValue("@ten", tenquan);
                                    cmdKhuPho.Parameters.AddWithValue("@ma", maquan);

                                    // Thực thi câu lệnh
                                    cmdKhuPho.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("Thêm thành công");


                                    txtMaQuanID.Text = "";
                                    txtTenQuan.Text = "";
                                    txtMaQuanID.Focus();
                                    if (txttimkiem.Text.Length > 0)
                                    {
                                        if (timkiem == "ten")
                                        {
                                            dgvQuan.DataSource = LayDSQuan(txttimkiem.Text);
                                        }
                                        if (timkiem == "ma")
                                        {
                                            dgvQuan.DataSource = LayDSQuan_ma(txttimkiem.Text);
                                        }
                                        if (timkiem == "")
                                        {
                                            dgvQuan.DataSource = LayDSQuan();
                                        }
                                    }
                                    else
                                    {
                                        dgvQuan.DataSource = LayDSQuan();
                                    }
                                }
                                catch
                                {
                                    con.Close();
                                    MessageBox.Show("Mã đã tồn tại");
                                }
                            }
                        }
                    }
                }
            }
        }

        private DataTable layDSQuan(string maQuanID)
        {
            SqlDataAdapter daQ;
            DataTable dsQ = new DataTable();
            try
            {
                //Mở database
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_TimMaQuan";
                cmdKP.CommandType = CommandType.StoredProcedure;
                cmdKP.Parameters.AddWithValue("@MaQuanID", maQuanID);
                daQ = new SqlDataAdapter(cmdKP);
                daQ.Fill(dsQ);
            }
            catch (Exception ex)
            {
                MessageBox.Show("In khong thanh cong" + ex);
            }
            finally
            {
                con.Close();
            }
            return dsQ;
        }
        private DataTable layDSQuan_Ten(string ten)
        {
            SqlDataAdapter daQ;
            DataTable dsQ = new DataTable();
            try
            {
                //Mở database
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_TimTenQuan";
                cmdKP.CommandType = CommandType.StoredProcedure;
                cmdKP.Parameters.AddWithValue("@TenQuan", ten);
                daQ = new SqlDataAdapter(cmdKP);
                daQ.Fill(dsQ);
            }
            catch (Exception ex)
            {
                MessageBox.Show("In khong thanh cong" + ex);
            }
            finally
            {
                con.Close();
            }
            return dsQ;
        }
        private void XoaQuan()
        {
            try
            {
                con.Open();

                // Khởi tạo và cấu hình SqlCommand
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_XoaQuan";
                cmdKP.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào SqlCommand
                cmdKP.Parameters.AddWithValue("@TenQuan", txtTenQuan.Text);
                cmdKP.Parameters.AddWithValue("@MaQuanID", txtMaQuanID.Text);

                // Thực thi câu lệnh
                if (cmdKP.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                };
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công do có phường tồn tại");
            }
            finally
            {
                con.Close();
                txtMaQuanID.ReadOnly = false;
                txtTenQuan.Text = "";
                txtMaQuanID.Text = "";
                dgvQuan.DataSource = LayDSQuan();
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                if (txttimkiem.Text.Length > 0)
                {
                    if (timkiem == "ma")
                    {
                        dgvQuan.DataSource = layDSQuan(txttimkiem.Text);
                    }
                    if (timkiem == "ten")
                    {
                        dgvQuan.DataSource = layDSQuan_Ten(txttimkiem.Text);
                    }
                    if (timkiem == "")
                    {
                        dgvQuan.DataSource = LayDSQuan();
                    }
                }
                else
                {
                    dgvQuan.DataSource = LayDSQuan();
                }
            }
        }
        private void XoaQuan_2()
        {
            try
            {
                con.Open();

                // Khởi tạo và cấu hình SqlCommand
                cmdKP.Connection = con;
                cmdKP = new SqlCommand("exec sp_XoaQuan '" + txtMaQuanID.Text + "',''", con);

                // Thực thi câu lệnh
                cmdKP.ExecuteNonQuery();

                MessageBox.Show("Xóa thành công!");
                con.Close();

                txtMaQuanID.ReadOnly = false;
                txtTenQuan.Text = "";
                txtMaQuanID.Text = "";
                txtMaQuanID.Focus();
                dgvQuan.DataSource = LayDSQuan();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                if (txttimkiem.Text.Length > 0)
                {
                    if (timkiem == "ma")
                    {
                        dgvQuan.DataSource = LayDSQuan(txttimkiem.Text);
                    }
                    if (timkiem == "ten")
                    {
                        dgvQuan.DataSource = layDSQuan_Ten(txttimkiem.Text);
                    }
                    if (timkiem == "")
                    {
                        dgvQuan.DataSource = LayDSQuan();
                    }
                }
                else
                {
                    dgvQuan.DataSource = LayDSQuan();
                }
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Xóa không thành công do có phường tồn tại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int chon;
            chon = dgvQuan.CurrentRow.Index;
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (txttimkiem.Text.Length == 0)
                {
                    XoaQuan();
                }
                else
                {
                    XoaQuan_2();
                }
            }
            else
            {

            }
            txtMaQuanID.Focus();
        }
        public void SuaQuan()
        {
            try
            {
                con.Open();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_SuaQuan";
                cmdKP.CommandType = CommandType.StoredProcedure;

                cmdKP.Parameters.AddWithValue("@MaQuanID", txtMaQuanID.Text);
                cmdKP.Parameters.AddWithValue("@TenQuan", txtTenQuan.Text);


                cmdKP.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                con.Close();


                txtMaQuanID.ReadOnly = false;
                txtTenQuan.Text = "";
                txtMaQuanID.Text = "";
                txtMaQuanID.Focus();
                dgvQuan.DataSource = LayDSQuan();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                if (txttimkiem.Text.Length > 0)
                {
                    if (timkiem == "ma")
                    {
                        dgvQuan.DataSource = LayDSQuan(txttimkiem.Text);
                    }
                    if (timkiem == "ten")
                    {
                        dgvQuan.DataSource = layDSQuan_Ten(txttimkiem.Text);
                    }
                    if (timkiem == "")
                    {
                        dgvQuan.DataSource = LayDSQuan();
                    }
                }
                else
                {
                    dgvQuan.DataSource = LayDSQuan();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Sửa không thành công do " + ex);
            }
        }
        public void SuaQuan(string maquanid)
        {
            try
            {
                con.Open();
                cmdKP = new SqlCommand("exec sp_SuaQuan '" + txtMaQuanID.Text + "','" + txtTenQuan.Text + "'", con);


                cmdKP.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                con.Close();

                txtMaQuanID.ReadOnly = false;
                txtTenQuan.Text = "";
                txtMaQuanID.Text = "";
                txtMaQuanID.Focus();
                dgvQuan.DataSource = LayDSQuan();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                if (txttimkiem.Text.Length > 0)
                {
                    if (timkiem == "ma")
                    {
                        dgvQuan.DataSource = LayDSQuan(txttimkiem.Text);
                    }
                    if (timkiem == "ten")
                    {
                        dgvQuan.DataSource = layDSQuan_Ten(txttimkiem.Text);
                    }
                    if (timkiem == "")
                    {
                        dgvQuan.DataSource = LayDSQuan();
                    }
                }
                else
                {
                    dgvQuan.DataSource = LayDSQuan();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Sửa không thành công do " + ex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaQuanID.Text.Length == 0 || txtTenQuan.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                string tenQuan = txtTenQuan.Text.Trim();
                string maQuanID = txtMaQuanID.Text.Trim();
                if (tenQuan.Length == 0 || maQuanID.Length == 0)
                {
                    MessageBox.Show("Không được để trống thông tin");
                }
                else
                {
                    if (tenQuan.Length > 20 || Regex.IsMatch(tenQuan, @"[^a-zA-Z0-9\s]"))
                    {
                        MessageBox.Show("Tên không được lớn hơn 50 kí tự và không có kí tự đặc biệt ngoại trừ khoảng trắng");
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            if (txttimkiem.Text.Length == 0)
                            {
                                SuaQuan();
                            }
                            else
                            {
                                SuaQuan(txtMaQuanID.Text);
                            }
                        }
                    }

                }
            }
            txtMaQuanID.Focus();
        }

        private void frmQuan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmQuan_KeyDown(object sender, KeyEventArgs e)
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
                        btnSua_Click(sender, e);
                        break;
                    case Keys.L:
                        btnLamMoi_Click(sender, e);
                        break;
                    case Keys.Q:
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
        }

        //private void frmQuan_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    frmChinh fc = new frmChinh();
        //    fc.Enabled = true;
        //}
    }
}
