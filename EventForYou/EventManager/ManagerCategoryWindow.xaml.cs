using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        //Данный метод отвечает за открытие окна заказов, которые может просматривать менеджер
        private void OrderManager(object sender, RoutedEventArgs e)
        {
            ManagerOrderWindow window = new ManagerOrderWindow();
            Debug.WriteLine("Был создан метод для перехода в новое окно");
            window.Show();
            Debug.WriteLine("Открылось новое окно");
            this.Close();
        }
        //Данный метод отвечает за открытие окна банкетов, в котором менеджер может выбрать мероприятие
        private void EventBManager(object sender, RoutedEventArgs e)
        {
            ManagerEventBanketWindow window = new ManagerEventBanketWindow();
            Debug.WriteLine("Был создан метод для перехода в новое окно");
            window.Show();
            Debug.WriteLine("Открылось новое окно");
            this.Close();
        }
        //Данный метод отвечает за открытие окна культурных мероприятий, в котором менеджер может выбрать мероприятие
        private void EventPManager(object sender, RoutedEventArgs e)
        {
            ManagerEventCultureWindow window = new ManagerEventCultureWindow();
            Debug.WriteLine("Был создан метод для перехода в новое окно");
            window.Show();
            Debug.WriteLine("Открылось новое окно");
            this.Close();
        }
        //Данный метод отвечает за открытие окна развлекательных мероприятий, в котором менеджер может выбрать мероприятие
        private void EventHManager(object sender, RoutedEventArgs e)
        {
            ManagerEventFunnyWindow window = new ManagerEventFunnyWindow();
            Debug.WriteLine("Был создан метод для перехода в новое окно");
            window.Show();
            Debug.WriteLine("Открылось новое окно");
            this.Close();
        }
    }
}
