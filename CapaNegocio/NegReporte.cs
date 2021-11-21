using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class NegReporte
    {
        private DataReporte objDataReporte = new DataReporte();
        public string RegistrarReporteFactura(HerramientaCartera objherramientacartera, Factura objfactura)
        {
            return objDataReporte.RegistrarReporteFactura(objherramientacartera, objfactura);
        }
        public string RegistrarReporteLetra(HerramientaCartera objherramientacartera,Letra objletra)
        {
            return objDataReporte.RegistrarReporteLetra(objherramientacartera, objletra);
        }
        public string RegistrarReporteRxH(HerramientaCartera objherramientacartera,RecibosxHonorario objrxh)
        {
            return objDataReporte.RegistrarReporteRxH(objherramientacartera, objrxh);
        }
        public List<HerramientaCartera> ListarReportes()
        {
            return objDataReporte.ListarReportes();
        }

        public List<HerramientaCartera> ListarReportesSoles(string tipomonedasoles)
        {

            return objDataReporte.ListarReportesSoles(tipomonedasoles);
        }

        public List<HerramientaCartera> ListarReportesDolares(string tipomonedadolares)
        {

            return objDataReporte.ListarReportesDolares(tipomonedadolares);
        }
    }
}
