
namespace View.QuanLyChucNang
{
    partial class QuanLyQuyen
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
            TKPR = new ComboBox();
            button1 = new Button();
            pnTable = new FlowLayoutPanel();
            panel2 = new Panel();
            lblChucNang = new Label();
            lblClass = new Label();
            lblNP = new Label();
            lblName = new Label();
            lblParent = new Label();
            lblStt = new Label();
            button2 = new Button();
            label8 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TKPR
            // 
            TKPR.FormattingEnabled = true;
            TKPR.Location = new Point(18, 38);
            TKPR.Name = "TKPR";
            TKPR.Size = new Size(243, 28);
            TKPR.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(316, 38);
            button1.Name = "button1";
            button1.Size = new Size(136, 31);
            button1.TabIndex = 1;
            button1.Text = "Lọc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnTable
            // 
            pnTable.AutoScroll = true;
            pnTable.BorderStyle = BorderStyle.FixedSingle;
            pnTable.Location = new Point(18, 198);
            pnTable.Name = "pnTable";
            pnTable.Size = new Size(1675, 679);
            pnTable.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblChucNang);
            panel2.Controls.Add(lblClass);
            panel2.Controls.Add(lblNP);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(lblParent);
            panel2.Controls.Add(lblStt);
            panel2.Location = new Point(17, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(1676, 74);
            panel2.TabIndex = 3;
            // 
            // lblChucNang
            // 
            lblChucNang.AutoSize = true;
            lblChucNang.Font = new Font("Segoe UI", 12F);
            lblChucNang.Location = new Point(1329, 22);
            lblChucNang.Name = "lblChucNang";
            lblChucNang.Size = new Size(52, 28);
            lblChucNang.TabIndex = 14;
            lblChucNang.Text = "Hiện";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 12F);
            lblClass.Location = new Point(1052, 24);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(55, 28);
            lblClass.TabIndex = 13;
            lblClass.Text = "Class";
            // 
            // lblNP
            // 
            lblNP.AutoSize = true;
            lblNP.Font = new Font("Segoe UI", 12F);
            lblNP.Location = new Point(652, 22);
            lblNP.Name = "lblNP";
            lblNP.Size = new Size(113, 28);
            lblNP.TabIndex = 12;
            lblNP.Text = "Namespace";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(298, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(136, 28);
            lblName.TabIndex = 11;
            lblName.Text = "Tên chức năng";
            // 
            // lblParent
            // 
            lblParent.AutoSize = true;
            lblParent.Font = new Font("Segoe UI", 12F);
            lblParent.Location = new Point(109, 22);
            lblParent.Name = "lblParent";
            lblParent.Size = new Size(140, 28);
            lblParent.TabIndex = 10;
            lblParent.Text = "Chức năng cha";
            // 
            // lblStt
            // 
            lblStt.AutoSize = true;
            lblStt.Font = new Font("Segoe UI", 12F);
            lblStt.Location = new Point(15, 22);
            lblStt.Name = "lblStt";
            lblStt.Size = new Size(43, 28);
            lblStt.TabIndex = 9;
            lblStt.Text = "STT";
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.Location = new Point(18, 89);
            button2.Name = "button2";
            button2.Size = new Size(136, 31);
            button2.TabIndex = 5;
            button2.Text = "Thêm quyền";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 15);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 6;
            label8.Text = "Chức năng cha";
            // 
            // QuanLyQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(pnTable);
            Controls.Add(button1);
            Controls.Add(TKPR);
            Name = "QuanLyQuyen";
            Size = new Size(1807, 913);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ComboBox TKPR;
        private Button button1;
        private FlowLayoutPanel pnTable;
        private Panel panel1;
        public Label label6;
        public Label label5;
        public Label label4;
        public Label label3;
        public Label label2;
        public Label label7;
        private Panel panel2;
        private Label lblChucNang;
        private Label lblClass;
        private Label lblNP;
        private Label lblName;
        private Label lblParent;
        private Label lblStt;
        private TextBox TKTen;
        private Button button2;
        private Label label8;
        private Label label1;
    }
}
