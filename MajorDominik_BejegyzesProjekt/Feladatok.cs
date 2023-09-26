﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorDominik_BejegyzesProjekt
{
    internal class Feladatok
    {
        private List<Bejegyzes> lista1;
        private List<Bejegyzes> lista2;

        public Feladatok()
        {
            lista1 = new List<Bejegyzes>();
            lista2 = new List<Bejegyzes>();
            Bekeres();
        }

        public void Bekeres()
        {
            Console.WriteLine("Adjon meg egy darabszámot: ");
            int darabSzam = int.Parse(Console.ReadLine());
            int bejegyzesekSzama = darabSzam;
            for (int i = 0; i < darabSzam; i++)
            {
                if (darabSzam < 0)
                {
                    Console.WriteLine("Nem értelmezhető a darabszám");
                }
                else
                {
                    Console.WriteLine($"Hozzon létre {bejegyzesekSzama} új bejegyzést");
                    Bejegyzes b = new Bejegyzes(Console.ReadLine(), Console.ReadLine());
                    bejegyzesekSzama--;
                    lista1.Add(b);
                }
            }
            Console.WriteLine("Bejegyzések létrehozva.");
        }

        public void Beolvasas()
        {
            StreamReader sr = new StreamReader("bejegyzesek.csv");
            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(';');
                string szerzo = adatok[0];
                string tartalom = adatok[1];
                Bejegyzes b = new Bejegyzes(szerzo, tartalom);
                lista1.Add(b);
            }
        }
    }
}
