using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.QuanLyChucNang
{
    public partial class QuanLyPhanQuyen : UserControl
    {

        private List<int> role1 = new List<int>();
        private List<int> role2 = new List<int>();
        private List<int> role3 = new List<int>();

        public QuanLyPhanQuyen()
        {
            InitializeComponent();
            LoadNewRole();
        }


        private void LoadNewActionInActive(int IdRole)
        {
            try
            {
                pnUpdate.Controls.Clear();

                var listAction = new DAO.SqlToLinq.Action().getAll().Where(x => x.Status == 1);

                foreach (var name in listAction.Where(x => x.IdParent == 0))
                {
                    if (new DAO.SqlToLinq.RoleAction().getByIdRoleAndAction(IdRole, name.Id) != null)
                    {
                        var lbl = new Label();
                        lbl.Text = "\n" + name.Name;
                        lbl.Font = new Font(lbl.Font.FontFamily, 12f, lbl.Font.Style);
                        lbl.Width = pnAction.Width - 25;
                        lbl.Height = 60;

                        pnUpdate.Controls.Add(lbl);

                        var pr = new Label();
                        pr.Width = lbl.Width - 25;
                        pr.Text = "* Truy cập";

                        pnUpdate.Controls.Add(pr);

                        foreach (var sub in listAction.Where(y => y.IdParent == name.Id))
                        {
                            if (new DAO.SqlToLinq.RoleAction().getByIdRoleAndAction(IdRole, sub.Id) != null)
                            {
                                var ck = new Label();
                                ck.Width = pr.Width;
                                ck.Text = sub.Name;
                                pnUpdate.Controls.Add(ck);
                            }

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void LoadNewAction(int IdRole)
        {
            try
            {
                role1.Clear();
                role2.Clear();
                role3.Clear();
                pnAction.Controls.Clear();

                var listAction = new DAO.SqlToLinq.Action().getAll().Where(x => x.Status == 1);

                foreach (var name in listAction.Where(x => x.IdParent == 0))
                {
                    var lbl = new Label();
                    lbl.Text = "\n" + name.Name;
                    lbl.Font = new Font(lbl.Font.FontFamily, 12f, lbl.Font.Style);
                    lbl.Width = pnAction.Width - 25;
                    lbl.Height = 60;

                    pnAction.Controls.Add(lbl);

                    var pr = new CheckBox();
                    pr.Width = lbl.Width - 20;
                    pr.Text = "* Truy cập";
                    pr.Tag = name.Id;

                    if (new DAO.SqlToLinq.RoleAction().getByIdRoleAndAction(IdRole, name.Id) != null)
                    {
                        pr.Checked = true;

                        if (IdRole == 1)
                        {
                            role1.Add(name.Id);
                        }
                        else if (IdRole == 2)
                        {
                            role2.Add(name.Id);
                        }
                        else
                        {
                            role3.Add(name.Id);
                        }
                    }


                    pr.CheckedChanged += (sender, e) =>
                    {
                        // Gọi phương thức CheckList và chuyển giá trị int vào
                        CheckList(sender, e, IdRole);
                    };

                    pnAction.Controls.Add(pr);

                    foreach (var sub in listAction.Where(y => y.IdParent == name.Id))
                    {
                        var ck = new CheckBox();
                        ck.Width = lbl.Width;
                        ck.Text = sub.Name;
                        ck.Tag = sub.Id;


                        if (new DAO.SqlToLinq.RoleAction().getByIdRoleAndAction(IdRole, sub.Id) != null)
                        {
                            ck.Checked = true;

                            if (IdRole == 1)
                            {
                                role1.Add(sub.Id);
                            }
                            else if (IdRole == 2)
                            {
                                role2.Add(sub.Id);
                            }
                            else
                            {
                                role3.Add(sub.Id);
                            }
                        }

                        pnAction.Controls.Add(ck);

                        ck.CheckedChanged += (sender, e) =>
                        {
                            // Gọi phương thức CheckList và chuyển giá trị int vào
                            CheckList(sender, e, IdRole);
                        };



                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }


        private void CheckList(object sender, EventArgs e, int IdRole)
        {
            CheckBox rd = (CheckBox)sender;
            if (rd.Checked)
            {
                // Xử lý khi RadioButton được chọn
                //MessageBox.Show(rd.Tag.ToString());
                // Thực hiện các hành động cần thiết dựa trên roleId hoặc roleName

                if (IdRole == 1)
                {
                    role1.Add(int.Parse(rd.Tag.ToString()));
                }
                else if (IdRole == 2)
                {
                    role2.Add(int.Parse(rd.Tag.ToString()));
                }
                else
                {
                    role3.Add(int.Parse(rd.Tag.ToString()));
                }
            }
            else
            {

                if (IdRole == 1)
                {
                    role1.Remove(int.Parse(rd.Tag.ToString()));
                }
                else if (IdRole == 2)
                {
                    role2.Remove(int.Parse(rd.Tag.ToString()));
                }
                else
                {
                    role3.Remove(int.Parse(rd.Tag.ToString()));
                }
            }
        }

        private void LoadNewRole()
        {
            try
            {
                var listRole = new DAO.SqlToLinq.Role().getAll().Where(x => x.Status == 1).ToList();

                foreach (var role in listRole)
                {
                    var rd = new RadioButton();
                    rd.Width = pnRole.Width - 10;
                    rd.Text = role.RoleName;
                    rd.Tag = role.Id;
                    rd.CheckedChanged += RD_Check;
                    pnRole.Controls.Add(rd);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void RD_Check(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            if (rd.Checked)
            {
                LoadNewAction(int.Parse(rd.Tag.ToString()));
                LoadNewActionInActive(int.Parse(rd.Tag.ToString()));

            }
        }

        private void Update(List<int> list, int IdRole)
        {
            try
            {
                foreach (var Act in new DAO.SqlToLinq.Action().getAll().Where(x => x.Status == 1))
                {
                    var id = new DAO.SqlToLinq.RoleAction().checkExist(IdRole, Act.Id);
                    if (id != -1)
                    {
                        var RA = new DAO.SqlToLinq.RoleAction().getById(id);
                        RA.Status = 0;

                        if (new DAO.SqlToLinq.RoleAction().Update(RA))
                        {
                            Debug.WriteLine("Set 0 " + Act.Name);
                        }
                    }
                    else
                    {
                        var RA = new Models.RoleAction()
                        {
                            IdAction = Act.Id,
                            IdRole = IdRole,
                            CreateAt = DateTime.Now,
                            UpdateAt = DateTime.Now,
                            Status = 0
                        };

                        if (new DAO.SqlToLinq.RoleAction().Insert(RA))
                        {
                            Debug.WriteLine("Them 0 " + Act.Name);
                        }
                    }
                }


                foreach (var IdAct in list)
                {
                    var id = new DAO.SqlToLinq.RoleAction().checkExist(IdRole, IdAct);
                    if (id != -1)
                    {
                        var RA = new DAO.SqlToLinq.RoleAction().getById(id);
                        RA.Status = 1;


                        if (new DAO.SqlToLinq.RoleAction().Update(RA))
                        {
                            Debug.WriteLine("Set 1 _ " + IdAct);
                        }
                    }
                }

                LoadNewActionInActive(IdRole);
                new MainForm.View.TrangChu.TrangChu().loadNew();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (role1.Count > 0)
            {
                Update(role1, 1);
                if (Models.Session.Role.Id == 1)
                {
                    MessageBox.Show("Thành công, hãy mở lại để hoàn tất cập nhật");
                }
                else
                {
                    MessageBox.Show("Đã cập nhật");
                }
            }
            if (role2.Count > 0)
            {
                Update(role2, 2);
                if (Models.Session.Role.Id == 2)
                {
                    MessageBox.Show("Thành công, hãy mở lại để hoàn tất cập nhật");
                }
                else
                {
                    MessageBox.Show("Đã cập nhật");
                }
            }
            if (role3.Count > 0)
            {
                Update(role3, 3);
                if (Models.Session.Role.Id == 3)
                {
                    MessageBox.Show("Thành công, hãy mở lại để hoàn tất cập nhật");
                }
                else
                {
                    MessageBox.Show("Đã cập nhật");
                }
            }

        }
    }
}
