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

namespace Diplom_Ivanov_Admin.Pages.mainWindowZakaz
{
    /// <summary>
    /// Логика взаимодействия для WindowAddZakaz.xaml
    /// </summary>
    /// 
    
    public partial class WindowAddZakaz : Window
    {
        Order order;
        private Action update;
       

        public WindowAddZakaz(Action update)
        {
            InitializeComponent();
            this.update = update;
            order = new Order();
            DataContext = order;
            stoliccombobox.ItemsSource = DataBase.GetContext().Table.ToList();
            Employeecomobox.ItemsSource = DataBase.GetContext().Employee.Where(p => p.id_Position == 4).ToList();
            var eatslist = DataBase.GetContext().Dishes.ToList();
            var eatslists = new List<Its>();
            eatslist.ForEach(x => eatslists.Add(new Its() { Name = x.Name_dish, IsCheched = false, Id = x.id_Dish, colichestvo = 1 }));
            dishcombobox.ItemsSource = eatslists;
        }
        public WindowAddZakaz(Order orders)
        {
            InitializeComponent();
            order = orders;
            DataContext = order;
            stoliccombobox.ItemsSource = DataBase.GetContext().Table.ToList();
            Employeecomobox.ItemsSource = DataBase.GetContext().Employee.ToList();
            var eatslist = DataBase.GetContext().Dishes.ToList();
            var eatslists = new List<Its>();
            eatslist.ForEach(x => eatslists.Add(new Its() { Name = x.Name_dish, IsCheched = false, Id = x.id_Dish, colichestvo = 1 }));
            dishcombobox.ItemsSource = eatslists;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!DataBase.GetContext().Order.ToList().Contains(order))
                {
                    DataBase.GetContext().Order.Add(order);
                }
                //добавление блюд
                var selectedItems = new List<Its>();
                for (int i = 0; i < dishcombobox.Items.Count; i++)
                {
                    var item = (Its)dishcombobox.Items[i];
                    if (item.IsCheched)
                    {

                        selectedItems.Add(item);
                    }
                }
                // с помощью данного метода связываем данные из таблицы Блюда с combobox
                selectedItems.ForEach(x => {
                    DataBase.GetContext().Dishes_in_Order.Add(new Dishes_in_Order()
                    {
                        id_order = order.id_Order,
                        id_dish = x.Id,
                        Quantity = x.colichestvo
                    });
                });
                DataBase.GetContext().SaveChanges();
                update();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
    public class Its
    {
        public int Id;
        public int colichestvo { get; set; }
        public string Name { get; set; }
        public bool IsCheched { get; set; }
    }
}
