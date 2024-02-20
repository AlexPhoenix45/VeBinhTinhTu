namespace View.QuanLyTaiKhoan
{
    partial class ThemTaiKhoan
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
            txtRole = new TextBox();
            txtSdt = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtTen = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtRole);
            panel1.Controls.Add(txtSdt);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtTen);
            panel1.Location = new Point(8, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 284);
            panel1.TabIndex = 0;
            // 
            // txtRole
            // 
            txtRole.BorderStyle = BorderStyle.FixedSingle;
            txtRole.Enabled = false;
            txtRole.Location = new Point(359, 219);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(294, 27);
            txtRole.TabIndex = 13;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(359, 158);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(294, 27);
            txtSdt.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(103, 223);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 11;
            label7.Text = "Vai trò";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(103, 158);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 9;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(103, 97);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(103, 36);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 6;
            label2.Text = "Tên tài khoản";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(359, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(294, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(359, 36);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(294, 27);
            txtTen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 22);
            label1.Name = "label1";
            label1.Size = new Size(267, 46);
            label1.TabIndex = 0;
            label1.Text = "Thêm tài khoản";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Location = new Point(499, 400);
            button1.Name = "button1";
            button1.Size = new Size(121, 33);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Location = new Point(643, 400);
            button2.Name = "button2";
            button2.Size = new Size(121, 33);
            button2.TabIndex = 2;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ThemTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 452);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ThemTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemTaiKhoan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbbRole;
        private TextBox textBox4;
        private TextBox txt;
        private TextBox txtEmail;
        private TextBox txtTen;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox txtSdt;
        private TextBox textBox1;
        private TextBox txtRole;
    }
}