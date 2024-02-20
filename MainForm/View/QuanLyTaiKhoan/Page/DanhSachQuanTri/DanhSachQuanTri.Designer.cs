namespace View.QuanLyTaiKhoan
{
    partial class DanhSachQuanTri
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
            pntable = new FlowLayoutPanel();
            panel1 = new Panel();
            Ma = new Label();
            Ten = new Label();
            lblSTT = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pntable
            // 
            pntable.AutoScroll = true;
            pntable.BorderStyle = BorderStyle.FixedSingle;
            pntable.Location = new Point(53, 236);
            pntable.Name = "pntable";
            pntable.Size = new Size(782, 490);
            pntable.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Ma);
            panel1.Controls.Add(Ten);
            panel1.Controls.Add(lblSTT);
            panel1.Location = new Point(53, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 79);
            panel1.TabIndex = 9;
            // 
            // Ma
            // 
            Ma.AutoSize = true;
            Ma.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Ma.Location = new Point(552, 29);
            Ma.Name = "Ma";
            Ma.Size = new Size(117, 28);
            Ma.TabIndex = 7;
            Ma.Text = "Mã quản trị";
            // 
            // Ten
            // 
            Ten.AutoSize = true;
            Ten.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Ten.Location = new Point(249, 29);
            Ten.Name = "Ten";
            Ten.Size = new Size(99, 28);
            Ten.TabIndex = 6;
            Ten.Text = "Tài khoản";
            // 
            // lblSTT
            // 
            lblSTT.AutoSize = true;
            lblSTT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSTT.Location = new Point(37, 29);
            lblSTT.Name = "lblSTT";
            lblSTT.Size = new Size(35, 28);
            lblSTT.TabIndex = 5;
            lblSTT.Text = "stt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 42);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 15;
            label1.Text = "Tìm kiếm";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Location = new Point(53, 104);
            button1.Name = "button1";
            button1.Size = new Size(118, 30);
            button1.TabIndex = 14;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // DanhSachQuanTri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(pntable);
            Name = "DanhSachQuanTri";
            Size = new Size(1223, 1129);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel pntable;
        private Panel panel1;
        public Label Ma;
        public Label Ten;
        public Label lblSTT;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
    }
}
