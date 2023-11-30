using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.View.TrangChu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            var roles = new DAO.SqlToLinq.Role().getAll().Where(x => x.Status == 1).ToList();

            txtRole.DisplayMember = "RoleName";
            txtRole.ValueMember = "Name";

            txtRole.DataSource = roles;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var tk = txtTaiKhoan.Text;
            var pass = txtPass.Text;
            var role = txtRole.SelectedValue.ToString();
            if(tk != "" && pass != "")
            {
                if(new XuLy.TrangChu.Login().LoginRole(tk, pass, role))
                {
                    var TrangChu = new TrangChu();

                    TrangChu.Show();
                }
                else
                {
                    MessageBox.Show("đăng nhập không thành công, vui lòng kiểm tra thông tin đang nhập");
                }
            }
            else
            {
                MessageBox.Show("vui lòng nhập đủ thông tin");
            }
        }


    }
}
