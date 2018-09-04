using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Jupiter.ViewModels;
using Jupiter.Lists;

namespace Jupiter.Views.Tarefas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TarefasView : ContentPage
	{
        TarefasViewModel vm;
        public TarefasView ()
		{
			InitializeComponent ();
            vm = new TarefasViewModel();
            BindingContext = vm;
		}

        private void SelecionouTarefaNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            if (ToolbarItems.Count == 1)
            {
                ToolbarItems.Insert(1, new ToolbarItem { Icon = "editPrj.png", Command = vm.EditarTarefaCommand });

                ToolbarItems.Insert(2, new ToolbarItem { Icon = "delPrj.png", Command = vm.ExcluirTarefaCommand });
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListView tskList = Content.FindByName<ListView>("tskList");
            tskList.BeginRefresh();

            if (!string.IsNullOrWhiteSpace(e.NewTextValue))
            {

                tskList.ItemsSource = DadosUsuariosProjetos.tarefas.Where((p =>

                p.NomeTarefa.IndexOf(e.NewTextValue, StringComparison.InvariantCultureIgnoreCase) >= 0)

                );
            }
            else
            {
                tskList.ItemsSource = DadosUsuariosProjetos.tarefas;
            }

            tskList.EndRefresh();
        }
    }
}