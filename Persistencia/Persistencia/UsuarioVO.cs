using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class UsuarioVO
    {

        public int id;
        public string login;
        public string pass;

        public UsuarioVO(int id, string login, string pass)
        {
            this.login = login;
            this.pass = pass;   
            this.id = id;

        }
    }

  
}
