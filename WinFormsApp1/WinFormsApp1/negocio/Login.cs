using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.persistencia;

namespace WinFormsApp1.negocio
{
    public class Login
    {
        private RepositorioUsuarios repositorioUsuarios;
        public Usuario? usuarioActual; //? permite valores null


        public Login()
        {
            this.repositorioUsuarios = new RepositorioUsuarios();
        }
        public bool autenticar(Usuario usuario)
        {
            Usuario usuarioRecuperado = repositorioUsuarios.buscarUsuario(usuario.login);
            if (usuarioRecuperado != null)
            {
                if (usuarioRecuperado.passwordCorrecta(usuario.pass))
                {
                    return true;
                } else
                {
                    return false;
                }
                
            } else
            {
                return false;
            }
        }
    }
}
