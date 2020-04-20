﻿using Modelo;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorArticulo
    {
        public List<Articulo> Listar()
        {
            List<Articulo> listadoArticulo;
            Articulo articulo;
            AccesoDatos conexion = null;
            try
            {
                listadoArticulo = new List<Articulo>();
                conexion = new AccesoDatos();
                conexion.Conectar();
                conexion.EjecutarConsulta("select a.Id, a.Codigo, a.Nombre, a.Descripcion, a.IdMarca, m.Descripcion, a.IdCategoria, c.Descripcion, a.ImagenUrl, a.Precio from ARTICULOS a left join MARCAS m on a.IdMarca = m.Id left join CATEGORIAS c on a.IdCategoria = c.Id");
                while (conexion.lector.Read())
                {
                    articulo = new Articulo();
                    articulo.Id = conexion.lector.GetInt32(0);
                    articulo.Codigo = conexion.lector.GetString(1);
                    articulo.Nombre = conexion.lector.GetString(2);
                    articulo.Descripcion = conexion.lector.GetString(3);
                    articulo.Imagen = conexion.lector.GetString(8);
                    articulo.Precio = conexion.lector.GetDecimal(9);

                    articulo.marca = new Marca();
                    articulo.marca.Id = conexion.lector.GetInt32(4);
                    articulo.marca.Descripcion = conexion.lector.GetString(5);

                    articulo.categoria = new Categoria();
                    articulo.categoria.Id = conexion.lector.GetInt32(6);
                    articulo.categoria.Descripcion = conexion.lector.GetString(7);

                    listadoArticulo.Add(articulo);
                }

                return listadoArticulo;
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Desconectar();
                }
            }

        }

        public void AgregarNuevo(Articulo articulo)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.Conectar();
                conexion.LimpiarParametro();

                conexion.AgregarParametro("@Codigo", articulo.Codigo);
                conexion.AgregarParametro("@Nombre", articulo.Nombre);
                conexion.AgregarParametro("@Descripcion", articulo.Descripcion);
                conexion.AgregarParametro("@idMarca", articulo.marca.Id.ToString());
                conexion.AgregarParametro("@idCategoria", articulo.categoria.Id.ToString());
                conexion.AgregarParametro("@urlImagen", articulo.Imagen);
                conexion.AgregarParametro("@Precio", articulo.Precio.ToString());

                conexion.EjecutarAccion("insert into ARTICULOS values (@Codigo, @Nombre, @Descripcion, @idMarca, @idCategoria, @urlImagen, @Precio)");
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Desconectar();
                }
            }

        }

        public void GuardarModificado(Articulo articulo)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.Conectar();
                conexion.LimpiarParametro();

                conexion.AgregarParametro("@Id", articulo.Id.ToString());
                conexion.AgregarParametro("@Codigo", articulo.Codigo);
                conexion.AgregarParametro("@Nombre", articulo.Nombre);
                conexion.AgregarParametro("@Descripcion", articulo.Descripcion);
                conexion.AgregarParametro("@idMarca", articulo.marca.Id.ToString());
                conexion.AgregarParametro("@idCategoria", articulo.categoria.Id.ToString());
                conexion.AgregarParametro("@urlImagen", articulo.Imagen);
                conexion.AgregarParametro("@Precio", articulo.Precio.ToString());

                conexion.EjecutarAccion("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, idMarca = @idMarca, idCategoria = @idCategoria, ImagenUrl = @urlImagen, Precio = @Precio where Id = @Id");
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Desconectar();
                }
            }

        }

    }
}