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
    public partial class frmXuLyPhong : Form
    {
        private string idPhong;
        private Database db;
        public frmXuLyPhong(string idPhong)
        {
            this.idPhong = idPhong;
            
            InitializeComponent();
        }

        private void frmXuLyPhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadLoaiPhong();

            if (string.IsNullOrEmpty(idPhong))//nếu idphong đc truyền qua là null = trường hợp thêm mới
            {
                lblTitle.Text = "Thêm phòng mới";
            }
            else//nếu idphong khác null <=> trường hợp cập nhật thông tin phòng
            {
                lblTitle.Text = "Cập nhật thông tin phòng";

                //vì phòng được xác định qua id nên chúng ta cần truyền tham số là giá trị của id phòng vào
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idPhong",
                        value = idPhong
                    }
                };
                var phong = db.SelectData("[selectPhong]", lstPara).Rows[0];// sử dụng hàm selectdata trong class datatabase để lấy dữ liệu phòng

                //kết quả trả về là 1 datatable chỉ gồm 1 hàng chính là hàng có chỉ số hàng bằng 0

                //set các dữ liệu lấy đc cho các component trên form frmXyLyPhong
                cbbLoaiPhong.SelectedValue = phong["IDLoaiPhong"].ToString();//set id loại phòng cho combobox
                txtTenPhong.Text = phong["TenPhong"].ToString();//set giá trị tên phòng cho textbox txtTenPhong
                if(phong["trangthai"].ToString() == "1")//set trạng thái hoạt động cho checkbox ckbHoatDong
                {
                    ckbHoatDong.Checked = true;
                }else
                {
                    ckbHoatDong.Checked = false;
                }
            }
        }
        private void LoadLoaiPhong()
        {
            var dt = db.SelectData("loadDsLoaiPhong");
            cbbLoaiPhong.DataSource = dt;
            cbbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbbLoaiPhong.ValueMember = "ID";
        }
        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose(); //đóng form lại
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbbLoaiPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng","Chú ý!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            var idLoaiPhong = cbbLoaiPhong.SelectedValue.ToString();
            var tenPhong = txtTenPhong.Text.Trim();
            var trangThai = ckbHoatDong.Checked?1:0;

            if (string.IsNullOrEmpty(tenPhong))
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhong.Select();
                return;
            }


            if (string.IsNullOrEmpty(idPhong))//trường hợp thêm mới phòng không có idphong <=> null
            {
                var lstPra = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idLoaiPhong",
                        value = idLoaiPhong
                    },
                    new CustomParameter()
                    {
                        key = "@tenPhong",
                        value = tenPhong
                    },
                    new CustomParameter()
                    {
                        key = "@trangThai",
                        value = trangThai.ToString()
                    }
                };
                var rs = db.ExeCute("[themMoiPhong]",lstPra);
                if(rs == 1)
                {
                    MessageBox.Show("Thêm mới phòng thành công!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //reset lại các giá trị của component sau khi thêm mới thành công
                    txtTenPhong.Text = null;
                    cbbLoaiPhong.SelectedIndex = 0;
                }
            }else//trường hợp cập nhật phòng đã tồn tại <=> idPhong có giá trị # null
            {
                //xử lý trường hợp cập nhật khi click vào button btnXacNhan
                //bên proc có 4 tham số đầu vào
                //vì vậy ở đây chúng ta cũng cần truyền 4 tham số tương ứng
                var lstPara = new List<CustomParameter>()
               {
                   new CustomParameter
                   {
                       key = "@idPhong",
                       value = idPhong
                   },
                   new CustomParameter
                   {
                       key = "@tenPhong",
                       value = txtTenPhong.Text
                   },
                   new CustomParameter
                   {
                       key = "@idLoaiPhong",
                       value = cbbLoaiPhong.SelectedValue.ToString()
                   },
                   new CustomParameter
                   {
                       key = "@trangThai",
                       value = trangThai.ToString()
                   }
               };
                var kq = db.ExeCute("updatePhong", lstPara);
                if(kq == 1)
                {
                    MessageBox.Show("Cập nhật thông tin phòng thành công!","Successfully!",MessageBoxButtons.OK,MessageBoxIcon.Information);//hiện thông báo thành công
                    this.Dispose();//đóng form frmXyLyPhong
                }else
                {
                    MessageBox.Show("Cập nhật thông tin phòng không thành công!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);//hiện thông báo không thành công
                }
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
