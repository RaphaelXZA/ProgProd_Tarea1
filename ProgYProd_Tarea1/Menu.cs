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
        int puertas;
        bool maletera;
        //Vehiculo v1;
        bool continueFlag = true;

        Vehiculo vehiculo;
        Carro carro;
        Moto moto;

        public void Execute()
        {
            vehiculo = new Vehiculo(marca, ruedas);
            carro = new Carro(marca, ruedas, puertas);
            moto = new Moto(marca, ruedas, maletera);

            PlayMenu();

        }

        private void PlayMenu()
        {
            while(continueFlag)
            {
                int option;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("ESCRIBE EL NUMERO PARA LA OPCION DESEADA:");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1. Añadir Vehiculo");
                Console.WriteLine("2. Añadir Carro");
                Console.WriteLine("3. Añadir Moto");
                Console.WriteLine("0. Salir");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        vehiculo.AddVehicle();
                        break;
                    case 2:
                        carro.AddVehicle();
                        break;
                    case 3:
                        moto.AddVehicle();
                        break;
                    case 0:
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

                }


            }
        }



        //private void ShowVehicleData()
        //{
        //    v1 = new Vehiculo(marca, ruedas);
        //    Console.WriteLine($"Marca del vehiculo: {marca}. Numero de ruedas: {ruedas}");
        //}
        
        
    }
}
