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
    public partial class ModelListSachThanhToan : UserControl
    {
        public ModelListSachThanhToan()
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}
        }
    }
}
