namespace View.QuanLyMuonTra.QuanLyMuon
{
    partial class ThanhToan
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
            QR = new PictureBox();
            panel1 = new Panel();
            pnNoiDung = new FlowLayoutPanel();
            pnListSach = new FlowLayoutPanel();
            pnBtn = new Panel();
            btnXN2 = new Button();
            btnHuy = new Button();
            btnTao = new Button();
            ((System.ComponentModel.ISupportInitialize)QR).BeginInit();
            panel1.SuspendLayout();
            pnNoiDung.SuspendLayout();
            pnBtn.SuspendLayout();
            SuspendLayout();
            // 
            // QR
            // 
            QR.Location = new Point(800, 81);
            QR.Name = "QR";
            QR.Size = new Size(313, 384);
            QR.SizeMode = PictureBoxSizeMode.Zoom;
            QR.TabIndex = 0;
            QR.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnNoiDung);
            panel1.Controls.Add(QR);
            panel1.Location = new Point(6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 541);
            panel1.TabIndex = 1;
            // 
            // pnNoiDung
            // 
            pnNoiDung.Controls.Add(pnListSach);
            pnNoiDung.Location = new Point(11, 50);
            pnNoiDung.Name = "pnNoiDung";
            pnNoiDung.Size = new Size(783, 468);
            pnNoiDung.TabIndex = 2;
            // 
            // pnListSach
            // 
            pnListSach.AutoScroll = true;
            pnListSach.Location = new Point(3, 3);
            pnListSach.Name = "pnListSach";
            pnListSach.Size = new Size(730, 322);
            pnListSach.TabIndex = 1;
            // 
            // pnBtn
            // 
            pnBtn.Controls.Add(btnXN2);
            pnBtn.Controls.Add(btnHuy);
            pnBtn.Controls.Add(btnTao);
            pnBtn.Location = new Point(6, 561);
            pnBtn.Name = "pnBtn";
            pnBtn.Size = new Size(1065, 89);
            pnBtn.TabIndex = 34;
            // 
            // btnXN2
            // 
            btnXN2.AllowDrop = true;
            btnXN2.BackColor = Color.YellowGreen;
            btnXN2.Font = new Font("Cambria", 10.2F);
            btnXN2.Location = new Point(162, 29);
            btnXN2.Name = "btnXN2";
            btnXN2.Size = new Size(136, 35);
            btnXN2.TabIndex = 30;
            btnXN2.Text = "Xác nhận và in";
            btnXN2.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.AllowDrop = true;
            btnHuy.BackColor = Color.LightCoral;
            btnHuy.Font = new Font("Cambria", 10.2F);
            btnHuy.Location = new Point(951, 29);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(99, 35);
            btnHuy.TabIndex = 29;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnTao
            // 
            btnTao.AllowDrop = true;
            btnTao.BackColor = Color.LightBlue;
            btnTao.Font = new Font("Cambria", 10.2F);
            btnTao.Location = new Point(34, 29);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(99, 35);
            btnTao.TabIndex = 28;
            btnTao.Text = "Xác nhận";
            btnTao.UseVisualStyleBackColor = false;
            btnTao.Click += btnTao_Click;
            // 
            // ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 709);
            Controls.Add(pnBtn);
            Controls.Add(panel1);
            Name = "ThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThanhToan";
            ((System.ComponentModel.ISupportInitialize)QR).EndInit();
            panel1.ResumeLayout(false);
            pnNoiDung.ResumeLayout(false);
            pnBtn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox QR;
        private Panel panel1;
        private FlowLayoutPanel pnListSach;
        private FlowLayoutPanel pnNoiDung;
        private Panel pnBtn;
        private Button btnXN2;
        private Button btnHuy;
        private Button btnTao;
    }
}