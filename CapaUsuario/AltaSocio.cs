using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaUsuario
{
    public partial class AltaSocio : Form
    {
        private Socio socioNuevo;
        private Socio socioModificado;
        public AltaSocio(Socio s)
        {
            socioNuevo = null;
            socioModificado = s;
            InitializeComponent();

            if (s != null)
            {
                altaSocio_boxNombre.Text = s.Nombre;
                altaSocio_boxApellido.Text = s.Apellido;
                altaSocio_boxDNI.Text = s.Dni.ToString();
                altaSocio_boxSexo.Text = s.Sexo.ToString();
                altaSocio_boxFechaNac.Value = s.FechaNac;
            }
        }

        private void altaSocio_botonGrabar_Click(object sender, EventArgs e)
        {
            if (socioModificado == null)
            {
                //revisar como mostrar e utilizar el num de socio
                //VARIABLE BUSCAR NUM DE SOCIO ANTERIOR
                //socioNuevo = new Socio(altaSocio_boxDNI.Text.Trim(), altaSocio_boxNombre.Text.Trim(), altaSocio_boxApellido.Text.Trim(), altaSocio_boxFechaNac.Value, altaSocio_boxSexo.Text.Trim());
            }
            else
            {
                //revisar como mostrar e utilizar el num de socio
                socioNuevo = socioModificado;
                //socioModificado.ModificarSocio(altaSocio_boxDNI.Text.Trim(), altaSocio_boxNombre.Text.Trim(), altaSocio_boxApellido.Text.Trim(), altaSocio_boxFechaNac.Value, altaSocio_boxSexo.Text.Trim());
            }

            this.Close();

        }

        private void altaSocio_botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Socio darSocio()
        {
            return socioNuevo;
        }
    }
}
