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

namespace Lievelingsstad.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string stad;
        string beginVanDeZin;
        public MainWindow()
        {
            InitializeComponent();
            beginVanDeZin = "Je lievelingsstad is ";
        }

        private void wndMainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            lstSteden.Items.Add("Antwerpen");
            lstSteden.Items.Add("Brugge");
            lstSteden.Items.Add("Brussel");
            lstSteden.Items.Add("Gent");
            lstSteden.Items.Add("Hasselt");

            btnNl.Visibility = Visibility.Hidden;
            btnEngels.Visibility = Visibility.Hidden;

            Title = "kies je lievelingsstad";
        }

        private void lstSteden_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
            stad = lstSteden.SelectedItem.ToString();
            lblLievelingsstad.Content = $"{beginVanDeZin}{stad}";

            btnNl.Visibility = Visibility.Visible;
            btnEngels.Visibility = Visibility.Visible;
        }

        private void btnEngels_Click(object sender, RoutedEventArgs e)
        {
            Title = "Choose your favorite city";
            
            beginVanDeZin = "Your favorite city is ";
            lblLievelingsstad.Content = $"{beginVanDeZin}{stad}";

        }

        private void btnNl_Click(object sender, RoutedEventArgs e)
        {
            Title = "kies je lievelingsstad";

            beginVanDeZin = "Je lievelingsstad is ";
            lblLievelingsstad.Content = $"{beginVanDeZin}{stad}";
        }
    }
}
