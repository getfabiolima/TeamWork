using Jupiter.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Jupiter.ViewModels;
using Jupiter.Models;

namespace Jupiter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjetosView : ContentPage
    {

       private ProjetosViewModel vm;

        public ProjetosView()
        {
            InitializeComponent();
            vm = new ProjetosViewModel();
            BindingContext = vm;
            ListView prjList = Content.FindByName<ListView>("prjList");
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            prjList.BeginRefresh();

            if (!string.IsNullOrWhiteSpace(e.NewTextValue))
            {

                prjList.ItemsSource = DadosUsuariosProjetos.projetos.Where((p =>

                p.NomeProjeto.IndexOf(e.NewTextValue, StringComparison.InvariantCultureIgnoreCase) >= 0)

                );
            }
            else
            {
                prjList.ItemsSource = DadosUsuariosProjetos.projetos;
            }

            prjList.EndRefresh();
        }


        public void SelecionouProjeto()
        {
            if (ToolbarItems.Count == 1)
            {
                ToolbarItems.Insert(0, new ToolbarItem { Icon = "Prj.png", Command = vm.ConsultarProjetoCommand });
                ToolbarItems.Insert(1, new ToolbarItem { Icon = "editPrj.png", Command = vm.EditarProjetoCommand });
                ToolbarItems.Insert(2, new ToolbarItem { Icon = "delPrj.png", Command = vm.ExcluirProjetoCommand });
            }
        }

    }
}