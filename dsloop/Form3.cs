using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsloop
{
    public partial class frmag : Form
    {
        public frmag()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double litro, result;
            char comb;

            litro = Convert.ToDouble(txtlitro.Text);
            comb = Convert.ToChar(txtcomb.Text);

            if(comb = A)
            {
                if(litro < 20)
                {
                    result = litro * (4.30 - (4.30 * 3 / 100));
                    txtresult.Text = result.ToString();
                }
                else
                {
                    result = litro * (4.30 - (4.30 * 5 / 100));
                    txtresult.Text = result.ToString();
                }
            }
            else if(comb = G)
            {
                if(litro < 20)
                {
                    result = litro * (5.50 - (5.50 * 4 / 100));
                    txtresult.Text = result.ToString();
                }
                else
                {
                    result = litro * (5.50 - (5.50 * 6 / 100));
                    txtresult.Text = result.ToString();
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtlitro.Clear();
            txtcomb.Clear();
            txtresult.Clear();
            txtlitro.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal frm = new frmprincipal();
            frm.Show();
        }
    }
}
