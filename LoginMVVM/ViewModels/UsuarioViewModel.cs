using LoginMVVM.Models;
using LoginMVVM.Services;
using LoginMVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginMVVM.ViewModels
{
    public class UsuarioViewModel : BaseViewModel
    {
        //Instancia da classe com os metodos de persistencia
        public UsuarioService usuarioService;


        //Propriedades vinculadas a View
        private string _nome;
        private string _email;
        private string _senha;

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
                OnPropertyChanged();
            }
        }

        //Criar uma lista de objetos
        private List<Usuario> _usuarioList;
        public List<Usuario> UsuarioList
        {
            get { return _usuarioList; }
            set
            {
                _usuarioList = value;
                OnPropertyChanged();
            }
        }

        public ICommand InserirCommand { get; set; }

        public async void Inserir()
        {
            try
            {
                //Primeiro que criamos e atribuimos os valores ao objeto usuario
                Usuario usuario = new Usuario()
                {
                    Nome = Nome,
                    Email = Email,
                    Senha = Senha
                };

                //Inserimos o registro no banco de dados atraves do objeto criado
                await usuarioService.AddAsync(usuario);

                //Retornos um confirmação visual para o usuario 
                AlertOK("Informação", "Registro salvo com sucesso.");
            }
            catch (Exception ex)
            {
                AlertOK("Erro", "Erro original: " + ex.Message);
            }
        }

        public ICommand RemoverCommand { get; set; }
        public async void Remover(Usuario usuario)
        {
            try
            {
                if (usuario == null)
                {
                    AlertOK("Erro", "Usuário não encontrado.");
                    return;
                }

                if (! await AlertSimNao("Confirmação", "Deseja realmente excluiro o item?"))
                    return;

                await usuarioService.DeleteAsync(usuario);

                CarregarUsuarios();

                AlertOK("Informação", "Usuário removido com sucesso.");
            }
            catch (Exception ex)
            {
                AlertOK("Erro", "Erro original: " + ex.Message);
            }
        }

        public ICommand CarregarUsuariosCommand { get; set; }

        public async void CarregarUsuarios()
        {
            try
            {
                //meotodo base que retorna todos os registros
                UsuarioList = await usuarioService.GetAllAsync();
            }
            catch (Exception ex)
            {
                //Tratamento de excessão
                AlertOK("Erro", "Erro original: " + ex.Message);
            }
        }

        public ICommand LoginEntrarCommand { get; set; }

        private async void LoginEntrar()
        {
            try
            {
                //Recuperar o registro que possua o email informado
                //E atribuido o retorno ao objeto user
                var user = await usuarioService.GetLoginAsync(Email);

                if (user == null) //verifica se o retorno foi nulo
                    AlertOK("Atenção", "Email inválido.");

                else
                {
                    if (user.Senha == Senha) //valida a senha carregada no objeto
                        AbrirModelAsync(new PrincipalView()); //abre a tela principal
                    else
                    {
                        AlertOK("Atenção", "Senha inválida.");
                    }
                }

            }
            catch (Exception ex)
            {
                //Tratamento de exceção para subir mensagem de erro ao usuário
                AlertOK("Erro", "Erro original: " + ex.Message);
            }
        }

        public ICommand LoginRegistrarCommand { get; set; }
        public async void LoginRegistrar()
        {
            //Abrir a View para registrar um novo usuário
            //Application.Current.MainPage = new NavigationPage(new RegistroView());
            AbrirModelAsync(new RegistroView());
        }

        public UsuarioViewModel()
        {
            usuarioService = new UsuarioService();
            InserirCommand = new Command(Inserir);
            CarregarUsuariosCommand = new Command(CarregarUsuarios);
            LoginEntrarCommand = new Command(LoginEntrar);
            LoginRegistrarCommand = new Command(LoginRegistrar);
            RemoverCommand = new Command<Usuario>(Remover);
        }
    }
}
