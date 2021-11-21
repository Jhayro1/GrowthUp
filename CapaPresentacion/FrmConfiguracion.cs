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
    public partial class FrmConfiguracion : Form
    {
        DataUsuario objdataUsuario;
        public FrmConfiguracion()
        {
            InitializeComponent();
            objdataUsuario = new DataUsuario();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            lblnombreUsuario.Text = Nube.UsuarioLog.nombres;
            lblApellidoUsuario.Text = Nube.UsuarioLog.apellidos;
            lblnombredeusuario.Text = Nube.UsuarioLog.nombreusuario;
            lblemailusuario.Text = Nube.UsuarioLog.email;
            lblCelularUsuario.Text = Nube.UsuarioLog.celular;
            lblDireccionUsuario.Text = Nube.UsuarioLog.direccion;
        }
    }
}
