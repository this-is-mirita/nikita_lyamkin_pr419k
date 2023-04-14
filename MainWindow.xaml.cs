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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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
        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = true;
            string validationMessage = "";

            // Проверка поля "Логин"
            string loginPattern = @"^\w{4,35}$";
            if (!Regex.IsMatch(LoginTextBox.Text, loginPattern))
            {
                isValid = false;
                validationMessage += "Неверный формат логина (должно быть от 4 до 35 символов, состоять из букв, цифр и символа '_')\n";
            }

            // Проверка поля "Пароль"
            if (PasswordBox.Password.Length < 10 || PasswordBox.Password.Length > 100)
            {
                isValid = false;
                validationMessage += "Длина пароля должна быть от 10 до 100 символов\n";
            }

            // Проверка поля "Электронная почта"
            string emailPattern = @"^.+@.+\..+$";
            if (!Regex.IsMatch(EmailTextBox.Text, emailPattern))
            {
                isValid = false;
                validationMessage += "Неверный формат электронной почты (должен содержать символ '@' и '.' после него)\n";
            }

            ValidationMessageTextBlock.Text = validationMessage;
            if (isValid)
            {
                ValidationMessageTextBlock.Text = "Форма заполнена верно";
            }
        }
    }
}
