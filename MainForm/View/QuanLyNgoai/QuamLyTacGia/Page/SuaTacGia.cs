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
    public partial class SuaTacGia : Form
    {
        private Models.TacGia tg;
        public SuaTacGia(Models.TacGia tg)
        {
            InitializeComponent();
            this.tg = tg;

            LoadNew();
        }

        private void LoadNew()
        {
            txtTen.Text = tg.TenTacGia.ToString();
            txtDiaChi.Text = tg.DiaChi.ToString();
            txtChucDanh.Text = tg.ChucDanh.ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var ten = txtTen.Text;
            var diachi = txtDiaChi.Text;
            var chucdanh = txtChucDanh.Text;

            if (ten != string.Empty && diachi != string.Empty && chucdanh != string.Empty)
            {
                var TG = new DAO.SqlToLinq.TacGia().getById(tg.Id);

                TG.TenTacGia = ten;
                TG.DiaChi = diachi;
                TG.ChucDanh = chucdanh;

                if (new DAO.SqlToLinq.TacGia().Update(TG))
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
    }
}
