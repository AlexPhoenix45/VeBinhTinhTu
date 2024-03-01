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
    public partial class SuaNhaXuatBan : Form
    {
        private Models.NhaXuatBan nxb;

        public SuaNhaXuatBan(Models.NhaXuatBan nxb)
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}
            this.nxb = nxb;
            loadNew();

        }
        private void loadNew()
        {
            txtTen.Text = nxb.TenNhaXuatBan.ToString();
            txtDiaChi.Text = nxb.DiaChi.ToString();
            txtNgay.Value = nxb.NgayThanhLap.ToLocalTime();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var ten = txtTen.Text;
            var diachi = txtDiaChi.Text;
            var ngay = txtNgay.Value;
            if(ten != string.Empty &&  diachi != string.Empty)
            {
                var NXB = new DAO.SqlToLinq.NhaXuatBan().getById(nxb.Id);
                NXB.TenNhaXuatBan = ten;
                NXB.DiaChi = diachi;
                NXB.NgayThanhLap = ngay;
                if(new DAO.SqlToLinq.NhaXuatBan().Update(NXB))
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
