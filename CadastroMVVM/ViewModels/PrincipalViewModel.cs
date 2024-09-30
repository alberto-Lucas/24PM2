using CadastroMVVM.Models;
using CadastroMVVM.Views;
using System.Windows.Input;

namespace CadastroMVVM.ViewModels
{
    public class PrincipalViewModel : BaseNotifyViewModel
    {
        //devemos replicar os campos do cadastro que existem na Model
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        //Criamos o comando do Cadastrar
        public ICommand CadastrarCommand { get; set; }

        //Criamos o método cadastrar
        private async void Cadastrar()
        {
            //Referenciamos a classe singleton
            var clienteSingleton = ClienteSingleton.Instancia;

            //Mapeamos o objeto
            clienteSingleton.Nome = Nome;
            clienteSingleton.CPF = CPF;
            clienteSingleton.RG = RG;
            clienteSingleton.Telefone = Telefone;
            clienteSingleton.DtNascimento = DtNascimento;
            clienteSingleton.Email = Email;
            clienteSingleton.Endereco = Endereco;

            await Application.Current.MainPage.Navigation.PushAsync(new VisualizarView());
        }

        //Criamos o contrutor da PrincipalViewModel
        public PrincipalViewModel()
        {
            //Vinculamos o método com o Command
            CadastrarCommand = new Command(Cadastrar);
        }
    }
}
