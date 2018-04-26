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
    /// Interaction logic for WpfSliderExtra.xaml
    /// </summary>
    public partial class WpfSliderExtra : Window
    {
        public WpfSliderExtra()
        {
            InitializeComponent();
        }


        #region Methoden

        void BeoordeelWaarden()
        {
            if (sldGetal1.Value > sldGetal2.Value)
            {
                lblBoodschap.Content = "Eerste>Tweede";

            }
            else if (sldGetal1.Value < sldGetal2.Value)
            {
                lblBoodschap.Content = "Eerste<Tweede";
            }
            else
            {
                lblBoodschap.Content = "Eerste=Tweede";
            }
        }


        #endregion


        #region EventHandlers 

        private void sldGetal1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BeoordeelWaarden();
        }

        private void sldGetal2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BeoordeelWaarden();
        }

        #endregion
    }
}
