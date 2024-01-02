namespace View.QuanLyMuonTra.QuanLyNhacTra
{
    partial class ViewNhacTra
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
            ListNT = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // ListNT
            // 
            ListNT.AutoScroll = true;
            ListNT.Location = new Point(0, 0);
            ListNT.Name = "ListNT";
            ListNT.Size = new Size(1332, 904);
            ListNT.TabIndex = 0;
            // 
            // ViewNhacTra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ListNT);
            Name = "ViewNhacTra";
            Size = new Size(1332, 904);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ListNT;
    }
}
