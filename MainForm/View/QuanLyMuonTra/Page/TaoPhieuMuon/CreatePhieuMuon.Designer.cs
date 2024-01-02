namespace View.QuanLyMuonTra.QuanLyPhieuMuon
{
    partial class CreatePhieuMuon
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
            txtMaDG = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtGhiChu = new TextBox();
            panel1 = new Panel();
            lblChuY = new Label();
            label3 = new Label();
            btnTao = new Button();
            btnHuy = new Button();
            btnXN2 = new Button();
            pnBtn = new Panel();
            label4 = new Label();
            txtHenTra = new DateTimePicker();
            txtListTG = new Label();
            cklTG = new CheckedListBox();
            btnTG = new Button();
            txtSubTK = new TextBox();
            label6 = new Label();
            pnTG = new Panel();
            panel1.SuspendLayout();
            pnBtn.SuspendLayout();
            pnTG.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaDG
            // 
            txtMaDG.BackColor = Color.White;
            txtMaDG.BorderStyle = BorderStyle.FixedSingle;
            txtMaDG.Enabled = false;
            txtMaDG.Font = new Font("Cambria", 10.2F);
            txtMaDG.Location = new Point(157, 117);
            txtMaDG.Name = "txtMaDG";
            txtMaDG.Size = new Size(216, 27);
            txtMaDG.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 7);
            label1.Name = "label1";
            label1.Size = new Size(326, 50);
            label1.TabIndex = 1;
            label1.Text = "Phiếu Mượn Sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.2F);
            label2.Location = new Point(50, 123);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã độc giả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 10.2F);
            label5.Location = new Point(50, 248);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 9;
            label5.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Cambria", 10.2F);
            txtGhiChu.Location = new Point(157, 242);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(216, 27);
            txtGhiChu.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pnTG);
            panel1.Controls.Add(txtListTG);
            panel1.Controls.Add(lblChuY);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(txtHenTra);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaDG);
            panel1.Location = new Point(82, 38);
            panel1.MinimumSize = new Size(907, 494);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 494);
            panel1.TabIndex = 27;
            // 
            // lblChuY
            // 
            lblChuY.AutoSize = true;
            lblChuY.Font = new Font("Cambria", 10.2F);
            lblChuY.Location = new Point(127, 312);
            lblChuY.Name = "lblChuY";
            lblChuY.Size = new Size(302, 20);
            lblChuY.TabIndex = 28;
            lblChuY.Text = "_ Phí mượn được tính là 1000VND/ngày ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10.2F);
            label3.Location = new Point(50, 312);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 27;
            label3.Text = "Chú ý:";
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
            // btnHuy
            // 
            btnHuy.AllowDrop = true;
            btnHuy.BackColor = Color.LightCoral;
            btnHuy.Font = new Font("Cambria", 10.2F);
            btnHuy.Location = new Point(793, 29);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(99, 35);
            btnHuy.TabIndex = 29;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
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
            btnXN2.Click += btnXN2_Click;
            // 
            // pnBtn
            // 
            pnBtn.Controls.Add(btnXN2);
            pnBtn.Controls.Add(btnHuy);
            pnBtn.Controls.Add(btnTao);
            pnBtn.Location = new Point(82, 535);
            pnBtn.Name = "pnBtn";
            pnBtn.Size = new Size(907, 89);
            pnBtn.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 10.2F);
            label4.Location = new Point(50, 185);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 6;
            label4.Text = "Ngày hẹn trả";
            // 
            // txtHenTra
            // 
            txtHenTra.CustomFormat = "dd/MM/yyyy";
            txtHenTra.Font = new Font("Cambria", 10.2F);
            txtHenTra.Format = DateTimePickerFormat.Custom;
            txtHenTra.Location = new Point(157, 182);
            txtHenTra.Name = "txtHenTra";
            txtHenTra.Size = new Size(216, 27);
            txtHenTra.TabIndex = 7;
            // 
            // txtListTG
            // 
            txtListTG.AutoSize = true;
            txtListTG.BackColor = SystemColors.ButtonFace;
            txtListTG.BorderStyle = BorderStyle.FixedSingle;
            txtListTG.Cursor = Cursors.Hand;
            txtListTG.Font = new Font("Cambria", 10.2F);
            txtListTG.Location = new Point(514, 113);
            txtListTG.MaximumSize = new Size(300, 0);
            txtListTG.MinimumSize = new Size(300, 30);
            txtListTG.Name = "txtListTG";
            txtListTG.Size = new Size(300, 30);
            txtListTG.TabIndex = 24;
            txtListTG.Text = "Chọn Sách";
            txtListTG.SizeChanged += txtListTG_SizeChanged;
            txtListTG.Click += txtListTG_Click;
            // 
            // cklTG
            // 
            cklTG.CheckOnClick = true;
            cklTG.FormattingEnabled = true;
            cklTG.Location = new Point(-1, 38);
            cklTG.Name = "cklTG";
            cklTG.Size = new Size(334, 180);
            cklTG.TabIndex = 7;
            // 
            // btnTG
            // 
            btnTG.Location = new Point(3, 224);
            btnTG.Name = "btnTG";
            btnTG.Size = new Size(104, 42);
            btnTG.TabIndex = 8;
            btnTG.Text = "xác nhận";
            btnTG.UseVisualStyleBackColor = true;
            btnTG.Click += btnTG_Click;
            // 
            // txtSubTK
            // 
            txtSubTK.Location = new Point(111, 5);
            txtSubTK.Name = "txtSubTK";
            txtSubTK.Size = new Size(218, 27);
            txtSubTK.TabIndex = 9;
            txtSubTK.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 27;
            label6.Text = "Tìm tên sách:";
            // 
            // pnTG
            // 
            pnTG.BorderStyle = BorderStyle.FixedSingle;
            pnTG.Controls.Add(label6);
            pnTG.Controls.Add(txtSubTK);
            pnTG.Controls.Add(btnTG);
            pnTG.Controls.Add(cklTG);
            pnTG.Font = new Font("Cambria", 10.2F);
            pnTG.Location = new Point(498, 146);
            pnTG.Name = "pnTG";
            pnTG.Size = new Size(334, 271);
            pnTG.TabIndex = 26;
            // 
            // CreatePhieuMuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 642);
            Controls.Add(pnBtn);
            Controls.Add(panel1);
            Name = "CreatePhieuMuon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatePhieuMuon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnBtn.ResumeLayout(false);
            pnTG.ResumeLayout(false);
            pnTG.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMaDG;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtGhiChu;
        private Panel panel1;
        private Button btnTao;
        private Button btnHuy;
        private Label lblChuY;
        private Label label3;
        private Button btnXN2;
        private Panel pnBtn;
        private Panel pnTG;
        private Label label6;
        private TextBox txtSubTK;
        private Button btnTG;
        private CheckedListBox cklTG;
        private Label txtListTG;
        private DateTimePicker txtHenTra;
        private Label label4;
    }
}