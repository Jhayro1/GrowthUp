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
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
        }

        private void BtnEstrCartera_Click(object sender, EventArgs e)
        {
            this.pnlFrmReporte.Controls.Clear();
            FormECartera frmReporte = new FormECartera() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmReporte.FormBorderStyle = FormBorderStyle.None;
            this.pnlFrmReporte.Controls.Add(frmReporte);
            frmReporte.Show();
        }

        private void BtnRegValores_Click(object sender, EventArgs e)
        {
            this.pnlFrmReporte.Controls.Clear();
            FormVRegistrados frmReporte = new FormVRegistrados() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmReporte.FormBorderStyle = FormBorderStyle.None;
            this.pnlFrmReporte.Controls.Add(frmReporte);
            frmReporte.Show();
        }
    }
}
