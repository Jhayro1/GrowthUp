using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class FormRecibosxHonorario : Form
    {
        NegReporte objNegReporte;
        public FormRecibosxHonorario()
        {
            InitializeComponent();
            objNegReporte = new NegReporte();
            LblPeriodoCapital_RxH.Visible = false;
            cmbperidodocapitalRxH.Visible = false;
        }
        private void FormRecibosxHonorario_Load(object sender, EventArgs e)
        {
        }
        private void BtnRegRecibos_Click(object sender, EventArgs e)
        {
            double sumavaloexpresadoIniciales = 0;
            double sumavaloexpresadoFinales = 0;
            if (txbNombre_Cliente.Text != "" && txbApellidos_Cliente.Text != "" && txbCorreo_Cliente.Text != ""
            && txbCelular_Cliente.Text != "" && txbDireccion_Cliente.Text != "" && txbDNI_Cliente.Text != ""
            && txbCiudad_Cliente.Text != "" && cmbTasaPlazo_RxH.Text != "" && txbTasa_RxH.Text != ""
            && dtpFechaDescuento_RxH.Text != "" && dtpFechaEmision_RxH.Text != "" && dtpFechaPago_RxH.Text != ""
            && txbTotalFacturado.Text != "" && txbRetencion_RxH.Text != "" && cmbMotivoCGI_RxH.Text != ""
            && txbValorCGI_RxH.Text != "" && cmbMotivoCGF_RxH.Text != "" && txbValorCGF_RxH.Text != ""
           )
            {
                int IDu = Nube.UsuarioLog.IdUsuario;
                int PlazodTasa = 0;
                double PeriodoCapital = 0;
                HerramientaCartera objherramientacartera = new HerramientaCartera();
                RecibosxHonorario objrxh = new RecibosxHonorario();

                objherramientacartera.Nombres = txbNombre_Cliente.Text;
                objherramientacartera.apellidos = txbApellidos_Cliente.Text;
                objherramientacartera.email = txbCorreo_Cliente.Text;
                objherramientacartera.celular = txbCelular_Cliente.Text;
                objherramientacartera.direccion = txbDireccion_Cliente.Text;
                objherramientacartera.DNI = txbDNI_Cliente.Text;
                objherramientacartera.ciudad = txbCiudad_Cliente.Text;
                objherramientacartera.PlazoTasa = Convert.ToString(cmbTasaPlazo_RxH.Text);
                objherramientacartera.TasaEoN = Convert.ToDouble(txbTasa_RxH.Text);
                objherramientacartera.FechaDescuento = Convert.ToDateTime(dtpFechaDescuento_RxH.Text);
                objherramientacartera.TipoTasa = Convert.ToString(cmbtipodetasa.Text);
                objherramientacartera.TipoMoneda = Convert.ToString(cmbtipomoneda.Text);
                objherramientacartera.fechaInicial = Convert.ToDateTime(dtpFechaEmision_RxH.Text);
                objherramientacartera.fechaFinal = Convert.ToDateTime(dtpFechaPago_RxH.Text);
                objherramientacartera.ValorNominal = Convert.ToDouble(txbTotalFacturado.Text);
                objherramientacartera.retencion = Convert.ToDouble(txbRetencion_RxH.Text);

                foreach (DataGridViewRow row in dgwCGI_RxH.Rows)
                {
                    sumavaloexpresadoIniciales += Convert.ToDouble(row.Cells["clmvalorexpresadoIniciales"].Value);
                }
                objherramientacartera.ValorExpresadoCGI = Convert.ToDouble(sumavaloexpresadoIniciales);

                foreach (DataGridViewRow row in dgwCGF_RxH.Rows)
                {
                    sumavaloexpresadoFinales += Convert.ToDouble(row.Cells["clmValorExpresadoCGF"].Value);
                }
                objherramientacartera.ValorExpresadoCGF = Convert.ToDouble(sumavaloexpresadoFinales);

                if (cmbTasaPlazo_RxH.Text == "Quincenal")
                {
                    PlazodTasa = 15;
                }
                if (cmbTasaPlazo_RxH.Text == "Mensual")
                {
                    PlazodTasa = 30;
                }
                if (cmbTasaPlazo_RxH.Text == "Bimestral")
                {
                    PlazodTasa = 60;
                }
                if (cmbTasaPlazo_RxH.Text == "Trimestral")
                {
                    PlazodTasa = 90;
                }
                if (cmbTasaPlazo_RxH.Text == "Cuatrimestral")
                {
                    PlazodTasa = 120;
                }
                if (cmbTasaPlazo_RxH.Text == "Semestral")
                {
                    PlazodTasa = 180;
                }
                if (cmbTasaPlazo_RxH.Text == "Anual")
                {
                    PlazodTasa = 360;
                }
                if (cmbperidodocapitalRxH.Text == "Quincenal")
                {
                    PeriodoCapital = 15;
                }
                if (cmbperidodocapitalRxH.Text == "Mensual")
                {
                    PeriodoCapital = 30;
                }
                if (cmbperidodocapitalRxH.Text == "Bimestral")
                {
                    PeriodoCapital = 60;
                }
                if (cmbperidodocapitalRxH.Text == "Trimestral")
                {
                    PeriodoCapital = 90;
                }
                if (cmbperidodocapitalRxH.Text == "Cuatrimestral")
                {
                    PeriodoCapital = 120;
                }
                if (cmbperidodocapitalRxH.Text == "Semestral")
                {
                    PeriodoCapital = 180;
                }
                if (cmbperidodocapitalRxH.Text == "Anual")
                {
                    PeriodoCapital = 360;
                }

                DateTime fechaInicial = dtpFechaEmision_RxH.Value.Date;
                DateTime fechaFinal = dtpFechaPago_RxH.Value.Date;
                DateTime fechaDescuento = dtpFechaDescuento_RxH.Value.Date;

                TimeSpan tSpan = fechaFinal - fechaInicial;
                TimeSpan tDesc = fechaDescuento - fechaInicial;

                int DiasDifIF = tSpan.Days;
                int DiasDifID = tDesc.Days;

                int DiasIF = DiasDifIF - DiasDifID;
                objherramientacartera.dias = Convert.ToInt32(DiasIF);

                int difdeFechas = 0;
                difdeFechas = (int)objherramientacartera.dias;

                double TE = 0;
                TE = (double)objherramientacartera.TasaEoN;

                if (label11.Text == "Tasa Efectiva")
                {
                    TE = TE / 100;
                }

                else
                {
                    TE = TE / 100;
                    double difperiodotasa = (double)(PeriodoCapital / PlazodTasa);
                    TE = Math.Pow(1 + TE, difperiodotasa);
                    TE = TE - 1;
                }

                double TEP = 0;
                double diffechawTasoPlaza = 0;

                diffechawTasoPlaza = (double)DiasIF / PlazodTasa;

                TEP = (double)Math.Pow(1 + TE, diffechawTasoPlaza);

                TEP = TEP - 1;

                double Tasadescontada = TEP / (1 + TEP);

                double ValorNominal;
                ValorNominal = (double)objherramientacartera.ValorNominal;

                double Descuento = ValorNominal * Tasadescontada;

                double ValorNeto = ValorNominal * (1 - Tasadescontada);

                double CGIniciales;
                CGIniciales = (double)objherramientacartera.ValorExpresadoCGI;

                double retencion;
                retencion = (double)objherramientacartera.retencion;

                double ValorTotalaRecibir = ValorNeto - CGIniciales - retencion;


                double CGFinales;
                CGFinales = (double)objherramientacartera.ValorExpresadoCGF;

                double ValorTotalaEntregar = ValorNominal + CGFinales - retencion;

                double TCEA = Math.Pow(ValorTotalaEntregar / ValorTotalaRecibir, 360 / difdeFechas);
                TCEA = TCEA - 1;

                if (cmbtipomoneda.Text == "Soles")
                {
                    objherramientacartera.MonedaSoles = ValorTotalaRecibir;
                    objherramientacartera.MonedaDolares = ValorTotalaRecibir / 4.1;
                }
                else
                {
                    objherramientacartera.MonedaDolares = ValorTotalaRecibir;
                    objherramientacartera.MonedaSoles = ValorTotalaRecibir * 4.1;
                }

                objherramientacartera.Tipo = "Recibos por Honorario";
                objherramientacartera.TEporcentaje = Convert.ToDouble(TEP * 100);
                objherramientacartera.dporcentaje = Convert.ToDouble(Tasadescontada * 100);
                objherramientacartera.descuento = Convert.ToDouble(Descuento);
                objherramientacartera.valorNeto = Convert.ToDouble(ValorNeto);
                objherramientacartera.valorTotalaRecibir = Convert.ToDouble(ValorTotalaRecibir);
                objherramientacartera.valorTotalaEntregar = Convert.ToDouble(ValorTotalaEntregar);
                objherramientacartera.TCEA = Convert.ToDouble(TCEA * 100);

                objrxh.IdUsuario = Convert.ToInt32(IDu);
                objrxh.IdHerramientaCartera = Convert.ToInt32(objherramientacartera.IdHerramientaCartera);

                this.pnlFormRecibos.Controls.Clear();
                MessageBox.Show(objNegReporte.RegistrarReporteRxH(objherramientacartera, objrxh));
                FormVRegistrados frmshowreporte = new FormVRegistrados() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmshowreporte.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormRecibos.Controls.Add(frmshowreporte);
                frmshowreporte.Show();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }

        private void cmbtipodetasa_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = cmbtipodetasa.SelectedIndex;
            label11.Text = cmbtipodetasa.Items[indice].ToString();
            if (label11.Text == "Tasa Nominal")
            {
                LblPeriodoCapital_RxH.Visible = true;
                cmbperidodocapitalRxH.Visible = true;
            }
            else
            {
                LblPeriodoCapital_RxH.Visible = false;
                cmbperidodocapitalRxH.Visible = false;
            }
        }

        private void btnagregarIniciales_Click(object sender, EventArgs e)
        {

            dgwCGI_RxH.Rows.Add(cmbMotivoCGI_RxH.Text, Convert.ToDouble(txbValorCGI_RxH.Text));
        }

        private void btnAgregarFinales_Click(object sender, EventArgs e)
        {

            dgwCGF_RxH.Rows.Add(cmbMotivoCGF_RxH.Text, Convert.ToDouble(txbValorCGF_RxH.Text));
        }

       
    }
}
