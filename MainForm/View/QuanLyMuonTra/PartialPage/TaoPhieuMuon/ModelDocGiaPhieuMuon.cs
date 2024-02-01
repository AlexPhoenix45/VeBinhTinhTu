using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyMuonTra.QuanLyPhieuMuon
{
    public partial class ModelDocGiaPhieuMuon : UserControl
    {
        public int IdDG;
        public int STT;
        public string MaDocGia;
        public string TenDG;
        public bool Status;

        public ModelDocGiaPhieuMuon(int STT, int IdDG, string MaDocGia, string TenDG, bool Status)
        {
            InitializeComponent();

            this.IdDG = IdDG;
            this.STT = STT;
            this.MaDocGia = MaDocGia;
            this.TenDG = TenDG;
            this.Status = Status;

            loadNew();
        }

        private void loadNew()
        {
            lblSTT.Text = STT.ToString();
            lblMaDG.Text = MaDocGia;
            lblTenDG.Text = TenDG;
            if (Status)
            {
                lblStatus.Text = "";
            }
            else
            {
                lblStatus.Text = "Chưa Trả sách";
                btnTaoPhieu.Visible = false;
            }
        }

        private void ModelDocGiaPhieuMuon_MouseEnter(object sender, EventArgs e)
        {
            var row = (Control)sender;
            row.BackColor = Color.LightGray;
        }

        private void ModelDocGiaPhieuMuon_MouseLeave(object sender, EventArgs e)
        {
            var row = (Control)sender;
            row.BackColor = Color.Transparent;
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            var crP = new QuanLyPhieuMuon.CreatePhieuMuon(IdDG);

            crP.Show();
        }
    }
}
