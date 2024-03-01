namespace View.QuanLyChucNang
{
    partial class QuanLyNhiemVu
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            pnList = new FlowLayoutPanel();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 38);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên nhiệm vụ";
            // 
            // button1
            // 
            button1.Location = new Point(261, 60);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // pnList
            // 
            pnList.AutoScroll = true;
            pnList.BorderStyle = BorderStyle.FixedSingle;
            pnList.Location = new Point(44, 162);
            pnList.Name = "pnList";
            pnList.Size = new Size(1258, 490);
            pnList.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(44, 119);
            button2.Name = "button2";
            button2.Size = new Size(175, 37);
            button2.TabIndex = 4;
            button2.Text = "Thêm nhiệm vụ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // QuanLyNhiemVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(pnList);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "QuanLyNhiemVu";
            Size = new Size(1357, 717);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private FlowLayoutPanel pnList;
        private Button button2;
    }
}
