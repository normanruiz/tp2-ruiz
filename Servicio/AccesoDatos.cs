using System;
using System.Data.SqlClient;

namespace Servicio
{
    public class AccesoDatos
    {
        public SqlConnection conexion { get; set; }
        public SqlCommand comando { get; set; }
        public SqlDataReader lector { get; set; }
        String cadena = @"data source =.\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security=sspi";

        public AccesoDatos()
        {
            conexion = new SqlConnection(cadena);
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        public void Conectar()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public void Desconectar()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public void EjecutarConsulta(String consulta)
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
                lector = comando.ExecuteReader();
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public void EjecutarAccion(String consulta)
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
                comando.ExecuteNonQuery();
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public void AgregarParametro(String parametro, String valor)
        {
            try
            {
                comando.Parameters.AddWithValue(parametro, valor);
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }


        public void LimpiarParametro()
        {
            try
            {
                comando.Parameters.Clear();
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }
    }
}
