using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace Data_Set
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string connectionStr = null;
        SqlDataAdapter adapter;
        DataSet dataSet;
        public MainWindow()
        {
            InitializeComponent();

            connectionStr ??= ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString;
        }

        private void LoadData()
        {
            string cmd;
            int selectedTabIndex;

            switch (tabs.SelectedIndex)
            { 
                case 0: cmd = "select * from Sellers"; break;
                case 1: cmd = "select * from Customers"; break;
                case 2: cmd = "select * from TSells"; break;
                default: cmd = "select * from Sellers"; break;
            }

            adapter = new(cmd, connectionStr);

            new SqlCommandBuilder(adapter);

            dataSet = new();

            adapter.Fill(dataSet);
            
            switch (tabs.SelectedIndex)
            { 
                case 0: gridS.ItemsSource = dataSet.Tables[0].DefaultView; break;
                case 1: gridC.ItemsSource = dataSet.Tables[0].DefaultView; break;
                case 2: gridSC.ItemsSource = dataSet.Tables[0].DefaultView; break;
                default: gridS.ItemsSource = dataSet.Tables[0].DefaultView; break;
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            adapter.Update(dataSet);
        }

        private void Tabs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadData();
        }
    }
}