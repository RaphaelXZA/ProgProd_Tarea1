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
        

    }
}
