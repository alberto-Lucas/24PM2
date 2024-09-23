using LoginMVVM.ViewModels;

namespace LoginMVVM.Views;

public partial class RegistroView : ContentPage
{
	public RegistroView()
	{
		InitializeComponent();
        this.BindingContext = new RegistroViewModel();
    }
}