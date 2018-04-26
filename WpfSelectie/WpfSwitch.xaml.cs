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
    /// Interaction logic for WpfSwitch.xaml
    /// </summary>
    public partial class WpfSwitch : Window
    {
        public WpfSwitch()
        {
            InitializeComponent();
        }

        #region Globale Variabelen


        #endregion

        #region Methoden
        string BepaalHTMLTeken(string ingave)
        {
            string retourstring = "";

            switch (ingave)
            {
                case "<":
                    retourstring = "&lt;";
                    break;
                case ">":
                    retourstring = "&gt;";
                    break;
                case "&":
                    retourstring = "&amp;";
                    break;
                case "@":
                    retourstring = "&#64;";
                    break;
                case "€":
                    retourstring = "&euro;";
                    break;
                default:
                    retourstring = "Nog niet opgenomen";
                    break;
            }




            return retourstring;

        }


        #endregion


        #region EventHandlers

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Selecteren van de het eerste ComboboxItem
            cmbTeken.SelectedIndex = 0;

            // Dynamisch vullen van de Combobox
            cmbTekenString.Items.Add("<");
            cmbTekenString.Items.Add(">");
            cmbTekenString.Items.Add("&");
            cmbTekenString.Items.Add("@");
            cmbTekenString.Items.Add("€");
            // Selecteren van het eerste ComboBoxItem = Netjes
            cmbTekenString.SelectedIndex = 0;
        }

        private void btnDagWeergave_Click(object sender, RoutedEventArgs e)
        {
            string dagNaam;
            DateTime momenteel = DateTime.Now;

            // DayOfWeek = enumeratie
            DayOfWeek dag = momenteel.DayOfWeek;

            switch (dag)
            {
                case DayOfWeek.Sunday:
                    dagNaam = "Zondag";
                    break;
                case DayOfWeek.Monday:
                    dagNaam = "Maandag";
                    break;
                case DayOfWeek.Tuesday:
                    dagNaam = "Dinsdag";
                    break;
                case DayOfWeek.Wednesday:
                    dagNaam = "Woensdag";
                    break;
                case DayOfWeek.Thursday:
                    dagNaam = "Donderdag";
                    break;
                case DayOfWeek.Friday:
                    dagNaam = "Vrijdag";
                    break;
                default:
                    dagNaam = "Zaterdag";
                    break;
            }
            lblMeldingDag.Content = "Vandaag is het " + dagNaam;
        }

        private void btnBoodschapAantal_Click(object sender, RoutedEventArgs e)
        {
            int aantalComputers = int.Parse(txtAantalComputers.Text);
            string boodschapComputers = "";

            if (aantalComputers >= 0)
            {

                switch (aantalComputers)
                {
                    case 0:
                        boodschapComputers = "Wellicht nu de tijd om eentje aan te kopen";
                        break;
                    case 1:
                        boodschapComputers = "Draait wellicht 7/7";
                        break;
                    case 2:
                        boodschapComputers = "Wellicht Laptop/Desktop";
                        break;
                    case 3:
                        boodschapComputers = "Verandering van spijs doet eten?";
                        break;

                    default:
                        boodschapComputers = "Tof, hopelijk niet allemaal om te gamen !?";
                        break;
                }

            }
            else
            {
                boodschapComputers = "Geef een geldige waarde in groter of gelijk aan 0";
            }
            lblComputerBoodschap.Content = boodschapComputers;
        }

        private void cmbTeken_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbTeken.SelectedItem != null) // of (cmbTeken.selectedindex >=0)
            {
                string teken = ((ComboBoxItem)cmbTeken.SelectedItem).Content.ToString();
                lblHTMLNotatie.Content = BepaalHTMLTeken(teken);


            }
        }

        private void cmbTekenString_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbTekenString.SelectedItem != null) // of (cmbTekenString.selectedindex >=0)
            {
                string teken = (string)cmbTekenString.SelectedItem; //OF  cmbTekenString.SelectedValue.ToString();
                lblHTMLNotatieAlt.Content = BepaalHTMLTeken(teken);


            }

        }

        #endregion

        
    }
}
