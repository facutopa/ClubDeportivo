using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CapaNegocio
{
    [Serializable]
    public class Clase
    {
        private string dia;
        private string horarios;
        private Profesor profesor;
        private ActividadDeportiva actividadDeportiva;
        private List<Socio> listaSocios;

        public Clase(string d, string h, Profesor prof, ActividadDeportiva activDepo)
        {
            dia = d;
            horarios = h;
            profesor = prof;
            actividadDeportiva = activDepo;
            listaSocios = new List<Socio>();
        }

        public void ModificarClase(string d, string h, Profesor prof, ActividadDeportiva activDepo)
        {
            dia = d;
            horarios = h;
            profesor = prof;
            actividadDeportiva = activDepo;
            listaSocios = new List<Socio>();
        }

        public override string ToString()
        {
            return "Día: " + this.dia + " Horario: " + this.horarios + "- Profesor: " + this.profesor;
        }

        public void InscribirSocio(Socio s, ActividadDeportiva a)
        {
            if(!listaSocios.Contains(s))
            {
                if (listaSocios.Count < a.MaxPersonas)
                {
                    this.listaSocios.Add(s);
                    s.AgregarActividad(a);
                }
                   //"Error: No hay cupo disponible";
                
            }
                //System.Windows.Forms.MessageBox.Show("Error: El socio ya se encuentra registrado");
            
        }

        public void DesInscribirSocio(Socio s, ActividadDeportiva a)
        {

            this.listaSocios.Remove(s);
            s.RemoverActividad(a);


        }

    }
}
