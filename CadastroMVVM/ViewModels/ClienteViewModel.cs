using CadastroMVVM.Models;
using CadastroMVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CadastroMVVM.ViewModels
{
    public class ClienteViewModel : BaseNotifyViewModel
    {
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

        public ClienteViewModel()
        {
            CadastrarCommand = new Command(Cadastrar);
            Carregar();
        }
    }
}
