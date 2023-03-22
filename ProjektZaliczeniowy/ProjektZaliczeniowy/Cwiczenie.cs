using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    [Serializable]
    public enum KatergoraCw { Barki, Biceps, Brzuch, Cale_cialo, Klatka_Piersiowa, Lydka, Plecy, Przedramie, Triceps, Uda_i_posladki}
    public class Cwiczenie : IComparable<Cwiczenie>, ICloneable
    {
        private KatergoraCw katergoria;
        private string nazwa;
        public string Nazwa
        {
            get => nazwa;
            set
            {
                if (Regex.IsMatch(value, @"\p{Lu}"))
                    nazwa = value;
                else
                    throw new LetterException();
            }
        }
        public KatergoraCw Kategoria { get => katergoria; set => katergoria = value; }
        /// <summary>
        /// Konstruktor nieparametryczny
        /// </summary>
        public Cwiczenie()
        {
        }
        /// <summary>
        /// Konstruktor parametryczny - obiekt nazwa
        /// </summary>
        /// <param name="nazwa"></param>
        public Cwiczenie(string nazwa) :this()//potrzebny do testu
        {
            Nazwa = nazwa;
        }
        /// <summary>
        /// Konstruktor parametryczn - obiekty kategoria i nazwa, wykorzystujacy konstruktor nieparametryczny
        /// </summary>
        /// <param name="katergoria"></param>
        /// <param name="nazwa"></param>
        public Cwiczenie(KatergoraCw katergoria, string nazwa) :this()
        {
            this.Kategoria = katergoria;
            this.Nazwa = nazwa;
        }
        /// <summary>
        /// Klonowanie plytkie
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        /// <summary>
        /// Porownuje obiekt typu Cwiczenie do innego obiektu tego samego typu
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Cwiczenie other)
        {
            if (object.ReferenceEquals(other, null))
                return 1;
            int wynik = Nazwa.CompareTo(other.Nazwa);
            if (wynik == 0)
                return Kategoria.CompareTo(other.Kategoria);
            return wynik;
            ;
        }
        public override string ToString()
        {
            return $"Kategoria: {Kategoria}, Nazwa: {Nazwa}"; ;
        }
    }
}
