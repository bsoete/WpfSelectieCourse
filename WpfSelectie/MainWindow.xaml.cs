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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfSelectie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Globale Variabelen
        // Variabele van het type Random (Genereerd random waarden)

        Random rd = new Random();
        int gokken;
        int teRadenCijfer;





        #endregion

        #region Methoden

        void PasGokkenAan()
        {
            
            lblGokken.Content = gokken.ToString();
            gokken++;
        }

        #endregion

        #region EventHandlers
        // Acties bij het inladen van de Window
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Bij het inladen wordt 1 random cijfer gemaakt
            teRadenCijfer = rd.Next(1, 11);
            gokken = 0;
            // Aanpassen van de GUI
            PasGokkenAan();
        }

        // Acties wanneer Gok wordt gemaakt
        private void btnGok_Click(object sender, RoutedEventArgs e)
        {
            // inlezen van de keuze van de gebruiker
            int gokkeuze = int.Parse(txtGok.Text);

            // if Statement - Juist/Fout
            if (gokkeuze == teRadenCijfer)
            {
                // Melding code is juist
                lstGokken.Items.Add("Goed geraden !");

                // Eventueel btn disabelen
                btnGok.IsEnabled = false;
            }
            else
            {
                lstGokken.Items.Add("Uw keuze " + gokkeuze.ToString() + " is niet juist.");
            }

            // Aanpassen van de teller
            PasGokkenAan();
        }


        #endregion


    }
}
