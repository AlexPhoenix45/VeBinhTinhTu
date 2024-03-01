using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyChucNang 
{
    public partial class QuanLyNhiemVu : UserControl
    {
        public QuanLyNhiemVu()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            pnList.Controls.Clear();
            int stt = 1;
            foreach(var x in new DAO.SqlToLinq.Role().getAll().Where(y => y.IsNhiemVu == 1 && y.Status == 1))
            {
                var row = new View.QuanLyChucNang.ModelNhiemVu(stt++, x);
                row.CT.Click += (sender, e) =>  ShowPhanCong(x);
                row.Sua.Click += (sender, e) => SuaR(x);
                row.Xoa.Click += (sender, e) => XoaR(x);

                pnList.Controls.Add(row);
            }
        }

        private void SuaR(Models.Role r)
        {
            var s = new SuaNhiemVu(r);
            s.FormClosed += T_FormClosed;
            s.Show();
        }

        private void XoaR(Models.Role r)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                r.Status = -1;

                if(new DAO.SqlToLinq.Role().UpdateRole(r))
                {
                    MessageBox.Show("Thành công");
                    load();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var t = new View.QuanLyChucNang.ThemNhiemVu();
            t.FormClosed += T_FormClosed;
            t.Show();
        }

        private void ShowPhanCong(Models.Role r)
        {
            var x = new PhanCong(r);
            x.FormClosed += T_FormClosed;

            x.Show();
        }

        private void T_FormClosed(object? sender, FormClosedEventArgs e)
        {
            load();
        }
    }
}
