﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.Sach
{
    public partial class ModelSach : UserControl
    {
        public ModelSach()
        {
            InitializeComponent();
        }
        public event EventHandler ReloadXoaSachComplete;

        private void sach_XoaSachComplete(object sender, EventArgs e)
        {
            ReloadXoaSachComplete?.Invoke(this, EventArgs.Empty);
        }

        private void img_MouseEnter(object sender, EventArgs e)
        {

            this.BackColor = Color.LightGray;
        }

        private void ModelSach_MouseLeave(object sender, EventArgs e)
        {

            this.BackColor = Color.Transparent;
        }
    }
}
