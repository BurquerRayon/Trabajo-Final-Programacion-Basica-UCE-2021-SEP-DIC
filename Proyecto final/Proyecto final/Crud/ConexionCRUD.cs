using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_final.Crud
{
    class ConexionCRUD
    {
        static private string CadenaConexion = "Data Source=RAYQUIRION;Initial Catalog=P1;Persist Security Info=True;User ID=sa;Password=Nata";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {

            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
