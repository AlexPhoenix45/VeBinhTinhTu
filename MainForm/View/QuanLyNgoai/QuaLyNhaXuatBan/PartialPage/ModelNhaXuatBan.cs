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

namespace View.QuanLyNgoai
{
    public partial class ModelNhaXuatBan : UserControl
    {
        private Models.NhaXuatBan NXB;
        private int stt;
        public ModelNhaXuatBan(int stt, Models.NhaXuatBan NXB)
        {
            InitializeComponent();
            this.NXB = NXB;
            this.stt = stt;
            loadNew();
        }
        private void loadNew()
        {
            try
            {
                txtSTT.Text = stt.ToString();
                txtTen.Text = NXB.TenNhaXuatBan.ToString();
                txtDiaChi.Text = NXB.DiaChi.ToString();
                txtNgay.Text = NXB.NgayThanhLap.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "leuleu");
            }
        }


        private void btnXoa_MouseEnter_1(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void ModelNhaXuatBan_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
