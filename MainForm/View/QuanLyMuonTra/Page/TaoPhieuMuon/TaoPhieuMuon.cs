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
        private DataTable dataTable;
        public TaoPhieuMuon()
        {
            InitializeComponent();

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
                    var row = new View.QuanLyMuonTra.QuanLyPhieuMuon.ModelDocGiaPhieuMuon(i, dg.Id, dg.MaDocGia, dgU.TaiKhoan, true);
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

        }

    }
}
