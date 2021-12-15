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
    public partial class FN4 : Form
    {
        public FN4()
        {
            InitializeComponent();
        }

        private void B4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encontraron X cantidad del pedidos en la fecha: " + TB2FN4.Text + ".");
            this.Hide();
        }
    }
}
