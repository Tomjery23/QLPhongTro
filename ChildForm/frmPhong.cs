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
    public partial class frmPhong : Form
    {
        private Database db;
       
        private int rowIndex = -1;//biến lưu chỉ số phòng của phòng đc chọn
        public frmPhong()
        {
            InitializeComponent();
        }

       

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmXuLyPhong(null).ShowDialog();//truyền tham số null vào để xác định trường hợp thêm mới phòng
            LoadDsPhong();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadDsPhong();

            #region gui
            //dat lai ten cot
            dgvPhong.Columns["tenloaiphong"].HeaderText = "Loại phòng";
            dgvPhong.Columns["tenphong"].HeaderText = "Phòng";
            dgvPhong.Columns["dongia"].HeaderText = "Đơn giá";
            dgvPhong.Columns["trangthai"].HeaderText = "Trạng thái";

            //set kích thước các cột
            dgvPhong.Columns["id"].Width = 50;
            dgvPhong.Columns["tenloaiphong"].Width = 200;
            dgvPhong.Columns["dongia"].Width = 200;            
            dgvPhong.Columns["trangthai"].Width = 200;

            dgvPhong.Columns["tenphong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//cho cột tên phòng tự động co giãn theo form 


            //căn chỉnh vị trí của cột
            dgvPhong.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;//căn phải cho cột đơn giá

            //định dạng phần nghìn cho cột đơn giá phòng
            dgvPhong.Columns["dongia"].DefaultCellStyle.Format = "N0";
            #endregion
        }

        private void LoadDsPhong()
        {
            db = new Database();

            var timKiem = txtTimKiem.Text.Trim();
            var lstPra = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@timKiem",
                    value = timKiem
                }
            };

            var dt = db.SelectData("loadDsPhong", lstPra);

            dgvPhong.DataSource = dt;

        }

        private void dgvPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id phòng đc chọn
            var idPhong = dgvPhong.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            new frmXuLyPhong(idPhong).ShowDialog();//truyền idPhong đc chọn qua form frmXuLyPHong để xác định trường hợp cập nhật phòng
            LoadDsPhong();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id phòng cần xóa trong sự kiện cell click của datagridview
            rowIndex = e.RowIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //kiểm tra xem rowIndex có phải < 0 hay không
            //nếu < 0 có nghĩa chưa có phòng nào được chọn để xóa cả vì chỉ số dòng phải bắt đầu từ 0
            if (rowIndex<0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa","Chú ý!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;//nếu gặp trường hợp chưa có phòng nào đc chọn để xóa thì sẽ dừng chương trình ngang đây
            }

            //nếu có phòng được chọn để xóa ( ngược lại trường hợp trên) thì hiện câu hỏi xác nhận xóa
            if(MessageBox.Show("Bạn có chắc muốn xóa phòng "+dgvPhong.Rows[rowIndex].Cells["tenphong"].Value.ToString()+" hay không?","Xác nhận xóa phòng",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //tương tự, chúng ta cần truyền giá trị id phòng cần xóa vào proc vừa mới khai báo
                var lstPara = new List<CustomParameter>
                {
                    new CustomParameter
                    {
                        key = "@idPhong",
                        value = dgvPhong.Rows[rowIndex].Cells["ID"].Value.ToString()
                    }
                };
                var kq = db.ExeCute("deletePhong", lstPara);

                //hiển thị thông báo trong trường hợp xóa thành công
                if(kq == 1)
                {
                    MessageBox.Show("Xóa phòng thành công!","Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //sau khi xóa thành công thì load lại ds phòng hiện tại bằng cách gọi lại hàm  LoadDsPhong
                    LoadDsPhong();
                }
            }
        }
    }
}
