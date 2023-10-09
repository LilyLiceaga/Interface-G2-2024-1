using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_G2_2024_1
{
    internal class Estufa : LineaBlanca , IEncender
    {
        internal Estufa()
        {
            Marca = "LG";

        }
        public void Encender()
        {
            Console.WriteLine("{0} :) ", Marca);
        }

    }
}
