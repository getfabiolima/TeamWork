using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jupiter.Views.Projetos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultarProjetoView : TabbedPage
    {
        public ConsultarProjetoView ()
        {
            InitializeComponent();
        }
    }
}