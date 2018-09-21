using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Transacciones t1 = new Transacciones("0001", "20/09/2018", 500000.00);
            Transacciones t2 = new Transacciones("0002", "21/09/2018", 250000.00);

            t1.muestraTransacciones();
            t2.muestraTransacciones();
            Console.ReadLine();

        }
    }
}
