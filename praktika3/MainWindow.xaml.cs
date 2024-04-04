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

using praktika3.SteamDataSetTableAdapters;

namespace praktika3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         
        accountTableAdapter account = new accountTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            AccountGrid.ItemsSource = account.GetFullInfo();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AccountGrid.Columns[0].Visibility = Visibility.Collapsed;
            AccountGrid.Columns[1].Visibility = Visibility.Collapsed;
            AccountGrid.Columns[2].Visibility = Visibility.Collapsed;
            AccountGrid.Columns[3].Header = "Никнейм";
            AccountGrid.Columns[4].Header = "Имя друга";
            AccountGrid.Columns[5].Header = "Одиночная игра";
            AccountGrid.Columns[6].Header = "Многопользовательская игра";
            AccountGrid.Columns[7].Header = "Кооперативная игра";
        }
        private void ef_Click(object sender, RoutedEventArgs e)
        {
            AccountEF accountEF = new AccountEF();
            this.Content = accountEF;
            
        }     
    }
}
