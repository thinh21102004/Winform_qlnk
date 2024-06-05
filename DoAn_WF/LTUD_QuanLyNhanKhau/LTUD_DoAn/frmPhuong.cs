using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LTUD_DoAn
{
    public partial class frmPhuong : Form
    {
        public frmPhuong()
        {
            InitializeComponent();
        }
        string timkiem = "";
        SqlConnection con = new SqlConnection(new Link()._Link);
        SqlCommand cmdKP;
        public DataTable LayDSPhuong()
        {
            DataTable dsp = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter();
            try
            {
                //mo db
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_LayDSPhuong";
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
        public DataTable LayDSPhuong(string ma)
        {
            DataTable dsp = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter();
            try
            {
                //mo db
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_timphuong_ma";
                cmdKP.CommandType = CommandType.StoredProcedure;
                cmdKP.Parameters.AddWithValue("@maphuong", ma);
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
        public DataTable LayDSPhuong_ten(string ten)
        {
            DataTable dsp = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter();
            try
            {
                //mo db
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "sp_timphuong_ten";
                cmdKP.CommandType = CommandType.StoredProcedure;
                cmdKP.Parameters.AddWithValue("@tenphuong", ten);
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
        private void dgvPhuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chon;
            chon = dgvPhuong.CurrentRow.Index;
            txtMaPhuongID.Text = dgvPhuong.Rows[chon].Cells[0].Value.ToString().Trim();
            txtTenPhuong.Text = dgvPhuong.Rows[chon].Cells[1].Value.ToString().Trim();
            txtMaQuanID.Text = dgvPhuong.Rows[chon].Cells[2].Value.ToString().Trim();
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenPhuong.Text = "";
            txtMaQuanID.Text = "";
            txtMaPhuongID.Text = "";
        }

        private void frmPhuong_Load(object sender, EventArgs e)
        {
            dgvPhuong.DataSource = LayDSPhuong();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            this.KeyPreview = true;
            this.KeyDown += frmPhuong_KeyDown;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhuongID.Text.Length == 0 || txtMaQuanID.Text.Length == 0 || txtTenPhuong.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                string maPhuongID = txtMaPhuongID.Text.Trim();
                string tenPhuong = txtTenPhuong.Text.Trim();
                string maQuanID = txtMaQuanID.Text.Trim();
                if (maPhuongID.Length == 0 || tenPhuong.Length == 0 || maQuanID.Length == 0)
                {
                    MessageBox.Show("Không được để trống thông tin");
                }
                else
                {
                    bool flag1 = false;
                    for (int i = 0; i < dgvPhuong.Rows.Count - 1; i++)
                    {
                        if (maPhuongID == dgvPhuong.Rows[i].Cells[0].Value.ToString().Trim())
                        {
                            flag1 = true;
                        }
                    }
                    if (flag1 == true)
                    {
                        MessageBox.Show("Mã phường đã được sử dụng");
                    }
                    else
                    {

                        if (maPhuongID.Length > 10 || Regex.IsMatch(maQuanID, @"[^a-zA-Z0-9]"))
                        {
                            MessageBox.Show("Mã Phường không được lớn hơn 10 kí tự và không có kí tự đặc biệt");
                        }

                        else
                        {
                            if (tenPhuong.Length > 20 || Regex.IsMatch(tenPhuong, @"[^a-zA-Z0-9\s]"))
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
                                        cmdKhuPho.CommandText = "sp_ThemPhuong";
                                        cmdKhuPho.CommandType = CommandType.StoredProcedure;

                                        // Thêm các tham số vào SqlCommand
                                        cmdKhuPho.Parameters.AddWithValue("@TenPhuong", txtTenPhuong.Text);
                                        cmdKhuPho.Parameters.AddWithValue("@maquan", txtMaQuanID.Text);
                                        cmdKhuPho.Parameters.AddWithValue("@MaPhuong", txtMaPhuongID.Text);

                                        // Thực thi câu lệnh
                                        cmdKhuPho.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Thêm thành công");

                                        txtMaPhuongID.Text = "";
                                        txtMaQuanID.Text = "";
                                        txtTenPhuong.Text = "";
                                        txtMaPhuongID.ReadOnly = false;
                                        txtMaPhuongID.Focus();
                                        btnThem.Enabled = true;
                                        btnXoa.Enabled = false;
                                        btnSua.Enabled = false;

                                        if (txttimkiem.Text.Length > 0)
                                        {
                                            if (timkiem == "ma")
                                            {
                                                dgvPhuong.DataSource = LayDSPhuong(txttimkiem.Text);
                                            }
                                            if (timkiem == "ten")
                                            {
                                                dgvPhuong.DataSource = LayDSPhuong_ten(txttimkiem.Text);
                                            }
                                            if (timkiem == "")
                                            {
                                                dgvPhuong.DataSource = LayDSPhuong();
                                            }
                                        }
                                        else
                                        {
                                            dgvPhuong.DataSource = LayDSPhuong();
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        con.Close();
                                        MessageBox.Show("Quận không tồn tại");
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    //Mở db
                    con.Open();

                    // Khởi tạo và cấu hình SqlCommand
                    SqlCommand cmdKhuPho = new SqlCommand();
                    cmdKhuPho.Connection = con;
                    cmdKhuPho.CommandText = "sp_XoaPhuong";
                    cmdKhuPho.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số vào SqlCommand
                    cmdKhuPho.Parameters.AddWithValue("@maphuong", txtMaPhuongID.Text);

                    // Thực thi câu lệnh
                    cmdKhuPho.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Xóa thành công!");

                    txtMaPhuongID.Text = "";
                    txtMaQuanID.Text = "";
                    txtTenPhuong.Text = "";
                    txtMaPhuongID.ReadOnly = false;
                    txtMaPhuongID.Focus();
                    btnThem.Enabled = true;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;

                    if (txttimkiem.Text.Length > 0)
                    {
                        if (timkiem == "ma")
                        {
                            dgvPhuong.DataSource = LayDSPhuong(txttimkiem.Text);
                        }
                        if (timkiem == "ten")
                        {
                            dgvPhuong.DataSource = LayDSPhuong_ten(txttimkiem.Text);
                        }
                        if (timkiem == "")
                        {
                            dgvPhuong.DataSource = LayDSPhuong();
                        }
                    }
                    else
                    {
                        dgvPhuong.DataSource = LayDSPhuong();
                    }

                }
                catch (Exception)
                {
                    con.Close();
                    MessageBox.Show("Xóa không thành công do vẫn còn khu phố");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhuongID.Text.Length == 0 || txtTenPhuong.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                string maphuong = txtMaPhuongID.Text.Trim();
                string tenphuong = txtTenPhuong.Text.Trim();
                if (tenphuong.Length == 0 || maphuong.Length == 0)
                {
                    MessageBox.Show("Không được để trống thông tin");
                }
                else
                {
                    if (tenphuong.Length > 20 || Regex.IsMatch(tenphuong, @"[^a-zA-Z0-9\s]"))
                    {
                        MessageBox.Show("Tên phường không được lớn hơn 20 kí tự và không có kí tự đặc biệt ngoại trừ khoảng trắng");
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {

                            try
                            {
                                //Mở db
                                con.Open();

                                // Khởi tạo và cấu hình SqlCommand
                                SqlCommand cmdKhuPho = new SqlCommand();
                                cmdKhuPho.Connection = con;
                                cmdKhuPho.CommandText = "sp_SuaPhuong";
                                cmdKhuPho.CommandType = CommandType.StoredProcedure;

                                // Thêm các tham số vào SqlCommand
                                cmdKhuPho.Parameters.AddWithValue("@tenphuong", txtTenPhuong.Text);
                                cmdKhuPho.Parameters.AddWithValue("@maquan", txtMaQuanID.Text);
                                cmdKhuPho.Parameters.AddWithValue("@maphuong", txtMaPhuongID.Text);

                                // Thực thi câu lệnh
                                cmdKhuPho.ExecuteNonQuery();

                                MessageBox.Show("Sửa thành công!");
                                con.Close();

                                txtMaPhuongID.Text = "";
                                txtMaQuanID.Text = "";
                                txtTenPhuong.Text = "";
                                txtMaPhuongID.ReadOnly = false;
                                txtMaPhuongID.Focus();
                                btnThem.Enabled = true;
                                btnXoa.Enabled = false;
                                btnSua.Enabled = false;

                                if (txttimkiem.Text.Length > 0)
                                {
                                    if (timkiem == "ma")
                                    {
                                        dgvPhuong.DataSource = LayDSPhuong(txttimkiem.Text);
                                    }
                                    if (timkiem == "ten")
                                    {
                                        dgvPhuong.DataSource = LayDSPhuong_ten(txttimkiem.Text);
                                    }
                                    if (timkiem == "")
                                    {
                                        dgvPhuong.DataSource = LayDSPhuong();
                                    }
                                }
                                else
                                {
                                    dgvPhuong.DataSource = LayDSPhuong();
                                }

                            }
                            catch (Exception)
                            {
                                con.Close();
                                MessageBox.Show("Quận không tồn tại");
                            }
                        }
                    }
                }
            }
        }

        private void frmPhuong_FormClosing(object sender, FormClosingEventArgs e)
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
        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timkiem = "ma";
            if (txttimkiem.Text.Length > 0)
            {
                if (timkiem == "ma")
                {
                    dgvPhuong.DataSource = LayDSPhuong(txttimkiem.Text);
                }
                if (timkiem == "ten")
                {
                    dgvPhuong.DataSource = LayDSPhuong_ten(txttimkiem.Text);
                }
                if (timkiem == "")
                {
                    dgvPhuong.DataSource = LayDSPhuong();
                }
            }
            else
            {
                dgvPhuong.DataSource = LayDSPhuong();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            timkiem = "ten";
            if (txttimkiem.Text.Length > 0)
            {
                if (timkiem == "ma")
                {
                    dgvPhuong.DataSource = LayDSPhuong(txttimkiem.Text);
                }
                if (timkiem == "ten")
                {
                    dgvPhuong.DataSource = LayDSPhuong_ten(txttimkiem.Text);
                }
                if (timkiem == "")
                {
                    dgvPhuong.DataSource = LayDSPhuong();
                }
            }
            else
            {
                dgvPhuong.DataSource = LayDSPhuong();
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Length > 0)
            {
                if (timkiem == "ma")
                {
                    dgvPhuong.DataSource = LayDSPhuong(txttimkiem.Text);
                }
                if (timkiem == "ten")
                {
                    dgvPhuong.DataSource = LayDSPhuong_ten(txttimkiem.Text);
                }
                if (timkiem == "")
                {
                    dgvPhuong.DataSource = LayDSPhuong();
                }
            }
            else
            {
                dgvPhuong.DataSource = LayDSPhuong();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaPhuongID.Text = "";
            txtMaQuanID.Text = "";
            txtTenPhuong.Text = "";
            txtMaPhuongID.ReadOnly = false;
            txtMaPhuongID.Focus();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txttimkiem.Text = "";
            rbma.Checked = false;
            rbten.Checked = false;
            timkiem = "";
            dgvPhuong.DataSource = LayDSPhuong();
        }

        private void frmPhuong_KeyDown(object sender, KeyEventArgs e)
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
    }
}
