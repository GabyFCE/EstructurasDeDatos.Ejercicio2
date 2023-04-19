using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.Ejercicio2
{
    internal class ModuloAutos
    {
        internal static void Alta()
        {
            List<AutoEnt> autos = new List<AutoEnt>();

            while (true)
            {
                //1) Pedir los datos para construir un objeto auto
                //2) agregarlo a la lista
                //3)preguntarle al usuario si quiere seguir o no,
                //4)si no, por ahora terminamos.
                //5)si si, seguimos

                AutoEnt nuevoAuto = IngresarAuto();
                autos.Add(nuevoAuto);
                Console.WriteLine("Se ha agregado un nuevo auto.");
                Console.WriteLine($"Cantidad: {autos.Count}");

                Console.WriteLine("¿Desea continuar? [S/N]");
                string continuar = null;
                while (continuar != "S" && continuar != "N")
                {
                    continuar = Console.ReadLine();
                }

                if (continuar == "N")
                {
                    break;
                }
            }

            AutoEnt IngresarAuto()
            {
                AutoEnt auto = new AutoEnt();
                while (true)
                {
                    //Marca
                    while (true)
                    {
                        Console.WriteLine("Ingrese la marca del auto");
                        var ingreso = Console.ReadLine();
                        if (!Validaciones.ValidarCadena(ingreso, 1, 30, soloLetras:true, out string errorNombre))
                        {
                            Console.WriteLine(errorNombre);
                            continue;
                        }


                        //sigo validando......

                        auto.Marca = ingreso;
                        break;
                    }

                    //Modelo
                    while (true)
                    {
                        Console.WriteLine("Ingrese el modelo del auto");
                        var ingreso = Console.ReadLine();
                        if (!Validaciones.ValidarCadena(ingreso, 1, 30, soloLetras: false, out string errorApellido))
                        {
                            Console.WriteLine(errorApellido);
                            continue;
                        }

                        //sigo validando......

                        auto.Modelo = ingreso;
                        break;
                    }

                    //Año
                    while (true)
                    {
                        Console.Write("Ingrese el año del auto");
                        var ingreso = Console.ReadLine();
                        if (!Validaciones.ValidarEntero(ingreso, 2_000, 2_001, out int año, out string errorEntero))
                        {
                            Console.WriteLine(errorEntero);
                            continue;
                        }

                        auto.Año = año;
                        break;
                    }

                    //Precio
                    while (true)
                    {
                        Console.Write("Ingrese el precio.");
                        var ingreso = Console.ReadLine();
                        if (!Validaciones.ValidarDecimal(ingreso, 1, maximo:null, out decimal precio, out string errorDecimal))
                        {
                            Console.WriteLine(errorDecimal);
                            continue;
                        }

                        auto.Precio = precio;
                        break;
                    }

                    ///etc...
                    ///

                    if (!auto.ValidaAuto(out string error))
                    {
                        Console.WriteLine(error);
                        continue;
                    }

                    break;
                }

                return auto;
            }

        }

        internal static void Baja()
        {
            throw new NotImplementedException();
        }

        internal static void Modificar()
        {
            throw new NotImplementedException();
        }
    }
}
