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
    public partial class FAC2 : Form
    {
        public FAC2()
        {
            InitializeComponent();
        }

        private void B1B2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encontro X Cantidad de pagos dirigidos a" + TB2FAC2.Text + "en la fecha" + TB2FAC1.Text + "por un valor de: RD$ XX.XX");
        }
    }
}
