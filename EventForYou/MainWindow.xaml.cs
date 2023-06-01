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

namespace EventForYou
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int id;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Category(object sender, RoutedEventArgs e)
        {
            Entities entities = new Entities();
            List<Users> agents = entities.Users.ToList();


            List<Event_Managers> agents2 = entities.Event_Managers.ToList();
            foreach (var item in agents)
            {
                if (Password.Password == item.Password && Login.Text == item.Login)
                {
                    User.CategoryWindow window = new User.CategoryWindow(item.ID);
                    id = item.ID;
                    User.CabinetRedactDataWindow window2 = new User.CabinetRedactDataWindow(item.ID);
                    User.EventFunnyWindow window3 = new User.EventFunnyWindow(item.ID);
                    User.OrderBirthdayWindow window4 = new User.OrderBirthdayWindow(item.ID);
                    User.EventCultureWindow window5 = new User.EventCultureWindow(item.ID);
                    User.OrderPicnicWindow window6 = new User.OrderPicnicWindow(item.ID);
                    User.EventBanketWindow window7 = new User.EventBanketWindow(item.ID);
                    User.OrderWeddingWindow window8 = new User.OrderWeddingWindow(item.ID);
                    User.OrderWindow window9 = new User.OrderWindow(item.ID);
                    window.Show();
                    this.Close();
                    Login.Text = item.Login;
                    MessageBox.Show("Добро пожаловать " + item.Login + "!");
                    return;

                }
            }
            foreach (var item2 in agents2)
            {
                if (Password.Password == item2.Password && Login.Text == item2.Login)
                {
                    Event_Manager.ManagerCategoryWindow window = new Event_Manager.ManagerCategoryWindow();
                    window.Show();
                    this.Close();
                    MessageBox.Show("Добро пожаловать менеджер Олег!");
                    return;
                }
            }
            foreach (var item in agents)
            {
                foreach (var item2 in agents2)
                {
                    if (Password.Password != item2.Password && Login.Text != item2.Login || Password.Password != item.Password && Login.Text != item.Login)
                    {
                        MessageBox.Show("Такого пользователя не существует");
                        return;
                    }
                }
            }
        }
        private void Registration(object sender, RoutedEventArgs e)
        {
            LoginAndRegistration.RegistrationWindow window = new LoginAndRegistration.RegistrationWindow(id);
            window.Show();
            this.Close();
        }
    }
}
