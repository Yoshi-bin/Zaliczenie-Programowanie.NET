using System.Windows;

namespace Zadanie4
{
    public partial class VehicleWindow : Window
    {
        private Category _category;

        public VehicleWindow(Category category)
        {
            InitializeComponent();
            _category = category;
            LoadCategoryDetails();
            LoadSubcategories();
        }

        private void LoadCategoryDetails()
        {
        }

        private void LoadSubcategories()
        {
        }

        private void SubcategoryListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SubcategoryListBox.SelectedItem is Subcategory selectedSubcategory)
            {
                var subcategoryWindow = new SubcategoryWindow(selectedSubcategory);
                subcategoryWindow.Show();
            }
        }
    }
}
