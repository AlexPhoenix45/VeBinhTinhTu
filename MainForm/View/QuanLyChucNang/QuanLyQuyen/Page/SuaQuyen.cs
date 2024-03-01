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
    public partial class SuaQuyen : Form
    {
        private Models.Action Act;
        public SuaQuyen(Models.Action Act)
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}

            this.Act = Act;
            loadNew();
        }

        private void loadNew()
        {
            var Acts = new DAO.SqlToLinq.Action().getAll().Where(x => x.IdParent == 0 && x.Status == 1);

            Name.Text = Act.Name;
            NP.Text = Act.Controller;
            Class.Text = Act.ActionName;
            if (Act.IsChucNangHien == 1)
            {
                Hien.Checked = true;
            }

            List<Models.CheckBox> items = new List<Models.CheckBox>();

            var it1 = new Models.CheckBox();
            if (Act.IdParent != 0)
            {
                it1.DisplayText = new DAO.SqlToLinq.Action().getById(Act.IdParent).Name;
                it1.Value = Act.IdParent;
                items.Add(it1);
            }
            else
            {
                it1.DisplayText = "";
                it1.Value = 0;
                IdParent.Enabled = false;
                items.Add(it1);
            }

            foreach (var action in Acts)
            {
                var it = new Models.CheckBox();
                it.Value = action.Id;
                it.DisplayText = action.Name;

                items.Add(it);
            }

            IdParent.DataSource = items;
            IdParent.ValueMember = "Value";
            IdParent.DisplayMember = "DisplayText";

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            if (Hien.Checked)
            {
                i = 1;
            }
            Act.IdParent = int.Parse(IdParent.SelectedValue.ToString());
            Act.Controller = NP.Text;
            Act.Name = Name.Text;
            Act.ActionName = Class.Text;
            Act.IsChucNangHien = i;
            Act.UpdateAt = DateTime.Now;

            if (new DAO.SqlToLinq.Action().Update(Act))
            {
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
        }
    }
}
