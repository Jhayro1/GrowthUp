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
    public partial class FormRegister : Form
    {
        NegUsuario objNegUsuario;
        public FormRegister()
        {
            InitializeComponent();
            objNegUsuario = new NegUsuario();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTitulo_Register_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            if (txbnombreregistro.Text != "" && txbapellidoregistro.Text != "" && txbcorreoregistro.Text != ""
                && txbcelularregistro.Text != "" && txbdireccionregistro.Text != "" && txbContrasena_Register.Text != "")
            {
                Usuario objusuario = new Usuario();
                objusuario.nombres = txbnombreregistro.Text;
                objusuario.apellidos = txbapellidoregistro.Text;
                objusuario.nombreusuario = txbNombredeUsuarioregistro.Text;
                objusuario.email = txbcorreoregistro.Text;
                objusuario.contraseña = txbContrasena_Register.Text;
                objusuario.celular = txbcelularregistro.Text;
                objusuario.direccion = txbdireccionregistro.Text;
                MessageBox.Show(objNegUsuario.RegistrarUsuario(objusuario));
                FormHome frmHome = new FormHome();
                frmHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }

        private void linkliniciarsesion_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
