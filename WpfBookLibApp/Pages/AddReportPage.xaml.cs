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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ModelsLib.Models;
using WpfBookLibApp.Repositories;
namespace WpfBookLibApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddReportPage.xaml
    /// </summary>
    public partial class AddReportPage : Page
    {
        private Book _book;
        public AddReportPage(Book book)
        {
            InitializeComponent();
            MarksBox.ItemsSource = App._repoMarkEnum.GetAll();
            _book = book;
        }

        private void SaveReportBtn_Click(object sender, RoutedEventArgs e)
        {
            if(MarksBox.SelectedIndex != -1)
            {
                BookFeedbacks bookFeedbacks = new BookFeedbacks()
                {
                    //
                };
            App._repoBookFeedbacks.Add(bookFeedbacks);
            }
            else
            {
                MessageBox.Show("Выберите оценку");
            }
        }
    }
}
