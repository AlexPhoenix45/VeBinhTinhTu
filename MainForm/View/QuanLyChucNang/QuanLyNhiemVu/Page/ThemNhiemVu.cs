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
    public partial class ThemNhiemVu : Form
    {
        public ThemNhiemVu()
        {
            InitializeComponent();

            Date.Format = DateTimePickerFormat.Custom;
            Date.CustomFormat = "dd/MM/yyyy";
            Date.Value = DateTimePicker.MaximumDateTime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Role = new Models.Role()
            {
                IsNhiemVu = 1,
                RoleName = Name.Text,
                Name = "",
                ThoiHan = Date.Value != DateTimePicker.MaximumDateTime ? Date.Value : null,
                Status = 1,
            };
            if (new DAO.SqlToLinq.Role().InsertRole(Role))
            {
                MessageBox.Show("Thêm thành công");
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
