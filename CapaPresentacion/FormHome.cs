using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormHome : Form
    {
        NegUsuario objnegUsuario;

        public FormHome()
        {
            InitializeComponent();
            objnegUsuario = new NegUsuario();
            Home FrmHome = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmHome);
            FrmHome.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e) //Salir
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e) //Minimizar
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint ="SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e) //BarraTitulo
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            Home FrmHome = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmHome);
            FrmHome.Show();
        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {
        }

        private void picblogoHome_Click(object sender, EventArgs e)
        {
            Home FrmHome = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmHome);
            FrmHome.Show();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = Nube.UsuarioLog.nombreusuario;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormPrincipal frmprincipal = new FormPrincipal();
            frmprincipal.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            Registrar_Documento FrmRegDocumento = new Registrar_Documento() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmRegDocumento.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmRegDocumento);
            FrmRegDocumento.Show();
        }

        private void btnCartera_Click(object sender, EventArgs e) //reportes
        {
            this.pnlFormLoader.Controls.Clear();
            FormReporte frmReporte = new FormReporte() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmReporte.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmReporte);
            frmReporte.Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            FrmConfiguracion frmmConfiguration = new FrmConfiguracion() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmmConfiguration.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmmConfiguration);
            frmmConfiguration.Show();
        }
    }
}
