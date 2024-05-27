using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiaN6
{
    internal class Moto : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando Mantenimiento de la moto: Lubricación de cadena y revisión de neumáticos.");
        }

        public override double obtenerCostoMantenimiento()
        {
            return 100.0; //Costo del mantenimiento de la moto.
        }
    }
}
