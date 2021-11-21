using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataReporte
    {
        public string RegistrarReporteFactura(HerramientaCartera objherramientacartera, Factura objfactura)
        {
            using (var contexto = new TrabajoFFinanzasEntities())
            {
                contexto.HerramientaCarteras.Add(objherramientacartera);
                contexto.Facturas.Add(objfactura);
                contexto.SaveChanges();
                return "Se registraron los datos";
            }

        }
        public string RegistrarReporteLetra(HerramientaCartera objherramientacartera, Letra objletra)
        {
            using (var contexto = new TrabajoFFinanzasEntities())
            {
                contexto.HerramientaCarteras.Add(objherramientacartera);
                contexto.Letras.Add(objletra);
                contexto.SaveChanges();
                return "Se registraron los datos";
            }

        }
        public string RegistrarReporteRxH(HerramientaCartera objherramientacartera, RecibosxHonorario objrxh)
        {
            using (var contexto = new TrabajoFFinanzasEntities())
            {
                contexto.HerramientaCarteras.Add(objherramientacartera);
                contexto.RecibosxHonorarios.Add(objrxh);
                contexto.SaveChanges();
                return "Se registraron los datos";
            }

        }
        public List<HerramientaCartera> ListarReportes()
        {
            TrabajoFFinanzasEntities contexto = new TrabajoFFinanzasEntities();
            return contexto.HerramientaCarteras.ToList<HerramientaCartera>();
        }
        public List<HerramientaCartera> ListarReportesSoles(string tipomonedaSoles)
        {
            TrabajoFFinanzasEntities contexto = new TrabajoFFinanzasEntities();
            var resultado = (from tipomoneda in contexto.HerramientaCarteras
                             where (tipomoneda.TipoMoneda == tipomonedaSoles)
                             select tipomoneda).ToList();

            return resultado;
        }

        public List<HerramientaCartera> ListarReportesDolares(string tipomonedaDolares)
        {
            TrabajoFFinanzasEntities contexto = new TrabajoFFinanzasEntities();
            var resultado = (from tipomoneda in contexto.HerramientaCarteras
                             where (tipomoneda.TipoMoneda == tipomonedaDolares)
                             select tipomoneda).ToList();

            return resultado;
        }
    }
}
