using Models;
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

namespace MainForm.View.QuanLySach.Sach
{
    public partial class SuaSach : Form
    {
        private string ListIdTG = "";
        private string ListtenTG = "";
        private int IdSach; 
        public SuaSach(int Id)
        {
            InitializeComponent();
            IdSach = Id;

            var sach = new DAO.SqlToLinq.Sach().getById(Id);

            loadnew(sach);
        }

        public event EventHandler<bool> InsertComplete;

        private void loadnew(Models.Sach s)
        {
            //load tt sach
            txtTen.Text = s.TenSach;
            txtMoTa.Text = s.MoTa;
            txtNamXB.Text = s.NamXuatBan.ToString();
            ListIdTG = s.ListIdTacGia.ToString();
            txtSoLuong.Text = s.SoLuong.ToString();
            txtTaiBan.Text = s.TaiBan;
            txtGia.Text = s.GiaSach.ToString();
            MaAnh.Text = s.AnhDaiDien.ToString();
            anhSach.ImageLocation = "D:\\LapTrinhWindow\\QuanLyThuVien\\MainForm\\Web\\Img\\AnhSach\\" + s.AnhDaiDien;


            //load list tg trong bộ lọc
            int ixd = 0;
            foreach(var x in s.ListIdTacGia.Split(','))
            {
                if(ixd == 0)
                {
                    txtListTG.Text = new DAO.SqlToLinq.TacGia().getById(int.Parse(x)).TenTacGia;
                    ixd++;
                }
                else
                {
                    txtListTG.Text +=", " + new DAO.SqlToLinq.TacGia().getById(int.Parse(x)).TenTacGia;
                }
            }

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
            ittl.Value = s.IdTheLoai;
            ittl.DisplayText = new DAO.SqlToLinq.TheLoai().getById(s.IdTheLoai).TenTheLoai;

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
            itxb.Value = s.IdNhaXuatBan;
            itxb.DisplayText = new DAO.SqlToLinq.NhaXuatBan().getById(s.IdNhaXuatBan).TenNhaXuatBan;

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

        private void anhSach_Click(object sender, EventArgs e)
        {
            slAnh.Visible = false;
            // Tạo một OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính của OpenFileDialog
            openFileDialog.Filter = "Image Files (*.bmp; *.jpg; *.jpeg; *.png)|*.bmp; *.jpg; *.jpeg; *.png";
            openFileDialog.Title = "Chọn ảnh";

            // Hiển thị hộp thoại và xác nhận việc chọn tệp tin
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc tệp tin ảnh được chọn và hiển thị trong PictureBox
                    string selectedImagePath = openFileDialog.FileName;
                    Image selectedImage = Image.FromFile(selectedImagePath);
                    anhSach.Image = selectedImage;

                    // Lấy tên file từ đường dẫn tệp tin
                    string fileName = Path.GetFileName(selectedImagePath);

                    // Hiển thị tên file trong một TextBox hoặc label (tuỳ thuộc vào yêu cầu của bạn)
                    // Ví dụ:
                    MaAnh.Text = XuLy.QuanLySach.Sach.TaoMa.MaNgauNhien(fileName.Length) + "_" + fileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc tệp tin ảnh: " + ex.Message);
                }
            }
            if (anhSach.Image == null)
            {
                slAnh.Visible = true;
            }
        }

        private bool LuuAnh()
        {// Kiểm tra xem PictureBox có hình ảnh hay không
            if (anhSach.Image != null)
            {
                // Đường dẫn để lưu ảnh
                string savePath = @"D:\LapTrinhWindow\QuanLyThuVien\MainForm\Web\Img\AnhSach\";

                // Tạo thư mục nếu nó không tồn tại
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);
                }

                // Lấy tên file từ PictureBox
                string fileName = MaAnh.Text; // Bạn có thể sử dụng tên file từ TextBox hoặc từ đường dẫn gốc

                // Tạo đường dẫn đầy đủ để lưu ảnh
                string fullPath = Path.Combine(savePath, fileName);

                try
                {
                    // Lưu ảnh từ PictureBox vào đường dẫn được chọn
                    anhSach.Image.Save(fullPath);

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không có ảnh để lưu.");
            }
            return false;
        }

        private bool LuuSach()
        {
            try
            {
                var s = new DAO.SqlToLinq.Sach().getById(IdSach);
                s.TenSach = txtTen.Text;
                s.MoTa = txtMoTa.Text;
                s.ListIdTacGia = ListIdTG;
                s.IdTheLoai = int.Parse(txtTL.SelectedValue.ToString());
                s.IdNhaXuatBan = int.Parse(txtNXB.SelectedValue.ToString());
                s.NamXuatBan = int.Parse(txtNamXB.Text);
                s.AnhDaiDien = MaAnh.Text;
                s.NhanVienThem = Session.Users.TaiKhoan;
                s.SoLuong = int.Parse(txtSoLuong.Text);
                s.TaiBan = txtTaiBan.Text;
                s.GiaSach = int.Parse(txtGia.Text);
                s.Status = 1;
                if (new DAO.SqlToLinq.Sach().Update(s))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (LuuAnh())
            {
                if (LuuSach())
                {
                    MessageBox.Show("Thêm thành công");
                    InsertComplete?.Invoke(this, true);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    InsertComplete?.Invoke(this, false);
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
                InsertComplete?.Invoke(this, false);
            }

            this.Close();
        }

        private void slAnh_Click(object sender, EventArgs e)
        {
            anhSach_Click(sender, e);
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
    }

}

