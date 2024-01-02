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
    public partial class ModelNhacTra : UserControl
    {
        public ModelNhacTra()
        {
            InitializeComponent();

            hover();
        }

        private void hover()
        {
            foreach (var x in this.Controls)
            {
                if (x is Control ctrl)
                {
                    ctrl.MouseEnter += ModelListPhieuMuon_MouseEnter;
                    ctrl.MouseLeave += ModelListPhieuMuon_MouseLeave;
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

 
    }
}
