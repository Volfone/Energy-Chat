using Energy_Chat.ADOApp;
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

namespace Energy_Chat
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTB.Text != string.Empty && LoginTB.Text != string.Empty && PasswordTB != null)
            {
                User user = new User()
                {
                    Name = NameTB.Text
                };

                Login login = new Login()
                {
                    Login1 = LoginTB.Text,
                    Password = PasswordTB.Password,
                    ID_User = user.User_ID
                };

                DBConnection.connection.User.Add(user);
                DBConnection.connection.Login.Add(login);
                DBConnection.connection.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно!");
            }

            else
            {
                MessageBox.Show("Заполните все данные!");
            }
        }
    }
}
