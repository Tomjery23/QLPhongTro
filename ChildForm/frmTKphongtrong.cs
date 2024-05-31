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
    public partial class frmTKphongtrong : Form
    {
        SqlConnection sqlcon = null;
        public frmTKphongtrong()
        {
            InitializeComponent();
        }

        private void dataPtrong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTKphongtrong_Load(object sender, EventArgs e)
        {
            // Kết nối đến cơ sở dữ liệu
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

                // Truy vấn SQL để lấy danh sách các phòng trống
                string query = "SELECT * FROM tblPhong WHERE TrangThai = 0"; // Giả sử 'TrangThai' là cột xác định trạng thái của phòng
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Hiển thị dữ liệu lên DataGridView
                dataPtrong.DataSource = dt;
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
    }
}
