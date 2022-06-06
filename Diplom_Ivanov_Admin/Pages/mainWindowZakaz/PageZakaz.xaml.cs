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
using Diplom_Ivanov_Admin.Pages.mainWindowEmployee;
using Diplom_Ivanov_Admin.Pages.mainWindowZakaz;

namespace Diplom_Ivanov_Admin.Pages.mainWindowZakaz
{
    /// <summary>
    /// Логика взаимодействия для PageZakaz.xaml
    /// </summary>
    public partial class PageZakaz : Page
    {
        private Page _userCardCurrentWidget;
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

        public PageZakaz()
        {
            InitializeComponent();
            Update();
            //UserCardCurrentWidget = new PageWidhetDish();
        }

        public void Update()
        {
            var spisok = DataBase.GetContext().Order.ToList();
            spisokZakaz.ItemsSource = spisok;
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null)
                return;
            Order order = DataBase.GetContext().Order.Where(p => p.id_Order == (int)btn.Tag).FirstOrDefault();
            PageWidhetDish viewer = new PageWidhetDish(order.Dishes_in_Order.ToList());
            UserCardCurrentWidget = viewer;
        }

        private void AddZalaz_Click(object sender, RoutedEventArgs e)
        {
            WindowAddZakaz windowAdd = new WindowAddZakaz(this.Update);
            windowAdd.Show();
            
        }

        private void spisokZakaz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Order order = spisokZakaz.SelectedItem as Order;
            PageWidhetDish viewer = new PageWidhetDish(order.Dishes_in_Order.ToList());
            UserCardCurrentWidget = viewer;

            if (spisokZakaz.SelectedItem == null)
            {
                return;
            }
            Dishes_in_Order employee = spisokZakaz.SelectedItem as Dishes_in_Order;
            if (employee == null)
                return;
            (UserCardCurrentWidget as PageWidhetDish).SetUser(employee);


         
        }

        private void RedacZakaz_Click(object sender, RoutedEventArgs e)
        {
            if(spisokZakaz.SelectedItem != null)
            {
                WindowAddZakaz addZakaz = new WindowAddZakaz(spisokZakaz.SelectedItem as Order);
                addZakaz.Show();
            }
        }

        private void DeleteZakaz_Click(object sender, RoutedEventArgs e)
        {
            if (spisokZakaz.SelectedItems.Count != 0) // проверка, выделен ли элемент в списке
            {
                List<Order> pM05Books = spisokZakaz.SelectedItems.OfType<Order>().ToList();
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хоите удалить?", "Удаление", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    DataBase.GetContext().Order.RemoveRange(pM05Books);
                    DataBase.GetContext().SaveChanges();
                    DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    Update();
                }
            }
        }
    }
}
