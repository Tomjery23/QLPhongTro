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
    public partial class frmBanQuyen : Form
    {
        private bool isAdmin;
        public frmBanQuyen()
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
        }
        SqlConnection sqlcon = null;

        
        private void LoadData()
        {
            try
            {
                // Open connection
                sqlcon.Open();

                string query;
                if (isAdmin)
                {
                    // If user is admin, show all licenses
                    query = @"
                        SELECT l.ID, l.SoBanQuyen, l.NgayCap, l.NgayHetHan, p.TenPhong
                        FROM tblBanQuyen l
                        JOIN tblPhong p ON l.PhongID = p.ID";
                }
                else
                {
                    // If user is not admin, show licenses for their specific room
                    query = @"
                        SELECT l.ID, l.SoBanQuyen, l.NgayCap, l.NgayHetHan
                        FROM tblBanQuyen l
                        JOIN tblPhong p ON l.PhongID = p.ID
                        WHERE p.TenPhong = @TenPhong";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlcon);
                if (!isAdmin)
                {
                    // If user is not admin, pass room name as parameter
                    adapter.SelectCommand.Parameters.AddWithValue("@TenPhong", "Tên phòng của người dùng");
                }

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Set column headers
                guna2DataGridView1.AutoGenerateColumns = false;
                guna2DataGridView1.Columns.Clear();

                guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "ID",
                    DataPropertyName = "ID"
                });
                guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Số Bản Quyền",
                    DataPropertyName = "SoBanQuyen"
                });
                guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Ngày Cấp",
                    DataPropertyName = "NgayCap"
                });
                guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Ngày Hết Hạn",
                    DataPropertyName = "NgayHetHan"
                });
                if (isAdmin)
                {
                    guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Tên Phòng",
                        DataPropertyName = "TenPhong"
                    });
                }

                // Display data in DataGridView
                guna2DataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Close connection
                sqlcon.Close();
            }
        }
        private void frmBanQuyen_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-I7PBESM\SQLEXPRESS;Initial Catalog=QLPhongTro;Integrated Security=True";
            sqlcon = new SqlConnection(connectionString);
            LoadData();
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
