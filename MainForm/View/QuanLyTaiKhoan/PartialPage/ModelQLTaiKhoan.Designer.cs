namespace View.QuanLyTaiKhoan
{
    partial class ModelQLTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelQLTaiKhoan));
            lblSTT = new Label();
            Ten = new Label();
            Ma = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSTT
            // 
            lblSTT.AutoSize = true;
            lblSTT.Font = new Font("Segoe UI", 10F);
            lblSTT.Location = new Point(23, 23);
            lblSTT.Name = "lblSTT";
            lblSTT.Size = new Size(29, 23);
            lblSTT.TabIndex = 0;
            lblSTT.Text = "stt";
            lblSTT.MouseEnter += lblSTT_MouseEnter;
            lblSTT.MouseLeave += ModelQLTaiKhoan_MouseLeave;
            // 
            // Ten
            // 
            Ten.AutoSize = true;
            Ten.Font = new Font("Segoe UI", 10F);
            Ten.Location = new Point(235, 23);
            Ten.Name = "Ten";
            Ten.Size = new Size(29, 23);
            Ten.TabIndex = 2;
            Ten.Text = "stt";
            Ten.MouseEnter += lblSTT_MouseEnter;
            Ten.MouseLeave += ModelQLTaiKhoan_MouseLeave;
            // 
            // Ma
            // 
            Ma.AutoSize = true;
            Ma.Font = new Font("Segoe UI", 10F);
            Ma.Location = new Point(538, 23);
            Ma.Name = "Ma";
            Ma.Size = new Size(29, 23);
            Ma.TabIndex = 3;
            Ma.Text = "stt";
            Ma.MouseEnter += lblSTT_MouseEnter;
            Ma.MouseLeave += ModelQLTaiKhoan_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += lblSTT_MouseEnter;
            pictureBox1.MouseLeave += ModelQLTaiKhoan_MouseLeave;
            // 
            // ModelQLTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pictureBox1);
            Controls.Add(Ma);
            Controls.Add(Ten);
            Controls.Add(lblSTT);
            Name = "ModelQLTaiKhoan";
            Size = new Size(755, 67);
            MouseEnter += lblSTT_MouseEnter;
            MouseLeave += ModelQLTaiKhoan_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        public Label lblSTT;
        public Label Ten;
        public Label Ma;
    }
}
