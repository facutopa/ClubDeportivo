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
    public partial class GestionActividadDeportiva : Form
    {
        private ActividadDeportiva ad;
        private ClubDeportivo adm;
        private List<ActividadDeportiva> listaActividades;
        private List<Clase> listaClases;
        public GestionActividadDeportiva(List<ActividadDeportiva> listaActividadDeportiva, ClubDeportivo a)
        {
            InitializeComponent();
            ad = null;
            adm = a;

            listBox1_ActividadesDeportivas.DataSource = null;
            listBox1_ActividadesDeportivas.DataSource = listaActividadDeportiva;
        }

        private void gestActDep_botonCrear_Click(object sender, EventArgs e)
        {
            AltaActividadDeportiva actividadDeporNueva = new AltaActividadDeportiva(null);
            actividadDeporNueva.ShowDialog();

            ad = actividadDeporNueva.darActividad();

            if (ad != null)
            {
                adm.agregarActividadDeportiva(ad);
                listBox1_ActividadesDeportivas.DataSource = null;
                listBox1_ActividadesDeportivas.DataSource = adm.ListaActividadesDeportivas();
            }
        }

        private void gestActDep_botonModif_Click(object sender, EventArgs e)
        {
            ad = listBox1_ActividadesDeportivas.SelectedItem as ActividadDeportiva;
            AltaActividadDeportiva actividadDeporNueva = new AltaActividadDeportiva(ad);
            actividadDeporNueva.ShowDialog();

            listBox1_ActividadesDeportivas.DataSource = null;
            listBox1_ActividadesDeportivas.DataSource = adm.ListaActividadesDeportivas();
        }

        private void gestActDep_botonEliminar_Click(object sender, EventArgs e)
        {
            ad = listBox1_ActividadesDeportivas.SelectedItem as ActividadDeportiva;
            adm.BorrarActividad(ad);

            listBox1_ActividadesDeportivas.DataSource = null;
            listBox1_ActividadesDeportivas.DataSource = adm.ListaActividadesDeportivas();
        }

        private void gestionActivDep_botonRefrescar_Click(object sender, EventArgs e)
        {
            listBox1_ActividadesDeportivas.DataSource = null;
            listBox1_ActividadesDeportivas.DataSource = adm.ListaActividadesDeportivas();
        }

        private void gestActDep_botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionActivDep_botonAsignarClase_Click(object sender, EventArgs e)
        {
            ad = listBox1_ActividadesDeportivas.SelectedItem as ActividadDeportiva;

            if (listaClases.Count == 0)
                MessageBox.Show("No hay clases registradas aun");
            else
            {
                if (listaActividades.Count == 0)
                    MessageBox.Show("No hay actividades registradas");
                else
                {
                    AsignarClase Asig = new AsignarClase(listaClases, ad);
                    Asig.ShowDialog();
                }

            }
            listBox1_ActividadesDeportivas.DataSource = null;
            listBox1_ActividadesDeportivas.DataSource = adm.ListaActividadesDeportivas();
        }
    }
}
