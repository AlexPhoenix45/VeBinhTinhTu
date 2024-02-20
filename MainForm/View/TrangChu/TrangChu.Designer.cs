namespace MainForm.View.TrangChu
{
    partial class TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            pntt = new Panel();
            pictureBox1 = new PictureBox();
            txtRoleCode = new Label();
            txtTaiKhoan = new Label();
            txtRole = new Label();
            pnMenu = new Panel();
            mnMenu = new MenuStrip();
            pnBan = new Panel();
            label3 = new Label();
            lblNow = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pnNoiDung = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pntt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnMenu.SuspendLayout();
            pnBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pntt);
            splitContainer1.Panel1.Controls.Add(pnMenu);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnBan);
            splitContainer1.Panel2.Controls.Add(pnNoiDung);
            splitContainer1.Size = new Size(1000, 595);
            splitContainer1.SplitterDistance = 109;
            splitContainer1.TabIndex = 0;
            // 
            // pntt
            // 
            pntt.BorderStyle = BorderStyle.FixedSingle;
            pntt.Controls.Add(pictureBox1);
            pntt.Controls.Add(txtRoleCode);
            pntt.Controls.Add(txtTaiKhoan);
            pntt.Controls.Add(txtRole);
            pntt.Location = new Point(-1, -1);
            pntt.Name = "pntt";
            pntt.Size = new Size(152, 98);
            pntt.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.ImageLocation = "D:\\LapTrinhWindow\\QuanLyThuVien\\MainForm\\Web\\Img\\images_user.png";
            pictureBox1.Location = new Point(81, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtRoleCode
            // 
            txtRoleCode.AutoSize = true;
            txtRoleCode.Location = new Point(11, 68);
            txtRoleCode.Name = "txtRoleCode";
            txtRoleCode.Size = new Size(50, 20);
            txtRoleCode.TabIndex = 3;
            txtRoleCode.Text = "label1";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.AutoSize = true;
            txtTaiKhoan.Location = new Point(11, 48);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(56, 20);
            txtTaiKhoan.TabIndex = 2;
            txtTaiKhoan.Text = "txtRole";
            // 
            // txtRole
            // 
            txtRole.AutoSize = true;
            txtRole.Font = new Font("Segoe UI", 12F);
            txtRole.Location = new Point(2, 11);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(73, 28);
            txtRole.TabIndex = 1;
            txtRole.Text = "txtRole";
            // 
            // pnMenu
            // 
            pnMenu.AutoSize = true;
            pnMenu.Controls.Add(mnMenu);
            pnMenu.Location = new Point(0, 103);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(400, 492);
            pnMenu.TabIndex = 0;
            // 
            // mnMenu
            // 
            mnMenu.Anchor = AnchorStyles.Top;
            mnMenu.Dock = DockStyle.None;
            mnMenu.ImageScalingSize = new Size(20, 20);
            mnMenu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            mnMenu.Location = new Point(13, 0);
            mnMenu.Name = "mnMenu";
            mnMenu.RightToLeft = RightToLeft.No;
            mnMenu.Size = new Size(30, 206);
            mnMenu.TabIndex = 0;
            mnMenu.Text = "menuStrip1";
            // 
            // pnBan
            // 
            pnBan.BorderStyle = BorderStyle.FixedSingle;
            pnBan.Controls.Add(label3);
            pnBan.Controls.Add(lblNow);
            pnBan.Controls.Add(label2);
            pnBan.Controls.Add(label1);
            pnBan.Controls.Add(pictureBox2);
            pnBan.Location = new Point(3, 5);
            pnBan.Name = "pnBan";
            pnBan.Size = new Size(855, 92);
            pnBan.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1020, 62);
            label3.Name = "label3";
            label3.Size = new Size(272, 20);
            label3.TabIndex = 4;
            label3.Text = "thư viện siêu cấp phong cách Thái Công";
            // 
            // lblNow
            // 
            lblNow.AutoSize = true;
            lblNow.Location = new Point(28, 58);
            lblNow.Name = "lblNow";
            lblNow.Size = new Size(50, 20);
            lblNow.TabIndex = 3;
            lblNow.Text = "label3";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(1000, 26);
            label2.Name = "label2";
            label2.Size = new Size(387, 40);
            label2.TabIndex = 2;
            label2.Text = "Thư viện siêu cấp THAPD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold | FontStyle.Italic);
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(14, 17);
            label1.MinimumSize = new Size(781, 0);
            label1.Name = "label1";
            label1.Size = new Size(781, 41);
            label1.TabIndex = 1;
            label1.Text = "Thư viện bách khoa siêu cấp vip toàn vũ trụ";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.ImageLocation = "";
            pictureBox2.Location = new Point(768, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pnNoiDung
            // 
            pnNoiDung.AutoSize = true;
            pnNoiDung.BackColor = Color.White;
            pnNoiDung.Location = new Point(4, 100);
            pnNoiDung.Name = "pnNoiDung";
            pnNoiDung.Size = new Size(0, 0);
            pnNoiDung.TabIndex = 0;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1000, 595);
            Controls.Add(splitContainer1);
            Name = "TrangChu";
            Text = "TrangChu";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pntt.ResumeLayout(false);
            pntt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnMenu.ResumeLayout(false);
            pnMenu.PerformLayout();
            pnBan.ResumeLayout(false);
            pnBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel pnMenu;
        private Label txtRole;
        private Label txtTaiKhoan;
        private Label txtRoleCode;
        private MenuStrip mnMenu;
        private Panel pnNoiDung;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel pntt;
        private Panel pnBan;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label lblNow;
        private Label label3;
    }
}