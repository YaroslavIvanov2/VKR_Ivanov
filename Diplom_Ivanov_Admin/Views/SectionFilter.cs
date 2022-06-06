using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom_Ivanov_Admin.DB;

namespace Diplom_Ivanov_Admin.Views
{
    class SectionFilter : INotifyPropertyChanged
    {
        public bool _isChecked = false;
        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                if(_isChecked != value)
                {
                    _isChecked = value;
                    PropertyChange("IsChecked");
                }
            }
        }
        public Category_of_dishes Category_Of_Dishes { get; set; }
        public Position Position { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void PropertyChange(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        
       
    }
}
