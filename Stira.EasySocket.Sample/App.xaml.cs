﻿using Prism.Ioc;
using Stira.EasySocket.Sample.Views;
using System.Windows;

namespace Stira.EasySocket.Sample
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
    }
}
