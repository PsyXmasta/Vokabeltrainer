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
        private Vokabel bearbeiteteVokabel;

        public MainWindow()
        {
            InitializeComponent();

            verwaltung = new VokabelVerwaltung();
            datenService = new DatenService();

            verwaltung.VokabelListe = datenService.Laden();

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

        private void BtnLoeschen_Click(object sender, RoutedEventArgs e)
        {
            Vokabel ausgewaehlteVokabel =
                dgVokabeln.SelectedItem as Vokabel;

            if (ausgewaehlteVokabel != null)
            {
                verwaltung.Loeschen(ausgewaehlteVokabel);

                Aktualisieren();
            }
        }

        private void BtnBearbeiten_Click(object sender, RoutedEventArgs e)
        {
            if (bearbeiteteVokabel == null)
            {
                bearbeiteteVokabel = dgVokabeln.SelectedItem as Vokabel;

                if (bearbeiteteVokabel != null)
                {
                    txtDeutsch.Text = bearbeiteteVokabel.Deutsch;
                    txtEnglisch.Text = bearbeiteteVokabel.Englisch;
                    txtKategorie.Text = bearbeiteteVokabel.Kategorie;

                    MessageBox.Show("Vokabel bearbeiten und erneut auf Bearbeiten klicken.");
                }
            }
            else
            {
                Vokabel neueVokabel = new Vokabel
                {
                    Deutsch = txtDeutsch.Text,
                    Englisch = txtEnglisch.Text,
                    Kategorie = txtKategorie.Text
                };

                verwaltung.Bearbeiten(
                    bearbeiteteVokabel,
                    neueVokabel);

                bearbeiteteVokabel = null;

                Aktualisieren();

                txtDeutsch.Clear();
                txtEnglisch.Clear();
                txtKategorie.Clear();

                MessageBox.Show("Vokabel aktualisiert.");
            }
        }

        private void BtnTraining_Click(object sender, RoutedEventArgs e)
        {
            TrainingsWindow trainingWindow =
                new TrainingsWindow(verwaltung.VokabelListe);

            trainingWindow.ShowDialog();
        }

        private void Aktualisieren()
        {
            dgVokabeln.ItemsSource = null;
            dgVokabeln.ItemsSource = verwaltung.VokabelListe;
        }
    }
}