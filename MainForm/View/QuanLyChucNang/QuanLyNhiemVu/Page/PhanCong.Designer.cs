namespace View.QuanLyChucNang
{
    partial class PhanCong
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
            dtDG = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            dtNV = new DataGridView();
            dtQT = new DataGridView();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox4 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dtDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtQT).BeginInit();
            SuspendLayout();
            // 
            // dtDG
            // 
            dtDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDG.Location = new Point(12, 179);
            dtDG.Name = "dtDG";
            dtDG.RowHeadersWidth = 51;
            dtDG.Size = new Size(337, 325);
            dtDG.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(469, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 41);
            label1.TabIndex = 1;
            label1.Text = "Phân công";
            // 
            // button1
            // 
            button1.Location = new Point(13, 89);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Phân công";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtNV
            // 
            dtNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtNV.Location = new Point(388, 179);
            dtNV.Name = "dtNV";
            dtNV.RowHeadersWidth = 51;
            dtNV.Size = new Size(337, 325);
            dtNV.TabIndex = 3;
            // 
            // dtQT
            // 
            dtQT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtQT.Location = new Point(759, 179);
            dtQT.Name = "dtQT";
            dtQT.RowHeadersWidth = 51;
            dtQT.Size = new Size(337, 325);
            dtQT.TabIndex = 4;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Enabled = false;
            checkBox5.Location = new Point(388, 149);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(138, 24);
            checkBox5.TabIndex = 9;
            checkBox5.Text = "Tất cả nhân viên";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Enabled = false;
            checkBox6.Location = new Point(759, 149);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(126, 24);
            checkBox6.TabIndex = 10;
            checkBox6.Text = "Tất cả quản trị";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Enabled = false;
            checkBox4.Location = new Point(13, 149);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(125, 24);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Tất cả độc giả";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // PhanCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 564);
            Controls.Add(checkBox5);
            Controls.Add(checkBox6);
            Controls.Add(checkBox4);
            Controls.Add(dtQT);
            Controls.Add(dtNV);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dtDG);
            Name = "PhanCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhanCong";
            ((System.ComponentModel.ISupportInitialize)dtDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtQT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtDG;
        private Label label1;
        private Button button1;
        private DataGridView dtNV;
        private DataGridView dtQT;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox4;
    }
}