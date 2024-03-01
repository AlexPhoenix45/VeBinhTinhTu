namespace View.QuanLyChucNang
{
    partial class ThemNhiemVu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            Date = new DateTimePicker();
            Name = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Date);
            panel1.Controls.Add(Name);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 320);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 212);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 4;
            label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 103);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên nhiệm vụ";
            // 
            // Date
            // 
            Date.Location = new Point(87, 235);
            Date.Name = "Date";
            Date.Size = new Size(235, 27);
            Date.TabIndex = 2;
            // 
            // Name
            // 
            Name.Location = new Point(87, 126);
            Name.Name = "Name";
            Name.Size = new Size(235, 27);
            Name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(87, 13);
            label1.Name = "label1";
            label1.Size = new Size(235, 41);
            label1.TabIndex = 0;
            label1.Text = "Thêm nhiệm vụ";
            // 
            // button1
            // 
            button1.Location = new Point(250, 352);
            button1.Name = "button1";
            button1.Size = new Size(179, 53);
            button1.TabIndex = 1;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 352);
            button2.Name = "button2";
            button2.Size = new Size(179, 53);
            button2.TabIndex = 2;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ThemNhiemVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 417);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Text = "ThemNhiemVu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private DateTimePicker Date;
        private TextBox Name;
        private Button button1;
        private Button button2;
    }
}