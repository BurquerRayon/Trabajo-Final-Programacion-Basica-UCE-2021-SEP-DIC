using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_final
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=RAYQUIRION;Initial Catalog=P2;Persist Security Info=True;User ID=sa;Password=Nata ");
        


        public void Logeo (string Usuario, string contraseña)
        {
            try 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Nombre, Tipo_Usuario FROM usuarios WHERE Usuario = @Usuario and Password = @Pas", con);
                cmd.Parameters.AddWithValue("Usuario", Usuario);
                cmd.Parameters.AddWithValue("Pas", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                if(dt.Rows.Count == 1)
                {
                    this.Hide();
                    if(dt.Rows [0][1].ToString() == "director")
                    {
                        new Admin(dt.Rows[0][1].ToString()).Show();
                    }
                  
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "supervisor")
                    {
                        new Supervisor(dt.Rows[0][0].ToString()).Show();
                    }

                    if (dt.Rows[0][1].ToString() == "empleado")
                    {
                        this.Hide();
                        new Empleado(dt.Rows[0][0].ToString()).Show();
                    }

                }               
                
                else 
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);           
            }

            finally 
            {
                con.Close();
            }


        }

        private void IP1_Click(object sender, EventArgs e)
        {
            Logeo(this.US.Text, this.Contra.Text);
        }
    }
}
