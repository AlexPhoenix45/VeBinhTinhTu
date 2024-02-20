namespace MainForm.View.TrangChu
{
    partial class Login
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
            label4 = new Label();
            button2 = new Button();
            btnLogin = new Button();
            txtRole = new ComboBox();
            label3 = new Label();
            txtPass = new TextBox();
            label2 = new Label();
            txtTaiKhoan = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtRole);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTaiKhoan);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(261, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 401);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(96, 20);
            label4.Name = "label4";
            label4.Size = new Size(132, 32);
            label4.TabIndex = 10;
            label4.Text = "Đăng nhập";
            // 
            // button2
            // 
            button2.Location = new Point(41, 312);
            button2.Name = "button2";
            button2.Size = new Size(101, 29);
            button2.TabIndex = 9;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(163, 312);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 29);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtRole
            // 
            txtRole.FormattingEnabled = true;
            txtRole.Location = new Point(41, 244);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(228, 28);
            txtRole.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 221);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Vai trò";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(41, 166);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(228, 27);
            txtPass.TabIndex = 5;
            txtPass.Text = "a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 143);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(41, 91);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(228, 27);
            txtTaiKhoan.TabIndex = 3;
            txtTaiKhoan.Text = "Phạm Anh Tú";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 68);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 483);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox txtPass;
        private Label label2;
        private TextBox txtTaiKhoan;
        private Label label1;
        private Button button2;
        private Button btnLogin;
        private ComboBox txtRole;
        private Label label4;
    }
}