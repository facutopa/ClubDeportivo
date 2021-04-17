using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    [Serializable]
    public class Profesor
    {
        private int dni;
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private string sexo;
        private string alias;

        public Profesor(int id, string nom, string ape, DateTime fechaN, string sex, string deposito)
        {
            dni = id;
            nombre = nom;
            apellido = ape;
            fechaNac = fechaN;
            sexo = sex;
            alias = deposito;
        }

        public void ModificarProfesor(int id, string nom, string ape, DateTime fechaN, string sex, string deposito)
        {
            dni = id;
            nombre = nom;
            apellido = ape;
            fechaNac = fechaN;
            sexo = sex;
            alias = deposito;
        }

        public string Alias
        {
            get { return alias; }
            set { alias = value; }
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

        public override string ToString()
        {

            return "DNI: " + dni + " - " + nombre + " " + apellido + " - Edad: " + edad();
        }
    }
}
