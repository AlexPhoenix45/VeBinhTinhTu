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

namespace View.QuanLyMuonTra.QuanLyMuon
{
    public partial class ChiTietPhieuMuon : Form
    {
        private List<int> listIdChiTiet = new List<int>();
        private List<double> listTiLe = new List<double>();
        private Models.PhieuMuon Phieu;

        public QuanLyMuon QuanLyMuon { get; set; }
        public ChiTietPhieuMuon(Models.PhieuMuon Phieu)
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}

            this.Phieu = Phieu;

            loadNew();
        }

        private void loadNew()
        {
            lblChuY.Text = "_ Phí mượn được tính là 1000VND/ngày. \n\n" +
                "_ Quá thời gian hẹn trả phạt \n \t\t\t\t 10%(giá trị sách)/ngày \n \t\t\t\t tính tất cả sách trong phiếu mượn. \n\n" +
                "_ Độ hư hại (nếu có) sẽ được quy ra tỉ lệ \n \t\t\t\t và đền theo giá sách";

            txtMaDG.Text = new DAO.SqlToLinq.DocGia().getById(Phieu.IdDocGia).MaDocGia;

            txtNgayMuon.Text = Phieu.NgayMuon.ToString("dd/MM/yyyy");
            txtNgayHen.Text = Phieu.NgayHenTra.ToString("dd/MM/yyyy");
            txtNgayTra.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtGhiChuMuon.Text = Phieu.GhiChuMuon;
            txtGhiChuTra.Text = Phieu.GhiChuTra;

            double phiMuon = 0;
            double phatMuon = 0;
            double phatHong = 0;


            if (Phieu.PhiMuon.HasValue)
            {
                txtPhiMuon.Text = Phieu.PhiMuon.Value.ToString();
                phiMuon = Phieu.PhiMuon.Value;
            }
            if (Phieu.PhiPhatTraMuon.HasValue)
            {
                txtPhatMuon.Text = Phieu.PhiPhatTraMuon.Value.ToString();
                phatMuon = Phieu.PhiPhatTraMuon.Value;
            }
            if (Phieu.PhiPhatHongSach.HasValue)
            {
                txtPhatHong.Text = Phieu.PhiPhatHongSach.Value.ToString();
                phatHong = Phieu.PhiPhatHongSach.Value;
            }

            txtTongPhi.Text = ((phiMuon + phatHong + phatMuon)) + "VND";



            pnListSach.Controls.Clear();
            int i = 0;
            foreach (var x in new DAO.SqlToLinq.ChiTietMuon().getByIdPhieu(Phieu.Id))
            {
                listIdChiTiet.Add(x.Id);
                listTiLe.Add(0);
                var old = new PartialPage.QuanLyMuon.ModelListSach();

                old.txtTen.Text = new DAO.SqlToLinq.Sach().getById(x.IdSach).TenSach + "\n\n";

                old.textBox1.Tag = i;
                old.textBox1.Text = x.TiLeHong.HasValue? x.TiLeHong.Value.ToString() : "0";
                old.textBox1.TextChanged += NhapTiLe;

                pnListSach.Controls.Add(old);

                i++;
            }


            if(Phieu.Status == 0)
            {
                txtGhiChuTra.Enabled = false;
                btnTao.Visible = false;
            }
        }

        private void NhapTiLe(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // Lấy giá trị của thuộc tính Tag
                object tagValue = textBox.Tag;

                // Kiểm tra xem tagValue có phải là số hay không (nếu cần)
                if (tagValue is int)
                {
                    int tagAsInt = (int)tagValue;
                    if (textBox.Text != string.Empty)
                    {
                        listTiLe[tagAsInt] = double.Parse(textBox.Text);
                        Console.WriteLine($"Tag value for TextBox {tagAsInt}: {tagAsInt}");

                        for (int i = 0; i < listTiLe.Count; i++)
                        {
                            Debug.WriteLine(listTiLe[i]);
                        }
                    }
                }
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            var ThanhToan = new View.QuanLyMuonTra.QuanLyMuon.ThanhToan(Phieu, listIdChiTiet, listTiLe);
            ThanhToan.GhiChuTra = txtGhiChuTra.Text;
            ThanhToan.FormClosed += ThanhToan_FormClosed;
            Debug.WriteLine(txtGhiChuTra.Text);

            ThanhToan.Show();
        }

        private void ThanhToan_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (QuanLyMuon != null)
            {
                this.FormClosed += (sender, e) => QuanLyMuon.loadNewHave_value(Phieu.Id);
            }


            this.loadNew();
        }
    }
}
