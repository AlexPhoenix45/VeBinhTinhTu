using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuonTra.QuanLyPhieuMuon
{
    public partial class TaoPhieuMuon : UserControl
    {
        public TaoPhieuMuon()
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}

            loadNew();
        }


        private void loadNew()
        {
            try
            {
                int i = 1;
                foreach (var dg in new DAO.SqlToLinq.DocGia().getAll().Where(x => x.Status == 1).ToList())
                {
                    var dgU = new DAO.SqlToLinq.Users().getById(dg.IdUser);

                    var row = new View.QuanLyMuonTra.QuanLyPhieuMuon.ModelDocGiaPhieuMuon(i, dg.Id, dg.MaDocGia, dgU.TaiKhoan, new DAO.SqlToLinq.PhieuMuon().checkDGMuonSach(dg.Id));
                    pnTable.Controls.Add(row);
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                pnTable.Controls.Clear();
                var ma = txtMaDG.Text;

                var us = new DAO.SqlToLinq.Users();

                int i = 1;
                foreach (var dg in new DAO.SqlToLinq.DocGia().getAll().Where(x => (ma != string.Empty ? x.MaDocGia.ToLower().Contains(ma.ToLower()) : true)
                                                                                   && x.Status == 1))
                {
                    var dgU = new DAO.SqlToLinq.Users().getById(dg.IdUser);

                    var row = new View.QuanLyMuonTra.QuanLyPhieuMuon.ModelDocGiaPhieuMuon(i, dg.Id, dg.MaDocGia, dgU.TaiKhoan, new DAO.SqlToLinq.PhieuMuon().checkDGMuonSach(dg.Id));
                    pnTable.Controls.Add(row);
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
