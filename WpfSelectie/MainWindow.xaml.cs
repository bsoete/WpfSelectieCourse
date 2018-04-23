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






        #endregion

        #region Methoden



        #endregion

        #region EventHandlers
        // Acties bij het inladen van de Window
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        // Acties wanneer Gok wordt gemaakt
        private void btnGok_Click(object sender, RoutedEventArgs e)
        {

        }


        #endregion


    }
}
