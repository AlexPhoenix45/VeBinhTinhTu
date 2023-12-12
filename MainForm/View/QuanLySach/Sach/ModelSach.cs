using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.Sach
{
    public partial class ModelSach : UserControl
    {
        public ModelSach()
        {
            InitializeComponent();
        }
        public event EventHandler ReloadXoaSachComplete;
        private void img_Click(object sender, EventArgs e)
        {
            if (img.Tag != null)
            {
                Sach.ChiTietSach sach = new ChiTietSach(int.Parse(img.Tag.ToString()));


                sach.XoaSachComplete += sach_XoaSachComplete;

                Control parent = this.Parent;

                parent.Controls.Clear();
                parent.Controls.Add(sach);
            }
        }

        private void sach_XoaSachComplete(object sender, EventArgs e)
        {
            ReloadXoaSachComplete?.Invoke(this, EventArgs.Empty);
        }
    }
}
