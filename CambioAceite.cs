using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiaN6
{
    public class CambioAceite : Servicios
    {
        public override void realizarServicio()
        {
            Console.WriteLine("\nRealizando el cambio de Aceite.");
        }

        public override double calcularCosto()
        {
            return 50.0; //Costo del Cambio de Aceite.
        }

        public override void tiempoTotal(double tipo)
        {
            if (tipo == 150)
            {
                Console.WriteLine("El cambio de aceite en el coche dura: 40 Min");
            }
            else
            {
                Console.WriteLine("El cambio de aceite en la moto dura: 20 Min");
            }
        }
    }
}
