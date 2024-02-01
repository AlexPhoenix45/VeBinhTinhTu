using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyChucNang
{
    public partial class QuanLyQuyen : UserControl
    {
        public QuanLyQuyen()
        {
            InitializeComponent();
            loadNew();
        }

        private void loadNew()
        {
            try
            {
                pnTable.Controls.Clear();
                var Acts = new DAO.SqlToLinq.Action().getAll().Where(x => x.Status == 1);
                // Lọc dữ liệu từ Acts với điều kiện IdParent == 0
                var filteredActs = Acts.Where(x => x.IdParent == 0).ToList();

                // Thêm một giá trị trống vào đầu danh sách
                filteredActs.Insert(0, new Models.Action { Id = -1, Name = "" }); // Điền giá trị Id và Name tùy ý

                // Thiết lập nguồn dữ liệu cho ComboBox
                TKPR.DataSource = filteredActs;

                // Xác định cách hiển thị dữ liệu trong ComboBox
                TKPR.DisplayMember = "Name";

                // Xác định giá trị của mỗi mục trong ComboBox
                TKPR.ValueMember = "Id";

                // Chọn mục đầu tiên (mục trống)
                TKPR.SelectedIndex = 0;


                int i = 1;
                foreach (var Act in Acts.Where(x => x.IdParent == 0))
                {
                    var lbl = new Label();
                    lbl.Text = "\n" + Act.Name;
                    lbl.Width = pnTable.Width - 30;
                    lbl.Height = 60;
                    lbl.Font = new Font(lbl.Font.FontFamily, 12f, lbl.Font.Style);

                    var rowSt = new View.QuanLyChucNang.ModelsQuyen(i, Act); i++;

                    rowSt.btnSua.Click += (sender, e) =>
                    {
                        // Gọi phương thức CheckList và chuyển giá trị int vào
                        BtnSua_Click(sender, e, Act.Id);
                    };

                    rowSt.btnXoa.Click += (sender, e) =>
                    {
                        // Gọi phương thức CheckList và chuyển giá trị int vào
                        BtnXoa_Click(sender, e, Act.Id);
                    };

                    pnTable.Controls.Add(lbl);
                    pnTable.Controls.Add(rowSt);

                    foreach (var sub in Acts.Where(x => x.IdParent == Act.Id))
                    {
                        var row = new View.QuanLyChucNang.ModelsQuyen(i, sub);
                        row.btnSua.Click += (sender, e) =>
                        {
                            // Gọi phương thức CheckList và chuyển giá trị int vào
                            BtnSua_Click(sender, e, sub.Id);
                        };

                        row.btnXoa.Click += (sender, e) =>
                        {
                            // Gọi phương thức CheckList và chuyển giá trị int vào
                            BtnXoa_Click(sender, e, sub.Id);
                        };

                        pnTable.Controls.Add(row);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e, int Id)
        {
            try
            {
                var act = new DAO.SqlToLinq.Action().getById(Id);
                if (act != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa " + act.Name + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã chọn Yes hay No
                    if (result == DialogResult.Yes)
                    {
                        // Người dùng đã chọn Yes, thực hiện xóa
                        act.Status = 0;
                        if (new DAO.SqlToLinq.Action().Update(act))
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
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e, int Id)
        {
            var Act = new DAO.SqlToLinq.Action().getById(Id);

            var sua = new View.QuanLyChucNang.SuaQuyen(Act);

            sua.FormClosed += Them_FormClosed;
            sua.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var them = new View.QuanLyChucNang.ThemQuyen();

            them.FormClosed += Them_FormClosed;

            them.Show();
        }

        private void Them_FormClosed(object? sender, FormClosedEventArgs e)
        {
            loadNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pnTable.Controls.Clear();

                var Acts = new DAO.SqlToLinq.Action().getAll().Where(x => x.Status == 1);

                int i = 1;
                foreach (var Act in Acts.Where(x => (int.Parse(TKPR.SelectedValue.ToString()) != -1 ? x.Id == int.Parse(TKPR.SelectedValue.ToString()) : true)
                                                                          && x.Status == 1 && x.IdParent == 0))
                {
                    var lbl = new Label();
                    lbl.Text = "\n" + Act.Name;
                    lbl.Width = pnTable.Width - 30;
                    lbl.Height = 60;
                    lbl.Font = new Font(lbl.Font.FontFamily, 12f, lbl.Font.Style);

                    var rowSt = new View.QuanLyChucNang.ModelsQuyen(i, Act); i++;

                    rowSt.btnSua.Click += (sender, e) =>
                    {
                        // Gọi phương thức CheckList và chuyển giá trị int vào
                        BtnSua_Click(sender, e, Act.Id);
                    };

                    rowSt.btnXoa.Click += (sender, e) =>
                    {
                        // Gọi phương thức CheckList và chuyển giá trị int vào
                        BtnXoa_Click(sender, e, Act.Id);
                    };

                    pnTable.Controls.Add(lbl);
                    pnTable.Controls.Add(rowSt);

                    foreach (var sub in Acts.Where(x => x.IdParent == Act.Id))
                    {
                        var row = new View.QuanLyChucNang.ModelsQuyen(i, sub);
                        row.btnSua.Click += (sender, e) =>
                        {
                            // Gọi phương thức CheckList và chuyển giá trị int vào
                            BtnSua_Click(sender, e, sub.Id);
                        };

                        row.btnXoa.Click += (sender, e) =>
                        {
                            // Gọi phương thức CheckList và chuyển giá trị int vào
                            BtnXoa_Click(sender, e, sub.Id);
                        };

                        pnTable.Controls.Add(row);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
