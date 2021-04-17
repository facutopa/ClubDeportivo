using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    [Serializable]
    public abstract class Socio
    {
        protected int nroSocio;
        protected int dni;
        protected string nombre;
        protected string apellido;
        protected DateTime fechaNac;
        protected string sexo;
        protected List<Factura> listaFacturas;
        protected List<ActividadDeportiva> listaActividadesInscriptas;

        public Socio(int nroS, int id, string nom, string ape, DateTime fechaN, string sex)
        {
            nroSocio = nroS;
            dni = id;
            nombre = nom;
            apellido = ape;
            fechaNac = fechaN;
            sexo = sex;
            listaFacturas = new List<Factura>();
            listaActividadesInscriptas = new List<ActividadDeportiva>();
        }
        /*
        public void ModificarSocio(int nroS, int id, string nom, string ape, DateTime fechaN, string sex)
        {
            nroSocio = nroS;
            dni = id;
            nombre = nom;
            apellido = ape;
            fechaNac = fechaN;
            sexo = sex;
            listaFacturas = new List<Factura>();
            listaActividadesInscriptas = new List<ActividadDeportiva>();
        }
        */
        public int NroSocio
        {
            get { return nroSocio; }
            set { nroSocio = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public List<Factura> ListaFacturas
        {
            get { return listaFacturas; }
        }

        public abstract void AgregarActividad(ActividadDeportiva a);

        public abstract void RemoverActividad(ActividadDeportiva a);

        public abstract List<ActividadDeportiva> ListaActividadesInscriptas();

        public void AgregarFactura(Factura f)
        {
            listaFacturas.Add(f);
        }

        public void RemoverFactura(Factura f)
        {
            listaFacturas.Remove(f);
        }


        public int edad()
        {
            DateTime hoy = DateTime.Today;
            int año = hoy.Year - fechaNac.Year;
            if (hoy.Month < fechaNac.Month)
                año--;
            else
                if (hoy.Month == fechaNac.Month && hoy.Day < fechaNac.Day)
                año--;
            return año;
        }

    }
}
