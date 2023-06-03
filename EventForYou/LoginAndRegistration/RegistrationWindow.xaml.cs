using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace EventForYou.LoginAndRegistration
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        int id;
        public RegistrationWindow(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        private void Register(object sender, RoutedEventArgs e)
        {
            try
            {
                Trace.Listeners.Add(new TextWriterTraceListener(File.Open("svodkaregistr.txt", FileMode.OpenOrCreate)));
                Trace.AutoFlush = true;
                Entities entity = new Entities();
                User_registration reg = new User_registration();
                List<User_registration> registr = entity.User_registration.ToList();
                List<Users> user = entity.Users.ToList();
                Users users = new Users();
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
                            MessageBox.Show("Пользователь с такими данными уже зарегестрирован");
                            return;
                        }
                    }
                }
                if (ml == false || fl == false || fg == false || rg == false || ph == false)
                {
                    MessageBox.Show("Не все данные введены верно");
                }
                if (Password.Password == Login.Text)
                {
                    MessageBox.Show("Пароль и логин не должны совпадать!");
                    return;
                }
                if (rg == false)
                {
                    MessageBox.Show("В пароле должны содержаться заглавные и строчные буквы Латинского алфавита, а также цифры! Количество символов в пароле должно быть больше 6!");
                    return;
                }
                if (ml && fl && fg && rg && ph)
                {
                    reg.FIO = FIO.Text;
                    reg.Phone = Phone.Text;
                    reg.E_mail = Email.Text;
                    users.Login = Login.Text;
                    users.Password = Password.Password;
                    entity.Users.Add(users);
                    entity.User_registration.Add(reg);
                    entity.SaveChanges();
                    entity.Dispose();
                    Trace.WriteLine("-------------------------------");
                    Trace.WriteLine(FIO.Text);
                    Trace.WriteLine(Phone.Text);
                    Trace.WriteLine(Email.Text);
                    Trace.WriteLine(Login.Text);
                    Trace.WriteLine(Password.Password);
                    Trace.WriteLine("-------------------------------");
                    MainWindow window = new MainWindow();
                    window.Show();
                    this.Close();
                    MessageBox.Show("Вы прошли регистрацию!!!");
                    return;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
