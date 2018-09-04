
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Jupiter.Views.Tarefas;
using Jupiter.ViewModels;

namespace Jupiter.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrincipalView : ContentPage
	{
		public PrincipalView ()
		{
			InitializeComponent ();
            BindingContext = new ProjetosViewModel();
        }

        private void ChamarProjetosView(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new ProjetosView(),true);
        }

        private void ChamarTarefasView(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new TarefasView(), true);
        }

        private void ChamarEquipesView(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new EquipesView(), true);
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}