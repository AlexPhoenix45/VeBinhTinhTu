﻿namespace QuanLySach.Sach
{
    partial class QuanLySach
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtListTG = new Label();
            label5 = new Label();
            txtTL = new ComboBox();
            txtNXB = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            txtNamXBTu = new TextBox();
            txtNamXBDen = new TextBox();
            txtGiaDen = new TextBox();
            txtGiaTu = new TextBox();
            label7 = new Label();
            txtTen = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtMoTa = new TextBox();
            XacNhan = new Button();
            pn = new FlowLayoutPanel();
            pnDS = new FlowLayoutPanel();
            DTSach = new DataGridView();
            pnCTSach = new Panel();
            pnList = new FlowLayoutPanel();
            pnChiTiet = new FlowLayoutPanel();
            btnAdd = new Button();
            cklTG = new CheckedListBox();
            pnTG = new Panel();
            btnTG = new Button();
            rjToggleButton1 = new Models.RJToggleButton();
            pn.SuspendLayout();
            pnDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTSach).BeginInit();
            pnTG.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(392, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Bộ lọc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(39, 19);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 65);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Tác giả:";
            // 
            // txtListTG
            // 
            txtListTG.AutoSize = true;
            txtListTG.BackColor = SystemColors.ButtonFace;
            txtListTG.BorderStyle = BorderStyle.FixedSingle;
            txtListTG.Location = new Point(498, 59);
            txtListTG.MaximumSize = new Size(200, 30);
            txtListTG.MinimumSize = new Size(200, 30);
            txtListTG.Name = "txtListTG";
            txtListTG.Size = new Size(200, 30);
            txtListTG.TabIndex = 4;
            txtListTG.Text = "Chọn tác giả";
            txtListTG.Click += txtListTG_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 103);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 5;
            label5.Text = "Thể loại:";
            // 
            // txtTL
            // 
            txtTL.BackColor = SystemColors.ButtonFace;
            txtTL.FormattingEnabled = true;
            txtTL.Location = new Point(498, 100);
            txtTL.Name = "txtTL";
            txtTL.Size = new Size(200, 28);
            txtTL.TabIndex = 6;
            // 
            // txtNXB
            // 
            txtNXB.BackColor = SystemColors.ButtonFace;
            txtNXB.FormattingEnabled = true;
            txtNXB.Location = new Point(498, 140);
            txtNXB.Name = "txtNXB";
            txtNXB.Size = new Size(200, 28);
            txtNXB.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 143);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 8;
            label4.Text = "Nhà xuất bản:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(754, 65);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 10;
            label6.Text = "Năm xuất bản:";
            // 
            // txtNamXBTu
            // 
            txtNamXBTu.BackColor = SystemColors.ButtonFace;
            txtNamXBTu.BorderStyle = BorderStyle.FixedSingle;
            txtNamXBTu.Location = new Point(862, 62);
            txtNamXBTu.Name = "txtNamXBTu";
            txtNamXBTu.Size = new Size(53, 27);
            txtNamXBTu.TabIndex = 11;
            // 
            // txtNamXBDen
            // 
            txtNamXBDen.BackColor = SystemColors.ButtonFace;
            txtNamXBDen.BorderStyle = BorderStyle.FixedSingle;
            txtNamXBDen.Location = new Point(934, 62);
            txtNamXBDen.Name = "txtNamXBDen";
            txtNamXBDen.Size = new Size(53, 27);
            txtNamXBDen.TabIndex = 12;
            // 
            // txtGiaDen
            // 
            txtGiaDen.BackColor = SystemColors.ButtonFace;
            txtGiaDen.BorderStyle = BorderStyle.FixedSingle;
            txtGiaDen.Location = new Point(934, 100);
            txtGiaDen.Name = "txtGiaDen";
            txtGiaDen.Size = new Size(53, 27);
            txtGiaDen.TabIndex = 15;
            // 
            // txtGiaTu
            // 
            txtGiaTu.BackColor = SystemColors.ButtonFace;
            txtGiaTu.BorderStyle = BorderStyle.FixedSingle;
            txtGiaTu.Location = new Point(862, 100);
            txtGiaTu.Name = "txtGiaTu";
            txtGiaTu.Size = new Size(53, 27);
            txtGiaTu.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(754, 103);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 13;
            label7.Text = "Giá tiền:";
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.White;
            txtTen.Location = new Point(145, 68);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(154, 27);
            txtTen.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 75);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 17;
            label8.Text = "Tên Sách";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 119);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 19;
            label9.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.BackColor = Color.White;
            txtMoTa.Location = new Point(145, 112);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(154, 27);
            txtMoTa.TabIndex = 18;
            // 
            // XacNhan
            // 
            XacNhan.BackColor = SystemColors.ButtonFace;
            XacNhan.Location = new Point(1091, 50);
            XacNhan.Name = "XacNhan";
            XacNhan.Size = new Size(94, 39);
            XacNhan.TabIndex = 20;
            XacNhan.Text = "Xác nhận";
            XacNhan.UseVisualStyleBackColor = false;
            XacNhan.Click += XacNhan_Click;
            // 
            // pn
            // 
            pn.AutoScroll = true;
            pn.AutoSize = true;
            pn.Controls.Add(pnDS);
            pn.Controls.Add(pnList);
            pn.Controls.Add(pnChiTiet);
            pn.Location = new Point(36, 258);
            pn.Name = "pn";
            pn.Size = new Size(4099, 699);
            pn.TabIndex = 21;
            // 
            // pnDS
            // 
            pnDS.AutoScroll = true;
            pnDS.AutoScrollMargin = new Size(500, 0);
            pnDS.Controls.Add(DTSach);
            pnDS.Controls.Add(pnCTSach);
            pnDS.Location = new Point(3, 3);
            pnDS.Name = "pnDS";
            pnDS.Size = new Size(1617, 640);
            pnDS.TabIndex = 2;
            // 
            // DTSach
            // 
            DTSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTSach.Location = new Point(3, 3);
            DTSach.Name = "DTSach";
            DTSach.RowHeadersWidth = 51;
            DTSach.Size = new Size(1028, 613);
            DTSach.TabIndex = 0;
            // 
            // pnCTSach
            // 
            pnCTSach.BorderStyle = BorderStyle.FixedSingle;
            pnCTSach.Location = new Point(1037, 3);
            pnCTSach.Name = "pnCTSach";
            pnCTSach.Size = new Size(476, 544);
            pnCTSach.TabIndex = 1;
            // 
            // pnList
            // 
            pnList.AutoScroll = true;
            pnList.AutoScrollMargin = new Size(500, 0);
            pnList.Location = new Point(1626, 3);
            pnList.Name = "pnList";
            pnList.Size = new Size(1300, 640);
            pnList.TabIndex = 0;
            // 
            // pnChiTiet
            // 
            pnChiTiet.AutoScroll = true;
            pnChiTiet.AutoScrollMargin = new Size(500, 0);
            pnChiTiet.Location = new Point(2932, 3);
            pnChiTiet.Name = "pnChiTiet";
            pnChiTiet.Size = new Size(1164, 640);
            pnChiTiet.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Location = new Point(36, 199);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 42);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Thêm Sách";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cklTG
            // 
            cklTG.CheckOnClick = true;
            cklTG.FormattingEnabled = true;
            cklTG.Location = new Point(0, 0);
            cklTG.Name = "cklTG";
            cklTG.Size = new Size(200, 158);
            cklTG.TabIndex = 7;
            // 
            // pnTG
            // 
            pnTG.BorderStyle = BorderStyle.FixedSingle;
            pnTG.Controls.Add(btnTG);
            pnTG.Controls.Add(cklTG);
            pnTG.Location = new Point(498, 89);
            pnTG.Name = "pnTG";
            pnTG.Size = new Size(0, 0);
            pnTG.TabIndex = 23;
            // 
            // btnTG
            // 
            btnTG.Location = new Point(3, 164);
            btnTG.Name = "btnTG";
            btnTG.Size = new Size(79, 33);
            btnTG.TabIndex = 8;
            btnTG.Text = "xác nhận";
            btnTG.UseVisualStyleBackColor = true;
            btnTG.Click += btnTG_Click;
            // 
            // rjToggleButton1
            // 
            rjToggleButton1.AutoSize = true;
            rjToggleButton1.Location = new Point(1176, 219);
            rjToggleButton1.MinimumSize = new Size(45, 22);
            rjToggleButton1.Name = "rjToggleButton1";
            rjToggleButton1.OffBackColor = Color.Gray;
            rjToggleButton1.OffToggleColor = Color.Gainsboro;
            rjToggleButton1.OnBackColor = Color.MediumSlateBlue;
            rjToggleButton1.OnToggleColor = Color.WhiteSmoke;
            rjToggleButton1.Size = new Size(45, 22);
            rjToggleButton1.TabIndex = 24;
            rjToggleButton1.UseVisualStyleBackColor = true;
            rjToggleButton1.CheckedChanged += rjToggleButton1_CheckedChanged;
            // 
            // QuanLySach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(rjToggleButton1);
            Controls.Add(pnTG);
            Controls.Add(btnAdd);
            Controls.Add(pn);
            Controls.Add(XacNhan);
            Controls.Add(label9);
            Controls.Add(txtMoTa);
            Controls.Add(label8);
            Controls.Add(txtTen);
            Controls.Add(txtGiaDen);
            Controls.Add(txtGiaTu);
            Controls.Add(label7);
            Controls.Add(txtNamXBDen);
            Controls.Add(txtNamXBTu);
            Controls.Add(label6);
            Controls.Add(txtNXB);
            Controls.Add(label4);
            Controls.Add(txtTL);
            Controls.Add(label5);
            Controls.Add(txtListTG);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuanLySach";
            Size = new Size(4138, 1122);
            pn.ResumeLayout(false);
            pnDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DTSach).EndInit();
            pnTG.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void CklTG_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label txtListTG;
        private Label label5;
        private ComboBox txtTL;
        private ComboBox txtNXB;
        private Label label4;
        private Label label6;
        private TextBox txtNamXBTu;
        private TextBox txtNamXBDen;
        private TextBox txtGiaDen;
        private TextBox txtGiaTu;
        private Label label7;
        private TextBox txtTen;
        private Label label8;
        private Label label9;
        private TextBox txtMoTa;
        private Button XacNhan;
        private FlowLayoutPanel pn;
        private Button btnAdd;
        private CheckedListBox cklTG;
        private Panel pnTG;
        private Button btnTG;
        private FlowLayoutPanel pnList;
        private FlowLayoutPanel pnChiTiet;
        private FlowLayoutPanel pnDS;
        private DataGridView DTSach;
        private Panel pnCTSach;
        private Models.RJToggleButton rjToggleButton1;
    }
}
