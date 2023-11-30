﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            loadNew();
        }

        private void loadNew()
        {
            if (Models.Session.Users != null)
            {
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
                        if (Act.Controller != string.Empty)
                        {
                            menuItem.Click += MenuItem_Click;
                            menuItem.Tag = Act.Id;
                        }
                        foreach (var act in new DAO.SqlToLinq.Action().getSubMenuByIdAct(Act.Id, Acts))
                        {
                            ToolStripMenuItem subMenuItem = new ToolStripMenuItem(act.Name);
                            subMenuItem.Tag = Act.Id;
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

            string value = clickedMenuItem.Tag?.ToString();

            string className = "QuanLySach.Sach.QuanLySach";

            Type panelType = Type.GetType(className);

            if (panelType != null)
            {
                var subPanel = Activator.CreateInstance(panelType);

                if (subPanel is Control)
                {
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
            // Xử lý sự kiện khi một mục menu con được chọn
            ToolStripMenuItem clickedMenuItem = (ToolStripMenuItem)sender;

            // Lấy giá trị từ thuộc tính Tag
            string value = clickedMenuItem.Tag?.ToString();

            MessageBox.Show($"Selected Sub Menu: {clickedMenuItem.Text}, Value: {value}");
        }

    }
}
