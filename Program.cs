using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_G2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Refrigerador miRefrigerador = new Refrigerador();
            IEncender encender = miRefrigerador;
            encender.Encender();

            Estufa miEstufa = new Estufa();

            miEstufa.Encender();

            Console.ReadLine();
        }
    }
}
