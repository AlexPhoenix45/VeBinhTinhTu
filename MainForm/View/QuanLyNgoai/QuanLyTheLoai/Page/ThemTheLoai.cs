using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyNgoai
{
    public partial class ThemTheLoai : Form
    {
        public ThemTheLoai()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var ten = txtTen.Text;
            if(ten != string.Empty )
            {
                var TL = new Models.TheLoai()
                {
                    TenTheLoai = ten,
                    Status = 1
                };
                if(new DAO.SqlToLinq.TheLoai().Insert(TL) )
                {
                    MessageBox.Show("Thêm thành công");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu!");
            
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
