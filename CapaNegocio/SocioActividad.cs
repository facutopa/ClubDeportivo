using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CapaNegocio
{
    [Serializable]
    public class SocioActividad : Socio
    {

        private List<ActividadDeportiva> listaActividadesInscriptas;
        public SocioActividad(int nroS, int id, string nom, string ape, DateTime fechaN, string sex) : base(nroS, id, nom, ape, fechaN, sex)
        {
            listaActividadesInscriptas = new List<ActividadDeportiva>();
        }

        public override string ToString()
        {
            return "DNI: " + dni + " - " + nombre + " " + apellido + " - Edad:" + edad();
        }

        public override void AgregarActividad(ActividadDeportiva act)
        {
            listaActividadesInscriptas.Add(act);
        }

        public override void RemoverActividad(ActividadDeportiva act)
        {
            listaActividadesInscriptas.Remove(act);
        }

        public override List<ActividadDeportiva> ListaActividadesInscriptas()
        {
            return listaActividadesInscriptas;
        }
    }
}
