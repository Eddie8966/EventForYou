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

namespace EventForYou.User
{
    /// <summary>
    /// Логика взаимодействия для CabinetWindow.xaml
    /// </summary>
    public partial class CabinetWindow : Window
    {
        int id;
        public CabinetWindow(int ID)
        {
            InitializeComponent();
            this.id = ID;
        }
        private void Category(object sender, RoutedEventArgs e)
        {
            CategoryWindow window = new CategoryWindow(id);
            window.Show();
            this.Close();
        }
        private void Order(object sender, RoutedEventArgs e)
        {
            OrderWindow window = new OrderWindow(id);
            window.Show();
            this.Close();
        }
        private void Redact(object sender, RoutedEventArgs e)
        {
            User.CabinetRedactDataWindow window = new CabinetRedactDataWindow(id);
            window.Show();
            this.Close();
        }

    }
}
