using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorDominik_BejegyzesProjekt
{
    internal class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott;
        private DateTime szerkesztve;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            szerkesztve = DateTime.Now;
        }

        public string Szerzo { get => szerzo; }
        public string Tartalom { get => tartalom; set => szerkesztve = DateTime.Now; }
        public int Likeok { get => likeok; set => likeok = value; }
        public DateTime Letrejott { get => letrejott; }
        public DateTime Szerkesztve { get => szerkesztve; }

        public void Like()
        {
            likeok++;
        }

        public override string ToString()
        {
            return $"{this.szerzo} Like-ok: {this.likeok} Létrejött: {this.letrejott}\nSzerkesztve: {this.szerkesztve}\n{tartalom}";
        }
    }
}
