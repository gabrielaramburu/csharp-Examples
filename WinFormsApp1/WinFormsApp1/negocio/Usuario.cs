using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinFormsApp1.negocio
{
    public class Usuario
    {
        public string login;
        public string pass;

        public Usuario(string login, string pass)
        {
            this.login = login;
            this.pass = pass;
        }

        public bool passwordCorrecta(string passAvalidar)
        {
           return pass.Equals(passAvalidar) ? true : false;
            /* es lo mismo que esto
            if (pass.Equals(passAvalidar))
            {
                return true;
            } else
            {
                return false;
            }

            */
        }


      
    }
}
