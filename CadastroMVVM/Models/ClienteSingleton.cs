using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroMVVM.Models
{
    public sealed class ClienteSingleton
    {
        //Ao executar o aplicativo
        //precisamos colocar a classe em memoria

        //Armezar o endereco da memoria Ex: 4xD1
        static ClienteSingleton instancia;

        //Criar o método para alocar em memoria
        public static ClienteSingleton Instancia
        {
            //retornar o endereco de memoria
            //ou seja o 4xD1
            get
            {
                //?? validar se a instancia esta populada

                //Valida se a classe foi instanciada
                //Ou se instancia vazia
                //devemos instanciar a classe em meoria
                //e retornamos o endereco
                //se a classe populada
                //quer dizer q ja foi instanciada
                //e ja retornamos o endereço
                return instancia ??
                    (instancia = new ClienteSingleton());
            }
        }

        //Apenas o construtor
        public ClienteSingleton() { }

        //Atributos
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}
