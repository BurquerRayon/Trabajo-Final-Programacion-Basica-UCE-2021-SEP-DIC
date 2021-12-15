using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_final.Crud
{
    class ClsProductos1
    {

        private ConexionCRUD conexion = new ConexionCRUD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader Leer;

        private int IDProd;
        private int IDCategoria;
        private int IDMarca;
        private string descripcion;
        private double precio;
        private double Cantidad;

        public int IDProd1 { get => IDProd; set => IDProd = value; }
        public int IDCategoria1 { get => IDCategoria; set => IDCategoria = value; }
        public int IDMarca1 { get => IDMarca; set => IDMarca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Cantidad1 { get => Cantidad; set => Cantidad = value; }

        public DataTable ListCategoria()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "ListCategoria";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            Leer.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListMar()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "ListMar";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            Leer.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public void InsertarProducto()
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "InPro";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@idcategoria", IDCategoria);
            Comando.Parameters.AddWithValue("@idmarca", IDMarca);
            Comando.Parameters.AddWithValue("@descripcion", descripcion);
            Comando.Parameters.AddWithValue("@prec", precio);
            Comando.Parameters.AddWithValue("@Can", Cantidad);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        public void EditarProd()
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "update PRODUCTOS set IDCategoria=" + IDCategoria + ",IDMarca=" + IDMarca + ",Descripcion='" + descripcion + "', Precio=" + precio + ",Cantidad=" + Cantidad + "WHERE IDPROD=" + IDProd;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public DataTable ListProc()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "ListarProductoDEF";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            Leer.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void EliminarProd()
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "delete PRODUCTOS where IDPROD=" + IDProd;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

    }
}