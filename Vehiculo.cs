using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiaN6
{
    public class Vehiculo
    {
        public virtual void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando Mantenimiento General del Vehiculo: ");
        }

        public virtual double obtenerCostoMantenimiento()
        {
            return 50.0; //Costo base de mantenimiento General.
        }

        public void Lavar()
        {
            Console.WriteLine("Lavando el vehiculo.");
        }
    }
}
