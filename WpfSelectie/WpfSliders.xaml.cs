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
    /// Interaction logic for WpfSliders.xaml
    /// </summary>
    public partial class WpfSliders : Window
    {
        public WpfSliders()
        {
            InitializeComponent();
        }

        #region EventHandlers

        private void btnTestSliders_Click(object sender, RoutedEventArgs e)
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
    }
}
