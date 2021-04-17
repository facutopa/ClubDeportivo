using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    [Serializable]
    public class Factura
    {
        private int nroFactura;
        private double monto;
        private DateTime fechaPago;
        private Socio socio;

        public Factura(int nroFactura, double monto, DateTime fechaPago, Socio socio)
        {
            this.nroFactura = nroFactura;
            this.monto = monto;
            this.fechaPago = fechaPago;
            this.socio = socio;
        }

        public int NroFactura
        {
            get { return nroFactura; }
            set { nroFactura = value; }
        }
        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        public DateTime FechaPago
        {
            get { return fechaPago; }
            set { fechaPago = value; }
        }
        public Socio Socio
        {
            get { return socio; }
            set { socio = value; }
        }

        public override string ToString()
        {
            return "N° Factura: "+ nroFactura +" - N° de Socio: " + socio + " - Fecha Pago: " + fechaPago + " - Monto: $ " + monto;
        }
    }
}
