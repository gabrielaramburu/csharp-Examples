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
            usuarios.Add(new Usuario(1, "pepe","123"));
            usuarios.Add(new Usuario(2, "aa", "aa"));
            usuarios.Add(new Usuario(3, "aa1", "aa"));
            usuarios.Add(new Usuario(4, "aa2", "aa"));
            usuarios.Add(new Usuario(5, "aa3", "aa"));
            usuarios.Add(new Usuario(6, "aa4", "aa"));
            usuarios.Add(new Usuario(7, "aa5", "aa"));
            usuarios.Add(new Usuario(8, "aa6", "aa"));
            usuarios.Add(new Usuario(9, "aa7", "aa"));
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

        public Usuario buscarUsuarioPorId(int id)
        {
            foreach (Usuario usr in usuarios)
            {
                if (usr.id == id)
                {
                   
                    return usr;
                }
            }
            //esto lo vamos a mejorar en futuras versiones
            return null;
        }


        public bool borrarUsuario(int idUsuario)
        {
            foreach (Usuario usr in usuarios)
            {
                if (usr.id == idUsuario)
                {
                    usuarios.Remove(usr);//borro usuario de la lista
                    return true;
                }
            }
          
            return false;
        }
        
    }
}
