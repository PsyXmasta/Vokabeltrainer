using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vokabeltrainer.Modelle;

namespace Vokabeltrainer.Services
{
    public class Training
    {
        public int Punkte { get; set; }

        public bool Pruefen(Vokabel vokabel, string antwort)
        {
            if (vokabel.Englisch.ToLower() == antwort.ToLower())
            {
                Punkte++;
                return true;
            }

            return false;
        }
    }
}
