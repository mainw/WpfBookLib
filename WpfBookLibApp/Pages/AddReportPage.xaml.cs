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
        private readonly IRepoBookFeedbacks _repoBookFeedbacks;
        public AddReportPage(IRepoBookFeedbacks repoBookFeedbacks)
        {
            InitializeComponent();
            _repoBookFeedbacks = repoBookFeedbacks;
        }

        private void SaveReportBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
