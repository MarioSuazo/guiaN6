using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiaN6
{
    internal class ReparacionFrenos : Servicios
    {
        public override void realizarServicio()
        {
            Console.WriteLine("\nRealizando la reparación de Frenos.");
        }

        public override double calcularCosto()
        {
            return 100.0; //Costo del Cambio de Aceite.
        }

        public override void tiempoTotal(double tipo)
        {
            if (tipo == 150)
            {
                Console.WriteLine("La Reparación de Frenos en el coche dura: 60 Min");
            }
            else
            {
               Console.WriteLine("La Reparación de Frenos en la moto dura: 90 Min");
            }
        }
    }
}
