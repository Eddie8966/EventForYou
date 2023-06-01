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
    /// Логика взаимодействия для ManagerPicnicBirthdayWindow.xaml
    /// </summary>
    public partial class ManagerBirthdayRedactationWindow : Window
    {
        public ManagerBirthdayRedactationWindow()
        {
            InitializeComponent();
        }
        private void CLW(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
