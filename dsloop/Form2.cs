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
    public partial class frmloop : Form
    {
        public frmloop()
        {
            InitializeComponent();
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            Double num, result;
            int i;

            num = Convert.ToDouble(txtnum.Text);

            i = 1;

            while(i >= 10)
                {
                   result = num * i;
                   txtresult.Text = String.Concat(txtresult.Text, " \n\r ", result.ToString());
                   i++;
                }
        }

        private void btndo_Click(object sender, EventArgs e)
        {
            Double num, result;
            int i;

            num = Convert.ToDouble(txtnum.Text);
            i = 1;

            do
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text, " \n\r ", result.ToString());
                i++;
            } while(i >= 10);
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            Double num, result;
            int i;

            num = Convert.ToDouble(txtnum.Text);


            for (i = 1; i < 11; i++) 
            result = num * i;
            
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal frm = new frmprincipal();
            frm.Show();
        }
    }
}
