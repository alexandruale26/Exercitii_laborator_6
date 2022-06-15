using System;

namespace Ex_3_1
{
    /// <summary>
    /// Creeaza un catalog.
    /// </summary>
    class Catalog
    {
        private readonly string numeClasa;
        private readonly Elev[] eleviiClasei;


        public Catalog(string numeClasa, Elev[] eleviiClasei)
        {
            this.numeClasa = numeClasa;
            this.eleviiClasei = eleviiClasei;
        }

        /// <summary>
        /// Gaseste premiantul clasei.
        /// </summary>
        /// <returns>Returneaza elevul cu media cea mai mare.</returns>
        public Elev GetPremiantul()
        {
            Elev premiant = null;
            double maxMedia = 0;   

            foreach (Elev elev in this.eleviiClasei)
            {
                double mediaElev = elev.GetMedia();

                if (maxMedia < mediaElev)
                {
                    maxMedia = mediaElev;
                    premiant = elev;
                }
            }
            return premiant;
        }


        /// <summary>
        /// Afiseaza fiecare elev din clasa.
        /// </summary>
        public void Tipareste()
        {
            Console.WriteLine($"\n\nNumele clasei este:  {this.numeClasa}\n");

            foreach (Elev elev in this.eleviiClasei)
            {
                elev.Tipareste();
            }
        }
    }
}
