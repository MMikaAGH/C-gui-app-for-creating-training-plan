using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy

{
    internal interface IPlanuje
    {
        void Umiesc(SzczegolyCwiczenia s);
        int PodajIlosc();
        void Zmien(SzczegolyCwiczenia stara, SzczegolyCwiczenia nowa);
        void Usun(SzczegolyCwiczenia s);
    }
}
