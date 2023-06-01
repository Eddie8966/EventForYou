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
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        int id;
        public OrderWindow(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        private void Category(object sender, RoutedEventArgs e)
        {
            CategoryWindow window = new CategoryWindow(id);
            window.Show();
            this.Close();
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
    }
}
