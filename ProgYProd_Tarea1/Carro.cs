using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgYProd_Tarea1
{
    internal class Carro : Vehiculo
    {
        protected int puertas;

        public Carro(string marca, int ruedas, int puertas) : base(marca, ruedas)
        {
            this.puertas = puertas;
        }

        public int Puertas { get { return puertas; } }

        public override void AddVehicle()
        {
            base.EnterBrand();
            base.EnterWheels();
            EnterDoors();
        }

        private void EnterDoors()
        {
            Console.WriteLine("Introduce la cantidad de puertas que tiene tu carro");
            puertas = int.Parse(Console.ReadLine());
            if (puertas == 2 || puertas == 4)
            {
                Console.WriteLine("Genial, por la cantidad de puertas es un carro hecho y derecho.");
            }
            else
            {
                Console.WriteLine("Numero de puertas invalido");
            }
        }
        public override void CheckNumberOfWheels(int ruedasNumber)
        {
            if (ruedasNumber == 4 || ruedasNumber == 6)
            {
                Console.WriteLine("Bien, es un carro efectivamente, Buen viaje!");
            }
            else
            {
                Console.WriteLine("Numero de ruedas invalido");
            }
        }
    }
}
