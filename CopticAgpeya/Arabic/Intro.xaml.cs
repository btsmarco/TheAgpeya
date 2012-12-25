using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace CopticAgpeya.Arabic
{
    public partial class Intro : PhoneApplicationPage
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void Prime_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Arabic/Prime.xaml", UriKind.Relative));
        }

        private void Terce_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Arabic/Terce.xaml", UriKind.Relative));
        }

        private void Sext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Arabic/Sext.xaml", UriKind.Relative));
        }

        private void None_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Arabic/None.xaml", UriKind.Relative));
        }

        private void Vespers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Arabic/Vespers.xaml", UriKind.Relative));
        }

        private void Compline_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Arabic/Compline.xaml", UriKind.Relative));
        }

        private void Midnight_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Arabic/Midnight.xaml", UriKind.Relative));
        }

        private void Other_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Arabic/Prayers.xaml", UriKind.Relative));
        }

        private void Veil_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Arabic/Veil.xaml", UriKind.Relative));
        }
    }
}