using System;

namespace Ex_3_1
{
    /// <summary>
    /// Creeaza un elev.
    /// </summary>
    class Elev
    {
        private readonly string nume;
        private readonly string prenume;
        private int[] note;


        public Elev(string nume, string prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
        }


        /// <summary>
        /// Calculeaza media elevului.
        /// </summary>
        /// <returns>Returneaza un double cu media elevului.</returns>
        public double GetMedia()
        {
            if (this.note != null)
            {
                double media = 0;

                foreach (int nota in this.note)
                {
                    media += nota;
                }

                return media / this.note.Length;
            }
            return 0;
        }


        /// <summary>
        /// Creeaza notele elevului.
        /// </summary>
        public void SetNote(int numarNote)
        {
            this.note = new int[numarNote];

            Console.WriteLine();
            for (int i = 0; i < this.note.Length; i++)
            {
                Console.WriteLine($"Introduceti nota numarul {i + 1} a elevului {this.nume} {this.prenume}");
                this.note[i] = int.Parse(Console.ReadLine());
            }
        }
        

        /// <summary>
        /// Afiseaza datele elevului.
        /// </summary>
        public void Tipareste()
        {
            double media = GetMedia();

            Console.WriteLine($"Elev:  {this.nume} {this.prenume}");

            if (note != null)  //////
            {
                Console.Write("Notele sunt:");
                for (int i = 0; i < note.Length; i++)
                {
                    Console.Write($"  {note[i]}");
                }

                if (media <= 0)
                    Console.WriteLine("\nElevul nu are media calculata");
                else
                    Console.WriteLine(string.Format($"\nMedia:  {media:N2}\n"));
            }
            else Console.WriteLine("Nu are note.\n");
        }
    }
}
