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
    public partial class GestionProfesor : Form
    {
        private Profesor p;
        private ClubDeportivo adm;
        public GestionProfesor(List<Profesor> listaProfesores, ClubDeportivo a)
        {
            InitializeComponent();
            p = null;
            adm = a;

            listBox1_Profesor.DataSource = null;
            listBox1_Profesor.DataSource = listaProfesores;
        }
        private void gestProfesor_botonCrear_Click(object sender, EventArgs e)
        {
            AltaProfesor profesorNuevo = new AltaProfesor(null);
            profesorNuevo.ShowDialog();

            p = profesorNuevo.darProfesor();

            if (p != null)
            {
                adm.agregarProfesor(p);
                listBox1_Profesor.DataSource = null;
                listBox1_Profesor.DataSource = adm.ListaProfesores();
            }
        }

        private void gestProfesor_botonModif_Click(object sender, EventArgs e)
        {
            p = listBox1_Profesor.SelectedItem as Profesor;
            AltaProfesor profesorNuevo = new AltaProfesor(p);
            profesorNuevo.ShowDialog();

            listBox1_Profesor.DataSource = null;
            listBox1_Profesor.DataSource = adm.ListaProfesores();
        }

        private void gestProfesor_botonEliminar_Click(object sender, EventArgs e)
        {
            p = listBox1_Profesor.SelectedItem as Profesor;
            adm.BorrarProfesor(p);

            listBox1_Profesor.DataSource = null;
            listBox1_Profesor.DataSource = adm.ListaProfesores();
        }

        private void gestProfesor_botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
