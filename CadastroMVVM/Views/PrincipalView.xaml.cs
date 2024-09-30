using CadastroMVVM.ViewModels;

namespace CadastroMVVM.Views;

public partial class PrincipalView : ContentPage
{
	public PrincipalView()
	{
		InitializeComponent();
		this.BindingContext = new ClienteViewModel();
	}
}