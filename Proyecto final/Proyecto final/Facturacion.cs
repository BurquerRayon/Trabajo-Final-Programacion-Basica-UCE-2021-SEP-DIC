using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void U1_Click(object sender, EventArgs e)
        {
            FAC1 frm = new FAC1();
            frm.Show();
        }

        private void U2_Click(object sender, EventArgs e)
        {
            FAC2 frm = new FAC2();
            frm.Show();
        }

        private void U3_Click(object sender, EventArgs e)
        {
            FAC3 frm = new FAC3();
            frm.Show();
        }

        private void U4_Click(object sender, EventArgs e)
        {
            FAC4 frm = new FAC4();
            frm.Show();
        }
    }
}
