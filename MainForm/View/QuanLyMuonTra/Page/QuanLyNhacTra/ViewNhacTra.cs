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
    public partial class ViewNhacTra : UserControl
    {
        public ViewNhacTra()
        {
            InitializeComponent();

            loadNew();
        }

        private void loadNew()
        {

            foreach (var x in new DAO.SqlToLinq.PhieuMuon().getAll().Where(x => x.IdDocGia == Models.Session.IdUserInRole
                                                                          && x.Status == 1))
            {
                var row = new View.QuanLyMuonTra.QuanLyNhacTra.ModelViewNhacTra(x);

                ListNT.Controls.Add(row);
            }
        }
    }
}
