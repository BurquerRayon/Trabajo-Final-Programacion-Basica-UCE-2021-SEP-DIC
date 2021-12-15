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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FN3 frm = new FN3();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FN4 frm = new FN4();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.Show();
        }
    }
}
