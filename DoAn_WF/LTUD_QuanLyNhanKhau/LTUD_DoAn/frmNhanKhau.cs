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
    public partial class frmNhanKhau : Form
    {
        public frmNhanKhau()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(new Link()._Link);
        SqlCommand cmdKP;
        private void frmNhanKhau_Load(object sender, EventArgs e)
        {
            dgvNhanKhau.DataSource = LayDSNhanKhau();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            this.KeyPreview = true;
            this.KeyDown += frmNhanKhau_KeyDown;
        }
        private DataTable LayDSNhanKhau()
        {
            SqlDataAdapter daNK;
            DataTable dsNK = new DataTable();
            try
            {
                //Mở database
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "Select_NhanKhau";
                cmdKP.CommandType = CommandType.StoredProcedure;
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
        private DataTable LayDSNhanKhau(string cccd)
        {
            SqlDataAdapter daNK;
            DataTable dsNK = new DataTable();
            try
            {
                //Mở database
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "TimCCCD";
                cmdKP.CommandType = CommandType.StoredProcedure;
                cmdKP.Parameters.AddWithValue("@CCCDID", txtTimKiem.Text);
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
        private DataTable LayDSNhanKhau_ten(string ten)
        {
            SqlDataAdapter daNK;
            DataTable dsNK = new DataTable();
            try
            {
                //Mở database
                con.Open();
                cmdKP = new SqlCommand();
                cmdKP.Connection = con;
                cmdKP.CommandText = "TimTen";
                cmdKP.CommandType = CommandType.StoredProcedure;
                cmdKP.Parameters.AddWithValue("@hoten", txtTimKiem.Text);
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

        private void dgvNhanKhau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCCCDID.ReadOnly = true;
        }
        string gioitinh = "";
        string timkiem = "";
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHoID.Text.Length == 0 || txtCCCDID.Text.Length == 0 || txtHoTen.Text.Length == 0 || gioitinh == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                string mahoid = txtMaHoID.Text.Trim();
                string tennk = txtHoTen.Text.Trim();
                string cccd = txtCCCDID.Text.Trim();
                string ngaysinh = dtpNgaySinh.Text.Trim();
                string gt = gioitinh;
                if (mahoid.Length == 0 || tennk.Length == 0 || cccd.Length == 0 || gt == "")
                {
                    MessageBox.Show("Không được để trống thông tin");
                }
                else
                {
                    bool flag1 = false;
                    for (int i = 0; i < dgvNhanKhau.Rows.Count - 1; i++)
                    {
                        if (cccd == dgvNhanKhau.Rows[i].Cells[0].Value.ToString().Trim())
                        {
                            flag1 = true;
                        }
                    }
                    if (flag1 == true)
                    {
                        MessageBox.Show("Căn cước công dân đã có người sử dụng");
                    }
                    else
                    {
                        bool flag2 = true;
                        for (int i = 0; i < cccd.Length; i++)
                        {
                            if (!char.IsDigit(cccd[i]))
                            {
                                flag2 = false;
                            }
                        }
                        if (flag2 == false || cccd.Length != 12)
                        {
                            MessageBox.Show("Căn cước công dân có 12 kí tự và chỉ chứa số");
                        }
                        else
                        {
                            if (tennk.Length > 50 || Regex.IsMatch(tennk, @"[^a-zA-Z0-9\s]"))
                            {
                                MessageBox.Show("Tên không được lớn hơn 50 kí tự và không có kí tự đặc biệt ngoại trừ khoảng trắng");
                            }
                            else
                            {
                                if (mahoid.Length > 10 || Regex.IsMatch(mahoid, @"[^a-zA-Z0-9]"))
                                {
                                    MessageBox.Show("Mã hộ không được lớn hơn 10 kí tự và không có kí tự đặc biệt");
                                }
                                else
                                {
                                    DialogResult dr = MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo);
                                    if (dr == DialogResult.Yes)
                                    {
                                        try
                                        {
                                            con.Open();
                                            cmdKP = new SqlCommand("execute Them_NhanKhau '" + cccd + "', '" + mahoid + "', '" + tennk + "', '" + gt + "', '" + ngaysinh + "'", con);
                                            cmdKP.ExecuteNonQuery();
                                            MessageBox.Show("Thêm nhân khẩu thành công");
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Thêm không thành công do hộ chưa tồn tại");
                                        }
                                        finally
                                        {
                                            con.Close();
                                            txtCCCDID.ReadOnly = false;
                                            txtCCCDID.Text = "";
                                            txtHoTen.Text = "";
                                            txtMaHoID.Text = "";
                                            gioitinh = "";
                                            rbNam.Checked = false;
                                            tbNu.Checked = false;
                                            dgvNhanKhau.DataSource = LayDSNhanKhau();
                                            btnSua.Enabled = false;
                                            btnXoa.Enabled = false;
                                            btnThem.Enabled = true;
                                            if (txtTimKiem.Text.Length > 0)
                                            {
                                                if (timkiem == "CCCD")
                                                {
                                                    dgvNhanKhau.DataSource = LayDSNhanKhau(txtTimKiem.Text);
                                                }
                                                if (timkiem == "ten")
                                                {
                                                    dgvNhanKhau.DataSource = LayDSNhanKhau_ten(txtTimKiem.Text);
                                                }
                                                if (timkiem == "")
                                                {
                                                    dgvNhanKhau.DataSource = LayDSNhanKhau();
                                                }
                                            }
                                            else
                                            {
                                                dgvNhanKhau.DataSource = LayDSNhanKhau();
                                            }
                                            txtCCCDID.Focus();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            gioitinh = "Nam";
        }

        private void tbNu_CheckedChanged(object sender, EventArgs e)
        {
            gioitinh = "Nu";
        }

        private void dgvNhanKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtCCCDID.ReadOnly = true;
            int chon;
            chon = dgvNhanKhau.CurrentRow.Index;
            txtMaHoID.Text = dgvNhanKhau.Rows[chon].Cells[1].Value.ToString().Trim();
            txtHoTen.Text = dgvNhanKhau.Rows[chon].Cells[2].Value.ToString().Trim();
            txtCCCDID.Text = dgvNhanKhau.Rows[chon].Cells[0].Value.ToString().Trim();
            if (dgvNhanKhau.Rows[chon].Cells[3].Value.ToString().Trim() != "Nam")
            {
                tbNu.Checked = true;
                gioitinh = "Nu";
            }
            else
            {
                rbNam.Checked = true;
                gioitinh = "Nam";
            }
            dtpNgaySinh.Text = dgvNhanKhau.Rows[chon].Cells[4].Value.ToString().Trim();

        }
        private void suaNhanKhau()
        {
            try
            {
                con.Open();
                cmdKP.Connection = con;
                cmdKP.CommandText = "Sua_NhanKhau";
                cmdKP.CommandType = CommandType.StoredProcedure;

                cmdKP.Parameters.AddWithValue("@CCCDID", txtCCCDID.Text);

                cmdKP.Parameters.AddWithValue("@MaHoID", txtMaHoID.Text);
                cmdKP.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmdKP.Parameters.AddWithValue("@GioiTinh", gioitinh);
                cmdKP.Parameters.AddWithValue("@NamSinh", dtpNgaySinh.Text);


                cmdKP.ExecuteNonQuery();
                MessageBox.Show("Sửa nhân khẩu thành công");
            }
            catch
            {
                MessageBox.Show("Sửa không thành công do hộ không tồn tại");
            }
            finally
            {
                con.Close();
                txtCCCDID.ReadOnly = false;
                txtCCCDID.Text = "";
                txtHoTen.Text = "";
                txtMaHoID.Text = "";
                gioitinh = "";
                rbNam.Checked = false;
                tbNu.Checked = false;
                dgvNhanKhau.DataSource = LayDSNhanKhau();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                if (txtTimKiem.Text.Length > 0)
                {
                    if (timkiem == "CCCD")
                    {
                        dgvNhanKhau.DataSource = LayDSNhanKhau(txtTimKiem.Text);
                    }
                    if (timkiem == "ten")
                    {
                        dgvNhanKhau.DataSource = LayDSNhanKhau_ten(txtTimKiem.Text);
                    }
                    if (timkiem == "")
                    {
                        dgvNhanKhau.DataSource = LayDSNhanKhau();
                    }
                }
                else
                {
                    dgvNhanKhau.DataSource = LayDSNhanKhau();
                }
            }
        }
        private void suaNhanKhau(string cccd)
        {
            try
            {
                con.Open();
                cmdKP.Connection = con;
                cmdKP = new SqlCommand("execute Sua_NhanKhau '" + txtCCCDID.Text + "','" + txtMaHoID.Text + "','" + txtHoTen.Text + "','" + gioitinh + "', '" + dtpNgaySinh.Text + "'", con);
                cmdKP.ExecuteNonQuery();
                MessageBox.Show("Sửa nhân khẩu thành công");
            }
            catch
            {
                MessageBox.Show("Sửa không thành công do hộ không tồn tại");
            }
            finally
            {
                con.Close();
                txtCCCDID.ReadOnly = false;
                txtCCCDID.Text = "";
                txtHoTen.Text = "";
                txtMaHoID.Text = "";
                gioitinh = "";
                rbNam.Checked = false;
                tbNu.Checked = false;
                dgvNhanKhau.DataSource = LayDSNhanKhau();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                if (txtTimKiem.Text.Length > 0)
                {
                    if (timkiem == "CCCD")
                    {
                        dgvNhanKhau.DataSource = LayDSNhanKhau(txtTimKiem.Text);
                    }
                    if (timkiem == "ten")
                    {
                        dgvNhanKhau.DataSource = LayDSNhanKhau_ten(txtTimKiem.Text);
                    }
                    if (timkiem == "")
                    {
                        dgvNhanKhau.DataSource = LayDSNhanKhau();
                    }
                }
                else
                {
                    dgvNhanKhau.DataSource = LayDSNhanKhau();
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHoID.Text.Length == 0 || txtCCCDID.Text.Length == 0 || txtHoTen.Text.Length == 0 || gioitinh == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                string mahoid = txtMaHoID.Text.Trim();
                string tennk = txtHoTen.Text.Trim();
                string cccd = txtCCCDID.Text.Trim();
                string ngaysinh = dtpNgaySinh.Text.Trim();
                string gt = gioitinh;
                if (mahoid.Length == 0 || tennk.Length == 0 || cccd.Length == 0 || gt == "")
                {
                    MessageBox.Show("Không được để trống thông tin");
                }
                else
                {
                    if (tennk.Length > 50 || Regex.IsMatch(tennk, @"[^a-zA-Z0-9\s]"))
                    {
                        MessageBox.Show("Tên không được lớn hơn 50 kí tự và không có kí tự đặc biệt ngoại trừ khoảng trắng");
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            if (txtTimKiem.Text.Length == 0)
                            {
                                suaNhanKhau();
                            }
                            else
                            {
                                suaNhanKhau(txtCCCDID.Text);
                            }
                        }
                    }

                }
            }
            txtCCCDID.Focus();
        }
        private void xoaNhanKhau()
        {
            try
            {
                con.Open();
                cmdKP.Connection = con;
                cmdKP = new SqlCommand("exec Xoa_NhanKhau '" + txtCCCDID.Text + "'", con);
                cmdKP.ExecuteNonQuery();
                MessageBox.Show("Xóa nhân khẩu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công" + ex);
            }
            finally
            {
                con.Close();
                txtCCCDID.ReadOnly = false;
                txtCCCDID.Text = "";
                txtHoTen.Text = "";
                txtMaHoID.Text = "";
                gioitinh = "";
                rbNam.Checked = false;
                tbNu.Checked = false;
                dgvNhanKhau.DataSource = LayDSNhanKhau();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                if (txtTimKiem.Text.Length > 0)
                {
                    if (timkiem == "CCCD")
                    {
                        dgvNhanKhau.DataSource = LayDSNhanKhau(txtTimKiem.Text);
                    }
                    if (timkiem == "ten")
                    {
                        dgvNhanKhau.DataSource = LayDSNhanKhau_ten(txtTimKiem.Text);
                    }
                    if (timkiem == "")
                    {
                        dgvNhanKhau.DataSource = LayDSNhanKhau();
                    }
                }
                else
                {
                    dgvNhanKhau.DataSource = LayDSNhanKhau();
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int chon;
            chon = dgvNhanKhau.CurrentRow.Index;
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                xoaNhanKhau();
            }
            else
            {

            }
            txtCCCDID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCCCDID.ReadOnly = false;
            txtCCCDID.Text = "";
            txtHoTen.Text = "";
            txtMaHoID.Text = "";
            gioitinh = "";
            rbNam.Checked = false;
            tbNu.Checked = false;
            dgvNhanKhau.DataSource = LayDSNhanKhau();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            txtTimKiem.Text = "";
            rdCCCD.Checked = false;
            rdTen.Checked = false;
            txtCCCDID.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {
                if (timkiem == "CCCD")
                {
                    dgvNhanKhau.DataSource = LayDSNhanKhau(txtTimKiem.Text);
                }
                if (timkiem == "ten")
                {
                    dgvNhanKhau.DataSource = LayDSNhanKhau_ten(txtTimKiem.Text);
                }
                if (timkiem == "")
                {
                    dgvNhanKhau.DataSource = LayDSNhanKhau();
                }
            }
            else
            {
                dgvNhanKhau.DataSource = LayDSNhanKhau();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timkiem = "CCCD";
            dgvNhanKhau.DataSource = LayDSNhanKhau(txtTimKiem.Text);
            if (txtTimKiem.Text.Length == 0)
            {
                dgvNhanKhau.DataSource = LayDSNhanKhau();
            }
        }

        private void rdTen_CheckedChanged(object sender, EventArgs e)
        {
            timkiem = "ten";
            dgvNhanKhau.DataSource = LayDSNhanKhau_ten(txtTimKiem.Text);
            if (txtTimKiem.Text.Length == 0)
            {
                dgvNhanKhau.DataSource = LayDSNhanKhau();
            }
        }

        private void frmNhanKhau_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmNhanKhau_KeyDown(object sender, KeyEventArgs e)
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
                        button1_Click(sender, e);
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

