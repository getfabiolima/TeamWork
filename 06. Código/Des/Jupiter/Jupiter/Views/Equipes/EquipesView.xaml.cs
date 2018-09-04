using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Jupiter.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jupiter.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EquipesView : ContentPage
	{
		public EquipesView ()
		{
			InitializeComponent ();
            BindingContext = new EquipesViewModel();
		}
	}
}