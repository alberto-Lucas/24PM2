using CadastroMVVM.Models;
using CadastroMVVM.Views;
using System.Windows.Input;

namespace CadastroMVVM.ViewModels
{
    public class PrincipalViewModel : BaseNotifyViewModel
    {
        //Replicar os campos do cadastro
        //que  existem na model
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        //Criar o comando cadastrar
        //que será vinculado a tela
        public ICommand CadastrarCommand { get; set; }

        //Criar o método para cadastrar o registro
        public async void Cadastrar()
        {
            //Usar a classe singleton como "banco de dados"

            //Referenciar a classe singleton
            var clienteSingleton = Cliente.Instancia;

            //Popular o objeto clienteSingleton
            //Com os atributos da tela
            //definidos acima
            clienteSingleton.Nome = Nome;
            clienteSingleton.CPF = CPF;
            clienteSingleton.RG = RG;
            clienteSingleton.Telefone = Telefone;
            clienteSingleton.DtNascimento = DtNascimento;
            clienteSingleton.Email = Email;
            clienteSingleton.Endereco = Endereco;

            //Nesse momento todos os dados informados
            //pelo usuario, foram salvos na 
            //memoria do dispositivo

            //Chamar a tela de visualização
            await Application.Current.MainPage.
                Navigation.PushAsync(
                    new VisualizarView());
        }

        //Para realizar os
        //vinculados dos botes, é preciso
        //criar o construtor da classe
        public PrincipalViewModel()
        {
            //Vinculamos o método Cadastrar
            //ao comando CadastrarCommand
            CadastrarCommand =
                new Command(Cadastrar);
        }
    }
}
