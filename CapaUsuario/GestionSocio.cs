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
    public partial class GestionSocio : Form
    {
        private Socio s;
        private ClubDeportivo adm;

        public GestionSocio(List<Socio> listaSocios, ClubDeportivo a)
        {
            InitializeComponent();
            s = null;
            adm = a;

            listBox1_Socios.DataSource = null;
            listBox1_Socios.DataSource = listaSocios;

        }

        private void gestSocio_botonCrear_Click(object sender, EventArgs e)
        {
            AltaSocio socioNuevo = new AltaSocio(null);
            socioNuevo.ShowDialog();

            s = socioNuevo.darSocio();

            if (s != null)
            {
                adm.agregarSocio(s);
                listBox1_Socios.DataSource = null;
                listBox1_Socios.DataSource = adm.ListaSocios();
            }
        }

        private void gestSocio_botonModif_Click(object sender, EventArgs e)
        {
            s = listBox1_Socios.SelectedItem as Socio;
            AltaSocio socioNuevo = new AltaSocio(s);
            socioNuevo.ShowDialog();

            listBox1_Socios.DataSource = null;
            listBox1_Socios.DataSource = adm.ListaSocios();
        }

        private void gestSocio_botonEliminar_Click(object sender, EventArgs e)
        {
            s = listBox1_Socios.SelectedItem as Socio;
            adm.BorrarSocio(s);

            listBox1_Socios.DataSource = null;
            listBox1_Socios.DataSource = adm.ListaSocios();
        }

        private void gestSocio_botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
