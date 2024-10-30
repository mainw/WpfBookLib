using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfBookLibApp.Repositories;
using Autofac;
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
        public static IRepoMark repoMark;
        public static IRepoNote _repoNote;
        public static IRepoUser _repoUser;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var builder = new ContainerBuilder();

            //Регистрация репозиториев
            builder.RegisterType<IRepoAuthor>().As<RepoAuthor>().SingleInstance();
            builder.RegisterType<IRepoAuthor>().As<RepoAuthor>().SingleInstance();

            //Регистрация окон
            builder.RegisterType<MainWindow>().AsSelf();


            _container = builder.Build();

            var mainWindow = _container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
