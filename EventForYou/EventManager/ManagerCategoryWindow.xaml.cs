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
using System.Windows.Shapes;

namespace EventForYou.Event_Manager
{
    /// <summary>
    /// Логика взаимодействия для ManagerCategotyWindow.xaml
    /// </summary>
    public partial class ManagerCategoryWindow : Window
    {
        public ManagerCategoryWindow()
        {
            InitializeComponent();
        }
        private void OrderManager(object sender, RoutedEventArgs e)
        {
            ManagerOrderWindow window = new ManagerOrderWindow();
            window.Show();
            
            this.Close();
        }
        private void EventBManager(object sender, RoutedEventArgs e)
        {
            ManagerEventBanketWindow window = new ManagerEventBanketWindow();
            window.Show();
            this.Close();
        }
        private void EventPManager(object sender, RoutedEventArgs e)
        {
            ManagerEventCultureWindow window = new ManagerEventCultureWindow();
            window.Show();
            this.Close();
        }
        private void EventHManager(object sender, RoutedEventArgs e)
        {
            ManagerEventFunnyWindow window = new ManagerEventFunnyWindow();
            window.Show();
            this.Close();
        }
    }
}
