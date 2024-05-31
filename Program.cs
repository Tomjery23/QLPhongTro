using QLPhongTro.ChildForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro
{
    static class Program
    {
       
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Hiển thị form đăng nhập
                frmlogin loginForm = new frmlogin();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Nếu đăng nhập thành công, hiển thị form chính
                    Application.Run(new frmMain());
                }
                else
                {
                    // Nếu đăng nhập thất bại hoặc bị hủy, thoát ứng dụng
                    Application.Exit();
                }
            }
        }
    }
