using System;

namespace Interface_G2_2024_1
{
    internal abstract class LineaBlanca
    {
        private string marca;

        public string Marca { 
            get => marca; 
            set => marca = value == "" ? "Generica" : value; } //? - if, : - else //Refactorizar
    }
}
