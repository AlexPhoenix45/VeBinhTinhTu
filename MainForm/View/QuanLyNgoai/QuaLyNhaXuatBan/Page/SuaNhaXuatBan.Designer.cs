namespace View.QuanLyNgoai
{
    partial class SuaNhaXuatBan
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
            btnThoat = new Button();
            btnXacNhan = new Button();
            panel1 = new Panel();
            txtNgay = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDiaChi = new TextBox();
            txtTen = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(694, 398);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(594, 398);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 7;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtNgay);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 347);
            panel1.TabIndex = 6;
            // 
            // txtNgay
            // 
            txtNgay.Location = new Point(335, 271);
            txtNgay.Name = "txtNgay";
            txtNgay.Size = new Size(250, 27);
            txtNgay.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 271);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 6;
            label4.Text = "Ngày thành lập";
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
            label2.Size = new Size(121, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên nhà xuất bản";
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
            label1.Size = new Size(277, 46);
            label1.TabIndex = 0;
            label1.Text = "Sửa nhà xuất bản";
            // 
            // SuaNhaXuatBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 445);
            Controls.Add(btnThoat);
            Controls.Add(btnXacNhan);
            Controls.Add(panel1);
            Name = "SuaNhaXuatBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuaNhaXuatBan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThoat;
        private Button btnXacNhan;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDiaChi;
        private TextBox txtTen;
        private Label label1;
        private DateTimePicker txtNgay;
    }
}