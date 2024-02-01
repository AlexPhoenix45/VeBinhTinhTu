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
    public partial class ModelsQuyen : UserControl
    {
        private int STT;
        private Models.Action Act;
        public ModelsQuyen(int stt, Models.Action Act)
        {
            InitializeComponent();

            this.STT = stt;
            this.Act = Act;

            loadNew();
        }


        private void loadNew()
        {
            lblStt.Text = STT.ToString();
            lblParent.Text = "";
            if (Act.IdParent != 0)
            {
                lblParent.Text = new DAO.SqlToLinq.Action().getById(Act.IdParent).Name;
            }

            lblName.Text = Act.Name;
            lblNP.Text = Act.Controller;
            lblClass.Text = Act.ActionName;
            lblChucNang.Text = "v";
            if (Act.IsChucNangHien == 0)
            {
                lblChucNang.Text = "";
            }
        }



        private void ModelsQuyen_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void ModelsQuyen_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
