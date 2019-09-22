using System.Windows;
using CodeAlong.Modules.Mail;
using CodeAlong.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace CodeAlong
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MailModule>();
        }
    }
}
