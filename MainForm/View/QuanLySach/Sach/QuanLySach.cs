using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using MainForm.View.QuanLySach.Sach;

namespace QuanLySach.Sach
{
    public partial class QuanLySach : UserControl
    {
        private string ListIdTG = "";
        private string ListtenTG = "";
        public QuanLySach()
        {
            InitializeComponent();
            loadTrang();
        }

        private void sach_ReloadXoaSachComplete(object sender, EventArgs e)
        {
            ListSach();
        }

        private void loadTrang()
        {
            // Đặt vị trí ban đầu cho các UserControl
            int topPosition = 0;

            // Load và thêm các UserControl vào Panel
            foreach (var s in new DAO.SqlToLinq.Sach().GetAll().Where(x => x.Status == 1))
            {
                Sach.ModelSach sach = new Sach.ModelSach();

                sach.ReloadXoaSachComplete += sach_ReloadXoaSachComplete;

                sach.txtImg.Text = s.TenSach.ToString();
                sach.img.ImageLocation = "D:\\LapTrinhWindow\\QuanLyThuVien\\MainForm\\Web\\Img\\AnhSach\\" + s.AnhDaiDien;
                sach.img.Tag = s.Id;

                pnList.Controls.Add(sach);

                // Tăng vị trí top cho UserControl tiếp theo
                topPosition += sach.Height; // Giả sử UserControl có chiều cao cố định
            }

            // Thêm Panel chứa các UserControl vào Form (hoặc UserControl chính của bạn)
            pn.Controls.Add(pnList);


            //load list tg trong bộ lọc
            List<Models.CheckBox> items = new List<Models.CheckBox>();
            foreach (var x in new DAO.SqlToLinq.TacGia().getAll().Where(x => x.Status == 1))
            {
                var it = new Models.CheckBox();
                it.Value = x.Id;
                it.DisplayText = x.TenTacGia.ToString();

                items.Add(it);
            }
            cklTG.DataSource = items;
            cklTG.ValueMember = "Value";
            cklTG.DisplayMember = "DisplayText";


            //load TheLoai va NXB
            List<Models.CheckBox> itsTL = new List<Models.CheckBox>();
            var ittl = new Models.CheckBox();
            ittl.Value = 0;
            ittl.DisplayText = "";

            itsTL.Add(ittl);
            foreach (var x in new DAO.SqlToLinq.TheLoai().getAll().Where(x => x.Status == 1))
            {
                var it = new Models.CheckBox();
                it.Value = x.Id;
                it.DisplayText = x.TenTheLoai.ToString();

                itsTL.Add(it);
            }
            txtTL.DataSource = itsTL;
            txtTL.ValueMember = "Value";
            txtTL.DisplayMember = "DisplayText";

            List<Models.CheckBox> itsNXB = new List<Models.CheckBox>();
            var itxb = new Models.CheckBox();
            itxb.Value = 0;
            itxb.DisplayText = "";

            itsNXB.Add(itxb);
            foreach (var x in new DAO.SqlToLinq.NhaXuatBan().getAll().Where(x => x.Status == 1))
            {
                var it = new Models.CheckBox();
                it.Value = x.Id;
                it.DisplayText = x.TenNhaXuatBan.ToString();

                itsNXB.Add(it);
            }
            txtNXB.DataSource = itsNXB;
            txtNXB.ValueMember = "Value";
            txtNXB.DisplayMember = "DisplayText";

        }

        private string ChonTG()
        {
            var u = "";
            ListIdTG = "";

            for (var i = cklTG.Items.Count - 1; i >= 0; i--)
            {
                if (cklTG.GetItemChecked(i))
                {
                    u += cklTG.Items[i].ToString() + ", ";
                }
            }

            int phay = 0;
            for (var i = 0; i < cklTG.Items.Count; i++)
            {
                if (cklTG.GetItemChecked(i))
                {
                    if (cklTG.Items[i] is Models.CheckBox item)
                    {
                        if (phay == 0)
                        {
                            ListIdTG += item.Value.ToString();
                            phay++;
                        }
                        else
                            ListIdTG += "," + item.Value.ToString();
                    }
                }
            }
            Debug.WriteLine(ListIdTG);

            return u.TrimEnd(',', ' '); // Remove the trailing comma and space
        }

        private void txtListTG_Click(object sender, EventArgs e)
        {
            if (pnTG.Size.Width == 0)
            {
                pnTG.Size = new Size(200, 200);
                cklTG.IntegralHeight = false;
                cklTG.ScrollAlwaysVisible = true;
            }
            else
            {
                pnTG.Size = new Size(0, 0);
            }
        }


        private void btnTG_Click(object sender, EventArgs e)
        {
            txtListTG.Text = ChonTG();
            pnTG.Size = new Size(0, 0);
        }

        private void ListSach()
        {
            var Ten = txtTen.Text;
            var MoTa = txtMoTa.Text;
            var listIdTG = ListIdTG;

            int IdTheLoai, IdNXB, NamXBTu, NamXBDen, GiaTu, GiaDen;

            if (!int.TryParse((txtTL.SelectedItem as Models.CheckBox)?.Value.ToString(), out IdTheLoai))
            {
                // Handle the case where parsing fails, e.g., show an error message or set a default value
                IdTheLoai = 0; // Default value or any other suitable default handling
            }

            if (!int.TryParse((txtNXB.SelectedItem as Models.CheckBox)?.Value.ToString(), out IdNXB))
            {
                // Handle the case where parsing fails
                IdNXB = 0;
            }

            if (!int.TryParse(txtNamXBTu.Text, out NamXBTu))
            {
                // Handle the case where parsing fails
                NamXBTu = 0;
            }

            if (!int.TryParse(txtNamXBDen.Text, out NamXBDen))
            {
                // Handle the case where parsing fails
                NamXBDen = 0;
            }

            if (!int.TryParse(txtGiaTu.Text, out GiaTu))
            {
                // Handle the case where parsing fails
                GiaTu = 0;
            }

            if (!int.TryParse(txtGiaDen.Text, out GiaDen))
            {
                // Handle the case where parsing fails
                GiaDen = 0;
            }


            pn.Controls.Clear();
            pnList.Controls.Clear();
            // Đặt vị trí ban đầu cho các UserControl
            int topPosition = 0;

            // Load và thêm các UserControl vào Panel
            foreach (var s in new DAO.SqlToLinq.Sach().TimKiem(Ten, MoTa, listIdTG, IdTheLoai, IdNXB, NamXBTu, NamXBDen, GiaTu, GiaDen))
            {
                Sach.ModelSach sach = new Sach.ModelSach();

                sach.ReloadXoaSachComplete += sach_ReloadXoaSachComplete;

                sach.txtImg.Text = s.TenSach.ToString();
                sach.img.ImageLocation = "D:\\LapTrinhWindow\\QuanLyThuVien\\MainForm\\Web\\Img\\AnhSach\\" + s.AnhDaiDien;
                sach.img.Tag = s.Id;

                pnList.Controls.Add(sach);

                // Tăng vị trí top cho UserControl tiếp theo
                topPosition += sach.Height; // Giả sử UserControl có chiều cao cố định
            }

            // Thêm Panel chứa các UserControl vào Form (hoặc UserControl chính của bạn)
            pn.Controls.Add(pnList);
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            ListSach();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemSach themSach = new ThemSach();

            themSach.InsertComplete += themSach_InsertComplete;
            themSach.Show();
        }

        private void themSach_InsertComplete(object sender, bool isSuccess)
        {
            if (isSuccess)
            {
                ListSach(); // Gọi phương thức làm mới dữ liệu
            }
        }
    }
}
