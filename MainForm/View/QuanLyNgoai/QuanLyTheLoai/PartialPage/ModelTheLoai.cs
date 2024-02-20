using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyNgoai
{
    public partial class ModelTheLoai : UserControl
    {
        private Models.TheLoai TL;
        private int stt;
        public ModelTheLoai(int stt, Models.TheLoai TL)
        {
            InitializeComponent();
            this.TL = TL;
            this.stt = stt;
            loadNew();
        }
        private void loadNew()
        {
            txtSTT.Text = stt.ToString();
            txtTen.Text = TL.TenTheLoai.ToString();
        }




        private void btnXoa_MouseEnter_1(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void ModelTheLoai_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
