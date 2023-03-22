using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjektZaliczeniowy
{
    [Serializable]
    public enum DzienTyg { Poniedzialek = 1, Wtorek = 2, Sroda = 3, Czwartek= 4, Piatek = 5, Sobota = 6, Niedziela = 7 }
    public class Plan : IPlanuje
    {
        private List<SzczegolyCwiczenia> planCwiczen;
        private DzienTyg dzienPlanu;
        public List<SzczegolyCwiczenia> PlanCwiczen { get => planCwiczen; set => planCwiczen = value; }
        public DzienTyg DzienPlanu { get => dzienPlanu; set => dzienPlanu = value; }

        /// <summary>
        /// Konstruktor nieparametryczny, inicjuje nowy obiekt
        /// </summary>
        public Plan()
        {
            PlanCwiczen = new List<SzczegolyCwiczenia>();
        }
        /// <summary>
        /// Konstruktor parametryczny - DzienTyg, inicjuje nowy obiekt.
        /// Wykorzystuje konstruktor podstawowy nieparametryczny
        /// </summary>
        /// <param name="dzien"></param>
        public Plan(DzienTyg dzien) :this()
        {
            this.PlanCwiczen = new List<SzczegolyCwiczenia>();
            this.DzienPlanu = dzien;
        }
        /// <summary>
        /// Podaje ilosc obiektow w liscie 
        /// </summary>
        /// <returns></returns>
        public int PodajIlosc()
        {
            int counter = PlanCwiczen.Count();
            return counter;
        }
        /// <summary>
        /// Dodaje element do listy
        /// </summary>
        /// <param name="s"></param>
        public void Umiesc(SzczegolyCwiczenia s)
        {
            PlanCwiczen.Add(s);
        }
        public void Usun(SzczegolyCwiczenia s)
        {
            PlanCwiczen.Remove(s);
        }

        /// <summary>
        /// Zamienia stary obiekt listy typu SzczegolyCwiczenia na nowy
        /// </summary>
        /// <param name="stara"></param>
        /// <param name="nowa"></param>
        public void Zmien(SzczegolyCwiczenia stara, SzczegolyCwiczenia nowa)
        {
            foreach (SzczegolyCwiczenia item in this.PlanCwiczen)
            {
                if (item.Equals(stara))
                {
                    int i = PlanCwiczen.IndexOf(item);
                    PlanCwiczen.Remove(stara);
                    PlanCwiczen.Insert(i, nowa);
                    break;
                }
            }
        }
        /// <summary>
        /// Zapisuje plik w XML
        /// </summary>
        /// <param name="nazwa"> Nazwa zapisywanego pliku</param>
        /// <param name="z"></param>
        public static void ZapiszXML(string nazwa, Plan z)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Plan));
            TextWriter writer = new StreamWriter($"{nazwa}.xml");
            serializer.Serialize(writer, z);
            writer.Close();
        }
        /// <summary>
        /// Odczytuje plik w XML
        /// </summary>
        /// <param name="nazwa">Nazwa odczytywanego pliku</param>
        /// <returns></returns>
        public static Plan OdczytajXML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Plan));
            FileStream fs = new FileStream($"{nazwa}.xml", FileMode.Open);
            return (Plan)serializer.Deserialize(fs);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DzienPlanu.ToString());
            foreach (SzczegolyCwiczenia item in PlanCwiczen)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

    }
}
