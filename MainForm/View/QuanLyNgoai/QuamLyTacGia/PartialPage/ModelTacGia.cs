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
    public partial class ModelTacGia : UserControl
    {
        private Models.TacGia TG;
        private int stt;
        public ModelTacGia(int stt,Models.TacGia TG)
        {
            InitializeComponent();
            this.TG = TG;
            this.stt = stt;
            loadNew();
        }

        private void loadNew()
        {
            txtSTT.Text = stt.ToString();
            txtTen.Text = TG.TenTacGia.ToString();
            txtDiaChi.Text = TG.DiaChi.ToString();
            txtChucDanh.Text = TG.ChucDanh.ToString();
        }
    }
}
