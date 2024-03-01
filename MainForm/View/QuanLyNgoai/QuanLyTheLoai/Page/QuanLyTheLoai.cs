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
    public partial class QuanLyTheLoai : UserControl
    {
        public QuanLyTheLoai()
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}
            loadNew();
        }

        private void loadNew()
        {
            pnTable.Controls.Clear();
            var list = new DAO.SqlToLinq.TheLoai().getAll().Where(x => x.Status == 1).ToList();
            int stt = 1;
            foreach (var x in list)
            {
                var row = new View.QuanLyNgoai.ModelTheLoai(stt++, x);
                row.btnSua.Click += (sender, e) =>
                {
                    // Gọi phương thức CheckList và chuyển giá trị int vào
                    BtnSua_Click(sender, e, x.Id);
                };
                row.btnXoa.Click += (sender, e) =>
                {
                    // Gọi phương thức CheckList và chuyển giá trị int vào
                    BtnXoa_Click(sender, e, x.Id);
                };
                pnTable.Controls.Add(row);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var ttl = new View.QuanLyNgoai.ThemTheLoai();
            ttl.FormClosed += Ttg_FormClosed;

            ttl.Show();
        }
        private void Ttg_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TimKiem();
        }
        private void BtnXoa_Click(object sender, EventArgs e, int IdTL)
        {
            var tl = new DAO.SqlToLinq.TheLoai().getById(IdTL);
            if (tl != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại " + tl.TenTheLoai + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra xem người dùng đã chọn Yes hay No
                if (result == DialogResult.Yes)
                {
                    var checkSach = new DAO.SqlToLinq.Sach().getByIdTheLoai(IdTL);

                    if (checkSach != null)
                    {
                        var tb = "Sách thuộc thể loại hiện hoạt:\n";

                        foreach (var t in checkSach)
                        {
                            tb += "\t- " + t.TenSach + "\n";
                        }

                        MessageBox.Show(tb, "Xóa thất bại!");
                    }
                    else
                    {
                        tl.Status = -1;
                        if (new DAO.SqlToLinq.TheLoai().Update(tl))
                        {
                            MessageBox.Show("Đã xóa!");
                            loadNew();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void BtnSua_Click(object sender, EventArgs e, int IdTL)
        {
            var tl = new DAO.SqlToLinq.TheLoai().getById(IdTL);

            var stl = new View.QuanLyNgoai.SuaTheLoai(tl);
            stl.FormClosed += Ttg_FormClosed;
            stl.Show();
        }
        private void TimKiem()
        {
            var ten = txtTen.Text.Trim().ToLower();
            int stt = 1;
            pnTable.Controls.Clear();
            foreach (var x in new DAO.SqlToLinq.TheLoai().getAll().Where(x => x.Status == 1 && x.TenTheLoai.ToLower().Contains(ten)))
            {
                var row = new View.QuanLyNgoai.ModelTheLoai(stt++, x);
                row.btnSua.Click += (sender, e) =>
                {
                    BtnSua_Click(sender, e, x.Id);
                };
                row.btnXoa.Click += (sender, e) =>
                {
                    BtnXoa_Click(sender, e, x.Id);
                };
                pnTable.Controls.Add(row);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
