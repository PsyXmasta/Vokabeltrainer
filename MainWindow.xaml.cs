using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vokabeltrainer.Modelle;
using Vokabeltrainer.Services;

namespace Vokabeltrainer
{
    public partial class MainWindow : Window
    {
        private VokabelVerwaltung verwaltung;
        private DatenService datenService;

        public MainWindow()
        {
            InitializeComponent();

            verwaltung = new VokabelVerwaltung();
            datenService = new DatenService();

            Aktualisieren();
        }

        private void BtnHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            Vokabel neueVokabel = new Vokabel
            {
                Deutsch = txtDeutsch.Text,
                Englisch = txtEnglisch.Text,
                Kategorie = txtKategorie.Text
            };

            verwaltung.Hinzufuegen(neueVokabel);

            Aktualisieren();

            txtDeutsch.Clear();
            txtEnglisch.Clear();
            txtKategorie.Clear();
        }

        private void BtnSpeichern_Click(object sender, RoutedEventArgs e)
        {
            datenService.Speichern(verwaltung.VokabelListe);

            MessageBox.Show("Vokabeln wurden gespeichert.");
        }

        private void BtnLaden_Click(object sender, RoutedEventArgs e)
        {
            verwaltung.VokabelListe = datenService.Laden();

            Aktualisieren();

            MessageBox.Show("Vokabeln wurden geladen.");
        }

        private void Aktualisieren()
        {
            dgVokabeln.ItemsSource = null;
            dgVokabeln.ItemsSource = verwaltung.VokabelListe;
        }
    }
}