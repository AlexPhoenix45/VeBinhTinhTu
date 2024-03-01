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

namespace View.QuanLyMuonTra.QuanLyNhacTra
{
    public partial class CreatePhieuNhac : Form
    {
        public Models.PhieuMuon Phieu;
        public CreatePhieuNhac(Models.PhieuMuon IdP)
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}

            Phieu = IdP;

            loadNew();
        }

        private void loadNew()
        {
            lblChuY.Text = "_ Phí mượn được tính là 1000VND/ngày. \n\n" +
                "_ Quá thời gian hẹn trả phạt \n \t\t\t\t 10%(giá trị sách)/ngày \n \t\t\t\t tính tất cả sách trong phiếu mượn. \n\n" +
                "_ Phí mượn và phí phạt được tính \n \t\t\t\t tại thời điểm xuất piếu";

            txtMaDG.Text = new DAO.SqlToLinq.DocGia().getById(Phieu.IdDocGia).MaDocGia;

            txtNgayMuon.Text = Phieu.NgayMuon.ToString("dd/MM/yyyy");
            txtNgayHen.Text = Phieu.NgayHenTra.ToString("dd/MM/yyyy");
            txtNgayTra.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtGhiChuMuon.Text = Phieu.GhiChuMuon;

            var ngayMuon = (Phieu.NgayHenTra - Phieu.NgayMuon).Days;
            var ngayPhat = (DateTime.Now - Phieu.NgayHenTra).Days;

            double tongPhi = 0;
            double pMuon = 0;
            double pTraMuon = 0;

            pnListSach.Text = "";

            foreach (var x in new DAO.SqlToLinq.ChiTietMuon().getByIdPhieu(Phieu.Id))
            {
                var sach = new DAO.SqlToLinq.Sach().getById(x.IdSach);

                double phiMuon = (ngayMuon * 1000);
                double phatMuon = (ngayPhat * sach.GiaSach * 0.1);

                pMuon += phiMuon;
                pTraMuon += phatMuon;
                tongPhi += (phiMuon + phatMuon);

                pnListSach.Text += new DAO.SqlToLinq.Sach().getById(x.IdSach).TenSach + "\n\n";
            }

            txtPhiMuon.Text = pMuon + "";
            txtPhatMuon.Text = pTraMuon + "";
            txtTongPhi.Text = tongPhi + " VND";

            var PhieuNhac = new DAO.SqlToLinq.PhieuNhacTra().getByIdPhieuMuon(Phieu.Id);
            if (PhieuNhac != null)
            {
                if (PhieuNhac.NgayTao.Date == DateTime.Now.Date)
                {
                    btnTao.Visible = false;
                }
            }

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            var ngayMuon = (Phieu.NgayHenTra - Phieu.NgayMuon).Days;
            var ngayPhat = (DateTime.Now - Phieu.NgayHenTra).Days;
            var nt = new Models.PhieuNhacTra()
            {
                IdPhieuMuon = Phieu.Id,
                SoNgayMuon = ngayMuon,
                SoNgayPhat = ngayPhat,
                PhiMuon = double.Parse(txtPhiMuon.Text),
                PhiPhat = double.Parse(txtPhatMuon.Text),
                NgayTao = DateTime.Now,
            };

            if (new DAO.SqlToLinq.PhieuNhacTra().Insert(nt))
            {
                MessageBox.Show("Nhắc trả thành công");

                loadNew();
            }
            else
            {
                MessageBox.Show("Nhắc trả không thành công");
            }
        }

        public bool taoAll()
        {
            var ngayMuon = (Phieu.NgayHenTra - Phieu.NgayMuon).Days;
            var ngayPhat = (DateTime.Now - Phieu.NgayHenTra).Days;
            var nt = new Models.PhieuNhacTra()
            {
                IdPhieuMuon = Phieu.Id,
                SoNgayMuon = ngayMuon,
                SoNgayPhat = ngayPhat,
                PhiMuon = double.Parse(txtPhiMuon.Text),
                PhiPhat = double.Parse(txtPhatMuon.Text),
                NgayTao = DateTime.Now,
            };

            if (new DAO.SqlToLinq.PhieuNhacTra().Insert(nt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
