using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using WinFormsApp1.negocio;

namespace WinFormsApp1.persistencia
{
  

    public class RepositorioUsuarios
    {
        public ArrayList usuarios;

        public RepositorioUsuarios()
        {
            usuarios = new ArrayList();
            usuarios.Add(new Usuario("pepe","123"));
            usuarios.Add(new Usuario("aa", "aa"));
        }

        public Usuario buscarUsuario(string login)
        {
            foreach (Usuario usr in usuarios)
            {
                if (usr.login.Equals(login))
                {
                    //es una buena practica logear a la consola
                    Console.WriteLine("Usuario existe " + login);
                    return usr;
                }
            }
            //esto lo vamos a mejorar en futuras versiones
            return null;
        }

        public ArrayList buscarTodos()
        {
            return this.usuarios;

        }
    }
}
