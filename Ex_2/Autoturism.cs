using System;

namespace Ex_2
{
    /// <summary>
    /// Creeaza un autoturism.
    /// </summary>
    class Autoturism
    {
        private readonly string marca;
        private readonly string nrInmatriculare;
        private readonly int capCilindrica;


        public Autoturism(string marca, string nrInmatriculare, int capCilindrica)
        {
            this.marca = marca;
            this.nrInmatriculare = nrInmatriculare;
            this.capCilindrica = capCilindrica;
        }

        /// <summary>
        /// Afiseaza datele autoturismului.
        /// </summary>
        public void Tipareste()
        {
            Console.WriteLine($"Autoturismul marca {this.marca} cu numarul de inmatriculare {this.nrInmatriculare}" +
                              $" are capacitatea cilindrica de {this.capCilindrica} centimetri cubi.");
        }
    }
}
