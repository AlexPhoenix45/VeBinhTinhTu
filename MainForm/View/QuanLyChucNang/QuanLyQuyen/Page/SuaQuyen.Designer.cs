namespace View.QuanLyChucNang
{
    partial class SuaQuyen
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Hien = new CheckBox();
            Class = new TextBox();
            Name = new TextBox();
            NP = new TextBox();
            IdParent = new ComboBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Hien);
            panel1.Controls.Add(Class);
            panel1.Controls.Add(Name);
            panel1.Controls.Add(NP);
            panel1.Controls.Add(IdParent);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 357);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 186);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 9;
            label5.Text = "Namespace";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(438, 186);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 8;
            label4.Text = "Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 91);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên chức năng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 91);
            label2.Name = "label2";
            label2.Size = new Size(248, 20);
            label2.TabIndex = 6;
            label2.Text = "Chức năng cha (để trống nếu là cha)";
            // 
            // Hien
            // 
            Hien.AutoSize = true;
            Hien.Location = new Point(37, 298);
            Hien.Name = "Hien";
            Hien.Size = new Size(133, 24);
            Hien.TabIndex = 5;
            Hien.Text = "Chức năng hiện";
            Hien.UseVisualStyleBackColor = true;
            // 
            // Class
            // 
            Class.Location = new Point(438, 209);
            Class.Name = "Class";
            Class.Size = new Size(368, 27);
            Class.TabIndex = 4;
            // 
            // Name
            // 
            Name.Location = new Point(438, 115);
            Name.Name = "Name";
            Name.Size = new Size(368, 27);
            Name.TabIndex = 3;
            // 
            // NP
            // 
            NP.Location = new Point(37, 209);
            NP.Name = "NP";
            NP.Size = new Size(368, 27);
            NP.TabIndex = 2;
            // 
            // IdParent
            // 
            IdParent.FormattingEnabled = true;
            IdParent.Location = new Point(37, 115);
            IdParent.Name = "IdParent";
            IdParent.Size = new Size(368, 28);
            IdParent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(311, 16);
            label1.Name = "label1";
            label1.Size = new Size(176, 46);
            label1.TabIndex = 0;
            label1.Text = "Sửa quyền";
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.Location = new Point(739, 400);
            button2.Name = "button2";
            button2.Size = new Size(120, 38);
            button2.TabIndex = 6;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Location = new Point(583, 400);
            button1.Name = "button1";
            button1.Size = new Size(120, 38);
            button1.TabIndex = 5;
            button1.Text = "Sửa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // SuaQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Text = "SuaQuyen";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox Hien;
        private TextBox Class;
        private TextBox Name;
        private TextBox NP;
        private ComboBox IdParent;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}