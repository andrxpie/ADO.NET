using Data_Access;
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

namespace Data_Access___WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Data data = null;
        public MainWindow()
        {
            InitializeComponent();
            data = new("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sells;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        private void TabSwitch(object sender, SelectionChangedEventArgs e)
        {
            switch(tabs.SelectedItem)
            {
                case 0: grid.ItemsSource = data.GetSells(); break;
                case 1: grid.ItemsSource = data.GetCustomers(); break;
                case 2: grid.ItemsSource = data.GetSellers(); break;
                default: grid.ItemsSource = data.GetSells(); break;
            }
        }
    }
}
