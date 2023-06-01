using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для CabinetRedactDataWindow.xaml
    /// </summary>
    public partial class CabinetRedactDataWindow : Window
    {
        int id;
        public CabinetRedactDataWindow(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        private void Save(object sender, RoutedEventArgs e)
        {
            Entities entity = new Entities();
            List<Users> user = entity.Users.ToList();
            List<User_registration> registr = entity.User_registration.ToList();
            User_registration Oleg2 = entity.User_registration.Where(a => a.ID == id).First();
            Users Oleg = entity.Users.Where(a => a.ID == id).First();
            Regex fio = new Regex("^[А-Я]{1}[а-я].+ [А-Я]{1}[а-я].+ [А-Я]{1}[а-я].+");
            bool fl = fio.IsMatch(FIO.Text);
            Regex login = new Regex("^[A-Z 0-9 a-z].+");
            bool fg = login.IsMatch(Login.Text);
            Regex password = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[0-9 a-z A-Z]{6,}$");
            bool rg = password.IsMatch(Password.Password);
            Regex phone = new Regex(@"^\+79|89[0-9]{9}$");
            bool ph = phone.IsMatch(Phone.Text);
            Regex mail = new Regex("[a-z].+[@]{1}[a-z].+[.]{1}");
            bool ml = mail.IsMatch(Email.Text);
            foreach (var item2 in user)
            {
                foreach (var item in registr)
                {
                    if (item2.Login == Login.Text || item.E_mail == Email.Text || item.Phone == Phone.Text)
                    {
                        MessageBox.Show("Пользователь с такими данными уже существует");
                        return;
                    }
                }
            }
            if (ml == false || fl == false || fg == false || rg == false || ph == false)
            {
                MessageBox.Show("Не все данные введены");
                return;
            }
            if (rg == false)
            {
                MessageBox.Show("В пароле должны содержаться заглавные и строчные буквы Латинского алфавита, а также цифры! Количество символов в пароле должно быть больше 6!");
                return;
            }
            if (Password.Password == Login.Text)
            {
                MessageBox.Show("Пароль и логин не должны совпадать!");
                return;
            }
            if (ml && fl && fg && rg && ph)
            {
                Oleg.Login = Login.Text;
                Oleg.Password = Password.Password;
                Oleg2.FIO = FIO.Text;
                Oleg2.Phone = Phone.Text;
                Oleg2.E_mail = Email.Text;
                entity.SaveChanges();
                entity.Dispose();
                CategoryWindow cat = new CategoryWindow(id);
                cat.Show();
                this.Close();
                return;
            }
        }
    }
}
