using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View.QuanLyChucNang
{
    public partial class ThemQuyen : Form
    {
        public ThemQuyen()
        {
            InitializeComponent();
            loadNew();
        }

        private void loadNew()
        {
            var Acts = new DAO.SqlToLinq.Action().getAll().Where(x => x.IdParent == 0 && x.Status == 1);

            List<Models.CheckBox> items = new List<Models.CheckBox>();
            
            var it1 = new Models.CheckBox();
            it1.DisplayText = "";
            it1.Value = 0;
            items.Add(it1);

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

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (Hien.Checked)
            {
                i = 1;
            }
            var Act = new Models.Action()
            {
                IdParent = int.Parse(IdParent.SelectedValue.ToString()),
                Controller = NP.Text,
                Name = Name.Text,
                ActionName = Class.Text,
                IsChucNangHien = i,
                CreateAt = DateTime.Now,
                UpdateAt = DateTime.Now,
                Status = 1
            };

            if (new DAO.SqlToLinq.Action().Insert(Act))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
