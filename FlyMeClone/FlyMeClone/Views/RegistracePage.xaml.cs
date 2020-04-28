using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlyMeClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistracePage : ContentPage
    {
        public RegistracePage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///home");
            Shell.SetFlyoutBehavior(Shell.Current, FlyoutBehavior.Flyout);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///login");
        }
    }
}