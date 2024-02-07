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
    public partial class QuanLyTacGia : UserControl
    {
        public QuanLyTacGia()
        {
            InitializeComponent();
            loadNew();
        }
        private void loadNew()
        {
            pnTable.Controls.Clear();
            var list = new DAO.SqlToLinq.TacGia().getAll().Where(x => x.Status == 1).ToList();
            int stt = 1;
            foreach (var x in list)
            {
                var row = new View.QuanLyNgoai.ModelTacGia(stt++, x);
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
            var ttg = new View.QuanLyNgoai.ThemTacGia();
            ttg.FormClosed += Ttg_FormClosed;

            ttg.Show();
        }

        private void Ttg_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TimKiem();
        }

        private void BtnXoa_Click(object? sender, EventArgs e, int IdTG)
        {
            var tg = new DAO.SqlToLinq.TacGia().getById(IdTG);
            if (tg != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả " + tg.TenTacGia + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra xem người dùng đã chọn Yes hay No
                if (result == DialogResult.Yes)
                {
                    // Người dùng đã chọn Yes, thực hiện xóa
                    tg.Status = 0;
                    if (new DAO.SqlToLinq.TacGia().Update(tg))
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
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void BtnSua_Click(object? sender, EventArgs e, int IdTG)
        {
            var tg = new DAO.SqlToLinq.TacGia().getById(IdTG);

            var stg = new View.QuanLyNgoai.SuaTacGia(tg);
            stg.FormClosed += Ttg_FormClosed;
            stg.Show();
        }

        private void TimKiem()
        {
            var ten = txtTen.Text.Trim().ToLower();
            int stt = 1;
            pnTable.Controls.Clear();
            foreach (var x in new DAO.SqlToLinq.TacGia().getAll().Where(x => x.Status == 1 && x.TenTacGia.ToLower().Contains(ten)))
            {
                var row = new View.QuanLyNgoai.ModelTacGia(stt++, x);
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
    }

}
