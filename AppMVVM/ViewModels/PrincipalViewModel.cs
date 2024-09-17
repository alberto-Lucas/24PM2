using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppMVVM.ViewModels
{
    //Fazer herança com a nossa classe Base
    public class 
        PrincipalViewModel : BaseNotifyViewModel
    {
        //Agora vou criar as proriedades 
        //para vinculo com a tela
        public string Nome { get; set; }

        //Criar uma propridade a ser monitorada
        private string _retorno;
        
        //Crio o observado de ação
        public string Retorno
        {
            get { return _retorno; } //Leitura
            set
            {
                //Value é o valor manipulado
                //Ex: "Lucas"
                _retorno = value; 
                //Comando para disparar o
                //observador de ação
                OnPropertyChanged();
            }
        }

        //Execução do comando do botão
        //O que será feito
        //Iremos recuperar o conteudo do campo Nome
        //e atualizar a lblRetorno com o conteudo 
        //da propriedade Retorno
        public Command RetornoCommand
        {
            get
            {
                //Definir a ação do botão
                return new Command(() =>
                {
                    //A propriedade Retorno vai 
                    //receber uma nova string
                    //concatena com a propriedade
                    //Nome
                    Retorno = "Olá, " + Nome;
                });
            }
        }

        //Criar o método para
        //chamada de outra tela
        private async void AbrirCad()
        {
            await Application.Current.MainPage.
                Navigation.PushAsync(
                    new Views.CadClienteView());
        }

        //Criar a propriedade do botão de cadastro
        public ICommand CadastroCommand { get; set; }

        //No construtor é realizado o vinculo 
        //da propriedade Command com o Método
        public  PrincipalViewModel()
        {
            //Vincular a propriedade e o método
            this.CadastroCommand =
                new Command(this.AbrirCad);
        }
    }
}
