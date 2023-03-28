using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsloop
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmloop frm = new frmloop();
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gasolinaalcoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmag frm = new frmag();
            frm.Show();
        }
    }
}
