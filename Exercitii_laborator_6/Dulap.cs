
namespace Ex_1
{
    class Dulap
    {
        private readonly int lungime;
        private readonly int latime;
        private readonly int inaltime;

        public Dulap(int lungime, int latime, int inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }

        /// <summary>
        /// Calculeaza volumul dulapului.
        /// </summary>
        /// <returns>Returneaza un intreg.</returns>
        public int CalculVolum()
        {
            return this.lungime * this.latime * this.inaltime;
        }
    }
}
