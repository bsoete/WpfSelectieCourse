﻿using System;
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
    /// Interaction logic for WpfRaadspelExtra.xaml
    /// </summary>
    public partial class WpfRaadspelExtra : Window
    {
        public WpfRaadspelExtra()
        {
            InitializeComponent();
        }


        #region Globale Variabelen
        // Variabele van het type Random (Genereerd random waarden)

        Random rd = new Random();
        int gokken;
        int teRadenCijfer;
        int gokKeuze;

        #endregion

        #region Methoden
        // Inlezen van de textingave
        void LeesWaarde()
        {
            gokKeuze = int.Parse(txtGok.Text);
        }

        // Aanpassen van het aantal gokken
        void PasGokkenAan()
        {
            lblGokken.Content = gokken.ToString();
            gokken++;
        }

        // Tekstvak leegmaken en focus geven
        void MaakTekstLeeg()
        {
            txtGok.Text = String.Empty;
            txtGok.Focus();
        }

        // Listbox leegmaken
        void MaakListboxLeeg()
        {
            lstGokken.Items.Clear();
        }

        // Weergeven van spiekgetal (voor ontwikkeling)
        void GeefVerborgencijferWeer(int getal)
        {
            lblSpiek.Content = getal.ToString();
        }



        #endregion

        #region EventHandlers
        // Acties bij het inladen van de Window
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Bij het inladen wordt 1 random cijfer gemaakt
            // Nu wordt een random cijfer gegenereerd tussen 1 en 10 (grootste getal niet inbegrepen)
            teRadenCijfer = rd.Next(1, 11);
            gokken = 0;
            // Aanpassen van de GUI
            PasGokkenAan();

            // Zorgt dat de tekstbox de Focus krijgt
            MaakTekstLeeg();

            // Geef verborgen cijfer weer
            GeefVerborgencijferWeer(teRadenCijfer);
        }

        // Acties wanneer Gok wordt gemaakt

        private void btnGok_Click(object sender, RoutedEventArgs e)
        {
            LeesWaarde();
            // Controleer of ingave tussen 0 en 11 ligt
            if ((gokKeuze > 0) && (gokKeuze < 11))
            {
                // Uitwerking met uw keuze => Getal is groter/kleiner/correct
                if (gokKeuze < teRadenCijfer)
                {
                    // Melding gok is te klein
                    lstGokken.Items.Add("Uw ingave : " + gokKeuze + " is te klein!");


                }
                else if (gokKeuze > teRadenCijfer)
                {
                    lstGokken.Items.Add("Uw ingave : " + gokKeuze + " is te groot!");

                }
                else
                {
                    lstGokken.Items.Add("Uw keuze " + gokKeuze.ToString() + " is juist.");
                    // Eventueel btn disabelen
                    btnGok.IsEnabled = false;
                }

                PasGokkenAan();
            }
            else
            {
                MessageBox.Show("Geef een getal tussen 0 en 10", "Melding gebruiker");
            }

            MaakTekstLeeg();

        }

        private void btnNieuwSpel_Click(object sender, RoutedEventArgs e)
        {
            MaakListboxLeeg();
            // Nieuw Random Cijfer
            teRadenCijfer = rd.Next(1, 11);
            btnGok.IsEnabled = true;
            MaakTekstLeeg();
            // Geef verborgen cijfer weer
            GeefVerborgencijferWeer(teRadenCijfer);
        }
        #endregion
    }
}
