using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Diplom_Ivanov_Admin.Pages.mainWindowEmployee;
using Diplom_Ivanov_Admin.Views;

namespace Diplom_Ivanov_Admin.Pages.mainWindowEmployee
{
    /// <summary>
    /// Логика взаимодействия для PageEmployee.xaml
    /// </summary>
    public partial class PageEmployee : Page
    {
        private Page _userCardCurrentWidget;
        CatalogDishViewModel catalogDish;
        public Page UserCardCurrentWidget
        {
            get { return _userCardCurrentWidget; }
            set
            {
                if (_userCardCurrentWidget == value)
                    return;

                _userCardCurrentWidget = value;
                UserCardFrame.Content = UserCardCurrentWidget;
            }
        }




        public PageEmployee()
        {
            InitializeComponent();
            catalogDish = new CatalogDishViewModel();
            DataContext = catalogDish;
            Update();
            
            UserCardCurrentWidget = new PageWidhetEmployee();
           
        }

        public void Update()
        {
           // DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var spisok = DataBase.GetContext().Employee.ToList();
           

            //поиск
            if (!String.IsNullOrWhiteSpace(Searctextbox.Text))
            {
                spisok = spisok.Where(p => p.Name.Contains(Searctextbox.Text)).ToList();
            }

            userTabel.ItemsSource = spisok;
        }

        private void userTabel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (userTabel.SelectedItem == null)
            {
                return;
            }
            Employee employee = userTabel.SelectedItem as Employee;
            if (employee == null)
                return;
            (UserCardCurrentWidget as PageWidhetEmployee).SetUser(employee);

        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            WindowAddEmployee windowAdd = new WindowAddEmployee(this.Update);
            windowAdd.Show();
        }

        private void redactorUser_Click(object sender, RoutedEventArgs e)
        {
            if(userTabel.SelectedItem != null)
            {
                WindowAddEmployee windowAdd = new WindowAddEmployee(userTabel.SelectedItem as Employee);
                windowAdd.Show();
            }
        }

        private void deletebutton_Click(object sender, RoutedEventArgs e)
        {
            if (userTabel.SelectedItems.Count != 0) // проверка, выделен ли элемент в списке
            {
                List<Employee> pM05Books = userTabel.SelectedItems.OfType<Employee>().ToList();
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хоите удалить?", "Удаление", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    DataBase.GetContext().Employee.RemoveRange(pM05Books);
                    DataBase.GetContext().SaveChanges();
                    DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    Update();
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e) => catalogDish.UpdateDishesList();


        private void CheckBox_Unchecked(object sender, RoutedEventArgs e) => catalogDish.UpdateDishesList();

    }
}
