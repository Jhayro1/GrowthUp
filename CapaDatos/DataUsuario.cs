using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataUsuario
    {
        public string RegistrarUsuario(Usuario objusuario)
        {
            using (var contexto = new TrabajoFFinanzasEntities())
            {
                contexto.Usuarios.Add(objusuario);
                contexto.SaveChanges();
                return "Usted se registro exitosamente";
            }
        }
        public List<Usuario> ListarUsuarios()
        {
            TrabajoFFinanzasEntities contexto = new TrabajoFFinanzasEntities();
            return contexto.Usuarios.ToList<Usuario>();

        }
    }
}
