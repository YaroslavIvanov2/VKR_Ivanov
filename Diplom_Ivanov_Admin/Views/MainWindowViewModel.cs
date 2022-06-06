using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Diplom_Ivanov_Admin.DB;
using Diplom_Ivanov_Admin.Pages.mainWindowEmployee;
using Diplom_Ivanov_Admin.Pages.mainWindowDish;
using Diplom_Ivanov_Admin.Pages.mainWindowZakaz;

namespace Diplom_Ivanov_Admin.Views
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private void PropertyChange(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        public event PropertyChangedEventHandler PropertyChanged;

        public Admin admin { get; private set; }
        public ObservableCollection<Page> PageCollection { get; private set; }
        private Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                if (_currentPage != value)
                {
                    _currentPage = value;
                    PropertyChange("CurrentPage");
                }
            }
        }
        internal void UpdateVrach()
        {
            throw new NotImplementedException();
        }

        public MainWindowViewModel(Admin admin)
        {
            this.admin = admin;
            PageCollection = new ObservableCollection<Page>();
            PageCollection.Add(new PageEmployee());
            PageCollection.Add(new PageDish());
            PageCollection.Add(new PageZakaz());
            CurrentPage = PageCollection[0];
           
        }

        public MainWindowViewModel()
        {
        }
    }
}
