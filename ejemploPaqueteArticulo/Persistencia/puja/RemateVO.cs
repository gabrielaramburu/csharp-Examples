using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.puja
{
    public class RemateVO
    {
        public int id;
        public string descripcion;
        public DateTime fechaPujaFinal;
        public string usuarioPujaFinal;
        public int montoMaximoPujaFinal;
        public DateTime fechaLimitePuja;



        public RemateVO(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }
        
        public RemateVO(int id, string descripcion, 
           DateTime fechaPujaFinal , string usuarioPujaFinal, int montoMaximoPujaFinal, DateTime fechaLimitePuja)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.fechaPujaFinal = fechaPujaFinal;
            this.usuarioPujaFinal = usuarioPujaFinal;
            this.montoMaximoPujaFinal = montoMaximoPujaFinal;
            this.fechaLimitePuja = fechaLimitePuja;
        }
    }

}
