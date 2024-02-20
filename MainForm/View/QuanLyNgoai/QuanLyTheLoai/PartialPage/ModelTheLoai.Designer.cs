namespace View.QuanLyNgoai
{
    partial class ModelTheLoai
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
            txtTen = new Label();
            txtSTT = new Label();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Salmon;
            btnXoa.Location = new Point(655, 34);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.MouseEnter += btnXoa_MouseEnter_1;
            btnXoa.MouseLeave += ModelTheLoai_MouseLeave;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ActiveCaption;
            btnSua.Location = new Point(532, 32);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.MouseEnter += btnXoa_MouseEnter_1;
            btnSua.MouseLeave += ModelTheLoai_MouseLeave;
            // 
            // txtTen
            // 
            txtTen.AutoSize = true;
            txtTen.Font = new Font("Segoe UI", 10F);
            txtTen.Location = new Point(235, 36);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(55, 23);
            txtTen.TabIndex = 7;
            txtTen.Text = "label2";
            txtTen.MouseEnter += btnXoa_MouseEnter_1;
            txtTen.MouseLeave += ModelTheLoai_MouseLeave;
            // 
            // txtSTT
            // 
            txtSTT.AutoSize = true;
            txtSTT.Font = new Font("Segoe UI", 10F);
            txtSTT.Location = new Point(46, 34);
            txtSTT.Name = "txtSTT";
            txtSTT.Size = new Size(37, 23);
            txtSTT.TabIndex = 6;
            txtSTT.Text = "STT";
            txtSTT.MouseEnter += btnXoa_MouseEnter_1;
            txtSTT.MouseLeave += ModelTheLoai_MouseLeave;
            // 
            // ModelTheLoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(txtTen);
            Controls.Add(txtSTT);
            Name = "ModelTheLoai";
            Size = new Size(901, 88);
            MouseEnter += btnXoa_MouseEnter_1;
            MouseLeave += ModelTheLoai_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnXoa;
        public Button btnSua;
        private Label txtTen;
        private Label txtSTT;
    }
}
