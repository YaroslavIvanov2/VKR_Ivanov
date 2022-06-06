using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Diplom_Ivanov_Admin.DB;

namespace Diplom_Ivanov_Admin.Views
{
    class CatalogDishViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string SearchString { get; set; } = "";
        public ObservableCollection<Dishes> Dishes { get; set; }
        public CatalogDishViewModel()
        {
            Dishes = new ObservableCollection<Dishes>();
            SectionFilters = new ObservableCollection<SectionFilter>(DataBase.GetContext().Category_of_dishes.Select(p => new SectionFilter() { Category_Of_Dishes = p }));
            SectionFilters2 = new ObservableCollection<SectionFilter>(DataBase.GetContext().Position.Select(p => new SectionFilter() { Position = p }));
            UpdateDishesList();
        }
            
        public ObservableCollection<SectionFilter> SectionFilters { get; private set; }
        public ObservableCollection<SectionFilter> SectionFilters2 { get; private set; }

        public void UpdateDishesList()
        {
            try
            {
                // Dishes = new ObservableCollection<Dishes>(DataBase.GetContext().Dishes);
                Dishes.Clear();
                List<Category_of_dishes> categories = SectionFilters.Where(p => p.IsChecked).Select(p => p.Category_Of_Dishes).ToList();
                List<Position> positions = SectionFilters.Where(p => p.IsChecked).Select(p => p.Position).ToList();
                List<Employee> employees = DataBase.GetContext().Employee.ToList();
                List<Dishes> dishes = DataBase.GetContext().Dishes.ToList();
                // фильтрация
                if (categories.Count != 0 )
                {
                    dishes = dishes.Where(p => categories.Contains(p.Category_of_dishes)).ToList();

                }
                // фильтрация
                if (positions.Count != 0)
                {
                    employees = employees.Where(p => positions.Contains(p.Position)).ToList();

                }
                //поиск
                if (!String.IsNullOrWhiteSpace(SearchString))
                {
                    dishes = dishes.Where(p => p.Name_dish.Contains(SearchString.Trim())).ToList();
                }
                if (dishes.Count != 0)
                {
                    foreach (Dishes dishes1 in dishes)
                        Dishes.Add(dishes1);
                }
                else MessageBox.Show("Ничего не найдено", "Реззультат поиска");
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Возникла ошибка:" +e.Message);
            }
        }
    }
}
