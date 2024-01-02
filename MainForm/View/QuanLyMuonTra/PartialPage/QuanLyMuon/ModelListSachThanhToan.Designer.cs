namespace View.QuanLyMuonTra.QuanLyMuon
{
    partial class ModelListSachThanhToan
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
            lblTen = new Label();
            lblPHong = new Label();
            lblTong = new Label();
            lblPMuon = new Label();
            lblMuon = new Label();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(16, 16);
            lblTen.MaximumSize = new Size(230, 0);
            lblTen.MinimumSize = new Size(230, 0);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(230, 20);
            lblTen.TabIndex = 0;
            lblTen.Text = "label1";
            // 
            // lblPHong
            // 
            lblPHong.AutoSize = true;
            lblPHong.Location = new Point(467, 16);
            lblPHong.Name = "lblPHong";
            lblPHong.Size = new Size(50, 20);
            lblPHong.TabIndex = 1;
            lblPHong.Text = "label2";
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Location = new Point(564, 16);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(50, 20);
            lblTong.TabIndex = 2;
            lblTong.Text = "label3";
            // 
            // lblPMuon
            // 
            lblPMuon.AutoSize = true;
            lblPMuon.Location = new Point(364, 16);
            lblPMuon.Name = "lblPMuon";
            lblPMuon.Size = new Size(50, 20);
            lblPMuon.TabIndex = 3;
            lblPMuon.Text = "label4";
            // 
            // lblMuon
            // 
            lblMuon.AutoSize = true;
            lblMuon.Location = new Point(269, 16);
            lblMuon.Name = "lblMuon";
            lblMuon.Size = new Size(50, 20);
            lblMuon.TabIndex = 4;
            lblMuon.Text = "label5";
            // 
            // ModelListSachThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblMuon);
            Controls.Add(lblPMuon);
            Controls.Add(lblTong);
            Controls.Add(lblPHong);
            Controls.Add(lblTen);
            Name = "ModelListSachThanhToan";
            Size = new Size(699, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTen;
        public Label lblPHong;
        public Label lblTong;
        public Label lblPMuon;
        public Label lblMuon;
    }
}
