using System.Windows;

namespace Zadanie4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
    
        }

        private void CategoryListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CategoryListBox.SelectedItem is Category selectedCategory)
            {
                var vehicleWindow = new VehicleWindow(selectedCategory);
                vehicleWindow.Show();
            }
        }
    }
}
