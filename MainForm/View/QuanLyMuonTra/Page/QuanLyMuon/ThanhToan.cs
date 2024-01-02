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
    public partial class ThanhToan : Form
    {
        private List<int> ListIdChiTiet = new List<int>();
        private List<double> ListTiLe = new List<double>();
        private Models.PhieuMuon Phieu;
        private double pMuon = 0;
        private double phatMuon = 0;
        private double phatHong = 0;
        public string GhiChuTra;

        public ThanhToan(Models.PhieuMuon Phieu, List<int> IdChiTiet, List<double> ListTiLe)
        {
            InitializeComponent();

            ListIdChiTiet = IdChiTiet;
            this.ListTiLe = ListTiLe;
            this.Phieu = Phieu;

            loadNew();
        }

        private void loadNew()
        {
            pnNoiDung.Controls.Clear();

            var row_th = new QuanLyMuonTra.QuanLyMuon.ModelListSachThanhToan();

            row_th.lblTen.Text = "Tên sách";
            row_th.lblMuon.Text = "Phí mượn";
            row_th.lblPHong.Text = "Phạt muộn";
            row_th.lblPMuon.Text = "Phạt hư hại";
            row_th.lblTong.Text = "Tổng";

            pnNoiDung.Controls.Add(row_th);

            var ngayMuon = (Phieu.NgayHenTra - Phieu.NgayMuon).Days;
            var ngayPhat = (DateTime.Now - Phieu.NgayHenTra).Days;

            double tongPhi = 0;
            for (int i = 0; i < ListIdChiTiet.Count; i++)
            {
                var ChiTiet = new DAO.SqlToLinq.ChiTietMuon().getAll().Where(x => x.Id == ListIdChiTiet[i]).FirstOrDefault();
                var sach = new DAO.SqlToLinq.Sach().getById(ChiTiet.IdSach);
                var rowList = new View.QuanLyMuonTra.QuanLyMuon.ModelListSachThanhToan();


                rowList.lblTen.Text = sach.TenSach;

                double phiMuon = (ngayMuon * 1000);
                double phatMuon = (ngayPhat * sach.GiaSach * 0.1);
                double phatHong = (sach.GiaSach * (ListTiLe[i] / 100));

                Debug.WriteLine(ListTiLe[i] + " * " + sach.GiaSach + " = " + phatHong);

                rowList.lblMuon.Text = phiMuon.ToString();
                rowList.lblPMuon.Text = phatMuon.ToString();
                rowList.lblPHong.Text = phatHong.ToString();

                rowList.lblTong.Text = (phiMuon + phatMuon + phatHong) + " VND";
                pnListSach.Controls.Add(rowList);


                pMuon += phiMuon;
                this.phatMuon += phatMuon;
                this.phatHong += phatHong;

                tongPhi += (phiMuon + phatMuon + phatHong);
            }

            pnNoiDung.Controls.Add(pnListSach);

            var rowTong = new QuanLyMuonTra.QuanLyMuon.ModelListSachThanhToan();

            rowTong.lblTen.Text = "";
            rowTong.lblMuon.Text = "";
            rowTong.lblPHong.Text = "";
            rowTong.lblPMuon.Text = "";
            rowTong.lblTong.Text = tongPhi + " VND";

            pnNoiDung.Controls.Add(rowTong);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                Phieu.PhiMuon = (float) pMuon;
                Phieu.PhiPhatTraMuon = (float) phatMuon;
                Phieu.PhiPhatHongSach = (float) phatHong;
                Phieu.GhiChuTra = GhiChuTra;
                Phieu.IdNVThanhToan = Models.Session.IdUserInRole;
                Phieu.Status = 0;

                if(new DAO.SqlToLinq.ChiTietMuon().UpdateAll(ListIdChiTiet, ListTiLe))
                {
                    if(new DAO.SqlToLinq.PhieuMuon().Update(Phieu)) 
                    {
                        MessageBox.Show("Thanh toán thành công");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thành công, có lỗi xảy ra");
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công, có lỗi xảy ra");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thành công, có lỗi xảy ra");
            }
        }
    }
}
