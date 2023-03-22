using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    [Serializable]
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tworzenie atlasu
            
            AtlasCw atlas = new AtlasCw();


            Cwiczenie cw1 = new Cwiczenie(KatergoraCw.Klatka_Piersiowa, "Pompki");
            Cwiczenie cw2 = new Cwiczenie(KatergoraCw.Klatka_Piersiowa, "Wyciskanie sztangi");
            Cwiczenie cw3 = new Cwiczenie(KatergoraCw.Klatka_Piersiowa, "Wyciskanie hantli");
            Cwiczenie cw4 = new Cwiczenie(KatergoraCw.Klatka_Piersiowa, "Rozpiętki");
            Cwiczenie cw5 = new Cwiczenie(KatergoraCw.Barki, "Wyciskania sztangi/hantli stojąc/siedząc");
            Cwiczenie cw6 = new Cwiczenie(KatergoraCw.Barki, "Wznosy ramion z hantlami na bok");
            Cwiczenie cw7 = new Cwiczenie(KatergoraCw.Barki, "Wznosy ramion z hantlami przed sobą");
            Cwiczenie cw8 = new Cwiczenie(KatergoraCw.Barki, "Przyciąganie sztangi łamanej przy ciele stojąc");
            Cwiczenie cw9 = new Cwiczenie(KatergoraCw.Przedramie, "Unoszenie krzesła");
            Cwiczenie cw10 = new Cwiczenie(KatergoraCw.Przedramie, "Obracanie hantli w dłoni");
            Cwiczenie cw11 = new Cwiczenie(KatergoraCw.Przedramie, "Zwis na drążku");
            Cwiczenie cw12 = new Cwiczenie(KatergoraCw.Przedramie, "Unoszenie hantli nachwytem");
            Cwiczenie cw13 = new Cwiczenie(KatergoraCw.Przedramie, "Unoszenie hantli podchwytem");
            Cwiczenie cw14 = new Cwiczenie(KatergoraCw.Brzuch, "Brzuszki");
            Cwiczenie cw15 = new Cwiczenie(KatergoraCw.Brzuch, "Przysiad");
            Cwiczenie cw16 = new Cwiczenie(KatergoraCw.Brzuch, "Rowerek");
            Cwiczenie cw17 = new Cwiczenie(KatergoraCw.Brzuch, "Hula hop");
            Cwiczenie cw18 = new Cwiczenie(KatergoraCw.Triceps, "Prostowanie przedramion z hantlami siedząc na ławce poziomej");
            Cwiczenie cw19 = new Cwiczenie(KatergoraCw.Triceps, "Prostowanie przedramion na wyciągu górnym");
            Cwiczenie cw20 = new Cwiczenie(KatergoraCw.Triceps, "Prostowanie przedramion z hantlami leżąc na ławce poziomej");
            Cwiczenie cw21 = new Cwiczenie(KatergoraCw.Triceps, "Pompki na poręczach");
            Cwiczenie cw22 = new Cwiczenie(KatergoraCw.Biceps, "Uginanie ramion ze sztangą");
            Cwiczenie cw23 = new Cwiczenie(KatergoraCw.Biceps, "Uginanie ramienia z hantlą w pozycji pochylonej z rotacją wewnętrzną");
            Cwiczenie cw24 = new Cwiczenie(KatergoraCw.Biceps, "Uginanie ramion ze sztangą łamaną stojąc");
            Cwiczenie cw25 = new Cwiczenie(KatergoraCw.Biceps, "Uginanie ramion stojąc przy użyciu linek wyciągu górnego");
            Cwiczenie cw26 = new Cwiczenie(KatergoraCw.Uda_i_posladki, "Wykroki ze sztangą");
            Cwiczenie cw27 = new Cwiczenie(KatergoraCw.Uda_i_posladki, "Przysiady na skrzynie");
            Cwiczenie cw28 = new Cwiczenie(KatergoraCw.Uda_i_posladki, "Przysiady ze sztangą trzymaną z przodu");
            Cwiczenie cw29 = new Cwiczenie(KatergoraCw.Uda_i_posladki, "Przysiady ze sztangą o wąskim rozstawie nóg");
            Cwiczenie cw30 = new Cwiczenie(KatergoraCw.Cale_cialo, "Deska bokiem");
            Cwiczenie cw31 = new Cwiczenie(KatergoraCw.Cale_cialo, "Przysiady");
            Cwiczenie cw32 = new Cwiczenie(KatergoraCw.Cale_cialo, "Wyciskanie hantli nad głową");
            Cwiczenie cw33 = new Cwiczenie(KatergoraCw.Cale_cialo, "Deska");
            Cwiczenie cw34 = new Cwiczenie(KatergoraCw.Lydka, "Wspięcia na palcach w pozycji siedzącej");
            Cwiczenie cw35 = new Cwiczenie(KatergoraCw.Lydka, "Wspięcia na palcach stojąc");
            Cwiczenie cw36 = new Cwiczenie(KatergoraCw.Lydka, "Wyciskanie obunóż na maszynie");
            Cwiczenie cw37 = new Cwiczenie(KatergoraCw.Lydka, "Wejście na podest ze sztangą");
            Cwiczenie cw39 = new Cwiczenie(KatergoraCw.Lydka, "Skipy");
            Cwiczenie cw40 = new Cwiczenie(KatergoraCw.Lydka, "Podskoki");
            Cwiczenie cw41 = new Cwiczenie(KatergoraCw.Lydka, "Sprinty 10m");
            atlas.Umiesc(cw1);
            atlas.Umiesc(cw2);
            atlas.Umiesc(cw3);
            atlas.Umiesc(cw4);
            atlas.Umiesc(cw5);
            atlas.Umiesc(cw6);
            atlas.Umiesc(cw7);
            atlas.Umiesc(cw8);
            atlas.Umiesc(cw9);
            atlas.Umiesc(cw10);
            atlas.Umiesc(cw11);
            atlas.Umiesc(cw12);
            atlas.Umiesc(cw13);
            atlas.Umiesc(cw14);
            atlas.Umiesc(cw15);
            atlas.Umiesc(cw16);
            atlas.Umiesc(cw17);
            atlas.Umiesc(cw18);
            atlas.Umiesc(cw19);
            atlas.Umiesc(cw20);
            atlas.Umiesc(cw21);
            atlas.Umiesc(cw21);
            atlas.Umiesc(cw22);
            atlas.Umiesc(cw23);
            atlas.Umiesc(cw24);
            atlas.Umiesc(cw25);
            atlas.Umiesc(cw26);
            atlas.Umiesc(cw27);
            atlas.Umiesc(cw28);
            atlas.Umiesc(cw29);
            atlas.Umiesc(cw30);
            atlas.Umiesc(cw31);
            atlas.Umiesc(cw32);
            atlas.Umiesc(cw33);
            atlas.Umiesc(cw34);
            atlas.Umiesc(cw35);
            atlas.Umiesc(cw36);
            atlas.Umiesc(cw37);
            atlas.Umiesc(cw39);
            atlas.Umiesc(cw40);
            atlas.Umiesc(cw41);

            atlas.Sortuj();

            AtlasCw.ZapiszXML("Atlas_Cwiczenia", atlas);

            //Klonowanie
            AtlasCw atlas2 = (AtlasCw)atlas.Clone();
            atlas2 = (AtlasCw)atlas.DeepClone();
            Console.WriteLine(atlas2.ToString());

            //Tworzenie Planu
            Plan pn = new Plan(DzienTyg.Poniedzialek);
            SzczegolyCwiczenia sc1 = new SzczegolyCwiczenia(KatergoraCw.Brzuch, "Brzuszki", "30", "3");
            pn.Umiesc(sc1);
            Console.WriteLine(sc1.ObliczIloscPowtorzen());
            SzczegolyCwiczenia sc2 = new SzczegolyCwiczenia(KatergoraCw.Klatka_Piersiowa, "Pompki", "30", "4");
            pn.Umiesc(sc2);
            Console.WriteLine(pn.ToString());

            SzczegolyCwiczenia sc3 = new SzczegolyCwiczenia(KatergoraCw.Barki, "Zwisy", "10", "3");
            pn.Zmien(sc2, sc3);
            pn.Usun(sc1);
            Console.WriteLine(pn.ToString());

            Console.WriteLine(pn.PodajIlosc());

            Console.ReadKey();
        }
    }
}
