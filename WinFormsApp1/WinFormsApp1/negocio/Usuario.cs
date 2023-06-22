using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WinFormsApp1.persistencia;

namespace WinFormsApp1.negocio
{
    public class Usuario
    {
        public int id;
        public string login;
        public string pass;

        private static RepositorioUsuarios repo = new RepositorioUsuarios();


        public Usuario(int id, string login, string pass)
        {
            
            this.id = id;
            this.login = login;
            this.pass = pass;
        }

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

        public static ArrayList obtenerUsuariosExistentes()
        {
            ArrayList usuarios = new ArrayList();
     
            //cargo filas a la grilla
            foreach (Usuario usr in repo.buscarTodos())
            {
                usuarios.Add(usr);
            }
            return usuarios;
        }
      
      
    }
}
