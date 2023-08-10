using System.Collections;
using Persistencia;

namespace Negocio
{
    public class Usuario
    {
         int id;
         string login;
         string password;

        public Usuario(int id, string login, string password)
        {
            this.id = id;
            this.login = login;
            this.password = password;
        }

        public static ArrayList obtenerUsuarios()
        {
            ArrayList usuariosObtenidos = new ArrayList();

            RepositorioUsuario repoUsr = new RepositorioUsuario();
            foreach(UsuarioVO usrVO in repoUsr.obtenerUsuarios()) {
                usuariosObtenidos.Add(new Usuario(
                                                usrVO.id,  
                                                usrVO.login, 
                                                usrVO.pass));
            }
            
            return usuariosObtenidos;
        }

        public override string ToString() { 
            return this.id + " " + this.login + "" + this.password;
        }
    }
}