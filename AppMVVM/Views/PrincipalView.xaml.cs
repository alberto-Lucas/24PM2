using AppMVVM.ViewModels;

namespace AppMVVM.Views;

public partial class PrincipalView : ContentPage
{
	public PrincipalView()
	{
		InitializeComponent();
        //Importar a pasta a onde esta a ViewModel
        //using AppMVVM.ViewModels;
        this.BindingContext = new PrincipalViewModel();
    }
}
