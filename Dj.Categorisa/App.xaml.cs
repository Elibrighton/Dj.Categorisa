using Dj.Categorisa.Models;
using Dj.Categorisa.ViewModels;
using Dj.Categorisa.Views;
using SongHandlerInterface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace Dj.Categorisa
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICategorisaViewModel, CategorisaViewModel>();
            container.RegisterType<ICategorisaModel, CategorisaModel>();
            container.RegisterType<ISongHandler, SongHandler.SongHandler>();

            var window = container.Resolve<CategorisaView>();
            window.Show();
        }
    }
}
