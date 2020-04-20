using Modelo;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorMarca
    {
        public List<Marca> Listar()
        {
            List<Marca> listadoMarcas;
            Marca marca;
            AccesoDatos conexion = null;
            try
            {
                listadoMarcas = new List<Marca>();
                conexion = new AccesoDatos();
                conexion.Conectar();
                conexion.EjecutarConsulta("select Id, Descripcion from MARCAS");
                while(conexion.lector.Read())
                {
                    marca = new Marca();
                    marca.Id = (int)conexion.lector["Id"];
                    marca.Descripcion = (String)conexion.lector["Descripcion"];

                    listadoMarcas.Add(marca);
                }

                return listadoMarcas;
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
            finally
            {
                if(conexion != null)
                {
                    conexion.Desconectar();
                }
            }
        }
    }
}
