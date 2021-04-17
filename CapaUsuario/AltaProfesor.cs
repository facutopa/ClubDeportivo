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
    public partial class AltaProfesor : Form
    {
        private AltaProfesor prof;
        private Profesor profesorNuevo;
        private Profesor profesorModificado;
        public AltaProfesor(Profesor p)
        {
            InitializeComponent();
            prof = null;
            profesorNuevo = null;
            profesorModificado = p;

            if (p != null)
            {
                altaProfesor_boxNombre.Text = p.Nombre;
                altaProfesor_boxApellido.Text = p.Apellido;
                altaProfesor_boxDNI.Text = p.Dni.ToString();
                altaProfesor_boxSexo.Text = p.Sexo.ToString();
                altaProfesor_boxFechaNac.Value = p.FechaNac;
                altaProfesor_textBoxAlias.Text = p.Alias.ToString(); ;
            }
        }
        private void altaProfesor_botonGrabar_Click(object sender, EventArgs e)
        {
            if (profesorModificado == null)
            {
                profesorNuevo = new Profesor(int.Parse(altaProfesor_boxDNI.Text.Trim()), altaProfesor_boxNombre.Text.Trim(), altaProfesor_boxApellido.Text.Trim(), altaProfesor_boxFechaNac.Value, altaProfesor_boxSexo.Text.Trim(), altaProfesor_textBoxAlias.Text.Trim());
            }
            else
            {
                profesorNuevo = profesorModificado;
                profesorModificado.ModificarProfesor(int.Parse(altaProfesor_boxDNI.Text.Trim()), altaProfesor_boxNombre.Text.Trim(), altaProfesor_boxApellido.Text.Trim(), altaProfesor_boxFechaNac.Value, altaProfesor_boxSexo.Text.Trim(), altaProfesor_textBoxAlias.Text.Trim());
            }
            this.Close();
        }

        private void altaProfesor_botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Profesor darProfesor()
        {
            return profesorNuevo;
        }
    }
}
