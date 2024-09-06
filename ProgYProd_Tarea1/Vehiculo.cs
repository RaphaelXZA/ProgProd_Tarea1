using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgYProd_Tarea1
{
    internal class Vehiculo
    {
        private string marca;
        private int ruedas;

       public Vehiculo(string marca, int ruedas)
        {
            this.marca = marca;
            this.ruedas = ruedas;
        }

        public string Nombre { get { return marca; } }
        public int Ruedas { get { return ruedas; } }

        public virtual void AddVehicle()
        {
            EnterBrand();
            EnterWheels();
        }

        protected void EnterBrand()
        {
            Console.WriteLine("Introduce la marca de tu Vehiculo");
            marca = Console.ReadLine();
            Console.WriteLine($"Genial, tu vehiculo es un {marca}!");

        }

        protected void EnterWheels()
        {
            Console.WriteLine("Introduce la cantidad de ruedas que tiene tu vehiculo");
            ruedas = int.Parse(Console.ReadLine());
            Console.WriteLine($"¿Dices que tu {marca} tiene {ruedas} ruedas?");
            this.CheckNumberOfWheels(ruedas);
        }

        public virtual void CheckNumberOfWheels(int ruedasNumber)
        {
            if (ruedasNumber <= 0)
            {
                Console.WriteLine("Un vehiculo terrestre no puede funcionar sin ruedas");
            }
            else if (ruedasNumber == 1)
            {
                Console.WriteLine("No es un vehiculo, es un monopatin");
            }
            else if (ruedasNumber == 2)
            {
                Console.WriteLine("Bien, tu vehiculo es efectivamente una moto, asegurate de usar casco. Buen viaje");
            }
            else if (ruedasNumber == 3)
            {
                Console.WriteLine("Que moto tan extraña. Buen viaje!");
            }
            else if (ruedasNumber == 4)
            {
                Console.WriteLine("Que lindo auto. Buen viaje!");
            }
            else if (ruedasNumber == 5)
            {
                Console.WriteLine("No creo que existan autos de 5 ruedas");
            }
            else if (ruedasNumber == 6)
            {
                Console.WriteLine("Genial, un todoterreno. Buen viaje!");
            }
            else
            {
                Console.WriteLine("Numero de ruedas invalido, escribe de nuevo");
            }
        }
    }
}
