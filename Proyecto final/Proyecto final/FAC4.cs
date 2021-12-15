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
    public partial class FAC4 : Form
    {
        public FAC4()
        {
            InitializeComponent();
        }

        private void B1B2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encontraron X Facturas dirigidos a " + TB4FAC3.Text + " Correspondientes a la fecha " + TB4FAC1.Text);            
            EFAC frm = new EFAC();
            frm.Show();
        }
    }
}
