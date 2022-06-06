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
using Diplom_Ivanov_Admin.Views;
using Diplom_Ivanov_Admin.Pages.mainWindowDish;


namespace Diplom_Ivanov_Admin.Pages.mainWindowDish
{
    /// <summary>
    /// Логика взаимодействия для PageDish.xaml
    /// </summary>
    public partial class PageDish : Page
    {
        CatalogDishViewModel catalogDish;
        WindowAddDish addDishes;
        public PageDish()
        {
            InitializeComponent();
            catalogDish = new CatalogDishViewModel();
            DataContext = catalogDish;
            
            DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
        }
        public void Update()
        {
            catalogDish.UpdateDishesList();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) => catalogDish.UpdateDishesList();

        private void CheckBox_Checked(object sender, RoutedEventArgs e) => catalogDish.UpdateDishesList();
        

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
           
                catalogDish.UpdateDishesList();
        }

        private void addDish_Click(object sender, RoutedEventArgs e)
        {
            
            WindowAddDish windowAddDish = new WindowAddDish(this.Update);
            windowAddDish.Show();
        }

       

        private void redactorDish_Click(object sender, RoutedEventArgs e)
        {
            if (spisok2.SelectedItem != null )
            {
                WindowAddDish windowAdd = new WindowAddDish(spisok2.SelectedItem  as Dishes);
                windowAdd.Show();
            }
            
        }

        private void deleteDish_Click(object sender, RoutedEventArgs e)
        {
            if (spisok2.SelectedItems.Count != 0) // проверка, выделен ли элемент в списке
            {
                List<Dishes> pM05Books = spisok2.SelectedItems.OfType<Dishes>().ToList();
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хоите удалить?", "Удаление", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    DataBase.GetContext().Dishes.RemoveRange(pM05Books);
                    DataBase.GetContext().SaveChanges();
                    DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    catalogDish.UpdateDishesList();
                }
            }
        }
       
    }
}
