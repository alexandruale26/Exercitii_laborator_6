using System;

namespace Ex_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Un catalog contine:
                * numele clasei
                * lista (vector) a elevilor
                * o functie "Tipareste” care va afisa numele clasei si care va tipari fiecare elev in parte
                * o functie "GetPremiantul” care va determina elevul cu media cea mai mare

              Elevii vor avea:
                * nume, prenume
                * o lista (vector) de note specifica fiecarui elev
                * o functie care va calcula media elevului
                * o functie "Tipareste” care va afisa informatiile elevului sub forma
                    - nume, prenume
                    - nota 0 nota 1 nota 2 .... nota m

              In functia “Main":
                - Initializati 3 elevi
                - Initializati un catalog adaugandu-i elevii
                - Afisati catalogul chemand metoda "Tipareste"
                - Apelati metoda GetPremiantul a catalogului si afisati elevul cu media cea mai mare

              Realizati diagrama UML a clasei
              
              Atentie la: constructori , modificatori de acces, clase
            */

            Console.WriteLine("Introduceti numarul de elevi");
            int numarElevi = int.Parse(Console.ReadLine());

            Console.WriteLine("Cate note vor primi elevii?");
            int numarNote = int.Parse(Console.ReadLine());


            Elev[] elevi = CitesteElev(numarElevi, numarNote);

            Console.WriteLine("\nIntroduceti numele clasei");
            Catalog catalogClasaX = new Catalog(Console.ReadLine(), elevi);

            catalogClasaX.Tipareste();

            AfisarePremiant(catalogClasaX);
        }


        static Elev[] CitesteElev(int numarElevi, int numarNote)
        {
            Elev[] elevi = new Elev[numarElevi];

            for (int i = 0; i < numarElevi; i++)
            {
                Console.WriteLine($"\nIntroduceti numele si apoi prenumele elevului {i+1}");
                elevi[i] = new Elev(Console.ReadLine(), Console.ReadLine());

                // daca comentam urmatoarea initializare nu vom primi erori
                elevi[i].SetNote(numarNote);
            }

            return elevi;
        }


        static void AfisarePremiant(Catalog catalogClasaX)
        {
            if (catalogClasaX.GetPremiantul() != null)
            {
                Console.WriteLine("\n\nPremiantul este:\n");
                catalogClasaX.GetPremiantul().Tipareste();
            }
            else
                Console.WriteLine("\nNu avem premiant");
        }
    }
}
