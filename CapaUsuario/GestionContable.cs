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
    public partial class GestionContable : Form
    {
        private Factura f;
        private ClubDeportivo adm;
        public GestionContable(List<Factura> listaFacturas, ClubDeportivo a)
        {
            InitializeComponent();
            f = null;
            adm = a;

            listBox2_ListaFacturas.DataSource = null;
            listBox2_ListaFacturas.DataSource = listaFacturas;
        }

        private void gestionContable_botonPagar_Click(object sender, EventArgs e)
        {

        }
    }
}
