using System.Collections;
using Persistencia;

namespace Negocio
{
    public class Paquete
    {
        public int id;
        public string descripcion;
        public string fecha;
        public ArrayList articulos;

        public Paquete(int id, string descripcion, string fecha)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.articulos = new ArrayList();
        }

        public static ArrayList obtenerPaquetes()
        {

            ArrayList paquetes = new ArrayList();

            RepositorioPaquete repoPaquete = new RepositorioPaquete();

            foreach (PaqueteVO paqueteVO in repoPaquete.obtenerPaquetes())
            {
                paquetes.Add(new Paquete(
                                                paqueteVO.id,
                                                paqueteVO.descripcion,
                                                paqueteVO.fecha));
            }

            return paquetes;
        }

        public override string ToString()
        {
            return this.id + " " + this.descripcion + " " + this.fecha;
        }

        public void agregarArticulo(Articulo articulo)
        {
            this.articulos.Add(articulo);
        }

        public void grabar()
        {
            RepositorioPaquete repoPaquete = new RepositorioPaquete();
            repoPaquete.quitarArticulos(this.id);

            RepositorioArticulo repoArticulo = new RepositorioArticulo();
            foreach (Articulo art in this.articulos)
            {
                repoArticulo.asignarArticuloAPaquete(this.id, art.id);
            }
           

        }


           
    }
}