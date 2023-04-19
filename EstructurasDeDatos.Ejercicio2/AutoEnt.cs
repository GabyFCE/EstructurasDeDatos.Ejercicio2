using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.Ejercicio2
{
    internal class AutoEnt
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public decimal Precio { get; set; }

        internal bool ValidaAuto(out string error)
        {

            error = null;

            if(Año < 1900)
            {
                error = "Fecha anterior a la existencia de autos (1900)";
                return false;
            }

            if(Año > DateTime.Now.Year)
            {
                error = "Año mayor al actual";
                return false;

            }

            if(Precio <= 0)
            {
                error = error + "\n" + "Precio menor igual a 0";
                return false;
            }

            return true;
        }
    }
}
