using LoginMVVM.ViewModels;

namespace LoginMVVM.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
        this.BindingContext = new LoginViewModel();
    }
}