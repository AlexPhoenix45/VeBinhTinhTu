using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyTaiKhoan
{
    public partial class ThemTaiKhoan : Form
    {
        private int IdRole;
        public ThemTaiKhoan(int IdRole)
        {
            InitializeComponent();if (Models.Session.cd.CheDoToi == 1){this.BackColor = Color.Silver;}

            this.IdRole = IdRole;

            loadNew();
        }

        private void loadNew()
        {
            txtRole.Text = new DAO.SqlToLinq.Role().getAll().Where(x => x.Id == IdRole).FirstOrDefault().RoleName;
            txtRole.Tag = new DAO.SqlToLinq.Role().getAll().Where(x => x.Id == IdRole).FirstOrDefault().Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var us = new Models.Users
            {
                TaiKhoan = txtTen.Text,
                MatKhau = txtEmail.Text,
                Email = txtEmail.Text,
                SoDienThoai = txtSdt.Text,
                Status = 1,
                Role = "1"
            };

            int IdUs = new DAO.SqlToLinq.Users().Insert(us);

            if (IdUs > 0)
            {
                if (IdRole == 1)
                {
                    var dg = new Models.DocGia
                    {
                        IdUser = IdUs,
                        MaDocGia = "DocGia" + IdUs,
                        Status = 1,
                    };

                    if (new DAO.SqlToLinq.DocGia().Insert(dg))
                    {
                        MessageBox.Show("\t-Mã độc giả: DocGia" + IdUs, "Thêm độc giả thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xả ra khi thêm độc giả", "Lỗi");
                    }
                }


                if (IdRole == 2)
                {
                    var nv = new Models.NhanVien
                    {
                        IdUser = IdUs,
                        MaNhanVien = "NhanVien" + IdUs,
                        Status = 1,
                    };

                    if (new DAO.SqlToLinq.NhanVien().Insert(nv))
                    {
                        MessageBox.Show("\t-Mã nhân viên: NhanVien" + IdUs, "Thêm nhân viên thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xả ra khi thêm nhân viên", "Lỗi");
                    }
                }


                if (IdRole == 3)
                {
                    var ad = new Models.Admin
                    {
                        IdUser = IdUs,
                        MaAdmin = "Admin" + IdUs,
                        Status = 1,
                    };

                    if (new DAO.SqlToLinq.Admin().Insert(ad))
                    {
                        MessageBox.Show("\t-Mã quản trị: Admin" + IdUs, "Thêm quản trị thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xả ra khi thêm quản trị", "Lỗi");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
