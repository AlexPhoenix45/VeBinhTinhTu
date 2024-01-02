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
    public partial class QuanLyMuon : UserControl
    {
        public QuanLyMuon()
        {
            InitializeComponent();
            loadNew();
        }

        private void loadNew()
        {
            try
            {
                int i = 1;
                foreach (var p in new DAO.SqlToLinq.PhieuMuon().getAll().Where(x => x.Status >= 0).OrderByDescending(x => x.Id).ToList())
                {
                    var row = new View.QuanLyMuonTra.QuanLyMuon.ModelListPhieuMuon(i, p);
                    row.QuanLyMuon = this;

                    pnTable.Controls.Add(row);
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadNewHave_value(int value)
        {
            try
            {
                pnTable.Controls.Clear();
                int i = 1;
                foreach (var p in new DAO.SqlToLinq.PhieuMuon().getAll().Where(x => x.Status >= 0).OrderByDescending(x => x.Id).ToList())
                {
                    var row = new View.QuanLyMuonTra.QuanLyMuon.ModelListPhieuMuon(i, p);

                    pnTable.Controls.Add(row);

                    // Nếu đạt đến vị trí cần scroll, thực hiện scroll
                    if (p.Id == value)
                    {
                        int scrollY = row.Height * (i - 1); // Tính toán khoảng cách scroll theo chiều dọc
                        pnTable.AutoScrollPosition = new Point(0, scrollY);
                    }

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
