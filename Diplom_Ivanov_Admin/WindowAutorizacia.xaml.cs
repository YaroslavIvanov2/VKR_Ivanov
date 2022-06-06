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
using Diplom_Ivanov_Admin.DB;

namespace Diplom_Ivanov_Admin
{
    /// <summary>
    /// Логика взаимодействия для WindowAutorizacia.xaml
    /// </summary>
    public partial class WindowAutorizacia : Window
    {
        private Admin admin;
        public WindowAutorizacia()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            admin.Login = loginTextBox.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(loginTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Password))
            {
                MessageBox.Show("Введите данные во все поля");
                return;
            }
            if (DataBase.GetContext().Admin.Where(p => p.Login == admin.Login && p.Password == admin.Password).ToList().Count != 1)
            {
                MessageBox.Show("Введены не правильно данные");
                return;
            }
            admin = DataBase.GetContext().Admin.Where(p => p.Login == admin.Login && p.Password == admin.Password).ToList().First();
            MainWindow mainWindow = new MainWindow(admin);
            mainWindow.Owner = this;
            mainWindow.Show();
            this.Hide();
        }

        private void passwordTextBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            admin.Password = passwordTextBox.Password;
        }
    }
}
