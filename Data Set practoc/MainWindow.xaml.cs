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

namespace Data_Set_practoc
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

        public void LoadData()
        {
            string cmd = "select * from Users";
            adapter = new(cmd, connectionStr);
            new SqlCommandBuilder(adapter);

            dataSet = new();
            adapter.Fill(dataSet);
            userList.ItemsSource = dataSet.Tables[0].DefaultView;
        }

        private void Add(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {

        }

        private void Update(object sender, RoutedEventArgs e)
        {
            adapter.Update(dataSet);
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}