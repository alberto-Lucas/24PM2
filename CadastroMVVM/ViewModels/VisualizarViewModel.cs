using CadastroMVVM.Models;

namespace CadastroMVVM.ViewModels
{
    public class VisualizarViewModel : BaseNotifyViewModel
    {
        //devemos replicar os campos do cadastro que existem na Model
        //porém os preparando com o observador
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                OnPropertyChanged();
            }
        }

        private string _cpf;

        public string CPF
        {
            get { return _cpf; }
            set
            {
                _cpf = value;
                OnPropertyChanged();
            }
        }

        private string _rg;

        public string RG
        {
            get { return _rg; }
            set
            {
                _rg = value;
                OnPropertyChanged();
            }
        }

        private string _telefone;

        public string Telefone
        {
            get { return _telefone; }
            set
            {
                _telefone = value;
                OnPropertyChanged();
            }
        }

        private DateTime _dtNascimento;

        public DateTime DtNascimento
        {
            get { return _dtNascimento; }
            set
            {
                _dtNascimento = value;
                OnPropertyChanged();
            }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private string _endereco;

        public string Endereco
        {
            get { return _endereco; }
            set
            {
                _endereco = value;
                OnPropertyChanged();
            }
        }

        //Criamos o método Carregar para mapear o Objeto
        private void Carregar()
        {
            var clienteSingleton = ClienteSingleton.Instancia;

            Nome = clienteSingleton.Nome;
            CPF = clienteSingleton.CPF;
            RG = clienteSingleton.RG;
            Telefone = clienteSingleton.Telefone;
            DtNascimento = clienteSingleton.DtNascimento;
            Email = clienteSingleton.Email;
            Endereco = clienteSingleton.Endereco;
        }

        //Criamos o contrutor da PrincipalViewModel
        public VisualizarViewModel()
        {
            //Chamamos o método Carregar
            Carregar();
        }
    }
}
