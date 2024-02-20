namespace View.QuanLyNgoai
{
    partial class ModelNhaXuatBan
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
            btnXoa = new Button();
            btnSua = new Button();
            txtNgay = new Label();
            txtDiaChi = new Label();
            txtTen = new Label();
            txtSTT = new Label();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Salmon;
            btnXoa.Location = new Point(926, 32);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.MouseEnter += btnXoa_MouseEnter_1;
            btnXoa.MouseLeave += ModelNhaXuatBan_MouseLeave;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ActiveCaption;
            btnSua.Location = new Point(803, 30);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.MouseEnter += btnXoa_MouseEnter_1;
            btnSua.MouseLeave += ModelNhaXuatBan_MouseLeave;
            // 
            // txtNgay
            // 
            txtNgay.AutoSize = true;
            txtNgay.Font = new Font("Segoe UI", 10F);
            txtNgay.Location = new Point(637, 33);
            txtNgay.Name = "txtNgay";
            txtNgay.Size = new Size(55, 23);
            txtNgay.TabIndex = 9;
            txtNgay.Text = "label4";
            txtNgay.MouseEnter += btnXoa_MouseEnter_1;
            txtNgay.MouseLeave += ModelNhaXuatBan_MouseLeave;
            // 
            // txtDiaChi
            // 
            txtDiaChi.AutoSize = true;
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(407, 33);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(55, 23);
            txtDiaChi.TabIndex = 8;
            txtDiaChi.Text = "label3";
            txtDiaChi.MouseEnter += btnXoa_MouseEnter_1;
            txtDiaChi.MouseLeave += ModelNhaXuatBan_MouseLeave;
            // 
            // txtTen
            // 
            txtTen.AutoSize = true;
            txtTen.Font = new Font("Segoe UI", 10F);
            txtTen.Location = new Point(188, 33);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(55, 23);
            txtTen.TabIndex = 7;
            txtTen.Text = "label2";
            txtTen.MouseEnter += btnXoa_MouseEnter_1;
            txtTen.MouseLeave += ModelNhaXuatBan_MouseLeave;
            // 
            // txtSTT
            // 
            txtSTT.AutoSize = true;
            txtSTT.Font = new Font("Segoe UI", 10F);
            txtSTT.Location = new Point(38, 32);
            txtSTT.Name = "txtSTT";
            txtSTT.Size = new Size(37, 23);
            txtSTT.TabIndex = 6;
            txtSTT.Text = "STT";
            txtSTT.MouseEnter += btnXoa_MouseEnter_1;
            txtSTT.MouseLeave += ModelNhaXuatBan_MouseLeave;
            // 
            // ModelNhaXuatBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(txtNgay);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTen);
            Controls.Add(txtSTT);
            Name = "ModelNhaXuatBan";
            Size = new Size(1057, 88);
            MouseEnter += btnXoa_MouseEnter_1;
            MouseLeave += ModelNhaXuatBan_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnXoa;
        public Button btnSua;
        private Label txtNgay;
        private Label txtDiaChi;
        private Label txtTen;
        private Label txtSTT;
    }
}
