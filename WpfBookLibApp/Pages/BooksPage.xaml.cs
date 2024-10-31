using ModelsLib.Models;
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

namespace WpfBookLibApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для BooksPage.xaml
    /// </summary>
    public partial class BooksPage : Page
    {
        public BooksPage()
        {
            InitializeComponent();
            LVBook.ItemsSource = App._repoBook.GetAll().ToList();
        }
        private void TBSearchBook_TextChanged(object sender, TextChangedEventArgs e)
        {
            var conBook = App._repoBook.GetAll().ToList();
            conBook = conBook.Where(p => p.Name.ToLower().Contains(TBSearchBook.Text.ToLower()) || p.Description.ToLower().Contains(TBSearchBook.Text.ToLower()) || p.NameGenres.ToLower().Contains(TBSearchBook.Text.ToLower())).ToList();
            LVBook.ItemsSource = conBook;
        }

        private void BtnAddBook_Click(object sender, RoutedEventArgs e)
        {
            // Ссылку на добавление книги
        }
    }
}
