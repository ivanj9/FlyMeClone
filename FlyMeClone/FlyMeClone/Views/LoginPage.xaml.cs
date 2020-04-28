using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlyMeClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CheckAuth();
        }
        private async void CheckAuth()
        {
            var remember = await SecureStorage.GetAsync(App.REMEMBER_ME);
            if (Convert.ToBoolean(remember))
            {
                await Shell.Current.GoToAsync("///home");
            }
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (RememberCheck.IsChecked)
            {
                // store in essentials
                await SecureStorage.SetAsync(App.REMEMBER_ME, RememberCheck.IsChecked.ToString());
            }
            await Shell.Current.GoToAsync("///home");
            Shell.SetFlyoutBehavior(Shell.Current, FlyoutBehavior.Flyout);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///registrace");
        }
    }
}