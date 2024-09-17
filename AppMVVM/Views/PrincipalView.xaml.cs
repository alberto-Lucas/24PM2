using AppMVVM.ViewModels;

namespace AppMVVM.Views;

public partial class PrincipalView : ContentPage
{
	public PrincipalView()
	{
		InitializeComponent();
        //Vincular a View com a ViewModel
        //Precisa importar a pasta da ViewModel
        //using AppMVVM.ViewModels;
        this.BindingContext =
            new PrincipalViewModel();
    }
}