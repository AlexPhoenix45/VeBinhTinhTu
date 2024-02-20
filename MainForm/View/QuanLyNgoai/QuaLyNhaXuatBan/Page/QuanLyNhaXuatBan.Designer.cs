namespace View.QuanLyNgoai
{
    partial class QuanLyNhaXuatBan
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
            panel1 = new Panel();
            txtChucDanh = new Label();
            txtDiaChi = new Label();
            label2 = new Label();
            txtSTT = new Label();
            btnThem = new Button();
            pnTable = new FlowLayoutPanel();
            btnTim = new Button();
            txtTen = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtChucDanh);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSTT);
            panel1.Location = new Point(58, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 70);
            panel1.TabIndex = 11;
            // 
            // txtChucDanh
            // 
            txtChucDanh.AutoSize = true;
            txtChucDanh.Font = new Font("Segoe UI", 10F);
            txtChucDanh.Location = new Point(636, 24);
            txtChucDanh.Name = "txtChucDanh";
            txtChucDanh.Size = new Size(128, 23);
            txtChucDanh.TabIndex = 9;
            txtChucDanh.Text = "Ngày thành lập";
            // 
            // txtDiaChi
            // 
            txtDiaChi.AutoSize = true;
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(406, 24);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(62, 23);
            txtDiaChi.TabIndex = 8;
            txtDiaChi.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(187, 24);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 7;
            label2.Text = "Tên nhà xuất bản";
            // 
            // txtSTT
            // 
            txtSTT.AutoSize = true;
            txtSTT.Font = new Font("Segoe UI", 10F);
            txtSTT.Location = new Point(37, 23);
            txtSTT.Name = "txtSTT";
            txtSTT.Size = new Size(37, 23);
            txtSTT.TabIndex = 6;
            txtSTT.Text = "STT";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightGreen;
            btnThem.Location = new Point(58, 117);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // pnTable
            // 
            pnTable.AutoScroll = true;
            pnTable.BorderStyle = BorderStyle.FixedSingle;
            pnTable.Location = new Point(58, 241);
            pnTable.Name = "pnTable";
            pnTable.Size = new Size(1098, 557);
            pnTable.TabIndex = 9;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(402, 41);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 8;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(165, 41);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(205, 27);
            txtTen.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 41);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 6;
            label1.Text = "Tên tác giả:";
            // 
            // QuanLyNhaXuatBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnThem);
            Controls.Add(pnTable);
            Controls.Add(btnTim);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Name = "QuanLyNhaXuatBan";
            Size = new Size(1579, 913);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label txtChucDanh;
        private Label txtDiaChi;
        private Label label2;
        private Label txtSTT;
        private Button btnThem;
        private FlowLayoutPanel pnTable;
        private Button btnTim;
        private TextBox txtTen;
        private Label label1;
    }
}
