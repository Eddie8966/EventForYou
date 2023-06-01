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
    /// Логика взаимодействия для ManagerOrderPicnicWindow.xaml
    /// </summary>
    public partial class ManagerOrderPicnicWindow : Window
    {
        public ManagerOrderPicnicWindow()
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
        private void ManagerRedactP(object sender, RoutedEventArgs e)
        {
            ManagerPicnicRedactationWindow window = new ManagerPicnicRedactationWindow();
            window.Show();
        }
    }
}
