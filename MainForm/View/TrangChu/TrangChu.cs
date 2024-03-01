using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MainForm.View.TrangChu
{
    public partial class TrangChu : Form
    {
        private int sizelogo = 60;
        public TrangChu()
        {
            InitializeComponent();

            loadNew();
        }


        private void loadLogo()
        {
            try
            {
                // Nạp hình ảnh của bạn
                Bitmap hinhGoc = new Bitmap("D:\\LapTrinhWindow\\QuanLyThuVien\\MainForm\\Web\\Img\\Logo.png");

                // Tạo một Bitmap có kích thước 60x60
                Bitmap hinhNho = new Bitmap(sizelogo, sizelogo);

                // Tạo một đối tượng Graphics để làm việc với Bitmap hinhNho
                using (Graphics g = Graphics.FromImage(hinhNho))
                {
                    // Đặt chế độ vẽ cho hình ảnh
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    // Tạo một GraphicsPath để định rộng hình tròn
                    using (GraphicsPath duongPath = new GraphicsPath())
                    {
                        // Thêm hình elip vào GraphicsPath
                        duongPath.AddEllipse(0, 0, sizelogo, sizelogo);

                        // Sử dụng đối tượng Graphics để thiết lập vùng clip
                        g.SetClip(duongPath);

                        // Vẽ hình ảnh gốc lên Bitmap hinhNho
                        g.DrawImage(hinhGoc, 0, 0, sizelogo, sizelogo);
                    }
                }

                // Đặt hình ảnh hình tròn làm hình nền cho PictureBox
                pictureBox2.BackgroundImage = hinhNho;
                // Stretch hình ảnh để vừa với PictureBox
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void loadNew()
        {
            mnMenu.Items.Clear();
            if (Models.Session.Users != null)
            {

                if (Models.Session.cd.CheDoToi == 1)
                {
                    this.BackColor = Color.DarkGray;
                    pnNoiDung.BackColor = Color.DarkGray;
                    mnMenu.BackColor = Color.DarkGray;
                }
                else
                {
                    this.BackColor = SystemColors.Control;
                    pnNoiDung.BackColor= Color.White;
                    mnMenu.BackColor = SystemColors.Control;
                }

                splitContainer1.Panel2.SizeChanged += PanelParent_SizeChanged;

                Debug.WriteLine(DateTime.Now);

                //full màn hình
                Screen mainScreen = Screen.PrimaryScreen;
                this.Width = mainScreen.Bounds.Width;
                this.Height = mainScreen.Bounds.Height;

                pntt.Width = pntt.Parent.Width;
                pnBan.Width = pnBan.Parent.Width;

                loadLogo();

                lblNow.Text = DateTime.Now.ToString("dd/MM/yyyy");

                //Load thông tin người dùng
                txtRole.Text = Models.Session.Role.RoleName;
                txtTaiKhoan.Text = Models.Session.Users.TaiKhoan;
                txtRoleCode.Text = Models.Session.RoleCode;

                //load Menu
                var Acts = new DAO.SqlToLinq.Action().getAllByIdUser();

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
                    if (subPanel is QLTV.View.CaiDat.CaiDat)
                    {
                        Debug.WriteLine("a đây rồi1");
                        var cd = (QLTV.View.CaiDat.CaiDat)subPanel;
                        cd.DoiGD.Click += DoiGD_CheckedChanged;
                        pnNoiDung.Controls.Clear();
                        pnNoiDung.Controls.Add(cd);
                    }
                    else
                    {
                        pnNoiDung.Controls.Clear();
                        pnNoiDung.Controls.Add(subPanel as Control);
                    }
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
                    if (subPanel is QLTV.View.CaiDat.CaiDat)
                    {
                        Debug.WriteLine("a đây rồi1");
                        var cd = (QLTV.View.CaiDat.CaiDat)subPanel;
                        cd.DoiGD.Click += DoiGD_CheckedChanged;
                        pnNoiDung.Controls.Clear();
                        pnNoiDung.Controls.Add(cd);
                    }
                    else
                    {
                        pnNoiDung.Controls.Clear();
                        pnNoiDung.Controls.Add(subPanel as Control);
                    }
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

        private void DoiGD_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RJToggleButton checkBox)
            {
                if (checkBox.Checked == true)
                {
                    Models.Session.cd.CheDoToi = 1;
                }
                else
                {
                    Models.Session.cd.CheDoToi = 0;
                }

                if (new DAO.SqlToLinq.CaiDat().Update(Models.Session.cd))
                {
                    pnNoiDung.Controls.Add(new QLTV.View.CaiDat.CaiDat());
                }
            }
                    loadNew();
        }
    }
}
