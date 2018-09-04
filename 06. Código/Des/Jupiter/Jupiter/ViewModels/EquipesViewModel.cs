using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Jupiter.Views.Equipes;
using Xamarin.Forms;

namespace Jupiter.ViewModels
{
    public class EquipesViewModel
    {
        public ICommand CriarEquipeCommand { get; set; }

        public EquipesViewModel()
        {
            CriarEquipeCommand = new Command(ChamarCriarEquipeView);
        }

        public void ChamarCriarEquipeView()
        {
            App.Current.MainPage.Navigation.PushAsync(new CriarEquipeView(), true);
        }
    }
}
