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
    /// Логика взаимодействия для ManagerEventCultureWindow.xaml
    /// </summary>
    public partial class ManagerEventCultureWindow : Window
    {
        public ManagerEventCultureWindow()
        {
            InitializeComponent();
        }
        private void ManagerCategory(object sender, RoutedEventArgs e)
        {
            ManagerCategoryWindow window = new ManagerCategoryWindow();
            window.Show();
            this.Close();
        }
        private void OrderManager(object sender, RoutedEventArgs e)
        {
            ManagerOrderWindow window = new ManagerOrderWindow();
            window.Show();
            this.Close();
        }
        private void OrderP(object sender, RoutedEventArgs e)
        {
            ManagerOrderPicnicWindow window = new ManagerOrderPicnicWindow();
            window.Show();
            this.Close();
        }
    }
}
