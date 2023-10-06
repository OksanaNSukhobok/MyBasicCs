using System;
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
    public partial class SubForm : Form
    {
        private Random rnd = new Random();
        public SubForm()
        {
            InitializeComponent();
        }

        private void SubForm_Click(object sender, EventArgs e)
        {
            /*
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            this.BackColor = randomColor;
            */
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
            /*
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            this.BackColor = randomColor;
            */
        }

        private void panelRandonColors_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            panelRandonColors.BackColor = randomColor;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
