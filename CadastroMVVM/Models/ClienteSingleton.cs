namespace CadastroMVVM.Models
{
    public sealed class ClienteSingleton
    {
        static ClienteSingleton _instancia;

        public static ClienteSingleton Instancia
        {
            get
            {
                return _instancia ??
                    (_instancia = new ClienteSingleton());
            }
        }

        public ClienteSingleton() { }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
