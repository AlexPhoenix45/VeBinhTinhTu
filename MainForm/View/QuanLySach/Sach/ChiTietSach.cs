using MainForm.View.QuanLySach.Sach;
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
        private int IdSach;
        public ChiTietSach(int Id)
        {
            InitializeComponent();
            IdSach = Id;
            loadNew(Id);
        }

        public event EventHandler XoaSachComplete;

        private void loadNew(int Id)
        {
            var s = new DAO.SqlToLinq.Sach().getById(Id);

            anhSach.ImageLocation = "D:\\LapTrinhWindow\\QuanLyThuVien\\MainForm\\Web\\Img\\AnhSach\\" + s.AnhDaiDien;
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            var sua = new SuaSach(IdSach);

            sua.InsertComplete += sua_InsertComplete;
            sua.Show();
        }

        private void sua_InsertComplete(object sender, bool isSuccess)
        {
            if (isSuccess)
            {
                loadNew(IdSach);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var sach = new DAO.SqlToLinq.Sach().getById(IdSach);
                sach.Status = -1;

                if (new DAO.SqlToLinq.Sach().Update(sach))
                {
                    MessageBox.Show("Xóa Thành Công");
                    XoaSachComplete?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XoaSachComplete?.Invoke(this, EventArgs.Empty);
        }
    }
}
