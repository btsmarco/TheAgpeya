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
using Microsoft.Phone.Tasks;

namespace CopticAgpeya.EnglishA
{
    public partial class PivotPage4 : PhoneApplicationPage
    {
        public PivotPage4()
        {
            InitializeComponent();
        }

        private void Settings(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.Relative));
        }
        private void arabicLight(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/ArMainPage.xaml", UriKind.Relative));
        }

        private void About(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/about.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher();
            objMediaPlayerLauncher.Media = new Uri("AgpeyaHyms/Sext/--------------", UriKind.Relative);
            objMediaPlayerLauncher.Location = MediaLocationType.Install;
            objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All;
            objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape;
            objMediaPlayerLauncher.Show();
        }
        private void Psalm_130(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher();
            objMediaPlayerLauncher.Media = new Uri("AgpeyaHyms/None/--------------------", UriKind.Relative);
            objMediaPlayerLauncher.Location = MediaLocationType.Install;
            objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All;
            objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape;
            objMediaPlayerLauncher.Show();
        }
        private void Psalm_131(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher();
            objMediaPlayerLauncher.Media = new Uri("/AgpeyaHyms/Prime/0--------", UriKind.Relative);
            objMediaPlayerLauncher.Location = MediaLocationType.Install;
            objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All;
            objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape;
            objMediaPlayerLauncher.Show();
        }
        private void Psalm_132(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher();
            objMediaPlayerLauncher.Media = new Uri("/AgpeyaHyms/None/-------------", UriKind.Relative);
            objMediaPlayerLauncher.Location = MediaLocationType.Install;
            objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All;
            objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape;
            objMediaPlayerLauncher.Show();
        }

        private void Psalm_133(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher();
            objMediaPlayerLauncher.Media = new Uri("/AgpeyaHyms/None/------------", UriKind.Relative);
            objMediaPlayerLauncher.Location = MediaLocationType.Install;
            objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All;
            objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape;
            objMediaPlayerLauncher.Show();
        }
        private void Psalm_136(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher();
            objMediaPlayerLauncher.Media = new Uri("/AgpeyaHyms/None/-----------", UriKind.Relative);
            objMediaPlayerLauncher.Location = MediaLocationType.Install;
            objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All;
            objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape;
            objMediaPlayerLauncher.Show();
        }
        private void Psalm_137(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher();
            objMediaPlayerLauncher.Media = new Uri("/AgpeyaHyms/Sext/083-Psalm83.mp3", UriKind.Relative);
            objMediaPlayerLauncher.Location = MediaLocationType.Install;
            objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All;
            objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape;
            objMediaPlayerLauncher.Show();
        }
        private void Psalm_140(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher();
            objMediaPlayerLauncher.Media = new Uri("/AgpeyaHyms/Colimpine/------------.mp3", UriKind.Relative);
            objMediaPlayerLauncher.Location = MediaLocationType.Install;
            objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All;
            objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape;
            objMediaPlayerLauncher.Show();
        }
        private void Psalm_141(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher();
            objMediaPlayerLauncher.Media = new Uri("AgpeyaHyms/Prime/--------------", UriKind.Relative);
            objMediaPlayerLauncher.Location = MediaLocationType.Install;
            objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All;
            objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape;
            objMediaPlayerLauncher.Show();
        }
        private void Psalm_145(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher();
            objMediaPlayerLauncher.Media = new Uri("AgpeyaHyms/None/086-Psalm86.mp3", UriKind.Relative);
            objMediaPlayerLauncher.Location = MediaLocationType.Install;
            objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All;
            objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape;
            objMediaPlayerLauncher.Show();
        }
        private void Psalm_146(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher();
            objMediaPlayerLauncher.Media = new Uri("/AgpeyaHyms/Sext/---------------------", UriKind.Relative);
            objMediaPlayerLauncher.Location = MediaLocationType.Install;
            objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All;
            objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape;
            objMediaPlayerLauncher.Show();
        }
        private void Psalm_147(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher();
            objMediaPlayerLauncher.Media = new Uri("/AgpeyaHyms/Sext/092-Psalm92.mp3", UriKind.Relative);
            objMediaPlayerLauncher.Location = MediaLocationType.Install;
            objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All;
            objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape;
            objMediaPlayerLauncher.Show();
        }
    }
}