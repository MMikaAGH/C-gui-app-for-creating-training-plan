using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    internal interface ISzczegoly
    {

        bool RownaSie(SzczegolyCwiczenia other);
        int ObliczIloscPowtorzen();
    }
}
