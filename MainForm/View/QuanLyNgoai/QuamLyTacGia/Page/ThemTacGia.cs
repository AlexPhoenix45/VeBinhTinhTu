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
    public partial class ThemTacGia : Form
    {
        public ThemTacGia()
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var ten = txtTen.Text;
            var diachi = txtDiaChi.Text;
            var chucdanh = txtChucDanh.Text;

            if (ten != string.Empty && diachi != string.Empty && chucdanh != string.Empty)
            {
                var TG = new Models.TacGia()
                {
                    TenTacGia = ten,
                    DiaChi = diachi,
                    ChucDanh = chucdanh,
                    Status = 1
                };

                if (new DAO.SqlToLinq.TacGia().Insert(TG))
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
