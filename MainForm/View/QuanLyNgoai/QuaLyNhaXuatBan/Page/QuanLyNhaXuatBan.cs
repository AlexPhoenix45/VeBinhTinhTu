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
    public partial class QuanLyNhaXuatBan : UserControl
    {
        public QuanLyNhaXuatBan()
        {
            InitializeComponent();
            loadNew();
        }

        private void loadNew()
        {
            pnTable.Controls.Clear();
            var list = new DAO.SqlToLinq.NhaXuatBan().getAll().Where(x => x.Status == 1).ToList();
            int stt = 1;
            foreach (var x in list)
            {
                var row = new View.QuanLyNgoai.ModelNhaXuatBan(stt++, x);
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

        private void BtnXoa_Click(object sender, EventArgs e, int IDNXB)
        {
            var nxb = new DAO.SqlToLinq.NhaXuatBan().getById(IDNXB);
            if (nxb != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà xuất bản " + nxb.TenNhaXuatBan + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra xem người dùng đã chọn Yes hay No
                if (result == DialogResult.Yes)
                {
                    var checkSach = new DAO.SqlToLinq.Sach().getByIdNXB(IDNXB);

                    if (checkSach != null)
                    {
                        var tb = "Sách thuộc nhà xuất bản hiện hoạt:\n";

                        foreach (var t in checkSach)
                        {
                            tb += "\t- " + t.TenSach + "\n";
                        }

                        MessageBox.Show(tb, "Xóa thất bại!");
                    }
                    else
                    {
                        nxb.Status = -1;
                        if (new DAO.SqlToLinq.NhaXuatBan().Update(nxb))
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

        private void BtnSua_Click(object sender, EventArgs e, int IDNXB)
        {
            var nxb = new DAO.SqlToLinq.NhaXuatBan().getById(IDNXB);

            var stg = new View.QuanLyNgoai.SuaNhaXuatBan(nxb);
            stg.FormClosed += Ttg_FormClosed;
            stg.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var ttg = new View.QuanLyNgoai.ThemNhaXuatBan();
            ttg.FormClosed += Ttg_FormClosed;

            ttg.Show();
        }
        private void Ttg_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TimKiem();
        }
        private void TimKiem()
        {
            var ten = txtTen.Text.Trim().ToLower();
            int stt = 1;
            pnTable.Controls.Clear();
            foreach (var x in new DAO.SqlToLinq.NhaXuatBan().getAll().Where(x => x.Status == 1 && x.TenNhaXuatBan.ToLower().Contains(ten)))
            {
                var row = new View.QuanLyNgoai.ModelNhaXuatBan(stt++, x);
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
