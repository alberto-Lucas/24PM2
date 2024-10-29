using CadastroMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroMVVM.ViewModels
{
    public class VisualizarViewModel : BaseNotifyViewModel
    {
        //Replicar os campos do cadastro
        //com base na model
        //porém utilizando agora os
        //observadores
        //Parar não disparar o obeservador
        //de maneira errado, vamos usar
        //variavel auxiliar

        private string _nome;
        public string Nome 
        { get
            {
                return _nome;
            }
            set
            {
                _nome = value;
                OnPropertyChanged();
            }        
        }

        private string _cpf;
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
                OnPropertyChanged();
            }
        }

        private string _rg;
        public string RG
        {
            get
            {
                return _rg;
            }
            set
            {
                _rg = value;
                OnPropertyChanged();
            }
        }
        private string _telefone;
        public string Telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                _telefone = value;
                OnPropertyChanged();
            }
        }

        private DateTime _dtNascimento;
        public DateTime DtNascimento
        {
            get
            {
                return _dtNascimento;
            }
            set
            {
                _dtNascimento = value;
                OnPropertyChanged();
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private string _endereco;
        public string Endereco
        {
            get
            {
                return _endereco;
            }
            set
            {
                _endereco = value;
                OnPropertyChanged();
            }
        }

        //Método para carregar os dados 
        //da classe Singleton
        private void Carregar()
        {
            //Mapear a class Singleton
            //para os atributos da tela
            var clienteSingleton =
                Cliente.Instancia;

            Nome = clienteSingleton.Nome;
            CPF = clienteSingleton.CPF;
            RG = clienteSingleton.RG;
            Telefone = clienteSingleton.Telefone;
            DtNascimento = clienteSingleton.DtNascimento;
            Email = clienteSingleton.Email;
            Endereco = clienteSingleton.Endereco;
        }

        //Criar o construturo para carregar 
        //os dados automaticamente
        public VisualizarViewModel()
        {
            //Chamar o método carregar
            Carregar();
        }
    }
}
