using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Un dulap are trei caracteristici: lungime, latime, inaltime. 
               Dulapul va avea o metoda care va calcula volumul acestuia.
     
               Folositi o clasa care va modela un dulap.
                    * Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
                    * Cele trei campuri vor fi initializate cu ajutorul constructorului.
                    * Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
                    * Realizati diagrama UML a clasei. 
                   
                    * Instantiati un dulap in functia Main, apelati metoda 
                      de calcul a volumului si afisati rezultatul.
            */

            Dulap dulap = new Dulap(Valoare(), Valoare(), Valoare());

            Console.WriteLine($"Volumul dulapului este: {dulap.CalculVolum()}");
        }

        static int Valoare()
        {
            Console.WriteLine("Introduceti marime");
            return int.Parse(Console.ReadLine());
        }
    }
}
