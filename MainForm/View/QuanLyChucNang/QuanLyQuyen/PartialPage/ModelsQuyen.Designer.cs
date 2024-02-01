namespace View.QuanLyChucNang
{
    partial class ModelsQuyen
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
            lblStt = new Label();
            lblParent = new Label();
            lblName = new Label();
            lblNP = new Label();
            lblClass = new Label();
            lblChucNang = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            SuspendLayout();
            // 
            // lblStt
            // 
            lblStt.AutoSize = true;
            lblStt.Font = new Font("Segoe UI", 10F);
            lblStt.Location = new Point(16, 22);
            lblStt.Name = "lblStt";
            lblStt.Size = new Size(55, 23);
            lblStt.TabIndex = 0;
            lblStt.Text = "label1";
            // 
            // lblParent
            // 
            lblParent.AutoSize = true;
            lblParent.Font = new Font("Segoe UI", 10F);
            lblParent.Location = new Point(110, 22);
            lblParent.Name = "lblParent";
            lblParent.Size = new Size(55, 23);
            lblParent.TabIndex = 1;
            lblParent.Text = "label2";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(299, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 23);
            lblName.TabIndex = 2;
            lblName.Text = "label3";
            // 
            // lblNP
            // 
            lblNP.AutoSize = true;
            lblNP.Font = new Font("Segoe UI", 10F);
            lblNP.Location = new Point(653, 22);
            lblNP.Name = "lblNP";
            lblNP.Size = new Size(55, 23);
            lblNP.TabIndex = 3;
            lblNP.Text = "label4";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 10F);
            lblClass.Location = new Point(1053, 24);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(55, 23);
            lblClass.TabIndex = 4;
            lblClass.Text = "label5";
            // 
            // lblChucNang
            // 
            lblChucNang.AutoSize = true;
            lblChucNang.Font = new Font("Segoe UI", 10F);
            lblChucNang.Location = new Point(1330, 22);
            lblChucNang.Name = "lblChucNang";
            lblChucNang.Size = new Size(55, 23);
            lblChucNang.TabIndex = 5;
            lblChucNang.Text = "label6";
            // 
            // btnSua
            // 
            btnSua.AutoSize = true;
            btnSua.BackColor = SystemColors.ActiveCaption;
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.Location = new Point(1424, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(84, 33);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.BackColor = Color.Salmon;
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.Location = new Point(1527, 16);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(84, 33);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // ModelsQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(lblChucNang);
            Controls.Add(lblClass);
            Controls.Add(lblNP);
            Controls.Add(lblName);
            Controls.Add(lblParent);
            Controls.Add(lblStt);
            Name = "ModelsQuyen";
            Size = new Size(1625, 67);
            MouseEnter += ModelsQuyen_MouseEnter;
            MouseLeave += ModelsQuyen_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStt;
        private Label lblParent;
        private Label lblName;
        private Label lblNP;
        private Label lblClass;
        private Label lblChucNang;
        public Button btnSua;
        public Button btnXoa;
    }
}
