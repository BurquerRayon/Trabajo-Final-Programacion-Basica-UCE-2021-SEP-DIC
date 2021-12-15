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
    public partial class FAC3 : Form
    {
        public FAC3()
        {
            InitializeComponent();
        }

        private void BFAC3_Click(object sender, EventArgs e)
        {

                if (TB3FAC1.Text == "abono")
                {
                    this.Hide();
                    MessageBox.Show("Se ha encontrado X cantidad de pagos del tipo: " + TB3FAC1.Text);
                    EFAC frm = new EFAC();
                    frm.Show();
                }

                if (TB3FAC1.Text == "efectivo")
                {
                    MessageBox.Show("Se ha encontrado X cantidad de pagos del tipo: " + TB3FAC1.Text);
                    EFAC frm = new EFAC();
                    frm.Show();
                }

                if (TB3FAC1.Text == "cheque")
                {
                    MessageBox.Show("Se ha encontrado X cantidad de pagos del tipo: " + TB3FAC1.Text);
                    EFAC frm = new EFAC();
                    frm.Show();
                }

                if (TB3FAC1.Text == "tarjeta electronica")
                {
                    MessageBox.Show("Se ha encontrado X cantidad de pagos del tipo: " + TB3FAC1.Text);
                    EFAC frm = new EFAC();
                    frm.Show();
                }

                if (TB3FAC1.Text == "pago en linea")
                {
                    MessageBox.Show("Se ha encontrado X cantidad de pagos del tipo: " + TB3FAC1.Text);
                    EFAC frm = new EFAC();
                    frm.Show();
                }    
        }          

        private void FAC3_Load(object sender, EventArgs e)
        {

        }
    }
}
