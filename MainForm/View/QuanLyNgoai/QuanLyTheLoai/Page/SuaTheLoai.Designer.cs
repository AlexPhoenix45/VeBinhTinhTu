﻿namespace View.QuanLyNgoai { 
    partial class SuaTheLoai
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
            label2 = new Label();
            txtTen = new TextBox();
            label1 = new Label();
            btnThoat = new Button();
            btnXacNhan = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 331);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 115);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên thể loại";
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
            label1.Size = new Size(195, 46);
            label1.TabIndex = 0;
            label1.Text = "Sửa thể loại";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(646, 391);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(546, 391);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 7;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // SuaTheLoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(btnXacNhan);
            Name = "SuaTheLoai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuaTheLoai";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox txtTen;
        private Label label1;
        private Button btnThoat;
        private Button btnXacNhan;
    }
}