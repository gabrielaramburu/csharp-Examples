using Persistencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Articulo
    {
        public int id;
        public string descripcion;
        public int precio;

        public Articulo(int id, string descripcion, int precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public static ArrayList obtenerArticulosSinPaquete()
        {
            ArrayList articulos = new ArrayList();

            RepositorioArticulo repoArticulo = new RepositorioArticulo();

            foreach (ArticuloVO artVO in repoArticulo.obtenerArticulosSinPaquete()) 
            {
                articulos.Add(new Articulo(
                                                artVO.id,
                                                artVO.descripcion,
                                                artVO.precio));
            }

            return articulos;
        }

        public static ArrayList obtenerArticulosPorPaquete(int idPaquete)
        {
            ArrayList articulos = new ArrayList();

            RepositorioArticulo repoArticulo = new RepositorioArticulo();

            foreach (ArticuloVO artVO in repoArticulo.obtenerArticulosPorPaquete(idPaquete))
            {
                articulos.Add(new Articulo(
                                                artVO.id,
                                                artVO.descripcion,
                                                artVO.precio));
            }

            return articulos;
        }


        public override string ToString()
        {
            return this.id + " " + this.descripcion + " " + this.precio;
        }
    }



   
}
