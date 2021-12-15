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
    public partial class Empleado : Form
    {
        public Empleado(string nombre)
        {
            InitializeComponent();
            lblU.Text = nombre;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este Perfil pertenece al Director: " + lblU.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {            
           Reportes frm = new Reportes();
           frm.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Facturacion frm = new Facturacion();
            frm.Show();
        }
    }
}
