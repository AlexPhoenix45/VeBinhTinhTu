namespace View.QuanLyMuonTra.QuanLyNhacTra
{
    partial class ListNhacTra
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMaDG = new TextBox();
            label5 = new Label();
            label1 = new Label();
            pnTable = new FlowLayoutPanel();
            btnTK = new Button();
            lblTen = new Label();
            txtTen = new TextBox();
            lblNgayHenTra = new Label();
            lblNgayMuon = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lblSTT = new Label();
            lblMaDG = new Label();
            taoAll = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaDG
            // 
            txtMaDG.Location = new Point(19, 53);
            txtMaDG.Name = "txtMaDG";
            txtMaDG.Size = new Size(140, 27);
            txtMaDG.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F);
            label5.Location = new Point(971, 29);
            label5.MaximumSize = new Size(200, 0);
            label5.MinimumSize = new Size(200, 0);
            label5.Name = "label5";
            label5.Size = new Size(200, 23);
            label5.TabIndex = 39;
            label5.Text = "Thao tác";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F);
            label1.Location = new Point(694, 29);
            label1.MaximumSize = new Size(200, 0);
            label1.MinimumSize = new Size(200, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 23);
            label1.TabIndex = 37;
            label1.Text = "ghi chú mượn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnTable
            // 
            pnTable.AutoScroll = true;
            pnTable.BorderStyle = BorderStyle.Fixed3D;
            pnTable.Location = new Point(19, 212);
            pnTable.Name = "pnTable";
            pnTable.Size = new Size(1176, 650);
            pnTable.TabIndex = 22;
            // 
            // btnTK
            // 
            btnTK.Location = new Point(345, 51);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(94, 29);
            btnTK.TabIndex = 21;
            btnTK.Text = "Tìm kiếm";
            btnTK.UseVisualStyleBackColor = true;
            btnTK.Click += btnTK_Click;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(181, 20);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(56, 20);
            lblTen.TabIndex = 20;
            lblTen.Text = "Họ Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(181, 53);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(140, 27);
            txtTen.TabIndex = 18;
            // 
            // lblNgayHenTra
            // 
            lblNgayHenTra.AutoSize = true;
            lblNgayHenTra.Font = new Font("Cambria", 12F);
            lblNgayHenTra.Location = new Point(486, 29);
            lblNgayHenTra.Name = "lblNgayHenTra";
            lblNgayHenTra.Size = new Size(119, 23);
            lblNgayHenTra.TabIndex = 32;
            lblNgayHenTra.Text = "Ngày hẹn trả";
            // 
            // lblNgayMuon
            // 
            lblNgayMuon.AutoSize = true;
            lblNgayMuon.Font = new Font("Cambria", 12F);
            lblNgayMuon.Location = new Point(309, 29);
            lblNgayMuon.Name = "lblNgayMuon";
            lblNgayMuon.Size = new Size(110, 23);
            lblNgayMuon.TabIndex = 31;
            lblNgayMuon.Text = "Ngày mượn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F);
            label4.Location = new Point(126, 29);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 30;
            label4.Text = "Mã độc giả";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblNgayHenTra);
            panel1.Controls.Add(lblNgayMuon);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblSTT);
            panel1.Location = new Point(19, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 75);
            panel1.TabIndex = 23;
            // 
            // lblSTT
            // 
            lblSTT.AutoSize = true;
            lblSTT.Font = new Font("Cambria", 12F);
            lblSTT.Location = new Point(21, 29);
            lblSTT.Name = "lblSTT";
            lblSTT.Size = new Size(44, 23);
            lblSTT.TabIndex = 29;
            lblSTT.Text = "STT";
            // 
            // lblMaDG
            // 
            lblMaDG.AutoSize = true;
            lblMaDG.Location = new Point(19, 20);
            lblMaDG.Name = "lblMaDG";
            lblMaDG.Size = new Size(84, 20);
            lblMaDG.TabIndex = 19;
            lblMaDG.Text = "Mã độc giả";
            // 
            // taoAll
            // 
            taoAll.BackColor = SystemColors.InactiveCaption;
            taoAll.Location = new Point(25, 98);
            taoAll.Name = "taoAll";
            taoAll.Size = new Size(140, 34);
            taoAll.TabIndex = 26;
            taoAll.Text = "Tạo nhanh";
            taoAll.UseVisualStyleBackColor = false;
            taoAll.Click += taoAll_Click;
            // 
            // ListNhacTra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(taoAll);
            Controls.Add(txtMaDG);
            Controls.Add(pnTable);
            Controls.Add(btnTK);
            Controls.Add(lblTen);
            Controls.Add(txtTen);
            Controls.Add(panel1);
            Controls.Add(lblMaDG);
            Name = "ListNhacTra";
            Size = new Size(1283, 1168);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox1;
        private Label label5;
        private Label label1;
        private FlowLayoutPanel pnTable;
        private Button btnTK;
        private Label lblTen;
        private TextBox txtTen;
        private TextBox txtMaDG;
        private Label lblNgayHenTra;
        private Label lblNgayMuon;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label lblSTT;
        private Label lblMaDG;
        private Button taoAll;
    }
}
