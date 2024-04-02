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
using Pipirka_One.DataSet1TableAdapters;

namespace Pipirka_One
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientsTableAdapter Сlients = new ClientsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            FullTable.ItemsSource = Сlients.GetData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FullTable.Columns[3].Visibility = Visibility.Collapsed;
            FullTable.Columns[9].Visibility = Visibility.Collapsed;
        }

    }
}
