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
    public partial class SuaTheLoai : Form
    {
        private Models.TheLoai tl;
        public SuaTheLoai(Models.TheLoai tl)
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}
            this.tl = tl;
            loadNew();
        }

        private void loadNew()
        {
            txtTen.Text = tl.TenTheLoai.ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var ten = txtTen.Text;
            if(ten != string.Empty)
            {
                var TL = new DAO.SqlToLinq.TheLoai().getById(tl.Id);
                TL.TenTheLoai = ten;
                if(new DAO.SqlToLinq.TheLoai().Update(TL))
                {
                    MessageBox.Show("Sửa thành công");

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
