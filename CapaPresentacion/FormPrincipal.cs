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
    public partial class FormPrincipal : Form
    {
        NegUsuario objNegUsuario;
        Nube objnube = new Nube();
        public FormPrincipal()
        {
            InitializeComponent();
            objNegUsuario = new NegUsuario();
        }

        private void cerrar_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_login_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitulo_Principal_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTitulo_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linklregistrate_Principal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister frmRegister = new FormRegister();
            frmRegister.Show();
            this.Hide();
        }

        private void txbuser_correologin_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btninciarsesion_Click(object sender, EventArgs e)
        {
            bool encontro = false;
            string pUsuario = txbuser_correologin.Text;
            string pContraseña = txbcontraseñalogin.Text;

            foreach (Usuario auxUsuario in objNegUsuario.ListarUsuarios())
            {
                if (auxUsuario.email == pUsuario && auxUsuario.contraseña == pContraseña)
                {
                    string NombreUsuario = auxUsuario.nombreusuario;
                    objnube.LOGIN(auxUsuario);
                    FormHome frmHome = new FormHome();
                    frmHome.Show();
                    this.Hide();
                    encontro = true;
                    break;
                }
                else encontro = false;
            }
            if (encontro == false) { MessageBox.Show("Datos incorrectos"); };
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
