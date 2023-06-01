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
    /// Логика взаимодействия для ManagerOrderWeddingWindow.xaml
    /// </summary>
    public partial class ManagerOrderWeddingWindow : Window
    {
        public ManagerOrderWeddingWindow()
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
        private void ManagerRedactW(object sender, RoutedEventArgs e)
        {
            ManagerWeddingRedactationWindow window = new ManagerWeddingRedactationWindow();
            window.Show();
        }
    }
}
