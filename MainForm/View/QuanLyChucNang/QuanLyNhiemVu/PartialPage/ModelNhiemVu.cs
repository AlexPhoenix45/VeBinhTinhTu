using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyChucNang
{

    public partial class ModelNhiemVu : UserControl
    {
        private Models.Role r;
        private int stt;
        public ModelNhiemVu(int stt, Models.Role r)
        {
            InitializeComponent();
            this.r = r;
            this.stt = stt;
            load();
        }

        private void load()
        {
            STT.Text = stt.ToString();
            Name.Text = r.RoleName;
            SL.Text = new DAO.SqlToLinq.UserRole().GetAll().Where(x => x.IdRole == r.Id && x.Status == 1).ToList().Count.ToString();
            ThHan.Text = r.ThoiHan.HasValue? r.ThoiHan.Value.ToString("dd/MM/yyyy") : "Vô thời hạn";

        }
    }
}
