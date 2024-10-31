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
using ModelsLib.Models;

namespace WpfBookLibApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditBookPage.xaml
    /// </summary>
    public partial class AddEditBookPage : Page
    {
        Book _book;
        private delegate void FuncBook(Book book);
        public AddEditBookPage(int id_book)
        {
            InitializeComponent();
            _book = App._repoBook.Get(id_book);
            LoadComboBox();
            if (_book != null)
            {
                NameBookTextBox.Text = _book.Name;
                YearTextBox.Text = Convert.ToString(_book.Date);
                GenreComboBox.SelectedItem = GenreComboBox.Items.Cast<ComboBoxItem>().FirstOrDefault(x => x.Content.ToString() == _book.NameGenres);
                AuthorComboBox.SelectedItem = AuthorComboBox.Items.Cast<ComboBoxItem>().FirstOrDefault(x => Convert.ToInt32(x.Tag) == _book.AuthorId);
                DescriptionTextBox.Text = _book.Description;
            }
        }

        public AddEditBookPage()
        {
            InitializeComponent();
            LoadComboBox();
        }
        private void UpdateBook(Book book)
        {
            _book.Name = book.Name;
            _book.Date = book.Date;
            _book.NameGenres = _book.NameGenres;
            _book.AuthorId = book.AuthorId;
            _book.Description = book.Description;
            App._repoBook.Edit(_book);
        }
        private void AddBook(Book book)
        {
            App._repoBook.Add(_book);
        }
        private void SaveBookBtn_Click(object sender, RoutedEventArgs e)
        {
            FuncBook func = AddBook;
            if (_book is null)
                func = UpdateBook;
            Book book = new Book();
            book.Name = NameBookTextBox.Text;
            book.Date = Convert.ToDateTime(YearTextBox.Text);
            book.NameGenres = Convert.ToString(((ComboBoxItem)GenreComboBox.SelectedItem).Content);
            book.AuthorId = (int)((ComboBoxItem)AuthorComboBox.SelectedItem).Tag;
            book.Description = DescriptionTextBox.Text;
            func.Invoke(book);
        }
        private void LoadComboBox()
        {
            var genres = Enum.GetValues(typeof(GenresEnum)).Cast<GenresEnum>();
            var authors = Enum.GetValues(typeof(Author)).Cast<Author>();
            GenreComboBox.ItemsSource = genres.Select(g => new ComboBoxItem { Content = g.ToString(), Tag = (int)(object)g }).ToList();
            AuthorComboBox.ItemsSource = authors.Select(x => new ComboBoxItem { Content = x.ToString(), Tag = (int)(object)x }).ToList();
        }
    }
}
