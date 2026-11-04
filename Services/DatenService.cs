using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Vokabeltrainer.Modelle;
using System.IO;

namespace Vokabeltrainer.Services
{
    public class DatenService
    {
        private const string DATEIPFAD = @"..\..\..\Daten\vokabeln.json";

        public void Speichern(List<Vokabel> vokabeln)
        {
            Directory.CreateDirectory(
                Path.GetDirectoryName(DATEIPFAD)!);

            string json = JsonSerializer.Serialize(
                vokabeln,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(DATEIPFAD, json);
        }

        public List<Vokabel> Laden()
        {
            if (!File.Exists(DATEIPFAD))
            {
                return new List<Vokabel>();
            }

            string json = File.ReadAllText(DATEIPFAD);

            return JsonSerializer.Deserialize<List<Vokabel>>(json)
                   ?? new List<Vokabel>();
        }
    }
}