using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgYProd_Tarea1
{
    internal class Menu
    {
        string marca;
        int ruedas;
        Vehiculo v1;
        
        public void Execute()
        { 
            EnterBrand();
            EnterWheels();
            ShowVehicleData();
        
        }

        private void ShowVehicleData()
        {
            v1 = new Vehiculo(marca, ruedas);
            Console.WriteLine($"Marca del vehiculo: {marca}. Numero de ruedas: {ruedas}");
        }
        
        private void EnterBrand()
        {
            Console.WriteLine("Introduce la marca de tu Vehiculo");
            marca = Console.ReadLine();
            Console.WriteLine($"Genial, tu vehiculo es un {marca}!");

        }

        private void EnterWheels()
        {
            bool continueFlag = true;
            while(continueFlag)
            {
                Console.WriteLine("Introduce la cantidad de ruedas que tiene tu vehiculo");
                ruedas = int.Parse(Console.ReadLine());
                Console.WriteLine($"¿Dices que tu {marca} tiene {ruedas} ruedas?");
                if (ruedas <= 0)
                {
                    Console.WriteLine("Un vehiculo no puede funcionar sin ruedas");
                }
                else if (ruedas == 1)
                {
                    Console.WriteLine("No es un vehiculo, es un monopatin");
                }
                else if (ruedas == 2)
                {
                    continueFlag = false;
                    Console.WriteLine("Bien, tu vehiculo es una moto, asegurate de usar casco. Buen viaje");
                }
                else if (ruedas == 3)
                {
                    continueFlag = false;
                    Console.WriteLine("Que moto tan extraña. Buen viaje!");
                }
                else if (ruedas == 4)
                {
                    continueFlag = false;
                    Console.WriteLine("Que lindo auto. Buen viaje!");
                }
                else if (ruedas == 5)
                {
                    Console.WriteLine("No creo que existan autos de 5 ruedas");
                }
                else if (ruedas == 6)
                {
                    continueFlag = false;
                    Console.WriteLine("Genial, un todoterreno. Buen viaje!");
                }
                else
                {
                    Console.WriteLine("Numero de ruedas invalido, escribe de nuevo");
                }
            }
        }
    }
}
