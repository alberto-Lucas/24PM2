using CadastroMVVM.ViewModels;

namespace CadastroMVVM.Views;

public partial class VisualizarView : ContentPage
{
	public VisualizarView()
	{
		InitializeComponent();
        this.BindingContext = new ClienteViewModel();
    }
}