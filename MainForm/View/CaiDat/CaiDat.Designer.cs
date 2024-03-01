namespace QLTV.View.CaiDat
{
    partial class CaiDat
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            DoiGD = new Models.RJToggleButton();
            rjToggleButton2 = new Models.RJToggleButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Enabled = false;
            textBox1.Location = new Point(64, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "   Chủ đề tối";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Enabled = false;
            textBox2.Location = new Point(64, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "   Danh mục sách dạng lưới";
            // 
            // DoiGD
            // 
            DoiGD.AutoSize = true;
            DoiGD.Location = new Point(389, 64);
            DoiGD.MinimumSize = new Size(45, 22);
            DoiGD.Name = "DoiGD";
            DoiGD.OffBackColor = Color.Gray;
            DoiGD.OffToggleColor = Color.Gainsboro;
            DoiGD.OnBackColor = Color.MediumSlateBlue;
            DoiGD.OnToggleColor = Color.WhiteSmoke;
            DoiGD.Size = new Size(45, 22);
            DoiGD.TabIndex = 2;
            DoiGD.UseVisualStyleBackColor = true;
            DoiGD.CheckedChanged += DoiGD_CheckedChanged;
            // 
            // rjToggleButton2
            // 
            rjToggleButton2.AutoSize = true;
            rjToggleButton2.Location = new Point(389, 138);
            rjToggleButton2.MinimumSize = new Size(45, 22);
            rjToggleButton2.Name = "rjToggleButton2";
            rjToggleButton2.OffBackColor = Color.Gray;
            rjToggleButton2.OffToggleColor = Color.Gainsboro;
            rjToggleButton2.OnBackColor = Color.MediumSlateBlue;
            rjToggleButton2.OnToggleColor = Color.WhiteSmoke;
            rjToggleButton2.Size = new Size(45, 22);
            rjToggleButton2.TabIndex = 3;
            rjToggleButton2.UseVisualStyleBackColor = true;
            rjToggleButton2.CheckedChanged += rjToggleButton2_CheckedChanged;
            // 
            // CaiDat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rjToggleButton2);
            Controls.Add(DoiGD);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "CaiDat";
            Size = new Size(948, 604);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Models.RJToggleButton rjToggleButton2;
        public Models.RJToggleButton DoiGD;
    }
}
