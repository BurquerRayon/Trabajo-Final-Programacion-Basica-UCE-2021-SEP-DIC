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
    public partial class Admin : Form
    {
        public Admin(string Nombre)
        {
            InitializeComponent();
            lblAdmin.Text = "Jose Elian Alcantara";
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscando Actualizaciones....");
            MessageBox.Show("Posee la ultima versión de este programa.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para mas informacion llamar al numero: 809-876-9588 o enviar un mensaje al correo electronico nd2019-3065@uce.edu.do.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este Perfil pertenece al Director: " + lblAdmin.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esepere un momento...");
            MessageBox.Show("El respaldo se ha realizado exitosamente en el servidor secundario: UCE2.");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
