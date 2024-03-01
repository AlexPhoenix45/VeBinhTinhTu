using MainForm.View.QuanLySach.Sach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyMuonTra.QuanLyPhieuMuon
{
    public partial class CreatePhieuMuon : Form
    {
        private string ListIdTG = "";
        private int IdDG;
        public CreatePhieuMuon(int idDG)
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}
            this.AutoScroll = true;

            IdDG = idDG;


            loadNew();
        }

        private void QuaDai()
        {

            panel1.Height = txtListTG.Location.Y + txtListTG.Height + 50;
            pnBtn.Location = new Point(pnBtn.Location.X, panel1.Location.Y + panel1.Height);

        }

        private void loadNew()
        {
            var dg = new DAO.SqlToLinq.DocGia().getById(IdDG);

            txtMaDG.Text = dg.MaDocGia;


            List<Models.CheckBox> items = new List<Models.CheckBox>();
            foreach (var x in new DAO.SqlToLinq.Sach().GetAll().Where(x => x.Status == 1))
            {
                var it = new Models.CheckBox();
                it.Value = x.Id;
                it.DisplayText = x.TenSach + " _ " + x.TaiBan;

                items.Add(it);
            }
            cklTG.DataSource = items;
            cklTG.ValueMember = "Value";
            cklTG.DisplayMember = "DisplayText";

            // text Chú ý

            lblChuY.Text = "_ Phí mượn được tính là 1000VND/ngày. \n\n" +
                            "_ Quá thời gian hẹn trả phạt \n \t\t\t\t 10%(giá trị sách)/ngày \n \t\t\t\t tính tất cả sách trong phiếu mượn. \n\n" +
                            "_ Độ hư hại (nếu có) sẽ được quy ra tỉ lệ \n \t\t\t\t và đền theo giá sách";
        }

        private string ChonTG()
        {
            var u = "";
            ListIdTG = "";

            for (var i = cklTG.Items.Count - 1; i >= 0; i--)
            {
                if (cklTG.GetItemChecked(i))
                {
                    u += cklTG.Items[i].ToString() + "\n\n";
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
            if (!pnTG.Visible)
            {
                pnTG.Visible = true;
                cklTG.IntegralHeight = false;
                cklTG.ScrollAlwaysVisible = true;
            }
            else
            {
                pnTG.Visible = false;
            }
        }


        private void btnTG_Click(object sender, EventArgs e)
        {
            txtListTG.Text = ChonTG();
            pnTG.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var tenSach = txtSubTK.Text.ToLower(); // Chuyển đổi tên sách về chữ thường để so sánh không phân biệt chữ hoa

            for (int i = 0; i < cklTG.Items.Count; i++)
            {
                var itemName = cklTG.GetItemText(cklTG.Items[i]).ToLower(); // Lấy tên sách tương ứng trong danh sách và chuyển về chữ thường

                if (itemName.Contains(tenSach))
                {
                    cklTG.SelectedIndex = i; // Chọn mục tương ứng trong CheckedListBox
                    cklTG.TopIndex = i; // Cuộn đến mục đã chọn
                }
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            //convert sang dang date trong SQLSV

            var HenTra = txtHenTra.Text;

            var NHT = DateTime.Now;
            if (DateTime.TryParseExact(HenTra, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out NHT))
            {
                // Parsing successful, use the NgayHenTra variable here
                Debug.WriteLine("Parsed Date: " + NHT.ToString("yyyy-MM-dd")); // Display the date in a specific format if needed
            }
            else
            {
                // Handle the case when parsing fails
                Debug.WriteLine("Cannot parse the date.");
            }

            var ghiChu = txtGhiChu.Text;
            List<string> lsach = ListIdTG.Split(",").ToList();

            var phieu = new Models.PhieuMuon
            {
                IdDocGia = IdDG,
                NgayHenTra = NHT,
                GhiChuMuon = ghiChu,
                IdNVTaoPhieu = Models.Session.IdUserInRole,
                Status = 1
            };
            if (new DAO.SqlToLinq.PhieuMuon().Insert(phieu, lsach))
            {
                MessageBox.Show("Tạo thành công");
            }
            else
            {
                MessageBox.Show("Tạo không thành công");
            }
        }

        private void btnXN2_Click(object sender, EventArgs e)
        {
            btnTao_Click(sender, e);
        }

        private void txtListTG_SizeChanged(object sender, EventArgs e)
        {
            QuaDai();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
