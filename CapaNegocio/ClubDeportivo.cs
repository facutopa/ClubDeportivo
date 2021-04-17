using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    [Serializable]
    public class ClubDeportivo
    {
        private List<ActividadDeportiva> listaActividadesDeportivas;
        private List<Factura> listaFacturas;
        private List<Socio> listaSocios;
        private List<Profesor> listaProfesores;

        public ClubDeportivo()
        {
            listaActividadesDeportivas = new List<ActividadDeportiva>();
            listaFacturas = new List<Factura>();
            listaSocios = new List<Socio>();
            listaProfesores = new List<Profesor>();
        }


        public List<ActividadDeportiva> ListaActividadesDeportivas()
        {
            return listaActividadesDeportivas;
        }

        public List<Factura> ListaFacturas()
        {
            return this.listaFacturas;
        }
        public List<Socio> ListaSocios()
        {
            return this.listaSocios;
        }

        public List<Profesor> ListaProfesores()
        {
            return this.listaProfesores;
        }

        public void agregarSocio(Socio s)
        {
            listaSocios.Add(s);
        }

        public void agregarProfesor(Profesor p)
        {
            listaProfesores.Add(p);
        }

        public void agregarFactura(Factura f)
        {
            listaFacturas.Add(f);
        }

        public void BorrarSocio(Socio s)
        {
           listaSocios.Remove(s);
        }

        public void BorrarProfesor(Profesor p)
        {
            listaProfesores.Remove(p);
        }
        public void BorrarActividad(ActividadDeportiva ad)
        {
            listaActividadesDeportivas.Remove(ad);
        }

        public void agregarActividadDeportiva(ActividadDeportiva ad)
        {
            listaActividadesDeportivas.Add(ad);
        }


    }
}
