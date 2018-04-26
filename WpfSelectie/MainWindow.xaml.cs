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

        #region EventHandlers

        private void btnRaad_Click(object sender, RoutedEventArgs e)
        {
            WpfRaadSpel lesRaadSpel = new WpfRaadSpel();
            lesRaadSpel.Show();
        }

        #endregion

        private void btnRaadExtra_Click(object sender, RoutedEventArgs e)
        {
            WpfRaadspelExtra lesOpdracht = new WpfRaadspelExtra();
            lesOpdracht.Show();
        }

        private void btnSlider_Click(object sender, RoutedEventArgs e)
        {
            WpfSliders sliderCursus = new WpfSliders();
            sliderCursus.Show();
        }

        private void btnSliderExtra_Click(object sender, RoutedEventArgs e)
        {
            WpfSliderExtra sliderExtra = new WpfSliderExtra();
            sliderExtra.Show();
        }

        private void btnSwitch_Click(object sender, RoutedEventArgs e)
        {
            WpfSwitch selectieSwich = new WpfSwitch();
            selectieSwich.Show();
        }
    }
}