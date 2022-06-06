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

namespace Diplom_Ivanov_Admin.Pages.mainWindowZakaz
{
    /// <summary>
    /// Логика взаимодействия для PageWidhetDish.xaml
    /// </summary>
    public partial class PageWidhetDish : Page
    {
        public PageWidhetDish(List<Dishes_in_Order> listEats)
        {
            InitializeComponent();
            //вызываем из таблицы данные для отображения
            listViewer.ItemsSource = listEats;
            //С помощью данного метода, вызываем списоку Заказ_Блюда где происходит подсчет данных из таблица, а именно Цена и Количество
            int total = 0;
            listEats.ToList().ForEach(e => total += e.Dishes.Price * e.Quantity);
            TotalPriceText.Text = $"Общая стоимость заказа: {total}";
        }
        public void SetUser(Dishes_in_Order dishes)
        {
            DataContext = dishes;

        }
        private void updateState()
        {
            Dishes_in_Order employees = (Dishes_in_Order)DataContext;
            //pictureUser.Visibility = employees != null ? Visibility.Visible : Visibility.Hidden;
            //pictureUser.Source = new BitmapImage(new Uri(System.IO.Path.GetFullPath($"../../resources/pic/{employees.user_role.name}.png")));
        }

        private void listViewer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
