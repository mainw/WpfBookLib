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
using System.Windows.Controls;
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
            RegisterRepo();
        }
        private void RegisterRepo()
        {
            _repoAuthor = _container.Resolve<IRepoAuthor>();
            _repoBook = _container.Resolve<IRepoBook>();
            _repoComment = _container.Resolve<IRepoComment>();
            _repoMarkEnum = _container.Resolve<IRepoMarkEnum>();
            _repoBookFeedbacks = _container.Resolve<IRepoBookFeedbacks>();
            _repoNote = _container.Resolve<IRepoNote>();
            _repoUser = _container.Resolve<IRepoUser>();
        }
        private IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //Регистрация репозиториев
            builder.RegisterType<RepoAuthor>().As<IRepoAuthor>().SingleInstance();
            builder.RegisterType<RepoBook>().As<IRepoBook>().SingleInstance();
            builder.RegisterType<RepoComment>().As<IRepoComment>().SingleInstance();
            builder.RegisterType<RepoMarkEnum>().As<IRepoMarkEnum>().SingleInstance();
            builder.RegisterType<RepoBookFeedbacks>().As<IRepoBookFeedbacks>().SingleInstance();
            builder.RegisterType<RepoNote>().As<IRepoNote>().SingleInstance();
            builder.RegisterType<RepoUser>().As<IRepoUser>().SingleInstance();
            
            //Регистрация окон
            builder.RegisterType<MainWindow>().AsSelf();

            //Регистрация страниц
            builder.RegisterType<AddEditBookPage>().AsSelf();
            builder.RegisterType<AddReportPage>().AsSelf();
            builder.RegisterType<BooksPage>().AsSelf();

            return builder.Build();
        }
        public static T CreatePage<T>() where T : Page
        {
            return _container.Resolve<T>();
        }
    }
}
