namespace View.QuanLyChucNang
{
    partial class DSUser
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
            pnDG = new FlowLayoutPanel();
            pnNV = new FlowLayoutPanel();
            pnQT = new FlowLayoutPanel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            SuspendLayout();
            // 
            // pnDG
            // 
            pnDG.AutoScroll = true;
            pnDG.BorderStyle = BorderStyle.FixedSingle;
            pnDG.Location = new Point(12, 107);
            pnDG.Name = "pnDG";
            pnDG.Size = new Size(310, 290);
            pnDG.TabIndex = 0;
            // 
            // pnNV
            // 
            pnNV.AutoScroll = true;
            pnNV.BorderStyle = BorderStyle.FixedSingle;
            pnNV.Location = new Point(351, 107);
            pnNV.Name = "pnNV";
            pnNV.Size = new Size(302, 290);
            pnNV.TabIndex = 1;
            // 
            // pnQT
            // 
            pnQT.AutoScroll = true;
            pnQT.BorderStyle = BorderStyle.FixedSingle;
            pnQT.Location = new Point(680, 107);
            pnQT.Name = "pnQT";
            pnQT.Size = new Size(310, 290);
            pnQT.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(820, 415);
            button1.Name = "button1";
            button1.Size = new Size(170, 36);
            button1.TabIndex = 2;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 46);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 3;
            label1.Text = "Độc giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(450, 46);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 4;
            label2.Text = "Nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(800, 46);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 5;
            label3.Text = "Quản trị";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 80);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(106, 24);
            checkBox4.TabIndex = 1;
            checkBox4.Text = "Chọn tất cả";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(351, 80);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(106, 24);
            checkBox5.TabIndex = 6;
            checkBox5.Text = "Chọn tất cả";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(680, 80);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(106, 24);
            checkBox6.TabIndex = 7;
            checkBox6.Text = "Chọn tất cả";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // DSUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 463);
            Controls.Add(checkBox5);
            Controls.Add(checkBox6);
            Controls.Add(label3);
            Controls.Add(checkBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pnQT);
            Controls.Add(pnNV);
            Controls.Add(pnDG);
            Name = "DSUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DSUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel pnDG;
        private FlowLayoutPanel pnNV;
        private FlowLayoutPanel pnQT;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
    }
}