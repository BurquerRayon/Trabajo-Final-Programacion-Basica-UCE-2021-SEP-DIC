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
    public partial class FAC1 : Form
    {
        public FAC1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encontro X Cantidad de Reportes con la fecha: " + TB1FAC1.Text);
        }
    }
}
