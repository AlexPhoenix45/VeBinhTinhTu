namespace View.QuanLyChucNang
{
    partial class ModelNhiemVu
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
            STT = new Label();
            Name = new Label();
            SL = new Label();
            CT = new Button();
            Sua = new Button();
            Xoa = new Button();
            ThHan = new Label();
            SuspendLayout();
            // 
            // STT
            // 
            STT.AutoSize = true;
            STT.Font = new Font("Segoe UI", 10F);
            STT.Location = new Point(21, 29);
            STT.Name = "STT";
            STT.Size = new Size(55, 23);
            STT.TabIndex = 0;
            STT.Text = "label1";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 10F);
            Name.Location = new Point(128, 29);
            Name.Name = "Name";
            Name.Size = new Size(55, 23);
            Name.TabIndex = 1;
            Name.Text = "label2";
            // 
            // SL
            // 
            SL.AutoSize = true;
            SL.Font = new Font("Segoe UI", 10F);
            SL.Location = new Point(502, 29);
            SL.Name = "SL";
            SL.Size = new Size(55, 23);
            SL.TabIndex = 2;
            SL.Text = "label3";
            // 
            // CT
            // 
            CT.Font = new Font("Segoe UI", 10F);
            CT.Location = new Point(871, 21);
            CT.Name = "CT";
            CT.Size = new Size(125, 34);
            CT.TabIndex = 3;
            CT.Text = "Phân công";
            CT.UseVisualStyleBackColor = true;
            // 
            // Sua
            // 
            Sua.Font = new Font("Segoe UI", 10F);
            Sua.Location = new Point(1002, 21);
            Sua.Name = "Sua";
            Sua.Size = new Size(94, 34);
            Sua.TabIndex = 4;
            Sua.Text = "Sửa";
            Sua.UseVisualStyleBackColor = true;
            // 
            // Xoa
            // 
            Xoa.Font = new Font("Segoe UI", 10F);
            Xoa.Location = new Point(1102, 21);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(94, 34);
            Xoa.TabIndex = 5;
            Xoa.Text = "Xóa";
            Xoa.UseVisualStyleBackColor = true;
            // 
            // ThHan
            // 
            ThHan.AutoSize = true;
            ThHan.Font = new Font("Segoe UI", 10F);
            ThHan.Location = new Point(664, 29);
            ThHan.Name = "ThHan";
            ThHan.Size = new Size(55, 23);
            ThHan.TabIndex = 6;
            ThHan.Text = "label3";
            // 
            // ModelNhiemVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(ThHan);
            Controls.Add(Xoa);
            Controls.Add(Sua);
            Controls.Add(CT);
            Controls.Add(SL);
            Controls.Add(Name);
            Controls.Add(STT);
            Size = new Size(1224, 75);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label STT;
        private Label Name;
        private Label SL;
        private Label ThHan;
        public Button CT;
        public Button Sua;
        public Button Xoa;
    }
}
