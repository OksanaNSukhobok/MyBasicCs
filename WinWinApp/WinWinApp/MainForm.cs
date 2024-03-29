﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void btnSubForm_Click(object sender, EventArgs e)
        {
            using (var frm = new SubForm())
            {
                frm.ShowDialog();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtOutput.Text ="Загрузился!" + Environment.NewLine;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            txtOutput.Text += "Показался!" + Environment.NewLine;
        }
    }
}
