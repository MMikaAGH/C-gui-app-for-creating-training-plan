using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    internal interface IAtlas
    {
        int PodajIlosc();
        void Umiesc(Cwiczenie s);
        void Sortuj();



    }
}
