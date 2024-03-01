namespace View.BaoCaoThongKe
{
    partial class BaoCaoThongKe
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
            pnND = new FlowLayoutPanel();
            dateEnd = new DateTimePicker();
            dateStart = new DateTimePicker();
            btnTK = new Button();
            SuspendLayout();
            // 
            // pnND
            // 
            pnND.AutoScroll = true;
            pnND.BackColor = Color.White;
            pnND.Location = new Point(0, 66);
            pnND.Name = "pnND";
            pnND.Size = new Size(1300, 784);
            pnND.TabIndex = 1;
            // 
            // dateEnd
            // 
            dateEnd.CustomFormat = "dd/MM/yyyy";
            dateEnd.Font = new Font("Cambria", 10.2F);
            dateEnd.Format = DateTimePickerFormat.Custom;
            dateEnd.Location = new Point(293, 20);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(216, 27);
            dateEnd.TabIndex = 8;
            // 
            // dateStart
            // 
            dateStart.CustomFormat = "dd/MM/yyyy";
            dateStart.Font = new Font("Cambria", 10.2F);
            dateStart.Format = DateTimePickerFormat.Custom;
            dateStart.Location = new Point(30, 20);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(216, 27);
            dateStart.TabIndex = 9;
            // 
            // btnTK
            // 
            btnTK.Location = new Point(571, 19);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(99, 28);
            btnTK.TabIndex = 10;
            btnTK.Text = "Xác nhận";
            btnTK.UseVisualStyleBackColor = true;
            btnTK.Click += btnTK_Click;
            // 
            // BaoCaoThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btnTK);
            Controls.Add(dateStart);
            Controls.Add(dateEnd);
            Controls.Add(pnND);
            Name = "BaoCaoThongKe";
            Size = new Size(1300, 850);
            Load += BaoCaoThongKe_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnND;
        private DateTimePicker dateEnd;
        private DateTimePicker dateStart;
        private Button btnTK;
        private Button button1;
    }
}
