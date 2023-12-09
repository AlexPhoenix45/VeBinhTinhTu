using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.Sach
{
    public partial class ChiTietSach : UserControl
    {
        public ChiTietSach(int Id)
        {
            InitializeComponent();
            loadNew(Id);
        }

        private void loadNew(int Id)
        {
            var s = new DAO.SqlToLinq.Sach().getById(Id);

            anhSach.ImageLocation = "D:\\LapTrinhWindow\\QuanLyThuVien\\MainForm\\Web\\Img\\" + s.AnhDaiDien;
            txtTen.Text = s.TenSach;
            txtMoTa.Text = s.MoTa;
            txtTG.Text = s.ListIdTacGia;
            txtTL.Text = s.IdTheLoai.ToString();
            txtNXB.Text = s.IdNhaXuatBan.ToString();
            txtNamXB.Text = s.NamXuatBan.ToString();
            txtSoLuong.Text = s.SoLuong.ToString();
            txtTaiBan.Text = s.TaiBan.ToString();
            txtGia.Text = s.GiaSach.ToString();
        }
    }
}
