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

        public void Hinzufuegen(Vokabel vokabel)
        {
            VokabelListe.Add(vokabel);
        }

        public void Loeschen(Vokabel vokabel)
        {
            VokabelListe.Remove(vokabel);
        }

        public void Bearbeiten(Vokabel alteVokabel, Vokabel neueVokabel)
        {
            int index = VokabelListe.IndexOf(alteVokabel);

            if (index >= 0)
            {
                VokabelListe[index] = neueVokabel;
            }
        }
    }
}
