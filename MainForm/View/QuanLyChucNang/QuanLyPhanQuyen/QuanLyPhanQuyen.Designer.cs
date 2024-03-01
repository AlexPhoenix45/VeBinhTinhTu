namespace View.QuanLyChucNang
{
    partial class QuanLyPhanQuyen
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
            pnAction = new FlowLayoutPanel();
            pnUpdate = new FlowLayoutPanel();
            pnRole = new FlowLayoutPanel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnAction
            // 
            pnAction.AutoScroll = true;
            pnAction.BorderStyle = BorderStyle.FixedSingle;
            pnAction.Location = new Point(1002, 194);
            pnAction.Name = "pnAction";
            pnAction.Size = new Size(429, 558);
            pnAction.TabIndex = 1;
            // 
            // pnUpdate
            // 
            pnUpdate.AutoScroll = true;
            pnUpdate.BorderStyle = BorderStyle.FixedSingle;
            pnUpdate.Location = new Point(522, 193);
            pnUpdate.Name = "pnUpdate";
            pnUpdate.Size = new Size(429, 558);
            pnUpdate.TabIndex = 2;
            // 
            // pnRole
            // 
            pnRole.AutoScroll = true;
            pnRole.BorderStyle = BorderStyle.FixedSingle;
            pnRole.Location = new Point(131, 194);
            pnRole.Name = "pnRole";
            pnRole.Size = new Size(335, 410);
            pnRole.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(131, 137);
            label1.MinimumSize = new Size(335, 60);
            label1.Name = "label1";
            label1.Size = new Size(335, 60);
            label1.TabIndex = 0;
            label1.Text = "Chọn đối tượng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(1002, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 61);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 16);
            label2.MinimumSize = new Size(200, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 28);
            label2.TabIndex = 1;
            label2.Text = "Chọn quyền ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(314, 14);
            button1.Name = "button1";
            button1.Size = new Size(110, 36);
            button1.TabIndex = 0;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(522, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 61);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 16);
            label3.MinimumSize = new Size(200, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 28);
            label3.TabIndex = 1;
            label3.Text = "Quyền hiện tại";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuanLyPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnRole);
            Controls.Add(pnUpdate);
            Controls.Add(pnAction);
            Name = "QuanLyPhanQuyen";
            Size = new Size(1579, 913);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel pnAction;
        private FlowLayoutPanel pnUpdate;
        private FlowLayoutPanel pnRole;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}
