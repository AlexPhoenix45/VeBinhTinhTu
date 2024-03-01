using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace QLTV.View.CaiDat
{
    public partial class CaiDat : UserControl
    {
        public CaiDat()
        {

            InitializeComponent(); if (Models.Session.cd.CheDoToi == 1) { this.BackColor = Color.Silver; }

            if (Models.Session.cd.CheDoToi == 1)
            {
                this.BackColor = Color.Silver;
                DoiGD.Checked = true;
            }
            else
            {
                this.BackColor = Color.White;
                DoiGD.Checked = false;
            }

            if (Models.Session.cd.DSList == 1)
            {
                rjToggleButton2.Checked = true;
            }
            else 
            {
                rjToggleButton2.Checked = false; 
            }
        }


        private void rjToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton2.Checked == true)
            {
                Models.Session.cd.DSList = 1;

            }
            else
            {
                Models.Session.cd.DSList = 0;
            }

            if (new DAO.SqlToLinq.CaiDat().Update(Models.Session.cd))
            {
                Debug.WriteLine("Back2 ok");
            }
        }

        private void DoiGD_CheckedChanged(object sender, EventArgs e)
        {
            if (DoiGD.Checked == true)
            {
                this.BackColor = Color.Silver;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }
    }
}
