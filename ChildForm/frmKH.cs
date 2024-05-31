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
    public partial class frmKH : Form
    {
        private Database db;
        public frmKH()
        {
            db = new Database();
            InitializeComponent();
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var ho = txtHo.Text.Trim();
            var tenDem = txtTenDem.Text.Trim();
            var ten = txtTen.Text.Trim();
            var dienThoai = txtDienThoai.Text.Trim();
            var cmnd = txtCMND.Text.Trim();
            var qq = txtQueQuan.Text.Trim();
            var hktt = txtHKTT.Text.Trim();

            //ràng buộc dữ liệu
            if (string.IsNullOrEmpty(ho) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(hktt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Ràng buộc thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //thỏa mãn ràng buộc dữ liệu -> thêm mới khách hàng
            var listP = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@ho",
                    value = ho
                },
                 new CustomParameter
                {
                    key = "@tenDem",
                    value = tenDem
                },
                  new CustomParameter
                {
                    key = "@ten",
                    value = ten
                },
                   new CustomParameter
                {
                    key = "@dienThoai",
                    value = dienThoai
                },
                    new CustomParameter
                {
                    key = "@cmnd",
                    value = cmnd
                },
                     new CustomParameter
                {
                    key = "@hktt",
                    value = hktt
                },
                      new CustomParameter
                     {
                    key = "@qq",
                    value = qq
                }
            };
            var rs = db.ExeCute("ThemKH", listP);
            if(rs == 1)
            {
                MessageBox.Show("Thêm mới khách hàng thành công!","SUCCESSFULLY",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
