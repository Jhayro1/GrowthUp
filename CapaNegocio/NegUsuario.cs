using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class NegUsuario
    {
        private DataUsuario objDataUsuario = new DataUsuario();
        public string RegistrarUsuario(Usuario objusuario)
        {
            return objDataUsuario.RegistrarUsuario(objusuario);
        }
        public List<Usuario> ListarUsuarios()
        {
            return objDataUsuario.ListarUsuarios();
        }
    }
}
