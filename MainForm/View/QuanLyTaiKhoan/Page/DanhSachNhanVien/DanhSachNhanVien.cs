using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyTaiKhoan
{
    public partial class DanhSachNhanVien : UserControl
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}
            loadNew();
        }
        private void loadNew()
        {
            pntable.Controls.Clear();

            int stt = 1;
            foreach (var x in new DAO.SqlToLinq.NhanVien().getAll().Where(x => x.Status == 1))
            {
                var row = new View.QuanLyTaiKhoan.ModelQLTaiKhoan();

                row.lblSTT.Text = stt++.ToString();
                row.Ten.Text = new DAO.SqlToLinq.Users().getById(x.IdUser).TaiKhoan;
                row.Ma.Text = x.MaNhanVien;

                pntable.Controls.Add(row);
            }
        }


        private void TTK_FormClosed(object? sender, FormClosedEventArgs e)
        {
            loadNew();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            pntable.Controls.Clear();

            int stt = 1;
            foreach (var x in new DAO.SqlToLinq.NhanVien().getAll().Where(x => x.Status == 1 && (x.MaNhanVien.ToLower().Contains(textBox1.Text.ToLower())
                                                                                                || new DAO.SqlToLinq.Users().getById(x.IdUser).TaiKhoan.ToLower().Contains(textBox1.Text.ToLower()))))
            {
                var row = new View.QuanLyTaiKhoan.ModelQLTaiKhoan();

                row.lblSTT.Text = stt++.ToString();
                row.Ten.Text = new DAO.SqlToLinq.Users().getById(x.IdUser).TaiKhoan;
                row.Ma.Text = x.MaNhanVien;

                pntable.Controls.Add(row);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var TTK = new View.QuanLyTaiKhoan.ThemTaiKhoan(2);
            TTK.FormClosed += TTK_FormClosed;


            TTK.Show();
        }
    }

}
