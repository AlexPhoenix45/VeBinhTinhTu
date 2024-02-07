namespace View.QuanLyNgoai
{
    partial class ThemTacGia
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtChucDanh = new TextBox();
            txtDiaChi = new TextBox();
            txtTen = new TextBox();
            label1 = new Label();
            btnXacNhan = new Button();
            btnThoat = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtChucDanh);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 347);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 271);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = "Chức danh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 193);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 115);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên tác giả";
            // 
            // txtChucDanh
            // 
            txtChucDanh.Location = new Point(335, 264);
            txtChucDanh.Name = "txtChucDanh";
            txtChucDanh.Size = new Size(312, 27);
            txtChucDanh.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(335, 186);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(312, 27);
            txtDiaChi.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(333, 108);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(312, 27);
            txtTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(267, 22);
            label1.Name = "label1";
            label1.Size = new Size(212, 46);
            label1.TabIndex = 0;
            label1.Text = "Thêm tác giả";
            label1.Click += label1_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(594, 389);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 1;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(694, 389);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // ThemTacGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 433);
            Controls.Add(btnThoat);
            Controls.Add(btnXacNhan);
            Controls.Add(panel1);
            Name = "ThemTacGia";
            Text = "ThemTacGia";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtChucDanh;
        private TextBox txtDiaChi;
        private TextBox txtTen;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnXacNhan;
        private Button btnThoat;
    }
}