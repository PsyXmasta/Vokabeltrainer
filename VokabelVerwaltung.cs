using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Vokabeltrainer.Modelle;

namespace Vokabeltrainer
{
    public class VokabelVerwaltung
    {
        public List<Vokabel> VokabelListe { get; set; }

        public VokabelVerwaltung()
        {
            VokabelListe = new List<Vokabel>();
        }
    }
}