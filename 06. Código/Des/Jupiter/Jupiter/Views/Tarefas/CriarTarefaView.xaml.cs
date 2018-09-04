using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jupiter.Views.Tarefas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CriarTarefaView : TabbedPage
	{
		public CriarTarefaView ()
		{
			InitializeComponent ();
		}
	}
}