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

namespace praktika3
{
    /// <summary>
    /// Логика взаимодействия для AccountEF.xaml
    /// </summary>

    public partial class AccountEF : Page
    {
        private SteamEntities1 steam = new SteamEntities1();
        public AccountEF()
        {
            InitializeComponent();
            AccountEf.ItemsSource = steam.account.ToList();
        }
    }
}
