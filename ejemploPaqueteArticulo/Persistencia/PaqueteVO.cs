using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PaqueteVO
    {

        public int id;
        public string descripcion;
        public string fecha;

        public PaqueteVO(int id, string descripcion, string fecha)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.fecha = fecha;
        }
    }

  
}
