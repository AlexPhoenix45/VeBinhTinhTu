namespace View.QuanLyNgoai
{
    partial class QuanLyTheLoai
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
            label1 = new Label();
            txtTen = new TextBox();
            btnTim = new Button();
            pnTable = new FlowLayoutPanel();
            btnThem = new Button();
            panel1 = new Panel();
            label2 = new Label();
            txtSTT = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 61);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Thể Loại";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(196, 54);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(225, 27);
            txtTen.TabIndex = 1;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(471, 57);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // pnTable
            // 
            pnTable.AutoScroll = true;
            pnTable.BorderStyle = BorderStyle.FixedSingle;
            pnTable.Location = new Point(66, 286);
            pnTable.Name = "pnTable";
            pnTable.Size = new Size(903, 557);
            pnTable.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightGreen;
            btnThem.Location = new Point(83, 157);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSTT);
            panel1.Location = new Point(66, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 70);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(298, 23);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 7;
            label2.Text = "Tên thể loại";
            // 
            // txtSTT
            // 
            txtSTT.AutoSize = true;
            txtSTT.Font = new Font("Segoe UI", 10F);
            txtSTT.Location = new Point(37, 23);
            txtSTT.Name = "txtSTT";
            txtSTT.Size = new Size(37, 23);
            txtSTT.TabIndex = 6;
            txtSTT.Text = "STT";
            // 
            // QuanLyTheLoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnThem);
            Controls.Add(pnTable);
            Controls.Add(btnTim);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Name = "QuanLyTheLoai";
            Size = new Size(1579, 913);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTen;
        private Button btnTim;
        private FlowLayoutPanel pnTable;
        private Button btnThem;
        private Panel panel1;
        private Label label2;
        private Label txtSTT;
    }
}
