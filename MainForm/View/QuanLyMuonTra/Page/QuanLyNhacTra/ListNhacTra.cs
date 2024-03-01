using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyMuonTra.QuanLyNhacTra
{
    public partial class ListNhacTra : UserControl
    {
        public ListNhacTra()
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}

            loadNew();
        }

        private void loadNew()
        {
            pnTable.Controls.Clear();
            int i = 1;
            foreach (var x in new DAO.SqlToLinq.PhieuMuon().getAll().Where(x => x.Status == 1).OrderByDescending(x => x.Id))
            {
                var row = new QuanLyNhacTra.ModelNhacTra();

                row.lblSTT.Text = i.ToString();
                row.lblMDG.Text = new DAO.SqlToLinq.DocGia().getById(x.IdDocGia).MaDocGia;
                row.lblNgayMuon.Text = x.NgayMuon.ToString("dd/MM/yyyy");
                row.lblNgayHenTra.Text = x.NgayHenTra.ToString("dd/MM/yyyy");
                row.lblGhiChuMuon.Text = x.GhiChuMuon;

                row.btnThaoTac.BackColor = Color.LightBlue;
                row.btnThaoTac.Text = "Tạo phiếu";

                row.btnThaoTac.Click += (s, ev) => btnThaoTac_Click(s, ev, x);
                var pnc = new DAO.SqlToLinq.PhieuNhacTra().getByIdPhieuMuon(x.Id);
                if (pnc != null)
                {
                    if (pnc.NgayTao.Date == DateTime.Now.Date)
                    {
                        row.btnThaoTac.BackColor = Color.LightGreen;
                        row.btnThaoTac.Text = "Xem";
                    }
                }

                pnTable.Controls.Add(row);

                i++;
            }
        }

        private void loadNewHasValue(int IdP)
        {
            pnTable.Controls.Clear();
            int i = 1;
            foreach (var x in new DAO.SqlToLinq.PhieuMuon().getAll().Where(x => x.Status == 1).OrderByDescending(x => x.Id))
            {
                var row = new QuanLyNhacTra.ModelNhacTra();

                row.lblSTT.Text = i.ToString();
                row.lblMDG.Text = new DAO.SqlToLinq.DocGia().getById(x.IdDocGia).MaDocGia;
                row.lblNgayMuon.Text = x.NgayMuon.ToString("dd/MM/yyyy");
                row.lblNgayHenTra.Text = x.NgayHenTra.ToString("dd/MM/yyyy");
                row.lblGhiChuMuon.Text = x.GhiChuMuon;

                row.btnThaoTac.BackColor = Color.LightBlue;
                row.btnThaoTac.Text = "Tạo phiếu";

                row.btnThaoTac.Click += (s, ev) => btnThaoTac_Click(s, ev, x);
                var pnc = new DAO.SqlToLinq.PhieuNhacTra().getByIdPhieuMuon(x.Id);
                if (pnc != null)
                {
                    if (pnc.NgayTao.ToString("dd/MM/yyyy").Equals(DateTime.Now.ToString("dd/MM/yyyy")))
                    {
                        row.btnThaoTac.BackColor = Color.LightGreen;
                        row.btnThaoTac.Text = "Xem";
                    }
                }

                pnTable.Controls.Add(row);

                if (x.Id == IdP)
                {
                    // Cuộn đến dòng cụ thể
                    pnTable.AutoScrollPosition = new Point(0, row.Location.Y);
                }

                i++;
            }
        }


        private void btnThaoTac_Click(object sender, EventArgs e, Models.PhieuMuon p)
        {
            var createPhieuNhac = new View.QuanLyMuonTra.QuanLyNhacTra.CreatePhieuNhac(p);

            createPhieuNhac.FormClosed += CreatePhieuNhac_FormClosed;

            createPhieuNhac.Show();
        }

        private void CreatePhieuNhac_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ép kiểu sender thành đối tượng CreatePhieuNhac
            if (sender is CreatePhieuNhac createPhieuNhac)
            {
                loadNewHasValue(createPhieuNhac.Phieu.Id);
            }
        }

        private void taoAll_Click(object sender, EventArgs e)
        {
            var ma = txtMaDG.Text;
            var ten = txtTen.Text;

            var dg = new DAO.SqlToLinq.DocGia();
            var us = new DAO.SqlToLinq.Users();

            var phieuCanTao = new DAO.SqlToLinq.PhieuMuon().getAll().Where(x => (ma != string.Empty ? dg.getById(x.IdDocGia).MaDocGia.ToLower().Contains(ma.ToLower()) : true)
                                                                                && (ten != string.Empty ? us.getById(dg.getById(x.IdDocGia).IdUser).TaiKhoan.ToLower().Contains(ten.ToLower()) : true)
                                                                               && x.Status == 1).OrderByDescending(x => x.Id).ToList(); // cần thay bằng hàm tìm kiếm

            int dem = 0;
            foreach (var x in phieuCanTao)
            {
                var createPhieuNhac = new View.QuanLyMuonTra.QuanLyNhacTra.CreatePhieuNhac(x);

                if (createPhieuNhac.taoAll())
                {
                    dem++;
                }
            }

            MessageBox.Show(dem + " phiếu tạo thành công\n\n" + (phieuCanTao.Count - dem) + " phiếu tạo thất bại");

            TimKiem();
        }

        private void TimKiem()
        {
            pnTable.Controls.Clear();
            var ma = txtMaDG.Text;
            var ten = txtTen.Text;

            var dg = new DAO.SqlToLinq.DocGia();
            var us = new DAO.SqlToLinq.Users();

            int i = 1;
            foreach (var x in new DAO.SqlToLinq.PhieuMuon().getAll().Where(x => (ma != string.Empty ? dg.getById(x.IdDocGia).MaDocGia.ToLower().Contains(ma.ToLower()) : true)
                                                                                && (ten != string.Empty ? us.getById(dg.getById(x.IdDocGia).IdUser).TaiKhoan.ToLower().Contains(ten.ToLower()) : true)
                                                                               && x.Status == 1).OrderByDescending(x => x.Id))
            {
                var row = new QuanLyNhacTra.ModelNhacTra();

                row.lblSTT.Text = i.ToString();
                row.lblMDG.Text = new DAO.SqlToLinq.DocGia().getById(x.IdDocGia).MaDocGia;
                row.lblNgayMuon.Text = x.NgayMuon.ToString("dd/MM/yyyy");
                row.lblNgayHenTra.Text = x.NgayHenTra.ToString("dd/MM/yyyy");
                row.lblGhiChuMuon.Text = x.GhiChuMuon;

                row.btnThaoTac.BackColor = Color.LightBlue;
                row.btnThaoTac.Text = "Tạo phiếu";

                row.btnThaoTac.Click += (s, ev) => btnThaoTac_Click(s, ev, x);
                var pnc = new DAO.SqlToLinq.PhieuNhacTra().getByIdPhieuMuon(x.Id);
                if (pnc != null)
                {
                    if (pnc.NgayTao.Date == DateTime.Now.Date)
                    {
                        row.btnThaoTac.BackColor = Color.LightGreen;
                        row.btnThaoTac.Text = "Xem";
                    }
                }

                pnTable.Controls.Add(row);

                i++;
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
