using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyTaiKhoan
{
    public partial class ModelQLTaiKhoan : UserControl
    {
        public ModelQLTaiKhoan()
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}
        }

        private void lblSTT_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void ModelQLTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
