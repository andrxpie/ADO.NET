using Microsoft.EntityFrameworkCore;
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

namespace Data_Annotations
{
    public partial class MainWindow : Window
    {
        ShopDB shopDB = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grid = new();

            switch (tabs.SelectedIndex)
            {
                case 0: grid.ItemsSource = shopDB.Shops.ToList(); break;
                case 1: grid.ItemsSource = shopDB.Workers.ToArray(); break;
                case 2: grid.ItemsSource = shopDB.Products.ToArray(); break;
            }
        }
    }
}