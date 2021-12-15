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
    public partial class FN3 : Form
    {
        public FN3()
        {
            InitializeComponent();
        }
        private void B3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encontraron X cantidad del producto: " + TB1FN3.Text + " en el almacen.");
            this.Hide();
        }
    }
}