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
    /// Логика взаимодействия для CategoryWindow.xaml
    /// </summary>
    public partial class CategoryWindow : Window
    {
        int id;
        public CategoryWindow(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        private void Cabinet(object sender, RoutedEventArgs e)
        {
            Entities entity = new Entities();
            List<User_registration> registr = entity.User_registration.ToList();
            List<Users> user = entity.Users.ToList();
            CabinetWindow window = new CabinetWindow(id);
            foreach (var item in user)
            {
                foreach (var item2 in registr)
                {
                    if (id == item.ID && id == item2.ID)
                    {
                        window.FIO.Text = item2.FIO;
                        window.Phone.Text = item2.Phone;
                        window.Email.Text = item2.E_mail;
                        window.Login.Text = item.Login;
                        window.Password.Text = item.Password;
                    }
                }
            }
            window.Show();
            this.Close();
        }
        private void Order(object sender, RoutedEventArgs e)
        {
            OrderWindow window = new OrderWindow(id);
            window.Show();
            this.Close();
        }
        private void EventB(object sender, RoutedEventArgs e)
        {
            EventBanketWindow window = new EventBanketWindow(id);
            window.Show();
            this.Close();
        }
        private void EventP(object sender, RoutedEventArgs e)
        {
            EventCultureWindow window = new EventCultureWindow(id);
            window.Show();
            this.Close();
        }
        private void EventH(object sender, RoutedEventArgs e)
        {
            EventFunnyWindow window = new EventFunnyWindow(id);
            window.Show();
            this.Close();
        }
    }
}
