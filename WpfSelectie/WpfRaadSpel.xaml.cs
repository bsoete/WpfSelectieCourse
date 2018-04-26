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

namespace WpfSelectie
{
    /// <summary>
    /// Interaction logic for WpfRaadSpel.xaml
    /// </summary>
    public partial class WpfRaadSpel : Window
    {
        public WpfRaadSpel()
        {
            InitializeComponent();
        }

        #region Globale Variabelen
        int teRaden;
        int pogingen;

        // Maken van een Random Object 
        Random rnd = new Random();


        #endregion


        #region Methoden




        #endregion



        #region EventHandlers
        // Acties bij het laden van het Window
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Toekennen van een random waarde aan variabele teRaden tussen 1 en 10 (Let op : 11 meegeven)
            teRaden = rnd.Next(1, 11);
            // Initialiseren van varibele pogingen
            pogingen = 0;
            // Weergeven van het Random getal in de GUI
            lblSpiek.Content = teRaden.ToString();
        }
        // Acties na klik op knop
        private void btnGok_Click(object sender, RoutedEventArgs e)
        {
            int gok = int.Parse(txtGok.Text);
            if (gok == teRaden)
            {
                pogingen++;
                // Weergeven van melding in lblGokjes
                lblGokjes.Content = $"Je hebt het getal {teRaden} geraden na {pogingen} pogingen ";
            }
            else
            {
                // Toevoegen van het verkeerd geraden getal in de lblGokjes
                lblGokjes.Content += "\n" + gok.ToString();
                // Leegmaken van de Tekstbox
                txtGok.Text = "";
                // Toekennen van de Focus aan de TextBox (Gebruikersgemak)
                txtGok.Focus();
                // Verhogen van de pogingen
                pogingen++;
            }
        }

        #endregion

       
    }
}
