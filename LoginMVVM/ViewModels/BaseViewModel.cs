using System.Windows.Input;

namespace LoginMVVM.ViewModels
{
    public class BaseViewModel : BaseNotifyViewModel
    {
        //Classe com metodos e atributos genericos que seram compartilhados em mais de uma View

        //Propriedade de texto para ocultar senha
        //IsPassword = true então a senha fica oculta Ex: *******
        //IsPassword = false então a senha fica exibida Ex: 123456
        bool _isPassword = true;
        public bool IsPassword
        {
            get { return _isPassword; }
            set
            {
                _isPassword = value;
                OnPropertyChanged();
            }
        }

        //Checkbox para mostrar senha
        bool _isShowPassword = false;
        public bool IsShowPassword
        {
            get { return _isShowPassword; }
            set
            {
                _isShowPassword = value;
                OnPropertyChanged();
                //Sempre que o status do checkbox for alterado
                //Atualizamos tbm a exibição da senha
                //Lembrando que devido a marcação visivel do checkbox
                //eles deve possuir o status contrario ao da exibição
                //Mostar senha é igual a marcado(Checked)
                //Então PassWord é igual a false
                //A exclemação ! é utilizada para negar um status do tipo boolean
                //ou seja se a variavel for true ao usar a ! ela sera lida como false
                IsPassword = !IsShowPassword;
            }
        }
        public ICommand MostrarSenhaCommand { get; set; }
        private void MostrarSenha()
        {
            IsShowPassword = !IsShowPassword;
        }

        public ICommand VoltarModalCommand { get; set; }

        public void VoltarModalAsync()
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }

        public BaseViewModel()
        {
            MostrarSenhaCommand = new Command(MostrarSenha);
            VoltarModalCommand = new Command(VoltarModalAsync);
        }


        public async void AbrirModelAsync(ContentPage View)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(View);
        }

        public async void AlertOK(string Titulo, string Msg)
        {
            await App.Current.MainPage.DisplayAlert(Titulo, Msg, "OK");
        }
        public async Task<bool> AlertSimNao(string titulo, string msg)
        {
            return await App.Current.MainPage.DisplayAlert(titulo, msg, "Sim", "Não");
        }

    }
}
