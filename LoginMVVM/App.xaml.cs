using LoginMVVM.Views;

namespace LoginMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
        }
    }
}
