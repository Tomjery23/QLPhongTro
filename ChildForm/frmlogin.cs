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

namespace QLPhongTro.ChildForm
{
    public partial class frmlogin : Form
    {
        SqlConnection sqlcon = null;
        public frmlogin()
        {
            InitializeComponent();

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(@"Data Source=DESKTOP-I7PBESM\SQLEXPRESS;Initial Catalog= QLPhongTro ;Integrated Security=True");
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            string tk = txtTk.Text.Trim();
            string mk = txtMK.Text.Trim();

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "SELECT * FROM tblQuanLy WHERE TaiKhoan = @tk AND MatKhau = @mk";
            sqlcmd.Parameters.AddWithValue("@tk", tk);
            sqlcmd.Parameters.AddWithValue("@mk", mk);
            sqlcmd.Connection = sqlcon;
            SqlDataReader data = sqlcmd.ExecuteReader();
            if (data.Read())
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                frmMain mainForm = new frmMain();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            // Đóng reader
            data.Close();
        }

        private void txtTk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
