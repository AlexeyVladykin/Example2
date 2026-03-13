using System.Collections.Generic;
using System.Windows;

namespace Testing
{
    /// <summary>
    /// Логика взаимодействия для ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        // Метод инициализации окна
        public ProductsWindow()
        {
            InitializeComponent();
            
            // Генерируем список товаров
            var products = GetManualProductsList();
            dgProducts.ItemsSource = products;
        }

        private List<Product> GetManualProductsList()
        {
            return new List<Product>()
    {
        new Product { Id = 1, Name = "Хлеб пшеничный", Price = 50m, Description = "Свежий хлеб из местной пекарни"},
        new Product { Id = 2, Name = "Молоко пастеризованное", Price = 70m, Description = "Натуральное молоко местного производства"},
        new Product { Id = 3, Name = "Картофель свежий", Price = 40m, Description = "Отборный картофель отечественного производителя"},
        new Product { Id = 4, Name = "Апельсины свежие", Price = 100m, Description = "Импортные апельсины отличного качества"},
        new Product { Id = 5, Name = "Масло сливочное", Price = 120m, Description = "Настоящее масло высшего сорта"},
        new Product { Id = 6, Name = "Сыр Российский", Price = 150m, Description = "Классический твердый сыр российского производства"},
        new Product { Id = 7, Name = "Колбаса докторская", Price = 200m, Description = "Высококачественная колбаса диетического назначения"},
        new Product { Id = 8, Name = "Сахар-песок", Price = 60m, Description = "Белый сахар высокого качества"},
        new Product { Id = 9, Name = "Макароны вареные", Price = 45m, Description = "Традиционные макаронные изделия из твердых сортов пшеницы"},
        new Product { Id = 10, Name = "Рыба замороженная", Price = 250m, Description = "Замороженная рыба для приготовления вкусных блюд"}
        // Добавляйте остальные продукты аналогично
    };
        }

        private void dgProducts_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}