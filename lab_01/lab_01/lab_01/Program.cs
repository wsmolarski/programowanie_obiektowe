using System;

namespace lab_01
{
    class Ulamek
    {
        static void Main(string[] args)
        {
            Ulamek ulamek1 = new Ulamek();
            Ulamek ulamek2 = new Ulamek();
        }
        private int licznik { get; set; }
        private int mianownik { get; set; }

        public Ulamek()
        {

        }
    public Ulamek(int licznik, int mianownik)
    {
            this.licznik = licznik;
            this.mianownik = mianownik;
    }

    }
}
