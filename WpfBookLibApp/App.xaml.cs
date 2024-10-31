using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfBookLibApp.Repositories;
using Autofac;
using WpfBookLibApp.Pages;
namespace WpfBookLibApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IContainer _container;
        public static IRepoAuthor _repoAuthor;
        public static IRepoBook _repoBook;
        public static IRepoComment _repoComment;
        public static IRepoMarkEnum _repoMarkEnum;
        public static IRepoBookFeedbacks _repoBookFeedbacks;
        public static IRepoNote _repoNote;
        public static IRepoUser _repoUser;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _container = Configure();

            var mainWindow = _container.Resolve<MainWindow>();
            mainWindow.Show();
        }
        private IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //Регистрация репозиториев
            builder.RegisterType<IRepoAuthor>().As<RepoAuthor>().SingleInstance();
            builder.RegisterType<IRepoBook>().As<RepoBook>().SingleInstance();
            builder.RegisterType<IRepoComment>().As<RepoComment>().SingleInstance();
            builder.RegisterType<IRepoMarkEnum>().As<RepoMarkEnum>().SingleInstance();
            builder.RegisterType<IRepoBookFeedbacks>().As<RepoBookFeedbacks>().SingleInstance();
            builder.RegisterType<IRepoNote>().As<RepoNote>().SingleInstance();
            builder.RegisterType<IRepoUser>().As<RepoUser>().SingleInstance();

            //Регистрация окон
            builder.RegisterType<MainWindow>().AsSelf();

            //Регистрация страниц
            builder.RegisterType<AddEditBookPage>().AsSelf();
            builder.RegisterType<AddReportPage>().AsSelf();
            builder.RegisterType<BooksPage>().AsSelf();

            return builder.Build();
        }
        public static void NavigateToPage<T>()
        {
            (App.Current.MainWindow as MainWindow).MainFrame.Navigate(_container.Resolve<T>());
        }
    }
}
