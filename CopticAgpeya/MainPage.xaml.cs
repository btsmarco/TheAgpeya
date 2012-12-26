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

namespace CopticAgpeya
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void Prime_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/English/Prime.xaml", UriKind.Relative));
        }

        private void Terce_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/English/Terce.xaml", UriKind.Relative));
        }

        private void Sext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/English/Sext.xaml", UriKind.Relative));
        }

        private void None_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/English/None.xaml", UriKind.Relative));
        }

        private void Vespers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/English/Vespers.xaml", UriKind.Relative));
        }

        private void Compline_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/English/Compline.xaml", UriKind.Relative));
        }

        private void Midnight_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/English/Midnight.xaml", UriKind.Relative));
        }

        private void Other_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/English/Prayers.xaml", UriKind.Relative));
        }

        private void Intro_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/English/Intro.xaml", UriKind.Relative));
        }

        private void Veil_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/English/Veil.xaml", UriKind.Relative));
        }

        private void Arabic_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ArMainPage.xaml", UriKind.Relative));

        }

        private void arabicLight(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/ArMainPage.xaml", UriKind.Relative));
        }

        private void About(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/about.xaml", UriKind.Relative));
        }
    }
}