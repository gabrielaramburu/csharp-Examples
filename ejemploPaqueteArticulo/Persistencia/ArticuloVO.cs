using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ArticuloVO
    {

        public int id;
        public string descripcion;
        public int precio;

        public ArticuloVO(int id, string descripcion, int precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
        }
    }

  
}
