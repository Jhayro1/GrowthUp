//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Letra
    {
        public int IdLetra { get; set; }
        public int IdUsuario { get; set; }
        public int IdHerramientaCartera { get; set; }
    
        public virtual HerramientaCartera HerramientaCartera { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
