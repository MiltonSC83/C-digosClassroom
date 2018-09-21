using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class Transacciones: ITransacciones
    {
        private string codigoT;
        private string fecha;
        private double monto;

        public Transacciones()
        {
            codigoT = "";
            fecha = "";
            monto = 0.0;
        }

        public Transacciones(string c, string f, double m)
        {
            codigoT = c;
            fecha = f;
            monto = m;
        }

        public void muestraTransacciones()
        {
            Console.WriteLine("Transacción: {0}", codigoT);
            Console.WriteLine("Data: {0}", fecha);
            Console.WriteLine("Monto: {0}", getmonto());
        }
        public double getmonto()
        {
            return monto;
        }
    }
}
