using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.Ejercicio2
{
    internal static class MenuPrincipal
    {
        public static void Mostrar()
        {
            Console.WriteLine("Menu principal");
            Console.WriteLine("1-Alta de auto");
            Console.WriteLine("2-Baja de auto");
            Console.WriteLine("3-Modificar auto");
            Console.WriteLine("4-Finalizar");

            while (true)
            {
                Console.WriteLine("ingrese su opción:");
                var ingreso = Console.ReadLine();
                if (!int.TryParse(ingreso, out var opcion))
                {
                    Console.WriteLine("Ingrese un numero válido");
                    continue;
                }

                if (opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Ingrese 1-4");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        ModuloAutos.Alta();
                        break;

                    case 2:
                        ModuloAutos.Baja();
                        break;

                    case 3:
                        ModuloAutos.Modificar();
                        break;

                    case 4: //finalizar
                        return;
                }

                break;
            }


        }
    }
}
