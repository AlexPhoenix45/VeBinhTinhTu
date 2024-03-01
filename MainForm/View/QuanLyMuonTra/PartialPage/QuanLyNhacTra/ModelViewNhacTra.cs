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
    public partial class ModelViewNhacTra : UserControl
    {
        private Models.PhieuMuon Phieu;
        private Models.PhieuNhacTra PhieuNhacTra;

        public ModelViewNhacTra(Models.PhieuMuon Phieu)
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}
            this.Phieu = Phieu;
            PhieuNhacTra = new DAO.SqlToLinq.PhieuNhacTra().getByIdPhieuMuon(Phieu.Id);

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
            txtNgayTra.Text = PhieuNhacTra.NgayTao.ToString("dd/MM/yyyy");

            txtGhiChuMuon.Text = Phieu.GhiChuMuon;


            pnListSach.Text = "";

            foreach (var x in new DAO.SqlToLinq.ChiTietMuon().getByIdPhieu(Phieu.Id))
            {
                pnListSach.Text += new DAO.SqlToLinq.Sach().getById(x.IdSach).TenSach + "\n\n";
            }

            txtPhiMuon.Text = PhieuNhacTra.PhiMuon + "";
            txtPhatMuon.Text = PhieuNhacTra.PhiPhat + "";
            txtTongPhi.Text = PhieuNhacTra.PhiMuon + PhieuNhacTra.PhiPhat + " VND";
        }
    }
}
