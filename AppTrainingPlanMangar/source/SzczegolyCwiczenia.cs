using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    [Serializable]
    public class SzczegolyCwiczenia : Cwiczenie, ISzczegoly
    {
        private string powtorzenia;
        private string serie;
        public string Serie
        {
            get => serie;
            set
            {
                if (value.Length != 1)
                    throw new Number1Exception("Maksymalnie 9 serii");
                serie = value;
            }

        }
        public string Powtorzenia { get => powtorzenia; set => powtorzenia = value; }
        /// <summary>
        /// Konstruktor nieparametryczny
        /// Wykorzystuje konstruktor nieparametryczny z klasy bazowej
        /// </summary>
        public SzczegolyCwiczenia() : base()
        {

        }
        /// <summary>
        /// Konstruktor parametryczny wykorzystujacy konstruktor parametryczny z klasy bazowej
        /// </summary>
        /// <param name="katergoria">Parametr kategorii Cwiczenia</param>
        /// <param name="nazwa">Parametr nazwy cwiczenia</param>
        /// <param name="powtorzenia">Parametr powtorzen szczegol cwiczenia</param>
        /// <param name="serie">Parametr serii powtorzen cwiczenia</param>
        public SzczegolyCwiczenia(KatergoraCw katergoria, string nazwa, string powtorzenia, string serie) : base(katergoria, nazwa)
        {
            this.Powtorzenia = powtorzenia;
            this.Serie = serie;
        }
        public override string ToString()
        {
            return base.ToString() + " powtórzenia: " + Powtorzenia + " serie: " + serie;
        }
        /// <summary>
        /// Oblicza lalczna ilosc powtorzen cwiczenia
        /// </summary>
        /// <returns></returns>
        public int ObliczIloscPowtorzen()
        {
            return int.Parse(Powtorzenia) * int.Parse(Serie);
        }
        /// <summary>
        /// Okresla czy dwa wystapienia sa takie same
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool RownaSie(SzczegolyCwiczenia other)
        {
            if (other.Nazwa == this.Nazwa)
                return true;
            return false;
        }

    }
}
