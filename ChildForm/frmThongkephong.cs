using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro.ChildForm
{
    public partial class frmThongkephong : Form
    {
        public frmThongkephong()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = null;
        private void frmThongkephong_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-I7PBESM\SQLEXPRESS;Initial Catalog=QLPhongTro;Integrated Security=True";
            sqlcon = new SqlConnection(connectionString);
            LoadData();

        }
        private void LoadData()
        {
            try
            {
                // Mở kết nối
                sqlcon.Open();

                // Truy vấn SQL
                string query = "SELECT * FROM tblPhong"; // Thay thế "TenBangPhieuThue" bằng tên bảng chứa thông tin phiếu thuê của bạn
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Hiển thị dữ liệu lên DataGridView
                guna2DataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối
                sqlcon.Close();
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
