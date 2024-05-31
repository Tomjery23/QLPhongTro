using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro.ChildForm
{
    public partial class frmDichVu : Form
    {
        private Database db;
        public frmDichVu()
        {
            db = new Database();
            InitializeComponent();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            LoadDSDV();

            dgvDV.Columns[1].HeaderText = "Tên dịch vụ";
            dgvDV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadDSDV()
        {
            

            var timKiem = txtTimKiem.Text.Trim();
            var lstPra = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@timKiem",
                    value = timKiem
                }
            };

            var dt = db.SelectData("LoadDSDV", lstPra);

            dgvDV.DataSource = dt;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(txtTenDV.Text.Trim().Length== 0)
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ","Ràng buộc dữ liệu!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }


            var lstPara = new List<CustomParameter>()
           {
               new CustomParameter()
               {
                   key = "@tenDV",
                   value = txtTenDV.Text
               }
           };
            if(db.ExeCute("ThemDV", lstPara) == 1)
            {

                MessageBox.Show("Thêm mới dịch vụ thành công!","Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDSDV();
                txtTenDV.Text = null;
            }
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSDV();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần cập nhật!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTenDV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var lstPara = new List<CustomParameter>()
           {
                new CustomParameter()
               {
                   key = "@id",
                   value = id.ToString()
               },
               new CustomParameter()
               {
                   key = "@tenDV",
                   value = txtTenDV.Text
               }
           };
            if (db.ExeCute("CapNhatDV", lstPara) == 1)
            {

                MessageBox.Show("Cập nhật dịch vụ thành công!","Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDSDV();
                txtTenDV.Text = null;
                id = -1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if(MessageBox.Show("Bạn có chắc muốn xóa dịch vụ này?","Xác nhận!!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPara = new List<CustomParameter>()
           {
                new CustomParameter()
               {
                   key = "@id",
                   value = id.ToString()
               }

           };
                if (db.ExeCute("XoaDV", lstPara) == 1)
                {

                    MessageBox.Show("Xóa dịch vụ thành công!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSDV();
                    txtTenDV.Text = null;
                    id = -1;
                }
            }
          
        }

        int id = -1;
        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                id = int.Parse(dgvDV.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenDV.Text = dgvDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
