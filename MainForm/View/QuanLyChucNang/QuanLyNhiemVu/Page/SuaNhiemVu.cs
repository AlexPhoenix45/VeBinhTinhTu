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
    public partial class SuaNhiemVu : Form
    {
        private Models.Role r;
        public SuaNhiemVu(Models.Role r)
        {
            InitializeComponent();
            this.r = r;

            Name.Text = r.RoleName;
            Date.Value = r.ThoiHan.HasValue? r.ThoiHan.Value : DateTimePicker.MaximumDateTime;
            Date.Format = DateTimePickerFormat.Custom;
            Date.CustomFormat = "dd/MM/yyyy";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r.RoleName = Name.Text;
            r.ThoiHan = Date.Value != DateTimePicker.MaximumDateTime ? Date.Value : null;
            if (new DAO.SqlToLinq.Role().UpdateRole(r))
            {
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
