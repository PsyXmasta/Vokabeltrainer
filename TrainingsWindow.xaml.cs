using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Vokabeltrainer.Modelle;
using Vokabeltrainer.Services;

namespace Vokabeltrainer
{
    public partial class TrainingsWindow : Window
    {
        private readonly List<Vokabel> vokabeln;
        private readonly Training training;

        private Vokabel aktuelleVokabel;

        public TrainingsWindow(List<Vokabel> vokabelListe)
        {
            InitializeComponent();

            vokabeln = vokabelListe;
            training = new Training();

            NeueFrage();
        }

        private void NeueFrage()
        {
            if (vokabeln.Count == 0)
            {
                MessageBox.Show("Keine Vokabeln vorhanden.");
                Close();
                return;
            }

            Random random = new Random();

            aktuelleVokabel = vokabeln[random.Next(vokabeln.Count)];

            txtVokabel.Text = aktuelleVokabel.Deutsch;

            txtAntwort.Clear();
        }

        private void BtnPruefen_Click(object sender, RoutedEventArgs e)
        {
            bool richtig = training.Pruefen(
                aktuelleVokabel,
                txtAntwort.Text);

            if (richtig)
            {
                MessageBox.Show("Richtig!");
            }
            else
            {
                MessageBox.Show(
                    $"Falsch! Richtige Antwort: {aktuelleVokabel.Englisch}");
            }

            lblPunkte.Content =
                $"Punkte: {training.Punkte}";

            NeueFrage();
        }
    }
}
