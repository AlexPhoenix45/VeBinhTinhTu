using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyMuonTra.QuanLyMuon
{
    public partial class ModelListPhieuMuon : UserControl
    {
        private Models.PhieuMuon Phieu;
        private int STT;
        public QuanLyMuon QuanLyMuon { get; set; }

        public ModelListPhieuMuon(int Stt, Models.PhieuMuon Phieu)
        {
            InitializeComponent();
            this.Phieu = Phieu;
            STT = Stt;

            loadNew();
        }

        private void loadNew()
        {
            lblSTT.Text = STT.ToString();
            lblMaDG.Text = new DAO.SqlToLinq.DocGia().getById(Phieu.IdDocGia).MaDocGia;
            lblNgayMuon.Text = Phieu.NgayMuon.ToString("dd/MM/yyyy");
            lblNgayHenTra.Text = Phieu.NgayHenTra.ToString("dd/MM/yyyy");
            lblGCM.Text = Phieu.GhiChuMuon.ToString();
            lblGCT.Text = Phieu.GhiChuTra.ToString();
            if (Phieu.NgayHoanTatTra.HasValue)
            {
                lblNgayTra.Text = Phieu.NgayHoanTatTra.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                lblNgayTra.Text = "";
            }

            if (Phieu.PhiMuon.HasValue)
            {
                lblPhiMuon.Text = Phieu.PhiMuon.ToString();
            }
            else
            {
                lblPhiMuon.Text = "";
            }

            if (Phieu.PhiPhatTraMuon.HasValue)
            {
                lblPhatMuon.Text = Phieu.PhiPhatTraMuon.ToString();
            }
            else
            {
                lblPhatMuon.Text = "";
            }

            if (Phieu.PhiPhatHongSach.HasValue)
            {
                lblPhatHuHai.Text = Phieu.PhiPhatHongSach.ToString();
            }
            else
            {
                lblPhatHuHai.Text = "";
            }

            if (Phieu.Status == 1)
            {
                if (Phieu.NgayHenTra < DateTime.Now)
                {
                    btnTaoPhieu.Text = "Trả muộn";
                    btnTaoPhieu.BackColor = Color.OrangeRed;
                }
                else
                {
                    btnTaoPhieu.Text = "Trả sách";
                }
            }
            else if (Phieu.Status == 0)
            {
                btnTaoPhieu.Text = "Xem";
                btnTaoPhieu.BackColor = Color.LightGreen;
            }

            foreach (var x in this.Controls)
            {
                if (x is Control txt)
                {
                    txt.MouseEnter += ModelListPhieuMuon_MouseEnter;
                    txt.MouseLeave += ModelListPhieuMuon_MouseLeave;
                }
            }
        }

        private void ModelListPhieuMuon_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void ModelListPhieuMuon_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            var ctPhieu = new QuanLyMuonTra.QuanLyMuon.ChiTietPhieuMuon(Phieu);
            ctPhieu.QuanLyMuon = QuanLyMuon;

            ctPhieu.Show();
        }
    }
}
