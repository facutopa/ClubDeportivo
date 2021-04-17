using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    [Serializable]
    public class SocioClub: Socio
    {
        private int cuota;
        private List<ActividadDeportiva> listaActividadesExcedentes;
        private List<ActividadDeportiva> listaActividadesInscriptas;

        public SocioClub(int nroS, int id, string nom, string ape, DateTime fechaN, string sex, int c) : base(nroS, id, nom, ape, fechaN, sex)
        {
            cuota = c;
        }

        public int Cuota
        {
            get { return cuota; }
            set { cuota = value; }
        }

        public override string ToString()
        {
            return "DNI: " + dni + " - " + nombre + " " + apellido + " - Edad:" + edad();
        }

        public override void AgregarActividad(ActividadDeportiva act)
        {
            if (listaActividadesInscriptas.Count == 5)
            {
                listaActividadesInscriptas.Add(act);
            }
            else
            {
                listaActividadesInscriptas.Add(act);
            }
        }

        public override void RemoverActividad(ActividadDeportiva act)
        {
            listaActividadesInscriptas.Remove(act);
        }

        public override List<ActividadDeportiva> ListaActividadesInscriptas()
        {
            List<ActividadDeportiva> lista;
            lista = new List<ActividadDeportiva>();
            foreach (ActividadDeportiva act in listaActividadesInscriptas)
            {
                lista.Add(act);
            }
            foreach (ActividadDeportiva actE in listaActividadesExcedentes)
            {
                lista.Add(actE);
            }

            return lista;
        }
    }
}
