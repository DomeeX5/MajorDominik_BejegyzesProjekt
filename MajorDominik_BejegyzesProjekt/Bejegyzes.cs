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
        private int like;
        private DateTime letrejott;
        private DateTime szerkesztve;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            like = 0;
            szerkesztve = DateTime.Now;
        }

        public string Szerzo { get => szerzo; }
        public string Tartalom { get => tartalom; set => szerkesztve = DateTime.Now; }
        public int Like { get => like; }
        public DateTime Letrejott { get => letrejott; }
        public DateTime Szerkesztve { get => szerkesztve; }
    }
}
