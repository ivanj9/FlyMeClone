using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FlyMeClone.Services;
using FlyMeClone.Views;

namespace FlyMeClone
{
    public partial class App : Application
    {
        public static string REMEMBER_ME = "remember_me";

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
