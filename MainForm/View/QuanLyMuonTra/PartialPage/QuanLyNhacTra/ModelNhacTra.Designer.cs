namespace View.QuanLyMuonTra.QuanLyNhacTra
{
    partial class ModelNhacTra
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
            panel1 = new Panel();
            btnThaoTac = new Label();
            lblGhiChuMuon = new Label();
            lblNgayHenTra = new Label();
            lblNgayMuon = new Label();
            lblMDG = new Label();
            lblSTT = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnThaoTac);
            panel1.Controls.Add(lblGhiChuMuon);
            panel1.Controls.Add(lblNgayHenTra);
            panel1.Controls.Add(lblNgayMuon);
            panel1.Controls.Add(lblMDG);
            panel1.Controls.Add(lblSTT);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 75);
            panel1.TabIndex = 24;
            // 
            // btnThaoTac
            // 
            btnThaoTac.AutoSize = true;
            btnThaoTac.BorderStyle = BorderStyle.FixedSingle;
            btnThaoTac.Font = new Font("Cambria", 12F);
            btnThaoTac.Location = new Point(971, 29);
            btnThaoTac.MaximumSize = new Size(200, 0);
            btnThaoTac.MinimumSize = new Size(200, 0);
            btnThaoTac.Name = "btnThaoTac";
            btnThaoTac.Size = new Size(200, 25);
            btnThaoTac.TabIndex = 39;
            btnThaoTac.Text = "Thao tác";
            btnThaoTac.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGhiChuMuon
            // 
            lblGhiChuMuon.AutoSize = true;
            lblGhiChuMuon.Font = new Font("Cambria", 12F);
            lblGhiChuMuon.Location = new Point(694, 29);
            lblGhiChuMuon.MaximumSize = new Size(200, 0);
            lblGhiChuMuon.MinimumSize = new Size(200, 0);
            lblGhiChuMuon.Name = "lblGhiChuMuon";
            lblGhiChuMuon.Size = new Size(200, 23);
            lblGhiChuMuon.TabIndex = 37;
            lblGhiChuMuon.Text = "ghi chú mượn";
            lblGhiChuMuon.TextAlign = ContentAlignment.MiddleCenter;
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
            // lblMDG
            // 
            lblMDG.AutoSize = true;
            lblMDG.Font = new Font("Cambria", 12F);
            lblMDG.Location = new Point(126, 29);
            lblMDG.Name = "lblMDG";
            lblMDG.Size = new Size(101, 23);
            lblMDG.TabIndex = 30;
            lblMDG.Text = "Mã độc giả";
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
            // ModelNhacTra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ModelNhacTra";
            Size = new Size(1176, 75);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label btnThaoTac;
        public Label lblGhiChuMuon;
        public Label lblNgayHenTra;
        public Label lblNgayMuon;
        public Label lblMDG;
        public Label lblSTT;
    }
}
