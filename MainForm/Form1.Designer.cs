namespace MainForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BangData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)BangData).BeginInit();
            SuspendLayout();
            // 
            // BangData
            // 
            BangData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BangData.Location = new Point(50, 36);
            BangData.Name = "BangData";
            BangData.RowHeadersWidth = 51;
            BangData.Size = new Size(689, 298);
            BangData.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BangData);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)BangData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView BangData;
    }
}
