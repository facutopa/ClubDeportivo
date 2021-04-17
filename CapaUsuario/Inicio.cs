using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaUsuario
{
    public partial class Inicio : Form
    {
        private ClubDeportivo adm;
        private List<Socio> listaSocios;
        private Socio s;
        private List<ActividadDeportiva> listaActividadDeportiva;
        private List<Factura> listaFacturas;
        private List<Profesor> listaProfesores;
        public Inicio()
        {
            InitializeComponent();
            //adm = ClubDeportivo.Recuperar();
            adm = new ClubDeportivo();
            s = null;
            listaSocios = adm.ListaSocios();
            listaActividadDeportiva = adm.ListaActividadesDeportivas();
            listaFacturas = adm.ListaFacturas();
            listaProfesores = adm.ListaProfesores();

        }

        private void adminButton_Socios_Click_1(object sender, EventArgs e)
        {
            //ABM SOCIOS
            GestionSocio soc = new GestionSocio(listaSocios, adm);
            soc.ShowDialog();
        }

        private void adminButton_Profesor_Click_1(object sender, EventArgs e)
        {
            //ABM PROFESORES
            GestionProfesor prof = new GestionProfesor(listaProfesores, adm);
            prof.ShowDialog();
        }

        private void adminButton_ActivDepo_Click_1(object sender, EventArgs e)
        {
            //ABM ACTIVIDADES
            GestionActividadDeportiva activDepo = new GestionActividadDeportiva(listaActividadDeportiva, adm);
            activDepo.ShowDialog();
        }


        private void adminButton_Factura_Click_1(object sender, EventArgs e)
        {
            //ABM PAGOS
            if (listaSocios.Count == 0)
                MessageBox.Show("No hay socios registrados, no se pueden gestionar pagos.");
            else
            {
                GestionContable factura = new GestionContable(listaFacturas, adm);
                factura.ShowDialog();
            }
        }

    }
}
