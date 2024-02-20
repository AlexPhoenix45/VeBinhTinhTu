namespace View.QuanLyNgoai
{
    partial class ModelTacGia
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
            txtSTT = new Label();
            txtTen = new Label();
            txtDiaChi = new Label();
            txtChucDanh = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            SuspendLayout();
            // 
            // txtSTT
            // 
            txtSTT.AutoSize = true;
            txtSTT.Font = new Font("Segoe UI", 10F);
            txtSTT.Location = new Point(36, 31);
            txtSTT.Name = "txtSTT";
            txtSTT.Size = new Size(37, 23);
            txtSTT.TabIndex = 0;
            txtSTT.Text = "STT";
            txtSTT.MouseEnter += txtSTT_MouseEnter_1;
            txtSTT.MouseLeave += ModelTacGia_MouseLeave;
            // 
            // txtTen
            // 
            txtTen.AutoSize = true;
            txtTen.Font = new Font("Segoe UI", 10F);
            txtTen.Location = new Point(186, 32);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(55, 23);
            txtTen.TabIndex = 1;
            txtTen.Text = "label2";
            txtTen.MouseEnter += txtSTT_MouseEnter_1;
            txtTen.MouseLeave += ModelTacGia_MouseLeave;
            // 
            // txtDiaChi
            // 
            txtDiaChi.AutoSize = true;
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(405, 32);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(55, 23);
            txtDiaChi.TabIndex = 2;
            txtDiaChi.Text = "label3";
            txtDiaChi.MouseEnter += txtSTT_MouseEnter_1;
            txtDiaChi.MouseLeave += ModelTacGia_MouseLeave;
            // 
            // txtChucDanh
            // 
            txtChucDanh.AutoSize = true;
            txtChucDanh.Font = new Font("Segoe UI", 10F);
            txtChucDanh.Location = new Point(635, 32);
            txtChucDanh.Name = "txtChucDanh";
            txtChucDanh.Size = new Size(55, 23);
            txtChucDanh.TabIndex = 3;
            txtChucDanh.Text = "label4";
            txtChucDanh.MouseEnter += txtSTT_MouseEnter_1;
            txtChucDanh.MouseLeave += ModelTacGia_MouseLeave;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ActiveCaption;
            btnSua.Location = new Point(801, 29);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.MouseEnter += txtSTT_MouseEnter_1;
            btnSua.MouseLeave += ModelTacGia_MouseLeave;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Salmon;
            btnXoa.Location = new Point(924, 31);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.MouseEnter += txtSTT_MouseEnter_1;
            btnXoa.MouseLeave += ModelTacGia_MouseLeave;
            // 
            // ModelTacGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(txtChucDanh);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTen);
            Controls.Add(txtSTT);
            Name = "ModelTacGia";
            Size = new Size(1059, 90);
            MouseEnter += txtSTT_MouseEnter_1;
            MouseLeave += ModelTacGia_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtSTT;
        private Label txtTen;
        private Label txtDiaChi;
        private Label txtChucDanh;
        public Button btnSua;
        public Button btnXoa;
    }
}
