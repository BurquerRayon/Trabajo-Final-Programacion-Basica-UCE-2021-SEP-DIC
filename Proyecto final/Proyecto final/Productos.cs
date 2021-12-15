using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_final.Crud;


namespace Proyecto_final
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        ClsProductos1 cls = new ClsProductos1();
        string operacion = "Insertar";
        string IDProd;

        public void Productos_Load(object sender, EventArgs e)
        {
            ListCategoria();
            ListMar();
            Listduc();
        }

        public void ListCategoria()
        {
            ClsProductos1 objprod = new ClsProductos1();
            CMBCAT.DataSource = objprod.ListCategoria();
            CMBCAT.DisplayMember = "Categoria";
            CMBCAT.ValueMember = "IDCat";
        }
        public void ListMar()
        { 
            ClsProductos1 objpro = new ClsProductos1();
            CMBMAR.DataSource = objpro.ListMar();
            CMBMAR.DisplayMember = "Marca";
            CMBMAR.ValueMember = "IDMar";
        }

        public void Ag_Click(object sender, EventArgs e)
        {
            if (operacion == "Insertar") 
            {
                cls.IDCategoria1 = Convert.ToInt32(CMBCAT.SelectedValue);
                cls.IDMarca1 = Convert.ToInt32(CMBMAR.SelectedValue);
                cls.Descripcion = Des.Text;
                cls.Precio = Convert.ToDouble(Pre.Text);
                cls.Cantidad1 = Convert.ToDouble(Can.Text);
                cls.InsertarProducto();
                MessageBox.Show("Insertado Correctamente");
            }
            else if (operacion == "Editar")
            {
                cls.IDProd1 = Convert.ToInt32(IDProd);
                cls.IDCategoria1 = Convert.ToInt32(CMBCAT.SelectedValue);
                cls.IDMarca1 = Convert.ToInt32(CMBMAR.SelectedValue);
                cls.Descripcion = Des.Text;
                cls.Precio = Convert.ToDouble(Pre.Text);
                cls.Cantidad1 = Convert.ToDouble(Can.Text);
                cls.EditarProd();
                operacion = "Insertar";
                MessageBox.Show("Se edito Correctamente");
            }

            Listduc();
        }

        public void Listduc()
        {
            ClsProductos1 objpro = new ClsProductos1();
            dataGridView2.DataSource = objpro.ListProc();
        }

        public void Ed_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                operacion = "Editar";         
                CMBCAT.Text = dataGridView2.CurrentRow.Cells["Categoria"].Value.ToString();
                CMBMAR.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                CMBCAT.Text = dataGridView2.CurrentRow.Cells["Categoria"].Value.ToString();
                CMBMAR.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                IDProd = dataGridView2.CurrentRow.Cells["ID"].Value.ToString();                
            }
            else
                MessageBox.Show("Debe seleccionar una fila");
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                cls.IDProd1 = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value;
                cls.EliminarProd();
                MessageBox.Show("Se elimino con exito");
                Listduc();
            }

            else
                MessageBox.Show("Seleccione una fila");
        }
    }
}
