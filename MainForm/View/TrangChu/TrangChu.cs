﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MainForm.View.TrangChu
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();


            splitContainer1.Panel2.SizeChanged += PanelParent_SizeChanged;

            Debug.WriteLine(DateTime.Now);

            loadNew();
        }

        private void loadNew()
        {
            if (Models.Session.Users != null)
            {
                //full màn hình
                Screen mainScreen = Screen.PrimaryScreen;
                this.Width = mainScreen.Bounds.Width;
                this.Height = mainScreen.Bounds.Height;


                //Load thông tin người dùng
                txtRole.Text = Models.Session.Role.RoleName;
                txtTaiKhoan.Text = Models.Session.Users.TaiKhoan;
                txtRoleCode.Text = Models.Session.RoleCode;

                //load Menu
                var Acts = new DAO.SqlToLinq.Action().getByIdRole(Models.Session.Role.Id);
                foreach (var Act in Acts)
                {
                    if (Act.IdParent == 0)
                    {

                        // Tạo một mục menu mới
                        ToolStripMenuItem menuItem = new ToolStripMenuItem(Act.Name);
                        menuItem.TextAlign = ContentAlignment.MiddleLeft;
                        menuItem.Font = new System.Drawing.Font(menuItem.Font.FontFamily, 12, FontStyle.Regular);
                        menuItem.AutoSize = true;
                        menuItem.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);

                        if (Act.Controller != string.Empty)
                        {
                            menuItem.Click += MenuItem_Click;
                            menuItem.Tag = Act.Id;

                        }
                        foreach (var act in new DAO.SqlToLinq.Action().getSubMenuByIdAct(Act.Id, Acts))
                        {
                            ToolStripMenuItem subMenuItem = new ToolStripMenuItem(act.Name);
                            subMenuItem.Tag = act.Id;
                            subMenuItem.Click += SubMenuItem_Click;
                            menuItem.DropDownItems.Add(subMenuItem);
                        }
                        mnMenu.Items.Add(menuItem);
                    }
                }
            }

            pnNoiDung.Width = pnNoiDung.Parent.Width;
        }

        private void PanelParent_SizeChanged(object sender, EventArgs e)
        {
            // Khi kích thước của Panel cha thay đổi, cập nhật chiều rộng của Panel con
            SetChildPanelWidth();
        }

        private void SetChildPanelWidth()
        {
            pnNoiDung.Width = pnNoiDung.Parent.Width;
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedMenuItem = (ToolStripMenuItem)sender;

            string value = clickedMenuItem.Tag?.ToString(); // Id action
            var Act = new DAO.SqlToLinq.Action().getById(int.Parse(value));
            string className = Act.Controller + "." + Act.ActionName;

            Type panelType = Type.GetType(className);

            if (panelType != null)
            {
                var subPanel = Activator.CreateInstance(panelType);

                if (subPanel is Control)
                {
                    pnNoiDung.Controls.Clear();
                    pnNoiDung.Controls.Add(subPanel as Control);
                }
                else
                {
                    MessageBox.Show("Không thể thêm subPanel vào Container vì kiểu không đúng.");
                }
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy lớp có tên " + className);
            }
        }

        private void SubMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedMenuItem = (ToolStripMenuItem)sender;

            string value = clickedMenuItem.Tag?.ToString(); // Id action
            var Act = new DAO.SqlToLinq.Action().getById(int.Parse(value));
            string className = Act.Controller + "." + Act.ActionName;

            Type panelType = Type.GetType(className);

            if (panelType != null)
            {
                var subPanel = Activator.CreateInstance(panelType);

                if (subPanel is Control)
                {
                    pnNoiDung.Controls.Clear();
                    pnNoiDung.Controls.Add(subPanel as Control);
                }
                else
                {
                    MessageBox.Show("Không thể thêm subPanel vào Container vì kiểu không đúng.");
                }
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy lớp có tên " + className);
            }
        }

    }
}
