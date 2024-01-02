namespace QuanLySach.Sach
{
    partial class ModelSach
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
            img = new PictureBox();
            txtImg = new Label();
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            SuspendLayout();
            // 
            // img
            // 
            img.Location = new Point(30, 27);
            img.Name = "img";
            img.Size = new Size(176, 243);
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.TabIndex = 0;
            img.TabStop = false;
            // 
            // txtImg
            // 
            txtImg.AutoSize = true;
            txtImg.Location = new Point(30, 283);
            txtImg.MaximumSize = new Size(175, 0);
            txtImg.Name = "txtImg";
            txtImg.Size = new Size(50, 20);
            txtImg.TabIndex = 1;
            txtImg.Text = "label1";
            // 
            // ModelSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtImg);
            Controls.Add(img);
            Name = "ModelSach";
            Size = new Size(238, 327);
            ((System.ComponentModel.ISupportInitialize)img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox img;
        public Label txtImg;
    }
}