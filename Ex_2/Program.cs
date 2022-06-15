using System;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Scrieti un program care va modela un autoturism. Un autoturism va avea o marca
              (string), un numar de inmatriculare (string), precum si o capacitate cilindrica (int).

                Autoturismul va avea:
                   * Campurile corespunzatoare caracteristicilor autoturismului.
                   * Un constructor care va initializa campurile acestuia.
                   * O metoda "Tiparire” care va afisa pe consola descrierea acestuia sub forma: 
                     “marca, numarDeInmatriculare, capacitateCilindrica".
                   * Realizati diagrama UML a clasei.
                    
                Folositi: clase , campuri , metode , modificatorii de acces adecvati,
                  comentarii xml pentru metodele publice.
                Creati doua obiecte de tipul autoturism in functia “Main” si apelati-le 
                  metodele "Tipareste".
            */


            Autoturism auto1 = new Autoturism("Mazda", "GL 04 EAZ", 1968);
            Autoturism auto2 = new Autoturism("Audi", "BC 78 FUN", 2771);

            auto1.Tipareste();
            auto2.Tipareste();
        }
    }
}
