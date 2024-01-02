namespace View.QuanLyMuonTra.QuanLyPhieuMuon
{
    partial class ModelDocGiaPhieuMuon
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
            btnTaoPhieu = new Button();
            lblSTT = new Label();
            lblMaDG = new Label();
            lblTenDG = new Label();
            lblStatus = new Label();
            ptAnhDD = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptAnhDD).BeginInit();
            SuspendLayout();
            // 
            // btnTaoPhieu
            // 
            btnTaoPhieu.BackColor = SystemColors.ActiveCaption;
            btnTaoPhieu.Cursor = Cursors.Hand;
            btnTaoPhieu.Font = new Font("Cambria", 13.8F);
            btnTaoPhieu.Location = new Point(1051, 21);
            btnTaoPhieu.Name = "btnTaoPhieu";
            btnTaoPhieu.Size = new Size(186, 43);
            btnTaoPhieu.TabIndex = 0;
            btnTaoPhieu.Text = "Tạo phiếu";
            btnTaoPhieu.UseVisualStyleBackColor = false;
            btnTaoPhieu.Click += btnTaoPhieu_Click;
            // 
            // lblSTT
            // 
            lblSTT.AutoSize = true;
            lblSTT.Font = new Font("Cambria", 13.8F);
            lblSTT.Location = new Point(21, 29);
            lblSTT.Name = "lblSTT";
            lblSTT.Size = new Size(25, 27);
            lblSTT.TabIndex = 1;
            lblSTT.Text = "1";
            // 
            // lblMaDG
            // 
            lblMaDG.AutoSize = true;
            lblMaDG.Font = new Font("Cambria", 13.8F);
            lblMaDG.Location = new Point(281, 29);
            lblMaDG.Name = "lblMaDG";
            lblMaDG.Size = new Size(120, 27);
            lblMaDG.TabIndex = 2;
            lblMaDG.Text = "Mã Độc Giả";
            // 
            // lblTenDG
            // 
            lblTenDG.AutoSize = true;
            lblTenDG.Font = new Font("Cambria", 13.8F);
            lblTenDG.Location = new Point(561, 29);
            lblTenDG.Name = "lblTenDG";
            lblTenDG.Size = new Size(126, 27);
            lblTenDG.TabIndex = 3;
            lblTenDG.Text = "Tên Độc Giả";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Cambria", 13.8F);
            lblStatus.Location = new Point(851, 29);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(113, 27);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Trạng thái";
            // 
            // ptAnhDD
            // 
            ptAnhDD.ImageLocation = "D:\\LapTrinhWindow\\QuanLyThuVien\\MainForm\\Web\\Img\\images_user.png";
            ptAnhDD.Location = new Point(106, 14);
            ptAnhDD.Name = "ptAnhDD";
            ptAnhDD.Size = new Size(71, 53);
            ptAnhDD.SizeMode = PictureBoxSizeMode.Zoom;
            ptAnhDD.TabIndex = 5;
            ptAnhDD.TabStop = false;
            // 
            // ModelDocGiaPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(ptAnhDD);
            Controls.Add(lblStatus);
            Controls.Add(lblTenDG);
            Controls.Add(lblMaDG);
            Controls.Add(lblSTT);
            Controls.Add(btnTaoPhieu);
            Name = "ModelDocGiaPhieuMuon";
            Size = new Size(1267, 84);
            MouseEnter += ModelDocGiaPhieuMuon_MouseEnter;
            MouseLeave += ModelDocGiaPhieuMuon_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)ptAnhDD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTaoPhieu;
        private Label lblSTT;
        private Label lblMaDG;
        private Label lblTenDG;
        private Label lblStatus;
        private PictureBox ptAnhDD;
    }
}
