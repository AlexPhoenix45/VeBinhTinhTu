namespace PartialPage.QuanLyMuon
{
    partial class ModelListSach
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
            txtTen = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.AutoSize = true;
            txtTen.Location = new Point(15, 12);
            txtTen.MinimumSize = new Size(320, 0);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(320, 20);
            txtTen.TabIndex = 0;
            txtTen.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(355, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(56, 27);
            textBox1.TabIndex = 1;
            // 
            // ModelListSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(txtTen);
            Name = "ModelListSach";
            Size = new Size(427, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label txtTen;
        public TextBox textBox1;
    }
}
