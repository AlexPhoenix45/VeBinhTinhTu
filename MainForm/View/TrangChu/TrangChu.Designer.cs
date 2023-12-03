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
            txtRoleCode = new Label();
            txtTaiKhoan = new Label();
            txtRole = new Label();
            pnMenu = new Panel();
            mnMenu = new MenuStrip();
            pnNoiDung = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnMenu.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtRoleCode);
            splitContainer1.Panel1.Controls.Add(txtTaiKhoan);
            splitContainer1.Panel1.Controls.Add(txtRole);
            splitContainer1.Panel1.Controls.Add(pnMenu);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnNoiDung);
            splitContainer1.Size = new Size(950, 595);
            splitContainer1.SplitterDistance = 159;
            splitContainer1.TabIndex = 0;
            // 
            // txtRoleCode
            // 
            txtRoleCode.AutoSize = true;
            txtRoleCode.Location = new Point(100, 52);
            txtRoleCode.Name = "txtRoleCode";
            txtRoleCode.Size = new Size(50, 20);
            txtRoleCode.TabIndex = 3;
            txtRoleCode.Text = "label1";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.AutoSize = true;
            txtTaiKhoan.Location = new Point(100, 19);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(56, 20);
            txtTaiKhoan.TabIndex = 2;
            txtTaiKhoan.Text = "txtRole";
            // 
            // txtRole
            // 
            txtRole.AutoSize = true;
            txtRole.Font = new Font("Segoe UI", 12F);
            txtRole.Location = new Point(4, 11);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(73, 28);
            txtRole.TabIndex = 1;
            txtRole.Text = "txtRole";
            // 
            // pnMenu
            // 
            pnMenu.Controls.Add(mnMenu);
            pnMenu.Location = new Point(0, 103);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(400, 492);
            pnMenu.AutoSize = true;
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
            mnMenu.Size = new Size(400, 206);
            mnMenu.TabIndex = 0;
            mnMenu.AutoSize = true;
            mnMenu.Text = "menuStrip1";
            // 
            // pnNoiDung
            // 
            pnNoiDung.AutoSize = true;
            pnNoiDung.Location = new Point(4, 100);
            pnNoiDung.Name = "pnNoiDung";
            pnNoiDung.Size = new Size(540, 331);
            pnNoiDung.TabIndex = 0;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(950, 595);
            Controls.Add(splitContainer1);
            Name = "TrangChu";
            Text = "TrangChu";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnMenu.ResumeLayout(false);
            pnMenu.PerformLayout();
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
    }
}