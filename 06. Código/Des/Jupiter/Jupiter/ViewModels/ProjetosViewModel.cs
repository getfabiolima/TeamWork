using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Jupiter.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Jupiter.Lists;
using Jupiter.Views.Projetos;

namespace Jupiter.ViewModels
{
    public class ProjetosViewModel
    {
        public ICommand CriarProjetoCommand { get; set; }
        public ICommand ConsultarProjetoCommand { get; set; }
        public ICommand EditarProjetoCommand { get; set; }
        public ICommand ExcluirProjetoCommand { get; set; }
        public ObservableCollection<Projeto> projetos { get; set; }

        public ProjetosViewModel()
        {
            projetos = DadosUsuariosProjetos.projetos;
            CriarProjetoCommand = new Command(ChamarCriarProjetoView);
            ConsultarProjetoCommand = new Command(ChamarConsultarProjetoView);
            EditarProjetoCommand = new Command(ChamarEditarProjetoView);
            ExcluirProjetoCommand = new Command(ExcluirProjeto);
        }

        public void ChamarCriarProjetoView()
        {
            App.Current.MainPage.Navigation.PushAsync(new CriarProjetoView() { BarBackgroundColor = Color.FromHex("#3b5998") }, true);
        }

        public void ChamarConsultarProjetoView()
        {
            App.Current.MainPage.Navigation.PushAsync(new ConsultarProjetoView() { BarBackgroundColor = Color.FromHex("#3b5998") }, true);
        }

        public void ChamarEditarProjetoView()
        {
            App.Current.MainPage.Navigation.PushAsync(new EditarProjetoView() { BarBackgroundColor = Color.FromHex("#3b5998") }, true);
        }

        public void ExcluirProjeto()
        {
            Application.Current.MainPage.DisplayAlert("Exclusão de Projeto", "Tem certeza que deseja" + Environment.NewLine + "excluir este projeto? ", "Sim", "Não");

        }
    }
}
