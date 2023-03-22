using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjektZaliczeniowy
{
    [Serializable]

    public class AtlasCw :  ICloneable, IAtlas
    {
        private List<Cwiczenie> atlas;
        /// <summary>
        /// Konstruktor nieparametryczny inicjuje nową liste - atlas
        /// </summary>
        public AtlasCw()
        {
            this.Atlas = new List<Cwiczenie>();
        }

        public List<Cwiczenie> Atlas { get => atlas; set => atlas = value; }
        /// <summary>
        /// Metoda podaje ilosc obiektow w liscie 
        /// </summary>
        /// <returns></returns>
        public int PodajIlosc()
        {
            int counter = Atlas.Count();
            return counter;
        }
        /// <summary>
        /// Metoda Dodaje obiekt typu Cwiczenie do listy
        /// </summary>
        /// <param name="s"></param>
        public void Umiesc(Cwiczenie s)
        {
            Atlas.Add(s);
        }
        /// <summary>
        /// Sortuje liste
        /// </summary>
        public void Sortuj()
        {
            Atlas.Sort();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Cwiczenie item in Atlas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Zapisuje w XML
        /// </summary>
        /// <param name="nazwa">nazwa pliku w ktorym zapisuje obiekt typu AtlasCw</param>
        /// <param name="z"></param>
        public static void ZapiszXML(string nazwa, AtlasCw z)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AtlasCw));
            TextWriter writer = new StreamWriter($"{nazwa}.xml");
            serializer.Serialize(writer, z);
            writer.Close();
        }
        /// <summary>
        /// Odczytuje plik XML
        /// </summary>
        /// <param name="nazwa">nazwa odczytywanego pliku</param>
        /// <returns></returns>
        public static AtlasCw OdczytajXML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AtlasCw));
            FileStream fs = new FileStream($"{nazwa}.xml", FileMode.Open);
            return (AtlasCw)serializer.Deserialize(fs);
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
        /// Klonowanie glebnokie
        /// </summary>
        /// <returns></returns>
        public object DeepClone()
        {
            AtlasCw atlas = new AtlasCw();
            foreach (Cwiczenie cwiczenie in this.Atlas)
                atlas.Umiesc((Cwiczenie)cwiczenie.Clone());
            return atlas;

        }

    }
}

