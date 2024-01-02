namespace QuanLyMuonTra.QuanLyPhieuMuon
{
    partial class TaoPhieuMuon
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblMaDG = new Label();
            lblTen = new Label();
            btnTK = new Button();
            pnTable = new FlowLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            lblStatus = new Label();
            lblTenDG = new Label();
            label1 = new Label();
            lblSTT = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 2;
            // 
            // lblMaDG
            // 
            lblMaDG.AutoSize = true;
            lblMaDG.Location = new Point(30, 36);
            lblMaDG.Name = "lblMaDG";
            lblMaDG.Size = new Size(84, 20);
            lblMaDG.TabIndex = 3;
            lblMaDG.Text = "Mã độc giả";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(192, 36);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(56, 20);
            lblTen.TabIndex = 4;
            lblTen.Text = "Họ Tên";
            // 
            // btnTK
            // 
            btnTK.Location = new Point(368, 67);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(94, 29);
            btnTK.TabIndex = 5;
            btnTK.Text = "Tìm kiếm";
            btnTK.UseVisualStyleBackColor = true;
            btnTK.Click += btnTK_Click;
            // 
            // pnTable
            // 
            pnTable.AutoScroll = true;
            pnTable.BorderStyle = BorderStyle.Fixed3D;
            pnTable.Location = new Point(30, 228);
            pnTable.Name = "pnTable";
            pnTable.Size = new Size(1276, 650);
            pnTable.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblTenDG);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblSTT);
            panel1.Location = new Point(30, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(1276, 75);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F);
            label2.Location = new Point(1132, 24);
            label2.Name = "label2";
            label2.Size = new Size(96, 27);
            label2.TabIndex = 11;
            label2.Text = "Thao tác";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Cambria", 13.8F);
            lblStatus.Location = new Point(862, 24);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(113, 27);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Trạng thái";
            // 
            // lblTenDG
            // 
            lblTenDG.AutoSize = true;
            lblTenDG.Font = new Font("Cambria", 13.8F);
            lblTenDG.Location = new Point(572, 24);
            lblTenDG.Name = "lblTenDG";
            lblTenDG.Size = new Size(126, 27);
            lblTenDG.TabIndex = 9;
            lblTenDG.Text = "Tên Độc Giả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F);
            label1.Location = new Point(292, 24);
            label1.Name = "label1";
            label1.Size = new Size(120, 27);
            label1.TabIndex = 8;
            label1.Text = "Mã Độc Giả";
            // 
            // lblSTT
            // 
            lblSTT.AutoSize = true;
            lblSTT.Font = new Font("Cambria", 13.8F);
            lblSTT.Location = new Point(32, 24);
            lblSTT.Name = "lblSTT";
            lblSTT.Size = new Size(51, 27);
            lblSTT.TabIndex = 7;
            lblSTT.Text = "STT";
            // 
            // TaoPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pnTable);
            Controls.Add(btnTK);
            Controls.Add(lblTen);
            Controls.Add(lblMaDG);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "TaoPhieuMuon";
            Size = new Size(1544, 926);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblMaDG;
        private Label lblTen;
        private Button btnTK;
        private FlowLayoutPanel pnTable;
        private Panel panel1;
        private Label lblStatus;
        private Label lblTenDG;
        private Label label1;
        private Label lblSTT;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}
