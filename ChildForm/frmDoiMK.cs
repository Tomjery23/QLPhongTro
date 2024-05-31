using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLPhongTro.ChildForm
{
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection sqlcon = null;

        private void btndoiMK_Click(object sender, EventArgs e)
        {
            string tendangnhap = txttendangnhap.Text.Trim();
            string matkhaucu = txtmatkhaucu.Text.Trim();
            string matkhaumoi = txtmatkhaumoi.Text.Trim();
            string nhaplai = txtnhaplai.Text.Trim();

            if (matkhaumoi != nhaplai)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp");
                return;
            }

            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(@"Data Source=DESKTOP-I7PBESM\SQLEXPRESS;Initial Catalog=QLPhongTro;Integrated Security=True");
            }

            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "SELECT * FROM tblQuanLy WHERE TaiKhoan = @tk AND MatKhau = @matkhaucu";
            sqlcmd.Parameters.AddWithValue("@tk", tendangnhap);  // Sử dụng tên đăng nhập đã nhập
            sqlcmd.Parameters.AddWithValue("@matkhaucu", matkhaucu);
            sqlcmd.Connection = sqlcon;
            SqlDataReader data = sqlcmd.ExecuteReader();

            if (data.Read())
            {
                data.Close();
                SqlCommand updateCmd = new SqlCommand();
                updateCmd.CommandType = CommandType.Text;
                updateCmd.CommandText = "UPDATE tblQuanLy SET MatKhau = @matkhaumoi WHERE TaiKhoan = @tk";
                updateCmd.Parameters.AddWithValue("@tk", tendangnhap);
                updateCmd.Parameters.AddWithValue("@matkhaumoi", matkhaumoi);
                updateCmd.Connection = sqlcon;
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng");
            }

            // Đóng kết nối
            sqlcon.Close();
        }
    }
}
