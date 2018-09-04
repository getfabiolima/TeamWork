using Jupiter.Lists;
using Jupiter.Models;
using Jupiter.Views.Tarefas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Jupiter.ViewModels
{
    class TarefasViewModel
    {
        public ICommand CriarTarefaCommand { get; set; }
        public ICommand EditarTarefaCommand { get; set; }
        public ICommand ExcluirTarefaCommand { get; set; }
        public ObservableCollection<Tarefa> tarefas { get; set; }

        public TarefasViewModel()
        {
            tarefas = DadosUsuariosProjetos.tarefas;
            CriarTarefaCommand = new Command(ChamarCriarTarefaView);
            EditarTarefaCommand = new Command(ChamarEditarTarefaView);
            ExcluirTarefaCommand = new Command(ExcluirTarefa);
        }

        public void ChamarCriarTarefaView()
        {
            // Verificar se não é possível deixar uma única NavigationPage com um voltar
            App.Current.MainPage.Navigation.PushAsync(new CriarTarefaView() { BarBackgroundColor = Color.FromHex("#3b5998") }, true);
        }

        public void ChamarEditarTarefaView()
        {
            App.Current.MainPage.Navigation.PushAsync(new EditarTarefaView() { BarBackgroundColor = Color.FromHex("#3b5998") }, true);
        }

        public void ExcluirTarefa()
        {
            Application.Current.MainPage.DisplayAlert("Exclusão de Tarefa", "Tem certeza que deseja" + Environment.NewLine + "excluir esta tarefa? ", "Sim", "Não");

        }
    }
}
