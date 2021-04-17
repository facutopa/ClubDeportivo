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
    public partial class AsignarClase : Form
    {
        private ActividadDeportiva ad;
        private List<Clase> listaClases;
        private Clase cl;
        public AsignarClase(List<Clase> listaC, ActividadDeportiva a)
        {
            InitializeComponent();
        }
    }
}
