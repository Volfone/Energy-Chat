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

namespace Energy_Chat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow win = new RegistrationWindow();
            win.Show();
            this.Close();
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTB.Text != string.Empty && PasswordTB != null)
            {
                var LoginData = DBConnection.connection.Login.Where(x => x.Login1 == LoginTB.Text).FirstOrDefault();
                if (LoginData != null)
                {
                    if (LoginData.Password == PasswordTB.Password)
                    {
                        Chat chat = new Chat();
                        chat.Show();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Неправильный пароль!");
                    }
                }

                else
                {
                    MessageBox.Show("Пользователь не найден!");
                }
            }

            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
