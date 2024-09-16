using System.Windows.Input;

namespace AppMVVM.ViewModels
{
    //Devemos fazer a herança com a classe BaseNotifyViewModel 
    public class PrincipalViewModel : BaseNotifyViewModel
    {
        //agora vamos criar as propriedades de acordo com a tela
        //geralmente é criado a ViewModel antes da View,
        //pois o front é modelado de acordo com o backend

        //Criar as propriedades dos componentes da tela
        public string Nome { get; set; }

        //Propriedade que sera monitorada
        private string _retorno;
        public string Retorno
        {
            get { return _retorno; }
            set
            {
                _retorno = value;
                //Comando para disparar a alteração da propriedade
                OnPropertyChanged();
            }
        }

        //Comando de execução do Botão
        //Iremos recuperar o conteudo do campo Nome
        //e atualizar a lblRetorno com o conteudo da 
        //propriedade Retorno
        public Command RetornoCommand
        {
            get
            {
                return new Command(() =>
                {
                    //Propriedade Retorno vai receber
                    //Uma nova string concatenada com a 
                    //propriedade Nome
                    Retorno = "Olá, " + Nome;
                });
            }
        }

        //Criamos é um método generico para a chamda da tela de cadastro
        private async void Cliente()
        {
            await Application.Current.MainPage.
                Navigation.PushAsync(new Views.CadClienteView());
        }

        //Agora precisamos criar a propriedade referente ao Command do botão
        public ICommand ClienteCommand { get; set; }


        //No construtor da classe é realizado o vinculo da propriedade Command
        //com o método generico
        public PrincipalViewModel()
        {
            this.ClienteCommand = new Command(this.Cliente);
        }
    }
}
