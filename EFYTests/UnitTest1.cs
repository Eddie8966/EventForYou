using EventForYou;
using System.Text.RegularExpressions;

namespace EFYTests
{
    public class UnitTestEFY
    {
        [Fact]
        public void LoginInputTest()
        {
            Users users = new Users();
            users.Login = "AsterDK";
            Regex rg = new Regex("^[A-Z 0-9 a-z].+");
            Assert.Matches(rg, users.Login);
        }
        [Fact]
        public void PhoneIsNotNullTest()
        {
            User_registration en = new User_registration();
            en.Phone = "89503403495";
            Assert.NotNull(en.Phone);
        }
        [Fact]
        public void AdminPasswordLoginTest()
        {
            Event_Managers en = new Event_Managers();
            en.Password = "Admin";
            en.Login = "Admin";
            Assert.Equal(en.Login, en.Password);
        }
        [Fact]
        public void EmailCheckTest()
        {
            User_registration en = new User_registration();
            en.E_mail = "dimacyber@mail.ru";
            Assert.Contains("@", en.E_mail);
        }
        [Fact]
        public void UserPasswordLoginTest()
        {
            Users en = new Users();
            en.Password = "Password234";
            en.Login = "AsterDK";
            Assert.DoesNotContain(en.Password, en.Login);
        }
        [Fact]
        public void PasswordInputTest()
        {
            Users en = new Users();
            Regex password = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[0-9 a-z A-Z]{6,}$");
            en.Password = "Dimacyber2020";
            Assert.Matches(password, en.Password);
        }
        [Fact]
        public void FIOInputTest()
        {
            User_registration en = new User_registration();
            Regex FIO = new Regex("^[А-Я]{1}[а-я].+ [А-Я]{1}[а-я].+ [А-Я]{1}[а-я].+");
            en.FIO = "Кудряшов Дмитрий";
            Assert.DoesNotMatch(FIO, en.FIO);
        }
    }
}