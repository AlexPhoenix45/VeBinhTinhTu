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
    public partial class DSUser : Form
    {
        private List<int> IdU = new List<int>();
        private Models.Role r;
        public DSUser(Models.Role r)
        {
            InitializeComponent();
            this.r = r;
            load();
        }

        private void lpnDG(bool ck, int LanDau)
        {
            pnDG.Controls.Clear();
            if (LanDau == 0)
            {
                foreach (var x in new DAO.SqlToLinq.DocGia().getAll().Where(x => x.Status == 1))
                {
                    bool k = false;
                    if (new DAO.SqlToLinq.UserRole().GetAll().Where(u => u.IdUser == x.IdUser && u.IdRole == this.r.Id && u.Status == 1).FirstOrDefault() != null)
                    {
                        k = true;
                        IdU.Add(x.IdUser);
                    }
                    var r = new CheckBox()
                    {
                        Checked = k,
                        Text = x.MaDocGia + "_" + new DAO.SqlToLinq.Users().getById(x.IdUser).TaiKhoan,
                        Tag = x.IdUser
                    };
                    r.Width = pnDG.Width;
                    r.CheckedChanged += R_CheckedChanged;
                    pnDG.Controls.Add(r);
                }
            }
            else
            {
                if (ck)
                {
                    foreach (var x in new DAO.SqlToLinq.DocGia().getAll().Where(x => x.Status == 1))
                    {
                        var r = new CheckBox()
                        {
                            Checked = true,
                            Text = x.MaDocGia + "_" + new DAO.SqlToLinq.Users().getById(x.IdUser).TaiKhoan,
                            Tag = x.IdUser
                        };
                        IdU.Add(x.IdUser);
                        r.Width = pnDG.Width;
                        r.CheckedChanged += R_CheckedChanged;
                        pnDG.Controls.Add(r);
                    }
                }
                else
                {
                    foreach (var x in new DAO.SqlToLinq.DocGia().getAll().Where(x => x.Status == 1))
                    {
                        var r = new CheckBox()
                        {
                            Checked = false,
                            Text = x.MaDocGia + "_" + new DAO.SqlToLinq.Users().getById(x.IdUser).TaiKhoan,
                            Tag = x.IdUser
                        };
                        if (IdU.Contains(x.IdUser))
                        {
                            IdU.Remove(x.IdUser);
                        }
                        r.Width = pnDG.Width;
                        r.CheckedChanged += R_CheckedChanged;
                        pnDG.Controls.Add(r);
                    }
                }
            }
        }

        private void lpnNV(bool ck, int LanDau)
        {
            pnNV.Controls.Clear();
            if (LanDau == 0)
            {
                foreach (var x in new DAO.SqlToLinq.NhanVien().getAll().Where(x => x.Status == 1))
                {
                    bool k = false;
                    if (new DAO.SqlToLinq.UserRole().GetAll().Where(u => u.IdUser == x.IdUser && u.IdRole == this.r.Id && u.Status == 1).FirstOrDefault() != null)
                    {
                        k = true;
                        IdU.Add(x.IdUser);
                    }
                    var r = new CheckBox()
                    {
                        Checked = k,
                        Text = x.MaNhanVien + "_" + new DAO.SqlToLinq.Users().getById(x.IdUser).TaiKhoan,
                        Tag = x.IdUser
                    };
                    r.Width = pnDG.Width;
                    r.CheckedChanged += R_CheckedChanged;
                    pnNV.Controls.Add(r);
                }
            }
            else
            {
                if (ck)
                {
                    foreach (var x in new DAO.SqlToLinq.NhanVien().getAll().Where(x => x.Status == 1))
                    {
                        var r = new CheckBox()
                        {
                            Checked = true,
                            Text = x.MaNhanVien + "_" + new DAO.SqlToLinq.Users().getById(x.IdUser).TaiKhoan,
                            Tag = x.IdUser
                        };
                        IdU.Add(x.IdUser);
                        r.Width = pnDG.Width;
                        r.CheckedChanged += R_CheckedChanged;
                        pnNV.Controls.Add(r);
                    }
                }
                else
                {
                    foreach (var x in new DAO.SqlToLinq.NhanVien().getAll().Where(x => x.Status == 1))
                    {
                        var r = new CheckBox()
                        {
                            Checked = false,
                            Text = x.MaNhanVien + "_" + new DAO.SqlToLinq.Users().getById(x.IdUser).TaiKhoan,
                            Tag = x.IdUser
                        };
                        if (IdU.Contains(x.IdUser))
                        {
                            IdU.Remove(x.IdUser);
                        }
                        r.Width = pnDG.Width;
                        r.CheckedChanged += R_CheckedChanged;
                        pnNV.Controls.Add(r);
                    }
                }
            }
        }

        private void R_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox CheckBox = sender as CheckBox;

            if (CheckBox != null)
            {
                bool isChecked = CheckBox.Checked;
                object tagValue = CheckBox.Tag;

                if (isChecked)
                {
                    IdU.Add((int)tagValue);
                }
                else
                {
                    IdU.Remove((int)tagValue);
                }
                // Sử dụng isChecked và tagValue tại đây
            }
        }

        private void lpnQT(bool ck, int LanDau)
        {
            pnQT.Controls.Clear();
            if (LanDau == 0)
            {
                foreach (var x in new DAO.SqlToLinq.Admin().getAll().Where(x => x.Status == 1))
                {
                    bool k = false;
                    if (new DAO.SqlToLinq.UserRole().GetAll().Where(u => u.IdUser == x.IdUser && u.IdRole == this.r.Id && u.Status == 1).FirstOrDefault() != null)
                    {
                        k = true;
                        IdU.Add(x.IdUser);
                    }
                    var r = new CheckBox()
                    {
                        Checked = k,
                        Text = x.MaAdmin + "_" + new DAO.SqlToLinq.Users().getById(x.IdUser).TaiKhoan,
                        Tag = x.IdUser
                    };
                    r.Width = pnDG.Width;
                    r.CheckedChanged += R_CheckedChanged;
                    pnQT.Controls.Add(r);
                }
            }
            else
            {
                if (ck)
                {
                    foreach (var x in new DAO.SqlToLinq.Admin().getAll().Where(x => x.Status == 1))
                    {
                        var r = new CheckBox()
                        {
                            Checked = true,
                            Text = x.MaAdmin + "_" + new DAO.SqlToLinq.Users().getById(x.IdUser).TaiKhoan,
                            Tag = x.IdUser
                        };
                        IdU.Add(x.IdUser);
                        r.Width = pnDG.Width;
                        r.CheckedChanged += R_CheckedChanged;
                        pnQT.Controls.Add(r);
                    }
                }
                else
                {
                    foreach (var x in new DAO.SqlToLinq.Admin().getAll().Where(x => x.Status == 1))
                    {
                        var r = new CheckBox()
                        {
                            Checked = false,
                            Text = x.MaAdmin + "_" + new DAO.SqlToLinq.Users().getById(x.IdUser).TaiKhoan,
                            Tag = x.IdUser
                        };
                        if (IdU.Contains(x.IdUser))
                        {
                            IdU.Remove(x.IdUser);
                        }
                        r.Width = pnDG.Width;
                        r.CheckedChanged += R_CheckedChanged;
                        pnQT.Controls.Add(r);
                    }
                }
            }
        }

        private void load()
        {
            lpnDG(false, 0);
            lpnNV(false, 0);
            lpnQT(false, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var ur in new DAO.SqlToLinq.UserRole().GetAll().Where(x => x.IdRole == r.Id))
            {
                ur.Status = -1;
                new DAO.SqlToLinq.UserRole().Update(ur);

            }

            foreach(var u in IdU)
            {
                var ur = new DAO.SqlToLinq.UserRole().GetAll().Where(x => x.IdUser == u && x.IdRole == r.Id).FirstOrDefault();
                if(ur != null)
                {
                    ur.Status = 1;

                    new DAO.SqlToLinq.UserRole().Update(ur);
                }
                else
                {
                    ur = new Models.UserRole()
                    {
                        IdRole = r.Id,
                        IdUser = u,
                        Status = 1
                    };
                    new DAO.SqlToLinq.UserRole().Insert(ur);
                }
            }
            MessageBox.Show("Thành công");

            this.Close();

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            lpnDG(checkBox4.Checked, 1);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            lpnNV(checkBox5.Checked, 1);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            lpnQT(checkBox6.Checked, 1);
        }
    }
}
