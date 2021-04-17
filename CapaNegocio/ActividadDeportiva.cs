using System;
using System.Collections.Generic;
using System.Text;
using CapaNegocio;

namespace CapaNegocio
{
    [Serializable]
    public class ActividadDeportiva
    {
        private int codActividad;
        private string nombre;
        private string descripcion;
        private float costo;
        private int maxPersonas;
        private List<Clase> listaClases;

        public ActividadDeportiva(int codAct, string nom, string descrip, float valor, int maxPer)
        {
            codActividad = codAct;
            nombre = nom;
            descripcion = descrip;
            costo = valor;
            maxPersonas = maxPer;
            listaClases = new List<Clase>();
        }

        public int CodigoActividad
        {
            get { return codActividad; }
            set { codActividad = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public float Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public int MaxPersonas
        {
            get { return maxPersonas; }
            set { maxPersonas = value; }
        }
        public List<Clase> ListaClases
        {
            get { return listaClases; }
        }

        public void ModificarActividadDeportiva(int codAct, string nom, string descrip, float valor, int maxPer)
        {
            codActividad = codAct;
            nombre = nom;
            descripcion = descrip;
            costo = valor;
            maxPersonas = maxPer;
            listaClases = new List<Clase>();
        }
        public override string ToString()
        {
            return "Nombre: " + nombre + " Costo: $" + costo + " Ctd. de Clases: " + listaClases.Count.ToString();
        }

        public List<Clase> darListaClases()
        {
            return listaClases;
        }

        public void DesasignarClase(Clase c, ActividadDeportiva a)
        {
            this.listaClases.Remove(c);
            //c.RemoverActividad(a); //falta crear metodo en "clase".
        }

        public void AsignarClase(Clase c, ActividadDeportiva a)
        {
            if (!listaClases.Contains(c))
            {
                if (listaClases.Count < maxPersonas)
                {
                    this.ListaClases.Add(c);
                    //c.AgregarActividad(a);//falta crear metodo en "clase".
                }
                    //MessageBox.Show("Error: No hay cupo disponible"); //pendiente
            }
              //  MessageBox.Show("Error: La clase ya se encuentra asignada");
        }

        public float DarCosto()
        {
            return this.costo;
        }
    }
}
