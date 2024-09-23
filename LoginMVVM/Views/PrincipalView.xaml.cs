using LoginMVVM.ViewModels;

namespace LoginMVVM.Views;

public partial class PrincipalView : ContentPage
{
	public PrincipalView()
	{
		InitializeComponent();
        this.BindingContext = new PrincipalViewModel();
    }
}