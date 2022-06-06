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
using Microsoft.Win32;

namespace Diplom_Ivanov_Admin.Pages.mainWindowDish
{
    /// <summary>
    /// Логика взаимодействия для WindowAddDish.xaml
    /// </summary>
    public partial class WindowAddDish : Window
    {
        Dishes dishes;
        public Dishes Editproducts { get; set; }
        private ImageHelp imageHelp { get; set; }
        private Action update;
        public WindowAddDish(Action update)
        {
            InitializeComponent();
            this.update = update;
            dishes = new Dishes();
            DataContext = dishes;
            imageHelp = new ImageHelp() { Products = dishes };
            Photo.DataContext = imageHelp;
            categorycombobox.ItemsSource = DataBase.GetContext().Category_of_dishes.ToList();
        }
        public WindowAddDish(Dishes dishes2)
        {
            InitializeComponent();
            dishes = dishes2;
            DataContext = dishes;
            imageHelp = new ImageHelp() { Products = dishes };
            Photo.DataContext = imageHelp;
            categorycombobox.ItemsSource = DataBase.GetContext().Category_of_dishes.ToList();
        }

        class ImageHelp : INotifyPropertyChanged
        {
            public Dishes Products { get; set; }
            public string Image
            {
                get => Products.Image;
                set
                {
                    Products.Image = value;
                    OnPropertyChanged("Image");
                }
            }
            private void OnPropertyChanged(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            public event PropertyChangedEventHandler PropertyChanged;
        }

        private void addImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files| *.jpg; *.png";
            if (openFileDialog.ShowDialog() == true)
            {

                try
                {
                    string path = "ImDish/" + DateTime.Now.ToBinary().ToString() + System.IO.Path.GetExtension(openFileDialog.FileName);
                    File.Copy(openFileDialog.FileName, System.IO.Path.GetFullPath(path));
                    imageHelp.Image = "" + path;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!DataBase.GetContext().Dishes.ToList().Contains(dishes))
                {
                    DataBase.GetContext().Dishes.Add(dishes);
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

        
    }
}
