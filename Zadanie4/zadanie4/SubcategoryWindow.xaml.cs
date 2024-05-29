using System.Windows;

namespace Zadanie4
{
    public partial class SubcategoryWindow : Window
    {
        private Subcategory _subcategory;

        public SubcategoryWindow(Subcategory subcategory)
        {
            InitializeComponent();
            _subcategory = subcategory;
            LoadSubcategoryDetails();
            LoadItems();
        }

        private void LoadSubcategoryDetails()
        {
            
        }

        private void LoadItems()
        {
            
        }
    }
}
