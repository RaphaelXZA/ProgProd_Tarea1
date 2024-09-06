using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgYProd_Tarea1
{
    internal class Moto : Vehiculo
    {
        protected bool tieneMaletera;

        public Moto(string marca, int ruedas, bool maletera) : base(marca, ruedas)
        {
            this.tieneMaletera = maletera;
        }

        public bool Maletera { get { return tieneMaletera; } }

        public override void AddVehicle()
        {
            base.EnterBrand();
            base.EnterWheels();
            EnterTrunck();
        }

        private void EnterTrunck()
        {
            int option;
            Console.WriteLine("¿Tu moto tiene maletera?");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                tieneMaletera = true;
                Console.WriteLine("Genial, podras llevarte equipaje en la moto");
            }
            else if (option == 2)
            {
                tieneMaletera = false;
                Console.WriteLine("Te tocara viajar ligero");
            }
            else
            {
                Console.WriteLine("Opcion invalida");
            }
        }
        public override void CheckNumberOfWheels(int ruedasNumber)
        {
            if (ruedasNumber == 2)
            {
                Console.WriteLine("Bien, es una moto efectivamente, Buen viaje!");
            }
            else
            {
                Console.WriteLine("Numero de ruedas invalido");
            }
        }
    }
}
