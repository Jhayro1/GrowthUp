using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Registrar_Documento : Form
    {
        public Registrar_Documento()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e) //boton facturas
        {
        }

        private void Registrar_Documento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //boton Facturas
        {
            this.pnlFormLoaderOpe_RegDoc.Controls.Clear();
            FormFactura frmregistrarfactura = new FormFactura() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; 
            frmregistrarfactura.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoaderOpe_RegDoc.Controls.Add(frmregistrarfactura);
            frmregistrarfactura.Show();
        }

        private void pnlFormLoaderOpe_RegDoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pnlFormLoaderOpe_RegDoc.Controls.Clear();
            FormRecibosxHonorario frmregistrarecibohonorario = new FormRecibosxHonorario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmregistrarecibohonorario.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoaderOpe_RegDoc.Controls.Add(frmregistrarecibohonorario);
            frmregistrarecibohonorario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pnlFormLoaderOpe_RegDoc.Controls.Clear();
            FormLetra frmRegistrarLetra = new FormLetra() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmRegistrarLetra.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoaderOpe_RegDoc.Controls.Add(frmRegistrarLetra);
            frmRegistrarLetra.Show();
        }
    }
}
