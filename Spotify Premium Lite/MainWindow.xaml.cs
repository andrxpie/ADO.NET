﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Spotify_Premium_Lite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(SpotifyLiteDbContext db)
        {
            DataContext = new ViewModel(db);
        }

        private void InstallAppButton(object sender, RoutedEventArgs e)
        {
            Process.Start("MicrosoftEdge.exe", @"https://download.scdn.co/SpotifySetup.exe");
        }

        private void ExplorePremiumButton(object sender, RoutedEventArgs e)
        {
            Process.Start("MicrosoftEdge.exe", @"https://www.spotify.com/by-ru/premium/?utm_source=app&utm_medium=desktop&utm_campaign=upgrade&ref=web_loggedin_upgrade_button");
        }

        private void MainAlbumChoiseButton(object sender, RoutedEventArgs e)
        {
            var button = (FrameworkElement)sender;
            var album = (Album)button.DataContext;

            Hide();

            ListWindow listWindow = new(album);
            listWindow.ShowDialog();

            Show();
        }
    }
}