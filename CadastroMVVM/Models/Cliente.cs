using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroMVVM.Models
{
    public sealed class Cliente
    {
        static Cliente instancia;

        public static Cliente Instancia
        {
            get
            {
                return instancia ??
                    (instancia = new Cliente());                
            }
        }

        public Cliente() { }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
