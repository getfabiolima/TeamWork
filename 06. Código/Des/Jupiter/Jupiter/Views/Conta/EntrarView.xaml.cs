using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Jupiter.ViewModels;

namespace Jupiter.Views.Conta
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntrarView : ContentPage
	{
        public EntrarView()
        {
            InitializeComponent();
            BindingContext = new EntrarViewModel();
        }

        public void ChamarCriarContaView()
        {
            App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new CriarContaView()) { BarBackgroundColor = Color.FromHex("#3b5998") }, true);
        }

        private void ChamarRedefinirSenhaView()
        {
            App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new RedefinirSenhaView()) { BarBackgroundColor = Color.FromHex("#3b5998") }, true);
        }
    }
}