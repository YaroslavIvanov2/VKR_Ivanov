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
using Diplom_Ivanov_Admin.DB;

namespace Diplom_Ivanov_Admin.Pages.mainWindowEmployee
{
    /// <summary>
    /// Логика взаимодействия для PageWidhetEmployee.xaml
    /// </summary>
    public partial class PageWidhetEmployee : Page
    {
       
        public PageWidhetEmployee()
        {
            InitializeComponent();
        }
        public void SetUser(Employee employee)
        {
            DataContext = employee;

        }
        private void updateState()
        {
            Employee employees = (Employee)DataContext;
            pictureUser.Visibility = employees != null ? Visibility.Visible : Visibility.Hidden;
            //pictureUser.Source = new BitmapImage(new Uri(System.IO.Path.GetFullPath($"../../resources/pic/{employees.user_role.name}.png")));
        }
    }
}
