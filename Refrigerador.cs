using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_G2_2024_1
{
    internal class Refrigerador : LineaBlanca , IEncender
    {
        internal Refrigerador()
        {
            Marca = "";
            Console.WriteLine("Verificando si hay alimentación");
        }

        void IEncender.Encender()
        {
            Console.WriteLine("{0} te da la bienvenida ", Marca);

        }
    }
}
