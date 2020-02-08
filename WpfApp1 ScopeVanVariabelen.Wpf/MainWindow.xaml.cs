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

namespace WpfApp1_ScopeVanVariabelen.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string naam;
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnOK.Visibility = Visibility.Hidden;
            lstVoorkeur.Items.Add("Programmeren");
            lstVoorkeur.Items.Add("Netwerkbeheer");
            lstVoorkeur.Items.Add("IOT");

        }

        private void txtNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNaam.Text.Length == 0)
                btnOK.Visibility = Visibility.Hidden;
            else
                btnOK.Visibility = Visibility.Visible;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            naam = txtNaam.Text;
            lblWelkom.Content = "Welkom in Howest " + naam;
        }

    

        private void lstVoorkeur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string voorkeursRichting;
            voorkeursRichting = lstVoorkeur.SelectedItem.ToString();
            tbkFeedback.Text = naam + " je voorkeur gaat uit naar " + voorkeursRichting;
        }
    }
}
