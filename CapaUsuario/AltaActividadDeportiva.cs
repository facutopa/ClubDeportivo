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
    public partial class AltaActividadDeportiva : Form
    {
        private AltaActividadDeportiva act;
        private ActividadDeportiva actividadNueva;
        private ActividadDeportiva actividadModificada;
        public AltaActividadDeportiva(ActividadDeportiva ad)
        {
            InitializeComponent();
        }

        public ActividadDeportiva darActividad()
        {
            return actividadNueva;
        }
    }
}
