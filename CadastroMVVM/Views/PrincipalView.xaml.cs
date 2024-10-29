using CadastroMVVM.ViewModels;

namespace CadastroMVVM.Views;

public partial class PrincipalView : ContentPage
{
	public PrincipalView()
	{
		InitializeComponent();
		//Semelhante a tag <Script/>
		//do HTML para vincular com o
		//arquivo .js
		this.BindingContext =
			new PrincipalViewModel();
	}
}