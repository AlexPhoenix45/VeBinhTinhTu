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
using Models;

namespace QuanLySach.Sach
{
    public partial class QuanLySach : UserControl
    {
        private string ListIdTG = "";
        private string ListtenTG = "";
        public QuanLySach()
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}
            DTSach.CellClick += DTSach_CellClick;


            var ACT = new DAO.SqlToLinq.Action().getAllByIdUser();

            var xoa = ACT.Where(x => x.Status == 1 && x.Name.Equals("ThemSach")).FirstOrDefault();

            if (xoa == null)
            {
                btnAdd.Visible = false;
            }

            if(Models.Session.cd.DSList == 1)
            {
                rjToggleButton1.Checked = true;
            }
            else
            {
                rjToggleButton1.Checked = false;
                pnDS.Visible = false;
            }


            loadTrang();
        }

        //Hàm Dạng Danh Sách
        
        private void LoadDS()
        {
            var sachList = new DAO.SqlToLinq.Sach().GetAll().Where(x => x.Status == 1);

            DataTable dt = new DataTable();

            // Thêm các cột vào DataTable
            dt.Columns.Add("STT", typeof(int)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("IdSach", typeof(int)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("Tên sách", typeof(string)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("Thể loại", typeof(string));
            dt.Columns.Add("Mô tả", typeof(string)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("Tác giả", typeof(string));
            dt.Columns.Add("Năm xuất bản", typeof(string));
            dt.Columns.Add("Số lượng", typeof(string));



            // Thêm dữ liệu từ sachList vào DataTable
            int stt = 1;
            foreach (var sach in sachList)
            {
                dt.Rows.Add(stt++,sach.Id, sach.TenSach, new DAO.SqlToLinq.TheLoai().getById(sach.IdTheLoai).TenTheLoai,
                            sach.MoTa, new DAO.SqlToLinq.Sach().getTacGias(sach.Id), sach.NamXuatBan, (sach.SoLuong - new DAO.SqlToLinq.ChiTietMuon().tongSach(sach.Id)) + "/" + sach.SoLuong);
            }

            // Gán DataTable làm DataSource cho DTSach
            DTSach.ReadOnly = true;
            DTSach.DataSource = dt;
            // Thiết lập chiều rộng cho các cột
            DTSach.Columns["STT"].Width = 50; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
            DTSach.Columns["IdSach"].Visible = false; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
            DTSach.Columns["Tên sách"].Width = 150; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
            DTSach.Columns["Mô tả"].Width = 200; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
            DTSach.Columns["Số lượng"].Width = 150; // Thiết lập chiều rộng cho cột "Năm Xuất Bản" là 150
            DTSach.Columns["Năm Xuất bản"].Width = 150; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
            DTSach.Columns["Thể loại"].Width = 150;
        }

        private void TkDS()
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
            var sachList = new DAO.SqlToLinq.Sach().TimKiem(Ten, MoTa, listIdTG, IdTheLoai, IdNXB, NamXBTu, NamXBDen, GiaTu, GiaDen);

            DataTable dt = new DataTable();

            // Thêm các cột vào DataTable
            dt.Columns.Add("STT", typeof(int)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("IdSach", typeof(int)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("Tên sách", typeof(string)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("Thể loại", typeof(string));
            dt.Columns.Add("Mô tả", typeof(string)); // Giả sử IdTacGia là kiểu int
            dt.Columns.Add("Tác giả", typeof(string));
            dt.Columns.Add("Năm xuất bản", typeof(string));
            dt.Columns.Add("Số lượng", typeof(string));



            // Thêm dữ liệu từ sachList vào DataTable
            int stt = 1;
            foreach (var sach in sachList)
            {
                dt.Rows.Add(stt++, sach.Id, sach.TenSach, new DAO.SqlToLinq.TheLoai().getById(sach.IdTheLoai).TenTheLoai,
                            sach.MoTa, new DAO.SqlToLinq.Sach().getTacGias(sach.Id), sach.NamXuatBan, (sach.SoLuong - new DAO.SqlToLinq.ChiTietMuon().tongSach(sach.Id)) + "/" + sach.SoLuong);
            }

            // Gán DataTable làm DataSource cho DTSach
            DTSach.ReadOnly = true;
            DTSach.DataSource = dt;
            // Thiết lập chiều rộng cho các cột
            DTSach.Columns["STT"].Width = 50; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
            DTSach.Columns["IdSach"].Visible = false; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
            DTSach.Columns["Tên sách"].Width = 150; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
            DTSach.Columns["Mô tả"].Width = 200; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
            DTSach.Columns["Số lượng"].Width = 150; // Thiết lập chiều rộng cho cột "Năm Xuất Bản" là 150
            DTSach.Columns["Năm Xuất bản"].Width = 150; // Thiết lập chiều rộng cho cột "Tác Giả" là 150
            DTSach.Columns["Thể loại"].Width = 150;
        }

        private void DTSach_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của cột ID của bản ghi được chọn
                var idValue = int.Parse(DTSach.Rows[e.RowIndex].Cells["IdSach"].Value.ToString());


                var ct = new View.QuanLySach.ChiTietSach2(idValue);

                pnCTSach.Controls.Clear();
                pnCTSach.Controls.Add(ct);
            }
        }




        //Hàm Dạng lưới

        private void TkLuoi()
        {
            List();

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
                sach.img.Click += Sach_Click;

                pnList.Controls.Add(sach);

                // Tăng vị trí top cho UserControl tiếp theo
                topPosition += sach.Height; // Giả sử UserControl có chiều cao cố định
            }

            // Thêm Panel chứa các UserControl vào Form (hoặc UserControl chính của bạn)
            pn.Controls.Add(pnList);
        }
        private void LoadLuoi()
        {
            // Đặt vị trí ban đầu cho các UserControl
            int topPosition = 0;

            List();
            // Load và thêm các UserControl vào Panel
            foreach (var s in new DAO.SqlToLinq.Sach().GetAll().Where(x => x.Status == 1))
            {
                Sach.ModelSach sach = new Sach.ModelSach();

                sach.ReloadXoaSachComplete += sach_ReloadXoaSachComplete;

                sach.txtImg.Text = s.TenSach.ToString();
                sach.img.ImageLocation = "D:\\LapTrinhWindow\\QuanLyThuVien\\MainForm\\Web\\Img\\AnhSach\\" + s.AnhDaiDien;
                sach.img.Tag = s.Id;

                sach.img.Click += Sach_Click;

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


        private void sach_ReloadXoaSachComplete(object sender, EventArgs e)
        {
            ListSach();
        }

        public void List()
        {
            pnChiTiet.Visible = false;
            pnChiTiet.Controls.Clear();
            pnList.Visible = true;
        }

        private void ChiTiet()
        {
            pnChiTiet.Visible = true;
            pnList.Visible = false;
        }

        private void loadTrang()
        {
            if (rjToggleButton1.Checked)
            {
                LoadDS();
            }
            else
            {
                LoadLuoi();
            }
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

            if (rjToggleButton1.Checked)
            {
                TkDS();
            }
            else
            {
                TkLuoi();
            }
        }

        private void Sach_Click(object? sender, EventArgs e)
        {
            ChiTiet();
            PictureBox anhSach = (PictureBox)sender;

            // Kiểm tra xem Tag có giá trị hay không
            if (anhSach.Tag != null)
            {
                Sach.ChiTietSach sach = new ChiTietSach(int.Parse(anhSach.Tag.ToString()));
                sach.button1.Click += Back_Click;
                sach.btnXoa.Click += sach_ReloadXoaSachComplete;

                pnChiTiet.Controls.Add(sach);
            }
        }


        private void Back_Click(object sender, EventArgs e)
        {
            List();
            pnChiTiet.Controls.Clear();
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



        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked)
            {
                Models.Session.cd.DSList = 1;
                List();
                TkDS();
                pnList.Visible = false;
                pnDS.Visible = true;
            }
            else
            {
                Models.Session.cd.DSList = 0;
                List();
                TkLuoi();
                pnList.Visible = true;
                pnDS.Visible = false;
            }

            if (new DAO.SqlToLinq.CaiDat().Update(Models.Session.cd))
            {
                Debug.WriteLine("Back2 ok");
            }
        }
    }
}
