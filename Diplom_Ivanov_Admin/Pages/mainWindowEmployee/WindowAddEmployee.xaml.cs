using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using Diplom_Ivanov_Admin.Pages.mainWindowEmployee;
using Microsoft.Win32;

namespace Diplom_Ivanov_Admin.Pages.mainWindowEmployee
{
    /// <summary>
    /// Логика взаимодействия для WindowAddEmployee.xaml
    /// </summary>
    public partial class WindowAddEmployee : Window
    {
        Employee employee;
        public Employee Editemployee { get; set; }
        private ImageHelp imageHelp { get; set; }
        private Action update;
        public WindowAddEmployee(Action update)
        {
            InitializeComponent();
            this.update = update;
            employee = new Employee();
            DataContext = employee;
            imageHelp = new ImageHelp() { employees = employee };
            Photo.DataContext = imageHelp;
            comboboxPositon.ItemsSource = DataBase.GetContext().Position.ToList();
        }
        class ImageHelp : INotifyPropertyChanged
        {
            public Employee employees { get; set; }
            public string Image
            {
                get => employees.Image;
                set
                {
                    employees.Image = value;
                    OnPropertyChanged("Image");
                }
            }
            private void OnPropertyChanged(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            public event PropertyChangedEventHandler PropertyChanged;
        }
        public WindowAddEmployee(Employee employees)
        {
            InitializeComponent();
            employee = employees;
            DataContext = employee;
            comboboxPositon.ItemsSource = DataBase.GetContext().Position.ToList();
        }

        private void addbutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!DataBase.GetContext().Employee.ToList().Contains(employee))
                {
                    DataBase.GetContext().Employee.Add(employee);
                }
                DataBase.GetContext().SaveChanges();
                update();
              
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void addImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files| *.jpg; *.png";
            if (openFileDialog.ShowDialog() == true)
            {

                try
                {
                    string path = "ImEmployee/" + DateTime.Now.ToBinary().ToString() + System.IO.Path.GetExtension(openFileDialog.FileName);
                    File.Copy(openFileDialog.FileName, System.IO.Path.GetFullPath(path));
                    imageHelp.Image = "" + path;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
