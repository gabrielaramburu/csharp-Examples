using Persistencia;
using Persistencia.puja;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.pujas
{
    public class Remate
    {
        public int idRemate;
        public string descripcion;
        public string? usuarioPuja;
        public int montoMaximoPuja;
        public DateTime fechaPujaFinal;

        public DateTime fechaLimitePuja;

        public Remate(int id, string descripcion)
        {
            this.idRemate = id;
            this.descripcion = descripcion;

        }

        public Remate(int id, string descripcion,
           DateTime fechaPujaFinal, string usuarioPujaFinal, int montoMaximoPujaFinal,
           DateTime fechaLimitePuja)
        {
            this.idRemate = id;
            this.descripcion = descripcion;
            this.fechaPujaFinal = fechaPujaFinal;
            this.usuarioPuja = usuarioPujaFinal;
            this.montoMaximoPuja = montoMaximoPujaFinal;
            this.fechaLimitePuja = fechaLimitePuja;
        }

        public static ArrayList obtenerRemates()
        {
            ArrayList remates = new ArrayList();
            RepositorioRemate repo = new RepositorioRemate();
            foreach (RemateVO remateVO in repo.obtenerRemates())
            {
                remates.Add(new Remate(remateVO.id, remateVO.descripcion));
            }
            return remates;
        }


        public static Remate obtenerRemateById(int idRemate)
        {
           
            RepositorioRemate repo = new RepositorioRemate();
            RemateVO remateVO = repo.obtenerRemate(idRemate);
            

            return new Remate(
                   remateVO.id, 
                   remateVO.descripcion,
                   remateVO.fechaPujaFinal, 
                   remateVO.usuarioPujaFinal, 
                   remateVO.montoMaximoPujaFinal,
                remateVO.fechaLimitePuja);
        }


        public override string ToString()
        {
            return this.descripcion;
        }

        public static string pujar(int idRemate, int monto, string usuario)
        {
            string mensajeError = "Un usuario realizó una puja mayor en el interin. Monto nueva puja: ";

            RepositorioRemate repo = new RepositorioRemate();
            RemateVO remateVO = repo.obtenerRemate(idRemate);
            if (monto <= remateVO.montoMaximoPujaFinal )
            {
                return mensajeError + remateVO.montoMaximoPujaFinal;
            } else {
                int registroActualizado = repo.actualizoPuja(idRemate, monto, usuario,
                    remateVO.fechaPujaFinal);
                if (registroActualizado <= 0) {
                    return mensajeError + remateVO.montoMaximoPujaFinal;
                } 
            }

            return "ok";
        }
    }
}
