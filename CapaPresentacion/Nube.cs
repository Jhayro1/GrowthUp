using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaPresentacion
{
    public class Nube
    {
        public static Usuario UsuarioLog { get; set; }
        public Nube()
        {
            if (UsuarioLog == null) { UsuarioLog = new Usuario(); }
        }
        public void LOGIN(Usuario AuxiliarAlumno)
        {

            UsuarioLog = AuxiliarAlumno;
        }
    }
}
