using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Jupiter.Views;
using System.ComponentModel;

namespace Jupiter.ViewModels
{
    public class EntrarViewModel : INotifyPropertyChanged
    {
        public ICommand PrincipalViewCommand { get; set; }

        private string _loginEntrar { get; set; }

        public EntrarViewModel()
        {

            PrincipalViewCommand = new Command(ChamarPrincipalView);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ChamarPrincipalView()
        {
            App.Current.MainPage = new NavigationPage(new PrincipalView()) { BarBackgroundColor = Color.FromHex("#3b5998") };
        }

        public string LoginEntrar
        {
            get => _loginEntrar;
            set
            {
                _loginEntrar = value;
                RaisePropertyChanged(nameof(LoginEntrar));
            }
        }

        private void RaisePropertyChanged(string v)
        {
            throw new NotImplementedException();
        }
    }
}
