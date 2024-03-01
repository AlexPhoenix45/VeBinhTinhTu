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
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}

            var ACT = new DAO.SqlToLinq.Action().getAllByIdUser();

            var xoa = ACT.Where(x => x.Status == 1 && x.Name.Equals("XoaSach")).FirstOrDefault();

            if (xoa == null)
            {
                btnXoa.Visible = false;
            }


            var sua = ACT.Where(x => x.Status == 1 && x.Name.Equals("SuaSach")).FirstOrDefault();

            if (sua == null)
            {
                btnSua.Visible = false;
            }

            IdSach = Id;
            loadNew(Id);
        }

        public event EventHandler ReloadXoaSachComplete;

        private void loadNew(int Id)
        {
            var s = new DAO.SqlToLinq.Sach().getById(Id);

            anhSach.ImageLocation = "D:\\LapTrinhWindow\\QuanLyThuVien\\MainForm\\Web\\Img\\AnhSach\\" + s.AnhDaiDien;
            txtTen.Text = s.TenSach;
            txtMoTa.Text = s.MoTa;

            var tg = "";
            int i = 0;
            foreach (var x in s.ListIdTacGia.Split(','))
            {
                if (i == 0)
                {
                    tg += new DAO.SqlToLinq.TacGia().getById(int.Parse(x)).TenTacGia;
                    i++;
                }
                else
                {
                    tg += ", " + new DAO.SqlToLinq.TacGia().getById(int.Parse(x)).TenTacGia;
                }
            }

            txtTG.Text = tg;
            txtTL.Text = new DAO.SqlToLinq.TheLoai().getById(s.IdTheLoai).TenTheLoai.ToString();
            txtNXB.Text = new DAO.SqlToLinq.NhaXuatBan().getById(s.IdTheLoai).TenNhaXuatBan.ToString();
            txtNamXB.Text = s.NamXuatBan.ToString();
            txtSoLuong.Text = s.SoLuong.ToString();
            txtConLai.Text = (s.SoLuong - new DAO.SqlToLinq.ChiTietMuon().tongSach(IdSach)).ToString();
            txtTaiBan.Text = s.TaiBan.ToString();
            txtGia.Text = s.GiaSach.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var sua = new View.QuanLySach.SuaSach(IdSach);

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
                    ReloadXoaSachComplete?.Invoke(this, e);
                }
            }
        }
    }
}
