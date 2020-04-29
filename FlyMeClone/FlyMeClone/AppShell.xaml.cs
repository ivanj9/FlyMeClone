using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FlyMeClone
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void MenuItem_Clicked(object sender, System.EventArgs e)
        {
            await SecureStorage.SetAsync(App.REMEMBER_ME, false.ToString());
            await Shell.Current.GoToAsync("///login");
            //Shell.SetFlyoutBehavior(Shell.Current, FlyoutBehavior.Disabled);
            //Shell.Current.FlyoutIsPresented = false;
        }

    }
}
