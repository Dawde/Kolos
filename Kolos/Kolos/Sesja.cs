using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kolos
{
    public class Sesja
    {
        public Sesja(char letter, int time, string path)
        {
            XDocument document = new XDocument(
                        new XElement("Sesja",
                        new XAttribute("litera", letter),
                        new XAttribute("czas", time)));
            document.Save(path);
        }

        public Sesja(string player, string country, string city, string plant, string animal, string thing, string name, string path)
        {
            XDocument plik = XDocument.Load(path);
            plik.Root.Add(
                new XElement("Gracz",
                new XAttribute("Gracz", player),
                new XElement("Państwo", country),
                new XElement("Miasto", city),
                new XElement("Roślina", plant),
                new XElement("Zwierzę", animal),
                new XElement("Rzecz", thing),
                new XElement("Imię", name)
                ));
            plik.Save(path);
        }
    }
}
