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
using Diplom_Ivanov_Admin.Views;
using Diplom_Ivanov_Admin.DB;

namespace Diplom_Ivanov_Admin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(Admin admin)
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(admin);
            Update();
        }
        public void Update()
        {
            DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => this.Close();
        
    }
}
